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
            this.TextureTransform = new System.Windows.Forms.Button();
            this.FolderTransform = new System.Windows.Forms.Button();
            this.RChannel = new System.Windows.Forms.CheckBox();
            this.selectTitle = new System.Windows.Forms.Label();
            this.GChannel = new System.Windows.Forms.CheckBox();
            this.BChannel = new System.Windows.Forms.CheckBox();
            this.AChannel = new System.Windows.Forms.CheckBox();
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
            // ColorSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AChannel);
            this.Controls.Add(this.BChannel);
            this.Controls.Add(this.GChannel);
            this.Controls.Add(this.selectTitle);
            this.Controls.Add(this.RChannel);
            this.Controls.Add(this.FolderTransform);
            this.Controls.Add(this.TextureTransform);
            this.Name = "ColorSpace";
            this.Text = "ColorSpace";
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
    }
}