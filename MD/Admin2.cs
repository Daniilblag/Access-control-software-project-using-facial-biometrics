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
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "admin";
            string password = "admin";
            string introduced_login = textBox1.Text.Trim();
            string introduced_password = textBox2.Text.Trim();

            if (introduced_login != login || introduced_password != password)
            {
                MessageBox.Show("Логин или пароль введен неверно");
            }
            else
            {
                Biometry biometry = new Biometry();
                biometry.Show();
                Hide();
            }
        }
    }
}
