using DirectShowLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin2 admin2 = new Admin2();
            admin2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin3 admin3 = new Admin3();
            admin3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin4 admin4 = new Admin4();
            admin4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin5 admin5 = new Admin5();
            admin5.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
