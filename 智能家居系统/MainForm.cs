using System;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;

namespace 智能家居系统
{

    public partial class MainForm : Form
    {

        #region "变量与对象"
        /// <summary>
        /// 语音识别引擎控制器
        /// </summary>
        SpeechRecognitionController UnitySREController = new SpeechRecognitionController();

        /// <summary>
        /// 数据库的长连接
        /// </summary>
        MySQLDataBaseController UnityDBController = new MySQLDataBaseController();

        /// <summary>
        /// 界面状态枚举
        /// </summary>
        private enum PanelState
        {
            /// <summary>
            /// 显示家电控制界面
            /// </summary>
            Control,
            /// <summary>
            /// 显示家电信息界面
            /// </summary>
            Info,
            /// <summary>
            /// 家电状态展示视图
            /// </summary>
            Card
        }
        /// <summary>
        /// 界面状态状态
        /// </summary>
        PanelState PanelStatenow;
        /// <summary>
        /// 获取或设置界面状态
        /// </summary>
        private PanelState PanelStateNow
        {
            get => PanelStatenow;
            //封装字段为属性：使用set自动触发界面切换
            set
            {
                PanelStatenow = value;
                UnityModule.DebugPrint("————————<<<  正在切换界面到 {0}  >>>————————",value.ToString());
                switch (value)
                {
                    case PanelState.Control:
                        {
                            //切换到控制界面
                            ControlPanel.Show();
                            if (InfoPanel.Visible)
                            {
                                InfoPanel.Hide();
                                InfoLabel.Image = UnityResource.Info_;
                            }
                            if (CardPanel.Visible)
                            {
                                CardPanel.Hide();
                                CardLabel.Image = UnityResource.Card_;
                            }
                            TargetLabel.Left = ControlLabel.Left;
                            MainPanel.Invalidate();

                            break;
                        }
                    case PanelState.Info:
                        {
                            //切换到信息界面
                            if (ControlPanel.Visible)
                            {
                                ControlPanel.Hide();
                                ControlLabel.Image = UnityResource.Control_;
                            }
                            InfoPanel.Show();
                            if (CardPanel.Visible)
                            {
                                CardPanel.Hide();
                                CardLabel.Image = UnityResource.Card_;
                            }
                            TargetLabel.Left = InfoLabel.Left;
                            MainPanel.Invalidate();
                            //如果被激活的家电项目不为空，立即刷新家电信息和事件
                            if (!string.IsNullOrEmpty(DomesticApplianceItem.ActiveItem?.MAC))
                            {
                                ShowDomesticApplianceInfo(DomesticApplianceItem.ActiveItem.MAC);
                                ShowDomesticApplianceEventLog(DomesticApplianceItem.ActiveItem.MAC);
                            }
                            break;
                        }
                    case PanelState.Card:
                        {
                            if (ControlPanel.Visible)
                            {
                                ControlPanel.Hide();
                                ControlLabel.Image = UnityResource.Control_;
                            }
                            if (InfoPanel.Visible)
                            {
                                InfoPanel.Hide();
                                InfoLabel.Image = UnityResource.Info_;
                            }
                            CardPanel.Show();
                            TargetLabel.Left = CardLabel.Left;
                            MainPanel.Invalidate();
                            break;
                        }
                }

                if(TipsBox.Visible) TipsBox.BringToFront();
                UnityModule.DebugPrint("界面切换完成！当前状态：" + value.ToString());
            }
        }

        #endregion

        #region "窗体事件"

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //初始化窗体
            this.Icon = UnityResource.LogoIcon;
            TimeLabel.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm");
            PanelStateNow = PanelState.Control;

            //使用静态变量，让DAItems知道容器地址，当释放某个DAItem时，会自动激活临近DAItem
            DomesticApplianceItem.ParentPanel = DomesticAppliancePanel;

            //注册鼠标拖动功能
            //LogoLabel.MouseDown += new MouseEventHandler(UnityModule.MoveFormViaMouse);
            TopPanel.MouseDown += new MouseEventHandler(UnityModule.MoveFormViaMouse);

            //允许多线程访问界面
            CheckForIllegalCrossThreadCalls = false;
            //控制MainPanel内三个界面容器控件填充父容器
            ControlPanel.Dock = DockStyle.Fill;
            InfoPanel.Dock = DockStyle.Fill;
            CardPanel.Dock = DockStyle.Fill;

            //控制界面针对家电的控制控件填充停靠
            AirConditioningPanel.Dock = DockStyle.Fill;
            TVPanel.Dock = DockStyle.Fill;

            //为按钮绑定鼠标动态效果事件
            RefreshButton.MouseEnter += new EventHandler(Button_MouseEnter);
            RefreshButton.MouseLeave += new EventHandler(Button_MouseLeave);
            RefreshButton.MouseDown += new MouseEventHandler(Button_MouseDown);
            RefreshButton.MouseUp += new MouseEventHandler(Button_MouseUp);

            InfoLabel.MouseEnter += new EventHandler(Button_MouseEnter);
            InfoLabel.MouseLeave += new EventHandler(TitleButton_MouseLeave);
            InfoLabel.MouseDown += new MouseEventHandler(Button_MouseDown);
            InfoLabel.MouseUp += new MouseEventHandler(Button_MouseUp);

            ControlLabel.MouseEnter += new EventHandler(Button_MouseEnter);
            ControlLabel.MouseLeave += new EventHandler(TitleButton_MouseLeave);
            ControlLabel.MouseDown += new MouseEventHandler(Button_MouseDown);
            ControlLabel.MouseUp += new MouseEventHandler(Button_MouseUp);

            CardLabel.MouseEnter += new EventHandler(Button_MouseEnter);
            CardLabel.MouseLeave += new EventHandler(TitleButton_MouseLeave);
            CardLabel.MouseDown += new MouseEventHandler(Button_MouseDown);
            CardLabel.MouseUp += new MouseEventHandler(Button_MouseUp);

            ExecuteButton.MouseEnter += new EventHandler(Button_MouseEnter);
            ExecuteButton.MouseLeave += new EventHandler(Button_MouseLeave);
            ExecuteButton.MouseDown += new MouseEventHandler(Button_MouseDown);
            ExecuteButton.MouseUp += new MouseEventHandler(Button_MouseUp);

            ExitButton.MouseEnter += new EventHandler(Button_MouseEnter);
            ExitButton.MouseDown += new MouseEventHandler(Button_MouseDown);
            ExitButton.MouseLeave += new EventHandler(Button_MouseLeave);

            //家电名称和描述显示控件鼠标进入或离开时改变编辑按钮的可见性
            Action<object, EventArgs> ShowEditButton = new Action<object, EventArgs>(delegate (object x,EventArgs y){ if (MACValueLabel.Text == "(unknown)") return; (x as Label).Image = UnityResource.Edit_0;(x as Label).ForeColor = Color.DeepSkyBlue; });
            Action<object, EventArgs> HideEditButton = new Action<object, EventArgs>(delegate (object x, EventArgs y) { if (MACValueLabel.Text == "(unknown)") return; (x as Label).Image = null; (x as Label).ForeColor = Color.FromArgb(255,64,64,64); });
            DeviceNameValueLabel.MouseEnter += new EventHandler(ShowEditButton);
            DescriptionValueLabel.MouseEnter += new EventHandler(ShowEditButton);
            DeviceNameValueLabel.MouseLeave += new EventHandler(HideEditButton);
            DescriptionValueLabel.MouseLeave += new EventHandler(HideEditButton);
            //允许点击时编辑家电名称和描述信息
            DeviceNameValueLabel.Click += new EventHandler(EditDAInfo);
            DescriptionValueLabel.Click += new EventHandler(EditDAInfo);

            //界面初始化完成
            LogoLabel.Text = "界面初始化完毕！";
            UnityModule.DebugPrint("界面初始化完毕！");
            this.Invalidate();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Invalidate();
            UnityModule.DebugPrint("界面显示完成。_Shown()");
            //连接数据库
            if (UnityDBController.CreateConnection())
            {
                LogoLabel.Text = "数据库连接成功！";
                UnityModule.DebugPrint("数据库长连接创建成功！");
            }
            else
            {
                LogoLabel.Text = "数据库连接失败！";
                new MyMessageBox("无法连接数据库！请退出系统并检查连接！", "数据库连接失败：", MyMessageBox.IconType.Error).ShowDialog(this);
                //ExitApplication();
            }

            //稳定界面
            this.Invalidate();
            UnityModule.DebugPrint("界面稳定！");

            //读取数据库里的家用电器
            LoadDomesticAppliance();

            LogoLabel.Text = "欢迎使用智能家居系统！";

            //创建语音识别引擎
            if (UnitySREController.CreateSREngine())
            {
                //导入语法
                LoadGrammar();

                //绑定识别完成方法
                UnitySREController.SpeechRecognized += new EventHandler<string>(SpeechRecognized);
            }
            //创建语音朗读引擎
            UnitySREController.CreateSpeechSynthesizer();
        }

        bool AllowToClose = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowToClose)
            {
                //未经允许关闭时拦截关闭消息
                e.Cancel = true;
                if (new MyMessageBox("您真的要退出智能家居系统吗？", MyMessageBox.IconType.Question).ShowDialog(this) != DialogResult.OK) return;
                ExitApplication();
            }
        }

        #endregion

        #region "界面大小改变自适应布局"

        private void TopPanel_Resize(object sender, EventArgs e)
        {
            ExitButton.Width = TopPanel.Height;
            ControlLabel.Left = (int)((TimeLabel.Left - 240) / 2);
            InfoLabel.Left = ControlLabel.Right + 20;
            CardLabel.Left = InfoLabel.Right + 20;
            TargetLabel.Left = TopPanel.Controls.Find(PanelStateNow.ToString() + "Label", false).First()?.Left??TargetLabel.Left;
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            TipsBox.Left = (TipsBox.Visible ? TipsBox.Parent.Width - TipsBox.Width : TipsBox.Parent.Width);
        }

        private void LeftPanel_Resize(object sender, EventArgs e)
        {
            DomesticAppliancePanel.Height = LeftPanel.Height - LogoPanel.Bottom;
        }

        #endregion

        #region "功能函数"

        /// <summary>
        /// 关闭数据库连接，退出系统
        /// </summary>
        private void ExitApplication()
        {
            //停止心跳，防止线程资源冲突
            SystemEngine.Stop();

            UnityModule.DebugPrint("正在退出系统...");
            //允许关闭窗体
            AllowToClose = true;
            //断开数据库连接
            if (UnityDBController != null)
            {
                UnityDBController.CloseConnection();
            }
            if (UnitySREController != null)
            {
                UnitySREController.StopSREngine();
                (UnitySREController as IDisposable).Dispose();
            }
            //向线程池申请可用线程，并在成功时回调动态隐藏函数
            ThreadPool.QueueUserWorkItem(delegate
            {
                while (this.Opacity > 0)
                {
                    this.Opacity -= 0.1;
                    Thread.Sleep(20);
                }
                UnityModule.DebugPrint("欢迎下次使用！再见！");
                //退出程序
                Application.Exit();
            });
        }

        /// <summary>
        /// 从数据库加载家电列表
        /// </summary>
        private void LoadDomesticAppliance()
        {
            UnityModule.DebugPrint("开始更新已连接家电信息...");
            //读取在线家电
            using (MySqlDataReader DataReader = UnityDBController.ExecuteReader("SELECT * FROM devicebase WHERE FD>=0"))
            {
                if (DataReader == null) return;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        string DeviceName="";
                        string Model="";
                        string Description="";
                        string Manufactor="";
                        string MAC="";
                        string DAType = "";

                        try
                        {
                            DeviceName = DataReader["DeviceName"] as string;
                            Description = DataReader["Description"] as string;
                            MAC = DataReader["MAC"] as string;
                            
                            //以MAC为唯一标识判断家电是否已经存在
                            if (DomesticApplianceItem.DAExists(MAC))
                            {
                                //家电已经存在了，仅更新家电名称和描述
                                UnityModule.DebugPrint("更新家电数据 : {0}",MAC);
                                DomesticApplianceItem.GetDAByMAC(MAC)?.SetDeviceNameAndDescription(DeviceName, Description);
                            }
                            else
                            {
                                //家电不存在，添加新家电
                                Model = DataReader["Model"] as string;
                                Manufactor = DataReader["Manufactor"] as string;
                                DAType = DataReader["Type"] as string;
                                DomesticApplianceItem newDAItem;
                                newDAItem = new DomesticApplianceItem(MAC, Manufactor,Model,DAType);
                                newDAItem.SetDeviceNameAndDescription(DeviceName,Description);
                                newDAItem.Width = DomesticAppliancePanel.Width-25;
                                newDAItem.ItemClick += new EventHandler(DomesticApplianceItem_ItemClick);

                                UnityModule.DebugPrint("增加新家电：{0}({1})\t\tMAC地址：{2}",DeviceName , Model, MAC);
                                this.Invoke(new Action(() =>
                                {
                                    DomesticAppliancePanel.Controls.Add(newDAItem);
                                    DomesticAppliancePanel.Invalidate();
                                    UnityModule.DebugPrint("成功加入列表控件");
                                }));
                            }
                        }
                        catch (Exception ex)
                        {
                            UnityModule.DebugPrint("读取家电列表时出错：\t" + DeviceName ?? "未知家电" + " (" + Model ?? "未知型号" + ")" + ex.Message);
                        }
                        UnityModule.DebugPrint("——————————");
                    }
                }
                DataReader.Close();
            }
            using (MySqlDataReader DataReader = UnityDBController.ExecuteReader("SELECT * FROM devicebase WHERE FD<0"))
            {
                if (DataReader == null) return;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        string MAC = "";
                        try
                        {
                            MAC = DataReader["MAC"] as string;
                            foreach(DomesticApplianceItem DAOffLine in DomesticAppliancePanel.Controls.Find(MAC, true))
                            {
                                UnityModule.DebugPrint("移除断开的家电[{0}]",MAC);
                                (DAOffLine as IDisposable).Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            UnityModule.DebugPrint("移除家电[{0}]时遇到错误：{1}" ,MAC,ex.Message);
                        }
                        UnityModule.DebugPrint("——————————");
                    }
                }
                DataReader.Close();
            }
            UnityModule.DebugPrint("在线家电读取完毕！");
        }

        #endregion

        #region "按钮动态效果"
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_2") as Image;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_1") as Image;
        }

        private void TitleButton_MouseLeave(object sender, EventArgs e)
        {
            if (((sender as Label).Tag as string) == PanelStateNow.ToString())
                (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_0") as Image;
            else
                (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_") as Image;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_0") as Image;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = UnityResource.ResourceManager.GetObject((sender as Label).Tag + "_1") as Image;
        }
        #endregion

        #region "顶部按钮点击事件"
        private void ControlLabel_Click(object sender, EventArgs e)
        {
            PanelStateNow = PanelState.Control;
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            PanelStateNow = PanelState.Info;
        }

        private void CardLabel_Click(object sender, EventArgs e)
        {
            PanelStateNow = PanelState.Card;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (!AllowToClose)
            {
                ExitButton.Image = UnityResource.ExitApp_1;
                if (new MyMessageBox("您真的要退出智能家居系统吗？", MyMessageBox.IconType.Question).ShowDialog(this) != DialogResult.OK)
                {
                    ExitButton.Image = UnityResource.ExitApp_0;
                    return;
                }
                ExitApplication();
            }
        }

        #endregion

        #region "家电信息界面事件"

        /// <summary>
        /// 编辑家电信息并储存进数据库
        /// </summary>
        private void EditDAInfo(object sender, EventArgs e)
        {
            if (MACValueLabel.Text == "(unknown)") return;
            string LabelName= (sender as Label).Name.Remove((sender as Label).Name.Length - "ValueLabel".Length),UserInput = "";
            if( MyMessageBox.ShowInputBox(string.Format("请输入 {0} 信息：",LabelName),ref UserInput, (sender as Label).Text,50) != DialogResult.OK) return;
            if (UnityDBController.ExecuteNonQuery("UPDATE devicebase SET {0} = '{1}' WHERE MAC='{2}'", LabelName, UserInput,MACValueLabel.Text))
            {
                (sender as Label).Text = UserInput;
                DomesticApplianceItem.GetDAByMAC(MACValueLabel.Text)?.SetDeviceNameAndDescription(DeviceNameValueLabel.Text,DescriptionValueLabel.Text);
                UnityModule.DebugPrint("{0} 值更新成功！",LabelName);
            }
            else
            {
                new MyMessageBox(string.Format("{0} 值编辑失败，请重试！",LabelName),MyMessageBox.IconType.Error).ShowDialog(this);
                UnityModule.DebugPrint("{0} 值更新失败！", LabelName);
            }

        }

        /// <summary>
        /// 重置家电事件列表
        /// </summary>
        private void ResetDAEventList()
        {
            EventListView.Items.Clear();
            LastEventTime = -1;
        }

        /// <summary>
        /// 初始化家电信息显示内容
        /// </summary>
        private void ResetDAInfoTable()
        {
            for (int Index = 0; Index < InfoTablePanel.Controls.Count; )
            {
                if (InfoTablePanel.Controls[Index].Name.EndsWith("ValueLabel"))
                {
                    //重置基本信息
                    InfoTablePanel.Controls[Index].Text = "(unknown)";
                }
                else if (InfoTablePanel.Controls[Index].Name.EndsWith("TempLabel"))
                {
                    //移除状态信息
                    Control TempControl = InfoTablePanel.Controls[Index];
                    InfoTablePanel.Controls.RemoveAt(Index);
                    TempControl.Dispose();
                    continue;
                }

                Index++;
            }
        }

        /// <summary>
        /// 点击家电事件列表表头进行排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            UnityModule.DebugPrint("事件列表按第 " + e.Column + " 列排序。");
            EventListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        /// <summary>
        /// 把上次读取的数据里读取家电信息显示在信息界面
        /// </summary>
        /// <param name="mac">家电的MAC地址</param>
        private void ShowDomesticApplianceInfo(string mac)
        {
            if (string.IsNullOrEmpty(mac)) return;
            //重置家电信息显示表
            ResetDAInfoTable();
            //加载基本信息
            using (MySqlDataReader DataReader = UnityDBController.ExecuteReader("SELECT * FROM devicebase WHERE MAC= '{0}'", mac))
            {
                if (DataReader == null) return;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        try
                        {
                            DeviceNameValueLabel.Text = DataReader["DeviceName"] as string;
                            ManufactorValueLabel.Text = DataReader["Manufactor"] as string;
                            ModelValueLabel.Text = DataReader["Model"] as string;
                            MACValueLabel.Text = DataReader["MAC"] as string;
                            TypeValueLabel.Text = DataReader["Type"] as string;
                            DescriptionValueLabel.Text = DataReader["Description"] as string;
                            FDValueLabel.Text = DataReader["FD"].ToString();
                        }
                        catch (Exception ex)
                        {
                            UnityModule.DebugPrint("读取家电信息时遇到错误：" + ex.Message);
                        }
                    }
                }
                DataReader.Close();
            }
            //加载状态信息
            using (MySqlDataReader DataReader = UnityDBController.ExecuteReader("SELECT * FROM statusbase WHERE MAC= '{0}'", mac))
            {
                if (DataReader == null) return;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        try
                        {
                            Label NameLabel = new Label()
                            {
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleRight,
                                Name = DataReader["StatusName"] as string + "TempLabel",
                                Text = DataReader["StatusDescription"] as string + "：",
                                Font = new Font(InfoTablePanel.Font.FontFamily, 12),
                                ForeColor = Color.FromArgb(64,64,64)
                            };
                            InfoTablePanel.Controls.Add(NameLabel);

                            Label ValueLabel = new Label() {
                                Dock = DockStyle.Fill,
                                Text = DataReader["StatusValue"] as string,
                                TextAlign = ContentAlignment.MiddleLeft,
                                Name = DataReader["StatusName"] as string + "ValueTempLabel",
                                Font = new Font(InfoTablePanel.Font.FontFamily,12,FontStyle.Bold),
                                ForeColor = Color.FromArgb(64, 64, 64)
                            };
                            InfoTablePanel.Controls.Add(ValueLabel);
                        }
                        catch (Exception ex)
                        {
                            UnityModule.DebugPrint("读取家电状态信息时遇到错误：" + ex.Message);
                        }
                    }
                }
                DataReader.Close();
            }
            UnityModule.DebugPrint("显示家电信息完成。");
        }

        /// <summary>
        /// 上次读取的最后一个事件的时间（用于心跳时仅更新最新的事件，防止ListView闪烁）
        /// </summary>
        int LastEventTime = -1;
        /// <summary>
        /// 从数据库读取家电的事件记录
        /// </summary>
        /// <param name="mac">家电设备的MAC地址</param>
        private void ShowDomesticApplianceEventLog(string mac)
        {
            if (string.IsNullOrEmpty(mac)) return;

            using (MySqlDataReader DataReader = UnityDBController.ExecuteReader("SELECT * FROM eventbase WHERE MAC= '{0}' AND EventTime>{1}", mac,LastEventTime))
            {
                if (DataReader == null) return;

                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        try
                        {
                            UnityModule.DebugPrint("读取到事件：" + DataReader["EventName"].ToString());
                            EventListView.Items.Add(new ListViewItem(new string[] { UnixTimeToString((long)(int)DataReader["EventTime"]), DataReader["EventName"].ToString(), DataReader["EventDescription"].ToString() }));
                            //更新上次事件时间
                            Int32.TryParse(DataReader["EventTime"].ToString(),out LastEventTime);
                        }
                        catch (Exception ex)
                        {
                            UnityModule.DebugPrint("读取事件时遇到错误：" + ex.Message);
                        }
                    }
                }
                DataReader.Close();
            }
            UnityModule.DebugPrint("读取家电事件列表完成。");
        }

        /// <summary>
        /// 把Unix时间戳转换为本地格式化时间
        /// </summary>
        /// <param name="UnixTime"></param>
        /// <returns></returns>
        private string UnixTimeToString(long UnixTime)
        {
            //神奇勿动！
            /*
             * 首先创建等于Unix时间戳的起始日期(1970/1/1 0:0:0)的时间对象
             * 为新的时间对象加上时间戳表示的时间
             * 把上述UTC时间转换为本地时间
             * 最后格式化输出（HH：24小时制；hh：12小时制）！
             */
            return new DateTime(1970, 1, 1, 0, 0, 0,DateTimeKind.Utc).AddSeconds(Convert.ToDouble(UnixTime)).ToLocalTime().ToString("yyyy/MM/dd HH:mm:ss");
        }

        #endregion

        #region "家电控制界面事件"\
        bool isLightOn = false;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            TcpClient TCPClient = null;
            NetworkStream TCPStream = null;
            try
            {
                TCPClient = new TcpClient();
                UnityModule.DebugPrint(" @ 创建TCP客户端连接，正在发送连接请求...");
                TCPClient.Connect("192.168.1.194", 1926);
                UnityModule.DebugPrint(" @ TCP连接创建成功");

                TCPStream = TCPClient.GetStream();
                UnityModule.DebugPrint(" @ TCP数据流创建成功");

                if (TCPStream.CanWrite)
                {
                    UnityModule.DebugPrint(" @ 正在发送家电控制指令...");
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(isLightOn ? "0" : "1");
                    TCPStream.Write(sendBytes, 0, sendBytes.Length);
                    isLightOn = !isLightOn;
                    UnityModule.DebugPrint(" @ 家电控制指令发送成功");
                    ShowTipsMessage("家电控制指令发送成功！", MyMessageBox.IconType.Info);
                }
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint(" @ 家电控制失败：{0}",ex.Message);
                ShowTipsMessage("家电控制指令发送失败！",ex.Message, MyMessageBox.IconType.Error);
            }

            TCPStream?.Close();
            TCPClient?.Close();
            UnityModule.DebugPrint("————————————————");
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            if (DomesticApplianceItem.ActiveItem == null) return;
            PowerButton.Image = UnityResource.Power_1;
            if (new MyMessageBox(string.Format("您确定要关闭家电 {0} 的电源吗？",DomesticApplianceItem.ActiveItem.Tag.ToString()),MyMessageBox.IconType.Question).ShowDialog(this) != DialogResult.OK) return;
            PowerButton.Image = UnityResource.Power_0;
            ShutdownDA(DomesticApplianceItem.ActiveItem.MAC);

            ShowTipsMessage("家电关闭成功：","家电 "+ DomesticApplianceItem.ActiveItem.Tag.ToString() +" 已关闭！",MyMessageBox.IconType.Info);

            ResetDAInfoTable();
            ResetDAEventList();
            (DomesticApplianceItem.ActiveItem as IDisposable).Dispose();
        }

        private void PowerButton_MouseEnter(object sender, EventArgs e)
        {
            if (DomesticApplianceItem.ActiveItem == null) return;
            PowerButton.Image = UnityResource.Power_1;
        }

        private void PowerButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (DomesticApplianceItem.ActiveItem == null) return;
            PowerButton.Image = UnityResource.Power_2;
        }

        private void PowerButton_MouseLeave(object sender, EventArgs e)
        {
            if (DomesticApplianceItem.ActiveItem == null) return;
            PowerButton.Image = UnityResource.Power_0;
        }

        /// <summary>
        /// 关闭家电的电源
        /// </summary>
        /// <param name="MAC">家电的MAC地址</param>
        private void ShutdownDA(string MAC)
        {
            //todo:使用网络协议发送关闭指令
            //一个简单的方法，在数据库将家电的在线特征置为 -1；
            UnityDBController.ExecuteNonQuery("UPDATE devicebase SET FD = {0} WHERE MAC='{1}'",-1,MAC);
        }

        #endregion

        #region "功能按钮流式布局区事件"

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UnityModule.DebugPrint("————————<<<  点击家电列表刷新按钮  >>>————————");
            SystemEngine.Stop();
            LoadDomesticAppliance();
            ShowTipsMessage("家电刷新完成：", "家电列表刷新完成！", MyMessageBox.IconType.Info);
            SystemEngine.Start();
        }

        private bool MicrophoneSwitch = false;
        private void VoiceButton_Click(object sender, EventArgs e)
        {
            UnityModule.DebugPrint("————————<<<  点击语音控制功能开关按钮  >>>————————");
            if (MicrophoneSwitch)
            {
                //关闭语音识别引擎
                UnitySREController.StopSREngine();
                MicrophoneSwitch = false;
                VoiceButton.Image = UnityResource.Microphone_Off;
                ShowTipsMessage("语音识别引擎：", "语音识别引擎已关闭！", MyMessageBox.IconType.Info);
            }
            else
            {
                //开启语音识别引擎
                if (UnitySREController.StartUpSREngine())
                {
                    MicrophoneSwitch = true;
                    VoiceButton.Image = UnityResource.Microphone_On;
                    ShowTipsMessage("语音识别引擎：", "语音识别引擎开启成功！", MyMessageBox.IconType.Info);
                }
                else {
                    ShowTipsMessage("语音识别引擎：", "语音识别引擎开启失败！", MyMessageBox.IconType.Warning);
                }
            }
        }

        private void VoiceButton_MouseDown(object sender, MouseEventArgs e)
        {
            VoiceButton.BackgroundImage = UnityResource.CircularButton_2;
        }

        private void VoiceButton_MouseEnter(object sender, EventArgs e)
        {
            VoiceButton.BackgroundImage = UnityResource.CircularButton_1;
        }

        private void VoiceButton_MouseLeave(object sender, EventArgs e)
        {
            VoiceButton.BackgroundImage = UnityResource.CircularButton_0;
        }
        
        private void VoiceButton_MouseUp(object sender, MouseEventArgs e)
        {
            VoiceButton.BackgroundImage = UnityResource.CircularButton_1;
        }

        #endregion

        #region "语音识别功能"

        /// <summary>
        /// 导入语音识别的语法
        /// </summary>
        private void LoadGrammar()
        {
            UnityModule.DebugPrint("开始导入语法...");
            try
            {
                //添加固定语法
                Choices GrammarChoice = new Choices();
                GrammarChoice.Add("你好");
                GrammarChoice.Add("hello");
                GrammarChoice.Add("刷新");
                GrammarChoice.Add("天气");
                GrammarChoice.Add("放松一下");
                GrammarChoice.Add("退出系统");
                UnitySREController.LoadGrammar(new Grammar(GrammarChoice.ToGrammarBuilder()));
                UnityModule.DebugPrint("固定短语导入完毕");

                //添加组合语法
                GrammarBuilder GrammarList = new GrammarBuilder();
                GrammarList.Append(new Choices("打开", "关闭"));
                GrammarList.Append(new Choices("电视", "空调", "电灯", "电风扇"));
                UnitySREController.LoadGrammar(new Grammar(GrammarList));

                UnityModule.DebugPrint("组合短语导入完毕");
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint("导入语法时遇到错误：{0}", ex.Message);
            }
        }

        /// <summary>
        /// 当 SpeechRecognitionEngine 采用与其加载启用的 Grammar 对象匹配的输入的时候引发
        /// </summary>
        /// <param name="VoiceCommand">识别到的语音指令</param>
        private void SpeechRecognized(object sender, string VoiceCommand)
        {
            switch (VoiceCommand)
            {
                case "hello":
                case "你好":
                    {
                        UnitySREController.VoiceSpeak("欢迎使用Smart Home，智能管家为您服务");
                        break;
                    }
                case "刷新":
                    {
                        UnityModule.DebugPrint("————————<<<  语音刷新指令  >>>————————");
                        LoadDomesticAppliance();
                        ShowTipsMessage("家电刷新完成：", "家电列表刷新完成！", MyMessageBox.IconType.Info);
                        break;
                    }
                case "放松一下":
                    {
                        string[] Jorks = new string[] {
                            "我有一个看家本领。什么？看家。",
                            "a说，你说我这穷日子过到啥时侯是个头啊？b说，那得看你能活多久了。",
                            "今天客户来银行取钱，坐下一句话说的我石化了：你好，我死期到了。",
                            "做人最失败的莫过于唐僧，身边的人不管是敌是友都想送他上西天",
                            "甲方的需求定下来，这次真不改了！",
                            "一首现代诗，《笑里藏刀》:哈哈哈哈哈哈哈哈哈哈哈哈哈哈刀哈哈哈哈哈哈哈哈哈哈哈哈哈哈",
                            "周末大家说要举行放鸽子大赛，最后，就我一个人去了。",
                            "公司举办扫雷大赛，第一名被辞退了",
                            "世界上有许多你意想不到的事，比如，你以为我要举个例子。",
                            "我就喜欢你看不惯我，还要和我一同建设社会主义的样子。",
                            "在此次打黑行动中，包拯壮烈牺牲",
                            "如果你每天能省下买一包烟的钱，那么十天后，你就能买十包。",
                            "三百六十行，行行要人命。",
                            "如果一个人没有梦想，那和无忧无虑有什么分别？",
                            "猜谜语：路边招手，打一出租车。",
                            "大爷说：你应该是象棋新手吧？我说：大爷，你怎么知道？大爷说：我在这玩了这么多年，第一步走帅的真不多",
                            "你的事就是我的事，我的事一般都懒得做。"
                        };
                        UnitySREController.VoiceSpeak(Jorks[new Random().Next(Jorks.Length)]);
                        break;
                    }
                case "天气":
                    {
                        UnitySREController.VoiceSpeak(string.Format("{0} 今日天气，{1}，实时温度，{2}，温度区间，{3}",CityNameLabel.Text,WeatherLabel.Text,TempLabel.Text, TempRngLabel.Text));
                        break;
                    }
                case "打开电视":
                case "关闭电视":
                case "打开空调":
                case "关闭空调":
                case "打开电灯":
                case "关闭电灯":
                case "打开电风扇":
                case "关闭电风扇":
                    {
                        UnitySREController.VoiceSpeak("正在为您" + VoiceCommand);
                        break;
                    }
                case "退出系统":
                    {
                        MainForm.ActiveForm.Close();
                        break;
                    }
                default:
                    {
                        UnitySREController.VoiceSpeak("我听不懂您在说什么");
                        UnityModule.DebugPrint("遇到未识别的指令：{0}",VoiceCommand);
                        break;
                    }
            }
        }

        #endregion

        #region "特殊方法"

        /// <summary>
        /// 判断家电是否在线
        /// </summary>
        /// <param name="MAC">家电的MAC地址</param>
        /// <returns>是否在线</returns>
        [Obsolete]
        private bool IsDAOnLine(string MAC)
        {
            object Result = UnityDBController.ExecuteScalar("SELECT FD FROM devicebase WHERE MAC='{0}'", MAC);
            if (Result == null) return false;
            return ((int)Result > -1);
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void SystemEngine_Tick(object sender, EventArgs e)
        {
            UnityModule.DebugPrint("————————<<<  心跳更新数据  >>>————————");
            TimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd\nhh:mm");

            LoadDomesticAppliance();

            if (PanelStatenow == PanelState.Info)
            {
                if (DomesticApplianceItem.ActiveItem != null && !string.IsNullOrEmpty(DomesticApplianceItem.ActiveItem.MAC))
                {
                    ShowDomesticApplianceInfo(DomesticApplianceItem.ActiveItem.MAC);
                    ShowDomesticApplianceEventLog(DomesticApplianceItem.ActiveItem.MAC);
                }
            }
            UnityModule.DebugPrint("——————————————————————————");
        }

        private void DomesticApplianceItem_ItemClick(object sender, EventArgs e)
        {
            object Result = UnityDBController.ExecuteScalar("SELECT FD FROM devicebase WHERE MAC='{0}'", (sender as DomesticApplianceItem).MAC);
            if (Result == null) return;
            if (-1 < (int)Result)
            {
                //如果用户点击的家电仍在线，更新家电信息
                UnityModule.DebugPrint("点击家电项目，加载家电信息和事件记录...");
                ShowDomesticApplianceInfo((sender as DomesticApplianceItem).MAC);

                ResetDAEventList();
                ShowDomesticApplianceEventLog((sender as DomesticApplianceItem).MAC);


                switch ((sender as DomesticApplianceItem).DAType)
                {
                    case "空调":
                        {
                            if (TVPanel.Visible) TVPanel.Hide();
                            AirConditioningPanel.Show();
                            AirConditioningPanel.BringToFront();
                            break;
                        }
                    case "电视":
                        {
                            if(AirConditioningPanel.Visible) AirConditioningPanel.Hide();
                            TVPanel.Show();
                            TVPanel.BringToFront();
                            break;
                        }
                    default:
                        {
                            TVPanel.Hide();
                            AirConditioningPanel.Hide();
                            break;
                        }

                }

            }
            else
            {
                ResetDAInfoTable();
                ResetDAEventList();
                (sender as IDisposable).Dispose();
            }
        }

        private void ControlLight()
        {

        }

        #endregion

    }
}
