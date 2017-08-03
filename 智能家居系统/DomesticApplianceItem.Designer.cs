namespace 智能家居系统
{
    partial class DomesticApplianceItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TypeLogoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.AutoSize = true;
            this.DeviceNameLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceNameLabel.Location = new System.Drawing.Point(50, 14);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(103, 20);
            this.DeviceNameLabel.TabIndex = 1;
            this.DeviceNameLabel.Text = "(默认家用电器)";
            this.DeviceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.DescriptionLabel.Location = new System.Drawing.Point(50, 38);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(163, 20);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "欢迎使用智能家居系统！";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeLogoLabel
            // 
            this.TypeLogoLabel.Image = global::智能家居系统.UnityResource.DefaultLogo;
            this.TypeLogoLabel.Location = new System.Drawing.Point(0, 10);
            this.TypeLogoLabel.Name = "TypeLogoLabel";
            this.TypeLogoLabel.Size = new System.Drawing.Size(50, 50);
            this.TypeLogoLabel.TabIndex = 0;
            // 
            // DomesticApplianceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DeviceNameLabel);
            this.Controls.Add(this.TypeLogoLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DomesticApplianceItem";
            this.Size = new System.Drawing.Size(215, 70);
            this.Load += new System.EventHandler(this.DomesticApplianceItem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DomesticApplianceItem_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLogoLabel;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}
