using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace MD
{
    public partial class Screentracking : Form
    {
        private System.Timers.Timer timer;
        private int intervalInSeconds;
        private int counter;
        private string screenshotsFolder;

        public Screentracking()
        {
            InitializeComponent();
            screenshotsFolder = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Screentracking_Load(object sender, EventArgs e)
        {
            // Создание папки для сохранения скриншотов, если она не существует
            Directory.CreateDirectory(screenshotsFolder);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Получение интервала времени из текстового поля
            if (int.TryParse(intervalTextBox.Text, out intervalInSeconds) && intervalInSeconds > 0)
            {
                // Инициализация и запуск таймера
                timer = new System.Timers.Timer(intervalInSeconds * 1000);
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
                counter = 0;

                // Блокировка кнопки "Start" и текстового поля
                startButton.Enabled = false;
                intervalTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid interval in seconds.");
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Создание скриншота экрана
            Bitmap screenshot = CaptureScreen();

            // Сохранение скриншота в файл
            string filePath = Path.Combine(screenshotsFolder, $"screenshot_{counter}.Png");
            screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            screenshot.Dispose();

            // Увеличение счетчика
            counter++;

            // Обновление ListBox с перечислением скриншотов
            Invoke(new Action(() => screenshotListBox.Items.Add(filePath)));

            // Остановка таймера после сохранения заданного количества скриншотов
            if (counter >= 5)
            {
                timer.Stop();

                // Разблокировка кнопки "Start" и текстового поля
                startButton.Enabled = true;
                intervalTextBox.Enabled = true;
            }
        }

        private Bitmap CaptureScreen()
        {
            // Получение размеров экрана
            int screenLeft = Screen.PrimaryScreen.Bounds.Left;
            int screenTop = Screen.PrimaryScreen.Bounds.Top;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Создание изображения для скриншота
            Bitmap screenshot = new Bitmap(screenWidth, screenHeight);

            // Создание графики из изображения скриншота
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                // Копирование содержимого экрана в графику скриншота
                graphics.CopyFromScreen(screenLeft, screenTop, 0, 0, screenshot.Size);
            }

            return screenshot;
        }

        private void screenshotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отображение выбранного скриншота в PictureBox
            string selectedFilePath = screenshotListBox.SelectedItem.ToString();
            if (File.Exists(selectedFilePath))
            {
                using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(fs);
                }
            }
        }
    }
}
