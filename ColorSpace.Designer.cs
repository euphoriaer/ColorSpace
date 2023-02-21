namespace ColorSpace
{
    partial class ColorSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSpace));
            this.TextureTransform = new System.Windows.Forms.Button();
            this.FolderTransform = new System.Windows.Forms.Button();
            this.RChannel = new System.Windows.Forms.CheckBox();
            this.selectTitle = new System.Windows.Forms.Label();
            this.GChannel = new System.Windows.Forms.CheckBox();
            this.BChannel = new System.Windows.Forms.CheckBox();
            this.AChannel = new System.Windows.Forms.CheckBox();
            this.GammaToLinner = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinnerToGamma = new System.Windows.Forms.CheckBox();
            this.Custom = new System.Windows.Forms.CheckBox();
            this.CustomValue = new System.Windows.Forms.TextBox();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.DragTip = new System.Windows.Forms.Label();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextureTransform
            // 
            this.TextureTransform.Location = new System.Drawing.Point(12, 12);
            this.TextureTransform.Name = "TextureTransform";
            this.TextureTransform.Size = new System.Drawing.Size(135, 35);
            this.TextureTransform.TabIndex = 0;
            this.TextureTransform.Text = "单个文件转换";
            this.TextureTransform.UseVisualStyleBackColor = true;
            this.TextureTransform.Click += new System.EventHandler(this.TextureTransform_Click);
            // 
            // FolderTransform
            // 
            this.FolderTransform.Location = new System.Drawing.Point(12, 53);
            this.FolderTransform.Name = "FolderTransform";
            this.FolderTransform.Size = new System.Drawing.Size(135, 36);
            this.FolderTransform.TabIndex = 1;
            this.FolderTransform.Text = "文件夹批量转换";
            this.FolderTransform.UseVisualStyleBackColor = true;
            this.FolderTransform.Click += new System.EventHandler(this.FolderTransform_Click);
            // 
            // RChannel
            // 
            this.RChannel.AutoSize = true;
            this.RChannel.Location = new System.Drawing.Point(284, 17);
            this.RChannel.Name = "RChannel";
            this.RChannel.Size = new System.Drawing.Size(35, 21);
            this.RChannel.TabIndex = 2;
            this.RChannel.Text = "R";
            this.RChannel.UseVisualStyleBackColor = true;
            this.RChannel.CheckedChanged += new System.EventHandler(this.RChannel_CheckedChanged);
            // 
            // selectTitle
            // 
            this.selectTitle.AutoSize = true;
            this.selectTitle.Location = new System.Drawing.Point(187, 21);
            this.selectTitle.Name = "selectTitle";
            this.selectTitle.Size = new System.Drawing.Size(80, 17);
            this.selectTitle.TabIndex = 3;
            this.selectTitle.Text = "转换通道选择";
            // 
            // GChannel
            // 
            this.GChannel.AutoSize = true;
            this.GChannel.Location = new System.Drawing.Point(325, 17);
            this.GChannel.Name = "GChannel";
            this.GChannel.Size = new System.Drawing.Size(36, 21);
            this.GChannel.TabIndex = 4;
            this.GChannel.Text = "G";
            this.GChannel.UseVisualStyleBackColor = true;
            this.GChannel.CheckedChanged += new System.EventHandler(this.GChannel_CheckedChanged);
            // 
            // BChannel
            // 
            this.BChannel.AutoSize = true;
            this.BChannel.Location = new System.Drawing.Point(366, 17);
            this.BChannel.Name = "BChannel";
            this.BChannel.Size = new System.Drawing.Size(35, 21);
            this.BChannel.TabIndex = 5;
            this.BChannel.Text = "B";
            this.BChannel.UseVisualStyleBackColor = true;
            this.BChannel.CheckedChanged += new System.EventHandler(this.BChannel_CheckedChanged);
            // 
            // AChannel
            // 
            this.AChannel.AutoSize = true;
            this.AChannel.Location = new System.Drawing.Point(407, 17);
            this.AChannel.Name = "AChannel";
            this.AChannel.Size = new System.Drawing.Size(35, 21);
            this.AChannel.TabIndex = 6;
            this.AChannel.Text = "A";
            this.AChannel.UseVisualStyleBackColor = true;
            this.AChannel.CheckedChanged += new System.EventHandler(this.AChannel_CheckedChanged);
            // 
            // GammaToLinner
            // 
            this.GammaToLinner.AutoSize = true;
            this.GammaToLinner.Location = new System.Drawing.Point(284, 53);
            this.GammaToLinner.Name = "GammaToLinner";
            this.GammaToLinner.Size = new System.Drawing.Size(122, 21);
            this.GammaToLinner.TabIndex = 7;
            this.GammaToLinner.Text = "GammaToLinner";
            this.GammaToLinner.UseVisualStyleBackColor = true;
            this.GammaToLinner.CheckedChanged += new System.EventHandler(this.GammaToLinner_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "转换方式";
            // 
            // LinnerToGamma
            // 
            this.LinnerToGamma.AutoSize = true;
            this.LinnerToGamma.Location = new System.Drawing.Point(284, 80);
            this.LinnerToGamma.Name = "LinnerToGamma";
            this.LinnerToGamma.Size = new System.Drawing.Size(122, 21);
            this.LinnerToGamma.TabIndex = 9;
            this.LinnerToGamma.Text = "LinnerToGamma";
            this.LinnerToGamma.UseVisualStyleBackColor = true;
            this.LinnerToGamma.CheckedChanged += new System.EventHandler(this.LinnerToGamma_CheckedChanged);
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(284, 107);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(63, 21);
            this.Custom.TabIndex = 10;
            this.Custom.Text = "自定义";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // CustomValue
            // 
            this.CustomValue.Location = new System.Drawing.Point(353, 105);
            this.CustomValue.Name = "CustomValue";
            this.CustomValue.Size = new System.Drawing.Size(100, 23);
            this.CustomValue.TabIndex = 11;
            // 
            // DragPanel
            // 
            this.DragPanel.AllowDrop = true;
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DragPanel.Controls.Add(this.DragTip);
            this.DragPanel.Location = new System.Drawing.Point(12, 95);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(255, 55);
            this.DragPanel.TabIndex = 12;
            // 
            // DragTip
            // 
            this.DragTip.AllowDrop = true;
            this.DragTip.AutoSize = true;
            this.DragTip.Enabled = false;
            this.DragTip.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DragTip.Location = new System.Drawing.Point(25, 12);
            this.DragTip.Name = "DragTip";
            this.DragTip.Size = new System.Drawing.Size(206, 31);
            this.DragTip.TabIndex = 0;
            this.DragTip.Text = "拖拽文件转换区域";
            // 
            // ColorSpace
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.CustomValue);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.LinnerToGamma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GammaToLinner);
            this.Controls.Add(this.AChannel);
            this.Controls.Add(this.BChannel);
            this.Controls.Add(this.GChannel);
            this.Controls.Add(this.selectTitle);
            this.Controls.Add(this.RChannel);
            this.Controls.Add(this.FolderTransform);
            this.Controls.Add(this.TextureTransform);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorSpace";
            this.Text = "ColorSpace";
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TextureTransform;
        private Button FolderTransform;
        private CheckBox RChannel;
        private Label selectTitle;
        private CheckBox GChannel;
        private CheckBox BChannel;
        private CheckBox AChannel;
        private CheckBox GammaToLinner;
        private Label label2;
        private CheckBox LinnerToGamma;
        private CheckBox Custom;
        private TextBox CustomValue;
        private Panel DragPanel;
        private Label DragTip;
    }
}