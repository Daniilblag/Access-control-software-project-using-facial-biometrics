using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class processtracking : Form
    {
        private Timer timer;
        private Stopwatch stopwatch;
        private string currentActiveApplication;

        public processtracking()
        {
            InitializeComponent();

            // Инициализация таймера
            timer = new Timer();
            timer.Interval = 10000; // Интервал таймера в миллисекундах (10 секунд)
            timer.Tick += Timer_Tick;

            // Инициализация секундомера
            stopwatch = new Stopwatch();
        }

        private void processtracking_Load(object sender, EventArgs e)
        {
            // Начало отслеживания активных приложений
            timer.Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxAppUsage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Очистка ListBox перед выводом данных
            appUsageListBox.Items.Clear();

            // Получение данных об использовании приложений
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    string applicationName = process.ProcessName;
                    TimeSpan usageTime = TimeSpan.FromMilliseconds(process.TotalProcessorTime.TotalMilliseconds);

                    // Добавление информации об использовании приложения в ListBox
                    string logEntry = $"{applicationName}: {usageTime.TotalSeconds} сек.";
                    appUsageListBox.Items.Add(logEntry);
                }
            }
        }

        // Импорт функций Windows API для получения активного приложения
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Получение активного приложения
            IntPtr foregroundWindowHandle = GetForegroundWindow();
            if (foregroundWindowHandle != IntPtr.Zero)
            {
                StringBuilder sb = new StringBuilder(256);
                GetWindowText(foregroundWindowHandle, sb, sb.Capacity);
                string activeApplication = sb.ToString();

                // Проверка изменения активного приложения
                if (activeApplication != currentActiveApplication)
                {
                    // Сохранение времени использования предыдущего приложения
                    if (!string.IsNullOrEmpty(currentActiveApplication))
                    {
                        TimeSpan elapsed = stopwatch.Elapsed;
                        SaveApplicationUsage(currentActiveApplication, elapsed);
                    }

                    // Обновление текущего активного приложения и сброс секундомера
                    currentActiveApplication = activeApplication;
                    stopwatch.Restart();
                }
            }
        }

        private void SaveApplicationUsage(string application, TimeSpan usageTime)
        {
            // Добавление информации о приложении в ListBox
            string logEntry = $"{DateTime.Now}: Приложение '{application}' использовано {usageTime.TotalSeconds} секунд.";
            appUsageListBox.Items.Add(logEntry);
        }
    }
}

