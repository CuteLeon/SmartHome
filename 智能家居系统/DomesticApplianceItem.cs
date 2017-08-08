using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能家居系统
{
    public partial class DomesticApplianceItem : UserControl,IDisposable
    {
        /// <summary>
        /// 放置家电项目的容器控件
        /// </summary>
        public static FlowLayoutPanel ParentPanel = null;
        /// <summary>
        /// 当前激活的家电项目
        /// </summary>
        private static DomesticApplianceItem activeItem = null;
        /// <summary>
        /// 当前家电列表里被激活的项目（可能为null；只读；）
        /// </summary>
        public static DomesticApplianceItem ActiveItem { get => activeItem;}

        /// <summary>
        /// 家电MAC与家电项目字典
        /// </summary>
        private static Dictionary<string, DomesticApplianceItem> DADictionary = new Dictionary<string, DomesticApplianceItem>();
        /// <summary>
        /// 当前家电项目对象的MAC
        /// </summary>
        public string MAC => Name;
        /// <summary>
        /// 家电厂商
        /// </summary>
        private readonly string Manufactor;
        /// <summary>
        /// 家电型号
        /// </summary>
        private readonly string Model;

        /// <summary>
        /// 继承自 IDisposable 接口，释放托管资源并自动从家电字典里移除此项（注意：必须使用 IDisposable 接口调用此方法）
        /// </summary>
        void IDisposable.Dispose()
        {
            try
            {
                //从字典移除此家电项目
                DADictionary.Remove(MAC);
                if (ParentPanel != null)
                {
                    int ThisIndex = ParentPanel.Controls.GetChildIndex(this);
                    ParentPanel.Controls.Remove(this);
                    if (ParentPanel.Controls.Count > 0)
                    {
                        UnityModule.DebugPrint("家电项目移除成功，正在激活临近项目");
                        activeItem =ParentPanel.Controls[Math.Min(ThisIndex,ParentPanel.Controls.Count-1)] as DomesticApplianceItem;
                        activeItem.DomesticApplianceItem_Click(activeItem,new EventArgs());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("家电[{0}]释放托管内存前预处理时出错：{1}",MAC,ex.Message);
            }

            base.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 判断指定MAC的家电是否已经存在于家电字典里（静态方法）
        /// </summary>
        /// <param name="mac">家电MAC</param>
        /// <returns>是否已经存在</returns>
        static public bool DAExists(string mac)
        {
            if (DADictionary == null) return false;
            try
            {
                return DADictionary.ContainsKey(mac);
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint("查询家电是否已经存在时遇到错误："+ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 根据家电MAC获得对应的家电项目
        /// </summary>
        /// <param name="MAC">家电MAC</param>
        /// <returns>获得MAC对应的家电项目（不存在时返回null）</returns>
        static public DomesticApplianceItem GetDAByMAC(string MAC)
        {
            DomesticApplianceItem TargetDA;
            return (DADictionary.TryGetValue(MAC, out TargetDA) ? TargetDA : null);
        }

        /// <summary>
        /// 点击家电项目
        /// </summary>
        public event EventHandler ItemClick;

        /// <summary>
        /// 创建新的家电项目（构造函数）
        /// </summary>
        /// <param name="mac">家电设备的MAC</param>
        /// <param name="manufactor">家电设备的厂商</param>
        /// <param name="model">家电设备的型号</param>
        public DomesticApplianceItem(string mac,string manufactor, string model)
        {
            InitializeComponent();
            //以设备MAC地址为键维护家电设备字典
            if (!string.IsNullOrEmpty(mac))
            {
                //以MAC为Name
                Name = mac;
                DADictionary.Add(mac, this);

                Manufactor = manufactor;
                Model = model;

                UnityModule.DebugPrint("以MAC为键，将家电加入在线家电字典");
            }
            else
            {
                UnityModule.DebugPrint("MAC为空，无法创建家电项目");
                throw new Exception("家电设备MAC为空，无法创建家电项目！");
            }
        }

        /// <summary>
        /// 修改家电信息
        /// </summary>
        /// <param name="DeviceName">家电设备的名称</param>
        /// <param name="Description">家电设备的型号</param>
        public void SetDeviceNameAndDescription(string DeviceName,string Description)
        {
            UnityModule.DebugPrint("修改家电控件信息：{0} / {1}",DeviceName,Description);
            DeviceNameLabel.Text = string.Format("{0} ({1})", DeviceName, (Model.StartsWith(Manufactor) ? Model : Manufactor + "-" + Model));
            this.Tag = DeviceNameLabel.Text;
            DescriptionLabel.Text = Description;
        }

        private void DomesticApplianceItem_Load(object sender, EventArgs e)
        {
            MouseEnter += new System.EventHandler(Controls_MouseEnter);
            MouseLeave += new System.EventHandler(Controls_MouseLeave);
            Click += new System.EventHandler(DomesticApplianceItem_Click);

            TypeLogoLabel.MouseLeave += new System.EventHandler(Controls_MouseLeave);
            TypeLogoLabel.Click += new System.EventHandler(DomesticApplianceItem_Click);

            DeviceNameLabel.MouseLeave += new System.EventHandler(Controls_MouseLeave);
            DeviceNameLabel.Click += new System.EventHandler(DomesticApplianceItem_Click);

            DescriptionLabel.MouseLeave += new System.EventHandler(Controls_MouseLeave);
            DescriptionLabel.Click += new System.EventHandler(DomesticApplianceItem_Click);
        }

        private void DomesticApplianceItem_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics MyGraphics = e.Graphics)
                using (Pen MyPen = new Pen(Color.LightGray, 2))
                    MyGraphics.DrawLine(MyPen,0,0,this.Width-1,0);
        }

        private void Controls_MouseEnter(object sender, EventArgs e)
        {
            if(ActiveItem!=this) this.BackColor = Color.Gainsboro;
        }

        private void Controls_MouseLeave(object sender, EventArgs e)
        {
            if (!this.RectangleToScreen(this.DisplayRectangle).Contains(MousePosition))
            {
                DeviceNameLabel.ForeColor = ActiveItem == this ? Color.DeepSkyBlue : Color.Black;
                this.BackColor = ActiveItem == this?Color.LightGray : Color.WhiteSmoke;
            }
        }

        private void DomesticApplianceItem_Click(object sender, EventArgs e)
        {
            if (activeItem != this)
            {
                if (activeItem != null)
                {
                    ActiveItem.DeviceNameLabel.ForeColor = Color.Black;
                    ActiveItem.BackColor = Color.WhiteSmoke;
                }
                activeItem = this;
            }
            DeviceNameLabel.ForeColor = Color.DeepSkyBlue;
            this.BackColor = Color.LightGray;
            this.Refresh();
            if (ItemClick != null) ItemClick(this,e);
        }

    }
}
