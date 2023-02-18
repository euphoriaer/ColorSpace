namespace ColorSpace
{
    public partial class ColorSpace : Form
    {
        public bool RChannelSelect;
        public bool GChannelSelect;
        public bool BChannelSelect;
        public bool AChannelSeelct;
        public ColorSpace()
        {
            InitializeComponent();
        }

        private void TextureTransform_Click(object sender, EventArgs e)
        {
            //单个文件转换

            //弹出文件选择

            //转换
        }

        private void FolderTransform_Click(object sender, EventArgs e)
        {
            //批量文件转换
            
            //弹出文件夹选择

            //获取所有文件

            //转换
        }

        private void RChannel_CheckedChanged(object sender, EventArgs e)
        {
            RChannelSelect=RChannel.Checked;
        }

        private void GChannel_CheckedChanged(object sender, EventArgs e)
        {
            GChannelSelect=GChannel.Checked;
        }

        private void BChannel_CheckedChanged(object sender, EventArgs e)
        {
            BChannelSelect=BChannel.Checked;
        }

        private void AChannel_CheckedChanged(object sender, EventArgs e)
        {
            AChannelSeelct=AChannel.Checked;
        }
    }
}