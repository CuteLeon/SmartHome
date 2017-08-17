namespace 智能家居系统
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftPanel = new 智能家居系统.MyPanel();
            this.LogoPanel = new 智能家居系统.MyPanel();
            this.FunctionButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Label();
            this.VoiceButton = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.DomesticAppliancePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TopPanel = new 智能家居系统.MyPanel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.MainPanel = new 智能家居系统.MyPanel();
            this.CardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WeatherPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.TempRngLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.TipsBox = new 智能家居系统.MyPanel();
            this.TipsIconLabel = new System.Windows.Forms.Label();
            this.TipsMessageLabel = new System.Windows.Forms.Label();
            this.TipsTitleLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new 智能家居系统.MyPanel();
            this.EventListView = new System.Windows.Forms.ListView();
            this.EventTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InfoTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoTitle = new System.Windows.Forms.Label();
            this.DescriptionValueLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FDValueLabel = new System.Windows.Forms.Label();
            this.FDLabel = new System.Windows.Forms.Label();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ManufactorValueLabel = new System.Windows.Forms.Label();
            this.ManufactorLabel = new System.Windows.Forms.Label();
            this.ModelValueLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.DeviceNameValueLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.MACValueLabel = new System.Windows.Forms.Label();
            this.MACLabel = new System.Windows.Forms.Label();
            this.ControlPanel = new 智能家居系统.MyPanel();
            this.TVPanel = new 智能家居系统.MyPanel();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Label();
            this.PowerButton = new System.Windows.Forms.Label();
            this.SystemEngine = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.FunctionButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceButton)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.WeatherPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TipsBox.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.InfoTablePanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.TVPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Controls.Add(this.DomesticAppliancePanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(1, 1);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(240, 598);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Resize += new System.EventHandler(this.LeftPanel_Resize);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.FunctionButtonPanel);
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(240, 216);
            this.LogoPanel.TabIndex = 0;
            // 
            // FunctionButtonPanel
            // 
            this.FunctionButtonPanel.AutoScroll = true;
            this.FunctionButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FunctionButtonPanel.Controls.Add(this.RefreshButton);
            this.FunctionButtonPanel.Controls.Add(this.VoiceButton);
            this.FunctionButtonPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FunctionButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FunctionButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FunctionButtonPanel.ForeColor = System.Drawing.Color.Black;
            this.FunctionButtonPanel.Location = new System.Drawing.Point(0, 170);
            this.FunctionButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FunctionButtonPanel.Name = "FunctionButtonPanel";
            this.FunctionButtonPanel.Size = new System.Drawing.Size(240, 46);
            this.FunctionButtonPanel.TabIndex = 9;
            this.FunctionButtonPanel.WrapContents = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.RefreshButton.Image = global::智能家居系统.UnityResource.Refresh_0;
            this.RefreshButton.Location = new System.Drawing.Point(191, 0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(46, 46);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Tag = "Refresh";
            this.RefreshButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // VoiceButton
            // 
            this.VoiceButton.BackgroundImage = global::智能家居系统.UnityResource.CircularButton_0;
            this.VoiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoiceButton.Image = global::智能家居系统.UnityResource.Microphone_Off;
            this.VoiceButton.Location = new System.Drawing.Point(139, 0);
            this.VoiceButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.VoiceButton.Name = "VoiceButton";
            this.VoiceButton.Size = new System.Drawing.Size(46, 46);
            this.VoiceButton.TabIndex = 10;
            this.VoiceButton.TabStop = false;
            this.VoiceButton.Click += new System.EventHandler(this.VoiceButton_Click);
            this.VoiceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VoiceButton_MouseDown);
            this.VoiceButton.MouseEnter += new System.EventHandler(this.VoiceButton_MouseEnter);
            this.VoiceButton.MouseLeave += new System.EventHandler(this.VoiceButton_MouseLeave);
            this.VoiceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VoiceButton_MouseUp);
            // 
            // LogoLabel
            // 
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogoLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LogoLabel.Image = global::智能家居系统.UnityResource.Logo;
            this.LogoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.LogoLabel.Size = new System.Drawing.Size(240, 170);
            this.LogoLabel.TabIndex = 6;
            this.LogoLabel.Text = "智能家居解决方案";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // DomesticAppliancePanel
            // 
            this.DomesticAppliancePanel.AutoScroll = true;
            this.DomesticAppliancePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DomesticAppliancePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DomesticAppliancePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DomesticAppliancePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DomesticAppliancePanel.ForeColor = System.Drawing.Color.Black;
            this.DomesticAppliancePanel.Location = new System.Drawing.Point(0, 216);
            this.DomesticAppliancePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DomesticAppliancePanel.Name = "DomesticAppliancePanel";
            this.DomesticAppliancePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DomesticAppliancePanel.Size = new System.Drawing.Size(240, 382);
            this.DomesticAppliancePanel.TabIndex = 1;
            this.DomesticAppliancePanel.WrapContents = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TimeLabel.Location = new System.Drawing.Point(333, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(145, 80);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "yyyy/MM/dd\r\nhh:mm";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.TimeLabel);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.ControlLabel);
            this.TopPanel.Controls.Add(this.CardLabel);
            this.TopPanel.Controls.Add(this.InfoLabel);
            this.TopPanel.Controls.Add(this.TargetLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(241, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(558, 80);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Resize += new System.EventHandler(this.TopPanel_Resize);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.ExitButton.Image = global::智能家居系统.UnityResource.ExitApp_0;
            this.ExitButton.Location = new System.Drawing.Point(478, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 80);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Tag = "ExitApp";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ControlLabel
            // 
            this.ControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.ControlLabel.Image = global::智能家居系统.UnityResource.Control_0;
            this.ControlLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ControlLabel.Location = new System.Drawing.Point(114, 5);
            this.ControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(60, 60);
            this.ControlLabel.TabIndex = 2;
            this.ControlLabel.Tag = "Control";
            this.ControlLabel.Text = "控制";
            this.ControlLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ControlLabel.Click += new System.EventHandler(this.ControlLabel_Click);
            // 
            // CardLabel
            // 
            this.CardLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.CardLabel.Image = global::智能家居系统.UnityResource.Card_;
            this.CardLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CardLabel.Location = new System.Drawing.Point(234, 5);
            this.CardLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(60, 60);
            this.CardLabel.TabIndex = 1;
            this.CardLabel.Tag = "Card";
            this.CardLabel.Text = "卡片";
            this.CardLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CardLabel.Click += new System.EventHandler(this.CardLabel_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.InfoLabel.Image = global::智能家居系统.UnityResource.Info_;
            this.InfoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoLabel.Location = new System.Drawing.Point(174, 5);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(60, 60);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Tag = "Info";
            this.InfoLabel.Text = "信息";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            // 
            // TargetLabel
            // 
            this.TargetLabel.BackColor = System.Drawing.Color.Transparent;
            this.TargetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.TargetLabel.Image = global::智能家居系统.UnityResource.Target;
            this.TargetLabel.Location = new System.Drawing.Point(129, 65);
            this.TargetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(60, 15);
            this.TargetLabel.TabIndex = 4;
            this.TargetLabel.Tag = "";
            this.TargetLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.CardPanel);
            this.MainPanel.Controls.Add(this.TipsBox);
            this.MainPanel.Controls.Add(this.InfoPanel);
            this.MainPanel.Controls.Add(this.ControlPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(241, 81);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(558, 518);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Resize += new System.EventHandler(this.MainPanel_Resize);
            // 
            // CardPanel
            // 
            this.CardPanel.Controls.Add(this.WeatherPanel);
            this.CardPanel.Controls.Add(this.tableLayoutPanel1);
            this.CardPanel.Controls.Add(this.tableLayoutPanel2);
            this.CardPanel.Controls.Add(this.tableLayoutPanel3);
            this.CardPanel.Controls.Add(this.tableLayoutPanel4);
            this.CardPanel.Controls.Add(this.tableLayoutPanel5);
            this.CardPanel.Location = new System.Drawing.Point(0, 0);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(10);
            this.CardPanel.Size = new System.Drawing.Size(559, 518);
            this.CardPanel.TabIndex = 2;
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherPanel.BackgroundImage = global::智能家居系统.UnityResource.WeatherBGI;
            this.WeatherPanel.ColumnCount = 2;
            this.WeatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.70166F));
            this.WeatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.29834F));
            this.WeatherPanel.Controls.Add(this.WeatherLabel, 0, 0);
            this.WeatherPanel.Controls.Add(this.TempRngLabel, 1, 3);
            this.WeatherPanel.Controls.Add(this.TempLabel, 1, 0);
            this.WeatherPanel.Controls.Add(this.CityNameLabel, 0, 2);
            this.WeatherPanel.ForeColor = System.Drawing.Color.White;
            this.WeatherPanel.Location = new System.Drawing.Point(15, 15);
            this.WeatherPanel.Margin = new System.Windows.Forms.Padding(5);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Padding = new System.Windows.Forms.Padding(5);
            this.WeatherPanel.RowCount = 4;
            this.WeatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.WeatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.WeatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.WeatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.WeatherPanel.Size = new System.Drawing.Size(280, 158);
            this.WeatherPanel.TabIndex = 1;
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WeatherLabel.Location = new System.Drawing.Point(5, 5);
            this.WeatherLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherPanel.SetRowSpan(this.WeatherLabel, 3);
            this.WeatherLabel.Size = new System.Drawing.Size(90, 111);
            this.WeatherLabel.TabIndex = 3;
            this.WeatherLabel.Text = "多云转阵雨";
            this.WeatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempRngLabel
            // 
            this.TempRngLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TempRngLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TempRngLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TempRngLabel.Location = new System.Drawing.Point(95, 116);
            this.TempRngLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TempRngLabel.Name = "TempRngLabel";
            this.TempRngLabel.Size = new System.Drawing.Size(180, 37);
            this.TempRngLabel.TabIndex = 2;
            this.TempRngLabel.Text = "19℃ ~ 30℃";
            this.TempRngLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempLabel
            // 
            this.TempLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TempLabel.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TempLabel.Location = new System.Drawing.Point(95, 5);
            this.TempLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TempLabel.Name = "TempLabel";
            this.WeatherPanel.SetRowSpan(this.TempLabel, 3);
            this.TempLabel.Size = new System.Drawing.Size(180, 111);
            this.TempLabel.TabIndex = 1;
            this.TempLabel.Text = "23℃";
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CityNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityNameLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CityNameLabel.Location = new System.Drawing.Point(5, 116);
            this.CityNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(90, 37);
            this.CityNameLabel.TabIndex = 0;
            this.CityNameLabel.Text = "兰州";
            this.CityNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel1.BackgroundImage = global::智能家居系统.UnityResource.CardBGI_0;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CardNameLabel, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(305, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62025F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 158);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardNameLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CardNameLabel.Location = new System.Drawing.Point(3, 126);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(113, 32);
            this.CardNameLabel.TabIndex = 0;
            this.CardNameLabel.Text = "电视";
            this.CardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipsBox
            // 
            this.TipsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.TipsBox.Controls.Add(this.TipsIconLabel);
            this.TipsBox.Controls.Add(this.TipsMessageLabel);
            this.TipsBox.Controls.Add(this.TipsTitleLabel);
            this.TipsBox.Location = new System.Drawing.Point(290, 30);
            this.TipsBox.Margin = new System.Windows.Forms.Padding(0);
            this.TipsBox.Name = "TipsBox";
            this.TipsBox.Padding = new System.Windows.Forms.Padding(1);
            this.TipsBox.Size = new System.Drawing.Size(270, 90);
            this.TipsBox.TabIndex = 5;
            this.TipsBox.Visible = false;
            // 
            // TipsIconLabel
            // 
            this.TipsIconLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TipsIconLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TipsIconLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipsIconLabel.Location = new System.Drawing.Point(1, 25);
            this.TipsIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TipsIconLabel.Name = "TipsIconLabel";
            this.TipsIconLabel.Size = new System.Drawing.Size(60, 64);
            this.TipsIconLabel.TabIndex = 5;
            // 
            // TipsMessageLabel
            // 
            this.TipsMessageLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TipsMessageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TipsMessageLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipsMessageLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TipsMessageLabel.Location = new System.Drawing.Point(61, 25);
            this.TipsMessageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TipsMessageLabel.Name = "TipsMessageLabel";
            this.TipsMessageLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TipsMessageLabel.Size = new System.Drawing.Size(208, 64);
            this.TipsMessageLabel.TabIndex = 4;
            this.TipsMessageLabel.Text = "智能家居解决方案";
            this.TipsMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipsTitleLabel
            // 
            this.TipsTitleLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TipsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipsTitleLabel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.TipsTitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TipsTitleLabel.Image = global::智能家居系统.UnityResource.Close_1;
            this.TipsTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipsTitleLabel.Location = new System.Drawing.Point(1, 1);
            this.TipsTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TipsTitleLabel.Name = "TipsTitleLabel";
            this.TipsTitleLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TipsTitleLabel.Size = new System.Drawing.Size(268, 24);
            this.TipsTitleLabel.TabIndex = 3;
            this.TipsTitleLabel.Text = "智能家居解决方案";
            this.TipsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TipsTitleLabel.Click += new System.EventHandler(this.TipsTitleLabel_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Controls.Add(this.EventListView);
            this.InfoPanel.Controls.Add(this.InfoTablePanel);
            this.InfoPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Padding = new System.Windows.Forms.Padding(15);
            this.InfoPanel.Size = new System.Drawing.Size(558, 518);
            this.InfoPanel.TabIndex = 4;
            this.InfoPanel.Visible = false;
            // 
            // EventListView
            // 
            this.EventListView.BackColor = System.Drawing.Color.White;
            this.EventListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventTimeColumnHeader,
            this.EventNameColumnHeader,
            this.EventDescriptionColumnHeader});
            this.EventListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventListView.FullRowSelect = true;
            this.EventListView.Location = new System.Drawing.Point(15, 245);
            this.EventListView.MinimumSize = new System.Drawing.Size(0, 250);
            this.EventListView.MultiSelect = false;
            this.EventListView.Name = "EventListView";
            this.EventListView.ShowGroups = false;
            this.EventListView.Size = new System.Drawing.Size(528, 258);
            this.EventListView.TabIndex = 3;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            this.EventListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.EventView_ColumnClick);
            // 
            // EventTimeColumnHeader
            // 
            this.EventTimeColumnHeader.Text = "事件时间";
            this.EventTimeColumnHeader.Width = 150;
            // 
            // EventNameColumnHeader
            // 
            this.EventNameColumnHeader.Text = "事件名称";
            this.EventNameColumnHeader.Width = 140;
            // 
            // EventDescriptionColumnHeader
            // 
            this.EventDescriptionColumnHeader.Text = "事件描述";
            this.EventDescriptionColumnHeader.Width = 400;
            // 
            // InfoTablePanel
            // 
            this.InfoTablePanel.AutoSize = true;
            this.InfoTablePanel.BackColor = System.Drawing.Color.White;
            this.InfoTablePanel.ColumnCount = 2;
            this.InfoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoTablePanel.Controls.Add(this.InfoTitle, 0, 0);
            this.InfoTablePanel.Controls.Add(this.DescriptionValueLabel, 1, 7);
            this.InfoTablePanel.Controls.Add(this.DescriptionLabel, 0, 7);
            this.InfoTablePanel.Controls.Add(this.FDValueLabel, 1, 6);
            this.InfoTablePanel.Controls.Add(this.FDLabel, 0, 6);
            this.InfoTablePanel.Controls.Add(this.TypeValueLabel, 1, 4);
            this.InfoTablePanel.Controls.Add(this.TypeLabel, 0, 4);
            this.InfoTablePanel.Controls.Add(this.ManufactorValueLabel, 1, 3);
            this.InfoTablePanel.Controls.Add(this.ManufactorLabel, 0, 3);
            this.InfoTablePanel.Controls.Add(this.ModelValueLabel, 1, 2);
            this.InfoTablePanel.Controls.Add(this.ModelLabel, 0, 2);
            this.InfoTablePanel.Controls.Add(this.DeviceNameValueLabel, 1, 1);
            this.InfoTablePanel.Controls.Add(this.DeviceNameLabel, 0, 1);
            this.InfoTablePanel.Controls.Add(this.MACValueLabel, 1, 5);
            this.InfoTablePanel.Controls.Add(this.MACLabel, 0, 5);
            this.InfoTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoTablePanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoTablePanel.Location = new System.Drawing.Point(15, 15);
            this.InfoTablePanel.Name = "InfoTablePanel";
            this.InfoTablePanel.RowCount = 8;
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoTablePanel.Size = new System.Drawing.Size(528, 230);
            this.InfoTablePanel.TabIndex = 2;
            // 
            // InfoTitle
            // 
            this.InfoTablePanel.SetColumnSpan(this.InfoTitle, 2);
            this.InfoTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoTitle.Location = new System.Drawing.Point(5, 5);
            this.InfoTitle.Margin = new System.Windows.Forms.Padding(5);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(518, 26);
            this.InfoTitle.TabIndex = 12;
            this.InfoTitle.Text = "家用电器信息";
            this.InfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionValueLabel
            // 
            this.DescriptionValueLabel.AutoSize = true;
            this.DescriptionValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DescriptionValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DescriptionValueLabel.Location = new System.Drawing.Point(267, 198);
            this.DescriptionValueLabel.Name = "DescriptionValueLabel";
            this.DescriptionValueLabel.Size = new System.Drawing.Size(258, 32);
            this.DescriptionValueLabel.TabIndex = 11;
            this.DescriptionValueLabel.Text = "(unknown)";
            this.DescriptionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 198);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(258, 32);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.Text = "描述：";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FDValueLabel
            // 
            this.FDValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FDValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FDValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FDValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FDValueLabel.Location = new System.Drawing.Point(267, 172);
            this.FDValueLabel.Name = "FDValueLabel";
            this.FDValueLabel.Size = new System.Drawing.Size(258, 26);
            this.FDValueLabel.TabIndex = 9;
            this.FDValueLabel.Text = "(unknown)";
            this.FDValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDLabel
            // 
            this.FDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FDLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FDLabel.Location = new System.Drawing.Point(3, 172);
            this.FDLabel.Name = "FDLabel";
            this.FDLabel.Size = new System.Drawing.Size(258, 26);
            this.FDLabel.TabIndex = 8;
            this.FDLabel.Text = "连接号：";
            this.FDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TypeValueLabel.Location = new System.Drawing.Point(267, 114);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(258, 26);
            this.TypeValueLabel.TabIndex = 7;
            this.TypeValueLabel.Text = "(unknown)";
            this.TypeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeLabel.Location = new System.Drawing.Point(3, 114);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(258, 26);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "类型：";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufactorValueLabel
            // 
            this.ManufactorValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManufactorValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManufactorValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManufactorValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManufactorValueLabel.Location = new System.Drawing.Point(267, 88);
            this.ManufactorValueLabel.Name = "ManufactorValueLabel";
            this.ManufactorValueLabel.Size = new System.Drawing.Size(258, 26);
            this.ManufactorValueLabel.TabIndex = 5;
            this.ManufactorValueLabel.Text = "(unknown)";
            this.ManufactorValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufactorLabel
            // 
            this.ManufactorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManufactorLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManufactorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManufactorLabel.Location = new System.Drawing.Point(3, 88);
            this.ManufactorLabel.Name = "ManufactorLabel";
            this.ManufactorLabel.Size = new System.Drawing.Size(258, 26);
            this.ManufactorLabel.TabIndex = 4;
            this.ManufactorLabel.Text = "厂商：";
            this.ManufactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelValueLabel
            // 
            this.ModelValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModelValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModelValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModelValueLabel.Location = new System.Drawing.Point(267, 62);
            this.ModelValueLabel.Name = "ModelValueLabel";
            this.ModelValueLabel.Size = new System.Drawing.Size(258, 26);
            this.ModelValueLabel.TabIndex = 3;
            this.ModelValueLabel.Text = "(unknown)";
            this.ModelValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModelLabel.Location = new System.Drawing.Point(3, 62);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(258, 26);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "家电型号：";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeviceNameValueLabel
            // 
            this.DeviceNameValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceNameValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceNameValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeviceNameValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeviceNameValueLabel.Location = new System.Drawing.Point(267, 36);
            this.DeviceNameValueLabel.Name = "DeviceNameValueLabel";
            this.DeviceNameValueLabel.Size = new System.Drawing.Size(258, 26);
            this.DeviceNameValueLabel.TabIndex = 1;
            this.DeviceNameValueLabel.Text = "(unknown)";
            this.DeviceNameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeviceNameLabel.Location = new System.Drawing.Point(3, 36);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(258, 26);
            this.DeviceNameLabel.TabIndex = 13;
            this.DeviceNameLabel.Text = "家电名称：";
            this.DeviceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MACValueLabel
            // 
            this.MACValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MACValueLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MACValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MACValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MACValueLabel.Location = new System.Drawing.Point(267, 140);
            this.MACValueLabel.Name = "MACValueLabel";
            this.MACValueLabel.Size = new System.Drawing.Size(258, 32);
            this.MACValueLabel.TabIndex = 16;
            this.MACValueLabel.Text = "(unknown)";
            this.MACValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MACLabel
            // 
            this.MACLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MACLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MACLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MACLabel.Location = new System.Drawing.Point(3, 140);
            this.MACLabel.Name = "MACLabel";
            this.MACLabel.Size = new System.Drawing.Size(258, 32);
            this.MACLabel.TabIndex = 14;
            this.MACLabel.Text = "MAC：";
            this.MACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.Controls.Add(this.TVPanel);
            this.ControlPanel.Controls.Add(this.ExecuteButton);
            this.ControlPanel.Controls.Add(this.PowerButton);
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ControlPanel.Size = new System.Drawing.Size(558, 518);
            this.ControlPanel.TabIndex = 3;
            // 
            // TVPanel
            // 
            this.TVPanel.Controls.Add(this.ChannelLabel);
            this.TVPanel.Controls.Add(this.ChannelBox);
            this.TVPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVPanel.Location = new System.Drawing.Point(15, 135);
            this.TVPanel.Name = "TVPanel";
            this.TVPanel.Size = new System.Drawing.Size(528, 248);
            this.TVPanel.TabIndex = 6;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChannelLabel.Location = new System.Drawing.Point(82, 113);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(162, 37);
            this.ChannelLabel.TabIndex = 10;
            this.ChannelLabel.Text = "频道：";
            this.ChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChannelBox
            // 
            this.ChannelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelBox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChannelBox.Location = new System.Drawing.Point(258, 116);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(192, 34);
            this.ChannelBox.TabIndex = 0;
            this.ChannelBox.Text = "5";
            this.ChannelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.Transparent;
            this.ExecuteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExecuteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.ExecuteButton.Image = global::智能家居系统.UnityResource.Execute_0;
            this.ExecuteButton.Location = new System.Drawing.Point(15, 383);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(528, 120);
            this.ExecuteButton.TabIndex = 5;
            this.ExecuteButton.Tag = "Execute";
            this.ExecuteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.BackColor = System.Drawing.Color.Transparent;
            this.PowerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PowerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.PowerButton.Image = ((System.Drawing.Image)(resources.GetObject("PowerButton.Image")));
            this.PowerButton.Location = new System.Drawing.Point(15, 15);
            this.PowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(528, 120);
            this.PowerButton.TabIndex = 4;
            this.PowerButton.Tag = "";
            this.PowerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            this.PowerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PowerButton_MouseDown);
            this.PowerButton.MouseEnter += new System.EventHandler(this.PowerButton_MouseEnter);
            this.PowerButton.MouseLeave += new System.EventHandler(this.PowerButton_MouseLeave);
            // 
            // SystemEngine
            // 
            this.SystemEngine.Enabled = true;
            this.SystemEngine.Interval = 5000;
            this.SystemEngine.Tick += new System.EventHandler(this.SystemEngine_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 126);
            this.label1.TabIndex = 1;
            this.label1.Text = "CH：5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel2.BackgroundImage = global::智能家居系统.UnityResource.CardBGI_1;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 183);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62025F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 158);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 126);
            this.label2.TabIndex = 1;
            this.label2.Text = "26 ℃";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "空调";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel3.BackgroundImage = global::智能家居系统.UnityResource.CardBGI_2;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(244, 183);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62025F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(299, 158);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 126);
            this.label4.TabIndex = 1;
            this.label4.Text = "正在甩干";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "洗衣机";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel4.BackgroundImage = global::智能家居系统.UnityResource.CardBGI_3;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 351);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62025F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 158);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 126);
            this.label6.TabIndex = 1;
            this.label6.Text = "已闭锁";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(3, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "电磁门";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel5.BackgroundImage = global::智能家居系统.UnityResource.CardBGI_4;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(284, 351);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62025F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(259, 158);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 126);
            this.label8.TabIndex = 1;
            this.label8.Text = "待机中...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(3, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "电风扇";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能家居系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.LeftPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.FunctionButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VoiceButton)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.WeatherPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TipsBox.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.InfoTablePanel.ResumeLayout(false);
            this.InfoTablePanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.TVPanel.ResumeLayout(false);
            this.TVPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private 智能家居系统.MyPanel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel DomesticAppliancePanel;
        private 智能家居系统.MyPanel TopPanel;
        private System.Windows.Forms.Label InfoLabel;
        private 智能家居系统.MyPanel MainPanel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer SystemEngine;
        private 智能家居系统.MyPanel ControlPanel;
        private 智能家居系统.MyPanel InfoPanel;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.TableLayoutPanel InfoTablePanel;
        private System.Windows.Forms.Label DescriptionValueLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label FDValueLabel;
        private System.Windows.Forms.Label FDLabel;
        private System.Windows.Forms.Label TypeValueLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ManufactorValueLabel;
        private System.Windows.Forms.Label ManufactorLabel;
        private System.Windows.Forms.Label ModelValueLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label DeviceNameValueLabel;
        private System.Windows.Forms.Label InfoTitle;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.ListView EventListView;
        private System.Windows.Forms.ColumnHeader EventNameColumnHeader;
        private System.Windows.Forms.ColumnHeader EventDescriptionColumnHeader;
        private System.Windows.Forms.Label MACValueLabel;
        private System.Windows.Forms.Label MACLabel;
        private System.Windows.Forms.ColumnHeader EventTimeColumnHeader;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Label PowerButton;
        private 智能家居系统.MyPanel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.FlowLayoutPanel FunctionButtonPanel;
        private System.Windows.Forms.PictureBox VoiceButton;
        private System.Windows.Forms.Label RefreshButton;
        private 智能家居系统.MyPanel TipsBox;
        private System.Windows.Forms.Label TipsIconLabel;
        private System.Windows.Forms.Label TipsMessageLabel;
        private System.Windows.Forms.Label TipsTitleLabel;
        private System.Windows.Forms.Label ExecuteButton;
        private MyPanel TVPanel;
        private System.Windows.Forms.TextBox ChannelBox;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.TableLayoutPanel WeatherPanel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.FlowLayoutPanel CardPanel;
        private System.Windows.Forms.Label TempRngLabel;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

