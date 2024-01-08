using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using DirectShowLib;
using System.Text.RegularExpressions;
using System.IO;

namespace MD
{
    public partial class MakeScreenShotForm : Form
    {
        private Image<Bgr, byte> image = null;
        private string fileName = string.Empty;

        public MakeScreenShotForm(Image<Bgr, byte> image)
        {
           this.image = image;
           InitializeComponent();
        }

        private void MakeScreenShotForm_Load(object sender, EventArgs e)
        {
            fileName = $"SH_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}_{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}.jpg";
            pictureBox1.Image = image.Bitmap;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(fileName, ImageFormat.Jpeg);
                if (File.Exists(fileName))
                {
                    Close();
                }
                else
                {
                    throw new Exception("Не удалось сохранить снимок!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
