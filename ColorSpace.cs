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
            //�����ļ�ת��

            //�����ļ�ѡ��

            //ת��
        }

        private void FolderTransform_Click(object sender, EventArgs e)
        {
            //�����ļ�ת��
            
            //�����ļ���ѡ��

            //��ȡ�����ļ�

            //ת��
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