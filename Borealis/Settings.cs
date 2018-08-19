using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borealis
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            try
            {
                HostnameTextBox.Text = Properties.Settings.Default["Hostname"].ToString();
                PortTextBox.Text = Properties.Settings.Default["Port"].ToString();
                UserTextBox.Text = Properties.Settings.Default["UserName"].ToString();
                PasswordTextBox.Text = Properties.Settings.Default["Password"].ToString();
            }
            catch (System.Configuration.SettingsPropertyNotFoundException)
            {
                // No settings defined. 1st time use?
            }

        }

        private void SettingsOk_Click(object sender, EventArgs e) => Close();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default["Hostname"] = HostnameTextBox.Text.Trim();
            //Properties.Settings.Default["Port"] = PortTextBox.Text.Trim();
            //Properties.Settings.Default["UserName"] = UserTextBox.Text.Trim();
            //Properties.Settings.Default["Password"] = PasswordTextBox.Text.Trim();
            //Properties.Settings.Default.Save();
        }
    }
}
