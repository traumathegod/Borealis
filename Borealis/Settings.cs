using System;
using System.Text;
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
                PortNumericUD.Value = (decimal)Properties.Settings.Default["Port"];
                UserTextBox.Text = Properties.Settings.Default["UserName"].ToString();
            }
            catch (System.Configuration.SettingsPropertyNotFoundException)
            {
                // No settings defined. 1st time use?
            }

        }

        private void SettingsOk_Click(object sender, EventArgs e) => Close();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Hostname"] = HostnameTextBox.Text.Trim();
            Properties.Settings.Default["Port"] = PortNumericUD.Value;
            Properties.Settings.Default["UserName"] = UserTextBox.Text.Trim();
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
