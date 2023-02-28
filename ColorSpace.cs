using System.IO;

namespace ColorSpace
{
    public partial class ColorSpace : Form
    {
        public bool RChannelSelect;
        public bool GChannelSelect;
        public bool BChannelSelect;
        public bool AChannelSeelct;
        public TranslateType translateType = TranslateType.GammaToLinner;

        public ColorSpace()
        {
            InitializeComponent();
            this.AllowDrop= true;
            DragPanel.AllowDrop = true;
            DragPanel.DragEnter += DragPanel_DragEnter;
            DragPanel.DragDrop += DragFileTransform;
        }

        private void DragPanel_DragEnter(object? sender, DragEventArgs e)
        {
         
            e.Effect = DragDropEffects.Copy; // Show Can Drag
          
        }

        private void DragFileTransform(object? sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < fileNames.Length; i++)
            {
                //弹出文件选择
                var file = fileNames[i];
                try
                {
                    ChangeColorSpace(file);
                }
                catch (Exception)
                {
                    MessageBox.Show("错误的文件类型!：" + file);
                    return;
                }
            }
            //转换完成
            MessageBox.Show("转换完成");
        }

        public enum TranslateType
        {
            GammaToLinner,
            LinnerToGamma,
            Custom
        }

        private void TextureTransform_Click(object sender, EventArgs e)
        {
            //单个文件转换
            var filePaths = DialogTools.OpenFiles(out var isOK, null);
            if (filePaths.Length==0)
            {
                return;
            }
            //弹出文件选择
            foreach (var file in filePaths)
            {
                try
                {
                    ChangeColorSpace(file);
                }
                catch (Exception)
                {
                    MessageBox.Show("错误的文件类型!：" + file);
                    return;
                }
            }
            //转换完成
            MessageBox.Show("转换完成");
        }

        private void FolderTransform_Click(object sender, EventArgs e)
        {
            //批量文件转换
            string folderPath = DialogTools.OpenFolder(out var isOK);

            if (folderPath == null)
            {
                return;
            }
            //弹出文件夹选择
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);
            //获取所有文件
            foreach (var file in files)
            {
                try
                {
                    ChangeColorSpace(file.FullName);
                }
                catch (Exception)
                {
                    MessageBox.Show("错误的文件类型!：" + file);
                    return;
                }
            }
            MessageBox.Show("转换完成");
            //转换
        }

        private void RChannel_CheckedChanged(object sender, EventArgs e)
        {
            RChannelSelect = RChannel.Checked;
        }

        private void GChannel_CheckedChanged(object sender, EventArgs e)
        {
            GChannelSelect = GChannel.Checked;
        }

        private void BChannel_CheckedChanged(object sender, EventArgs e)
        {
            BChannelSelect = BChannel.Checked;
        }

        private void AChannel_CheckedChanged(object sender, EventArgs e)
        {
            AChannelSeelct = AChannel.Checked;
        }

        private void GammaToLinner_CheckedChanged(object sender, EventArgs e)
        {
            translateType = TranslateType.GammaToLinner;
        }

        private void LinnerToGamma_CheckedChanged(object sender, EventArgs e)
        {
            translateType = TranslateType.LinnerToGamma;
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            translateType = TranslateType.Custom;
        }

        public void ChangeColorSpace(string filePath)
        {
            if (File.Exists(filePath))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filePath);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                var image = System.Drawing.Image.FromStream(ms);
                Bitmap tex = new Bitmap(image);
                Bitmap newTex = new Bitmap(image);
                int w = tex.Width;
                int h = tex.Height;

                switch (translateType)
                {
                    case TranslateType.GammaToLinner:
                        newTex = SetRGBAGammaToLinner(tex, w, h);
                        newTex.Save(filePath);
                        break;

                    case TranslateType.LinnerToGamma:
                        newTex = SetRGBALinnerToGamma(tex, w, h);
                        newTex.Save(filePath);
                        break;

                    case TranslateType.Custom:
                        float customValue = float.Parse(CustomValue.Text);
                        newTex = SetRGBACustom(tex, w, h, customValue);
                        newTex.Save(filePath);
                        break;

                    default:
                        break;
                }
            }
        }

        private Bitmap SetRGBACustom(Bitmap tex, int w, int h, float customValue)
        {
            Bitmap newTex = new Bitmap(w, h);
            Color temp = Color.White;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var pix = tex.GetPixel(i, j);
                    int r = pix.R;
                    int g = pix.G;
                    int b = pix.B;
                    int a = pix.A;

                    if (RChannelSelect)
                    {
                        r = (int)(CustomTranslate((float)pix.R / 255, customValue) * 255);
                    }

                    if (GChannelSelect)
                    {
                        g = (int)(CustomTranslate((float)pix.G / 255, customValue) * 255);
                    }

                    if (BChannelSelect)
                    {
                        b = (int)(CustomTranslate((float)pix.B / 255, customValue) * 255);
                    }

                    if (AChannelSeelct)
                    {
                        a = (int)(CustomTranslate((float)pix.A / 255, customValue) * 255);
                    }
                    temp = Color.FromArgb(a, r, g, b);
                    newTex.SetPixel(i, j, temp);
                }
            }

            return newTex;
        }

        private Bitmap SetRGBALinnerToGamma(Bitmap tex, int w, int h)
        {
            Bitmap newTex = new Bitmap(w, h);
            Color temp = Color.White;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var pix = tex.GetPixel(i, j);
                    int r = pix.R;
                    int g = pix.G;
                    int b = pix.B;
                    int a = pix.A;

                    if (RChannelSelect)
                    {
                        r = (int)(FastLinearToSRGB((float)pix.R / 255) * 255);
                    }

                    if (GChannelSelect)
                    {
                        g = (int)(FastLinearToSRGB((float)pix.G / 255) * 255);
                    }

                    if (BChannelSelect)
                    {
                        b = (int)(FastLinearToSRGB((float)pix.B / 255) * 255);
                    }

                    if (AChannelSeelct)
                    {
                        a = (int)(FastLinearToSRGB((float)pix.A / 255) * 255);
                    }
                    temp = Color.FromArgb(a, r, g, b);
                    newTex.SetPixel(i, j, temp);
                }
            }

            return newTex;
        }

        private Bitmap SetRGBAGammaToLinner(Bitmap tex, int w, int h)
        {
            Bitmap newTex = new Bitmap(w, h);
            Color temp = Color.White;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var pix = tex.GetPixel(i, j);
                    int r = pix.R;
                    int g = pix.G;
                    int b = pix.B;
                    int a = pix.A;

                    if (RChannelSelect)
                    {
                        r = (int)(FastSRGBToLinear((float)pix.R / 255) * 255);
                    }

                    if (GChannelSelect)
                    {
                        g = (int)(FastSRGBToLinear((float)pix.G / 255) * 255);
                    }

                    if (BChannelSelect)
                    {
                        b = (int)(FastSRGBToLinear((float)pix.B / 255) * 255);
                    }

                    if (AChannelSeelct)
                    {
                        a = (int)(FastSRGBToLinear((float)pix.A / 255) * 255);
                    }
                    temp = Color.FromArgb(a, r, g, b);
                    newTex.SetPixel(i, j, temp);
                }
            }

            return newTex;
        }

        public double FastSRGBToLinear(float c)
        {
            return c * (c * (c * 0.305306011 + 0.682171111) + 0.012522878);
        }

        public double FastLinearToSRGB(float c)
        {
            return Math.Clamp((1.055 * MathF.Pow(c, 0.416f) - 0.055), 0, 1);
        }

        public double CustomTranslate(float c, float pow)
        {
            return Math.Clamp((1.055 * MathF.Pow(c, pow) - 0.055), 0, 1);
        }
    }
}