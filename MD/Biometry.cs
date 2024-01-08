using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using IronPython.Hosting;
using IronPython.Runtime;
using System.Diagnostics;
using System.IO;

namespace MD
{
    public partial class Biometry : Form
    {
        private VideoCapture capture = null;

        private DsDevice[] webCams = null;

        private int selectedCameraId = 0;

        public Biometry()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void Biometry_Load(object sender, EventArgs e)
        {
            webCams = DsDevice.GetDevicesOfCat(DirectShowLib.FilterCategory.VideoInputDevice);

            for (int i = 0; i < webCams.Length; i++)
            {
                toolStripComboBox1.Items.Add(webCams[i].Name);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCameraId = toolStripComboBox1.SelectedIndex;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (webCams.Length == 0)
                {
                    throw new Exception("Нет доступных камер!");
                }
                else if (toolStripComboBox1.SelectedItem == null)
                {
                    throw new Exception("Необходимо выбрать камеру");
                }
                else if (capture != null)
                {
                    capture.Start();   
                }
                else 
                {
                    capture = new VideoCapture(selectedCameraId);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    capture.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                capture.Retrieve(m);
                pictureBox1.Image = m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal).Bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                    capture.Dispose();
                    capture = null;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    selectedCameraId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    Mat m = new Mat();
                    capture.Retrieve(m);
                    MakeScreenShotForm screenShotForm = new MakeScreenShotForm(m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal));
                    screenShotForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // метод в C#, который вызывает Python-код для выполнения аутентификации
        public void PerformBiometrics()
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            // Загрузка и выполнение Python-скрипта с функцией биометрии
            engine.ExecuteFile("C:\\Users\\Даниил\\Desktop\\MD\\MD\\PythonScripts\\facial_authentication.py", scope);

            // Получение ссылки на функцию биометрии
            dynamic biometricsFunction = scope.GetVariable("perform_biometrics");

            // Вызов функции биометрии и получение результата
            dynamic result = biometricsFunction();

            // Обработка результата биометрии
            ProcessBiometricsResult(result);

            if (result == true)
            {
                MessageBox.Show("Аутентификация прошла успешно");
            }
            else
            {
                MessageBox.Show("Ошибка аутентификации");
            }
        }

        private void ProcessBiometricsResult(dynamic result)
        {
            // Обработка результата биометрии в C#
            // ...
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PerformBiometrics();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string pythonScriptPath = "C:\\Users\\Даниил\\Desktop\\MD\\MD\\PythonScripts\\known_faces.py";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "known_faces.py";
            startInfo.Arguments = pythonScriptPath;

            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string output = reader.ReadToEnd();
                    // Обработка вывода скрипта, если необходимо
                }
            }

            MessageBox.Show("Известные лица были обновлены.");
        }


        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
