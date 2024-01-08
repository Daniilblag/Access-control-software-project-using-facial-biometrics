using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class Accesslevels : Form
    {
        private Dictionary<string, List<string>> accessLevels;

        public Accesslevels()
        {
            InitializeComponent();
            accessLevels = new Dictionary<string, List<string>>();
        }

        private void Accesslevels_Load(object sender, EventArgs e)
        {

        }

        private void lbAccessLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accessLevel = GetSelectedAccessLevel();
            if (accessLevel != null)
            {
                lbApplications.Items.Clear();
                if (accessLevels.ContainsKey(accessLevel))
                {
                    foreach (string application in accessLevels[accessLevel])
                    {
                        lbApplications.Items.Add(application);
                    }
                }
            }
        }

        private string GetSelectedAccessLevel()
        {
            if (lbAccessLevels.SelectedIndex != -1)
            {
                return lbAccessLevels.SelectedItem.ToString();
            }
            return null;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAccessLevel_Click_1(object sender, EventArgs e)
        {
            string accessLevel = txtAccessLevel.Text.Trim();
            if (!string.IsNullOrEmpty(accessLevel) && !accessLevels.ContainsKey(accessLevel))
            {
                accessLevels.Add(accessLevel, new List<string>());
                lbAccessLevels.Items.Add(accessLevel);
                txtAccessLevel.Clear();
            }
            else
            {
                MessageBox.Show("Введите уникальное имя уровня доступа");
            }
        }

        private void btnAddApplication_Click_1(object sender, EventArgs e)
        {
            string accessLevel = GetSelectedAccessLevel();
            if (accessLevel != null)
            {
                string application = txtApplication.Text.Trim();
                if (!string.IsNullOrEmpty(application) && !accessLevels[accessLevel].Contains(application))
                {
                    accessLevels[accessLevel].Add(application);
                    lbApplications.Items.Add(application);
                    txtApplication.Clear();
                }
                else
                {
                    MessageBox.Show("Введите уникальное имя приложения");
                }
            }
            else
            {
                MessageBox.Show("Выберите уровень доступа");
            }
        }

        private void btnRemoveAccessLevel_Click_1(object sender, EventArgs e)
        {
            string accessLevel = GetSelectedAccessLevel();
            if (accessLevel != null)
            {
                accessLevels.Remove(accessLevel);
                lbAccessLevels.Items.Remove(accessLevel);
                lbApplications.Items.Clear();
            }
            else
            {
                MessageBox.Show("Выберите уровень доступа для удаления");
            }
        }
    }
}
