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
            this.LeftPanel = new 数码复印机保密检查系统.MyPanel();
            this.DomesticAppliancePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TopPanel = new 数码复印机保密检查系统.MyPanel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.MainPanel = new 数码复印机保密检查系统.MyPanel();
            this.CardPanel = new 数码复印机保密检查系统.MyPanel();
            this.ControlPanel = new 数码复印机保密检查系统.MyPanel();
            this.InfoPanel = new 数码复印机保密检查系统.MyPanel();
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
            this.DateAndTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.InfoTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LeftPanel.Controls.Add(this.DomesticAppliancePanel);
            this.LeftPanel.Controls.Add(this.LogoLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(1, 1);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(240, 598);
            this.LeftPanel.TabIndex = 0;
            // 
            // DomesticAppliancePanel
            // 
            this.DomesticAppliancePanel.AutoScroll = true;
            this.DomesticAppliancePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DomesticAppliancePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DomesticAppliancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DomesticAppliancePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DomesticAppliancePanel.ForeColor = System.Drawing.Color.Black;
            this.DomesticAppliancePanel.Location = new System.Drawing.Point(0, 200);
            this.DomesticAppliancePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DomesticAppliancePanel.Name = "DomesticAppliancePanel";
            this.DomesticAppliancePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DomesticAppliancePanel.Size = new System.Drawing.Size(240, 398);
            this.DomesticAppliancePanel.TabIndex = 1;
            this.DomesticAppliancePanel.WrapContents = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogoLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LogoLabel.Image = global::智能家居系统.UnityResource.Logo;
            this.LogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LogoLabel.Size = new System.Drawing.Size(240, 200);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "智能家居解决方案";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
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
            this.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.MainPanel.Controls.Add(this.ControlPanel);
            this.MainPanel.Controls.Add(this.InfoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(241, 81);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(558, 518);
            this.MainPanel.TabIndex = 2;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.Transparent;
            this.CardPanel.Location = new System.Drawing.Point(0, 0);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(15);
            this.CardPanel.Size = new System.Drawing.Size(600, 518);
            this.CardPanel.TabIndex = 5;
            this.CardPanel.Visible = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ControlPanel.Size = new System.Drawing.Size(600, 518);
            this.ControlPanel.TabIndex = 3;
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
            this.InfoPanel.Size = new System.Drawing.Size(600, 518);
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
            this.EventListView.Size = new System.Drawing.Size(570, 258);
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
            this.InfoTablePanel.Size = new System.Drawing.Size(570, 230);
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
            this.InfoTitle.Size = new System.Drawing.Size(560, 26);
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
            this.DescriptionValueLabel.Location = new System.Drawing.Point(288, 198);
            this.DescriptionValueLabel.Name = "DescriptionValueLabel";
            this.DescriptionValueLabel.Size = new System.Drawing.Size(279, 32);
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
            this.DescriptionLabel.Size = new System.Drawing.Size(279, 32);
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
            this.FDValueLabel.Location = new System.Drawing.Point(288, 172);
            this.FDValueLabel.Name = "FDValueLabel";
            this.FDValueLabel.Size = new System.Drawing.Size(279, 26);
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
            this.FDLabel.Size = new System.Drawing.Size(279, 26);
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
            this.TypeValueLabel.Location = new System.Drawing.Point(288, 114);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(279, 26);
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
            this.TypeLabel.Size = new System.Drawing.Size(279, 26);
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
            this.ManufactorValueLabel.Location = new System.Drawing.Point(288, 88);
            this.ManufactorValueLabel.Name = "ManufactorValueLabel";
            this.ManufactorValueLabel.Size = new System.Drawing.Size(279, 26);
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
            this.ManufactorLabel.Size = new System.Drawing.Size(279, 26);
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
            this.ModelValueLabel.Location = new System.Drawing.Point(288, 62);
            this.ModelValueLabel.Name = "ModelValueLabel";
            this.ModelValueLabel.Size = new System.Drawing.Size(279, 26);
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
            this.ModelLabel.Size = new System.Drawing.Size(279, 26);
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
            this.DeviceNameValueLabel.Location = new System.Drawing.Point(288, 36);
            this.DeviceNameValueLabel.Name = "DeviceNameValueLabel";
            this.DeviceNameValueLabel.Size = new System.Drawing.Size(279, 26);
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
            this.DeviceNameLabel.Size = new System.Drawing.Size(279, 26);
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
            this.MACValueLabel.Location = new System.Drawing.Point(288, 140);
            this.MACValueLabel.Name = "MACValueLabel";
            this.MACValueLabel.Size = new System.Drawing.Size(279, 32);
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
            this.MACLabel.Size = new System.Drawing.Size(279, 32);
            this.MACLabel.TabIndex = 14;
            this.MACLabel.Text = "MAC：";
            this.MACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateAndTimeTimer
            // 
            this.DateAndTimeTimer.Enabled = true;
            this.DateAndTimeTimer.Interval = 5000;
            this.DateAndTimeTimer.Tick += new System.EventHandler(this.DateAndTimeTimer_Tick);
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
            this.TopPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.InfoTablePanel.ResumeLayout(false);
            this.InfoTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private 数码复印机保密检查系统.MyPanel LeftPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.FlowLayoutPanel DomesticAppliancePanel;
        private 数码复印机保密检查系统.MyPanel TopPanel;
        private System.Windows.Forms.Label InfoLabel;
        private 数码复印机保密检查系统.MyPanel MainPanel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer DateAndTimeTimer;
        private 数码复印机保密检查系统.MyPanel ControlPanel;
        private 数码复印机保密检查系统.MyPanel InfoPanel;
        private 数码复印机保密检查系统.MyPanel CardPanel;
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
    }
}

