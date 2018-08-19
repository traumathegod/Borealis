using System;
using System.Windows.Forms;

namespace Borealis
{
    public partial class MainForm : Form
    {
        private Help helpForm;
        private Settings settingsForm;
        private bool echo = true;
        private System.Drawing.Color color = System.Drawing.Color.Green;
        private string CMD = "C:\\WINDOWS\\system32\\cmd.exe";
        private string SSH = "ssh.exe";
        private string arguments = "";

        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default["IsFirstBoot"].Equals(false))
            {
                settingsOpenFormButton_Click("InitialBoot", null);
            }
        }

        private void helpOpenFormButton_Click(object sender, EventArgs e)
        {
            helpForm = new Help();
            helpForm.Show();
        }

        private void settingsOpenFormButton_Click(object sender, EventArgs e)
        {
            settingsForm = new Settings();
            settingsForm.Show();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            
            CMDConsole.StartProcess(CMD, "");
        }

        private string BuildSSHConnectionString()
        {
            string userName = Properties.Settings.Default["UserName"].ToString();
            string host = Properties.Settings.Default["Hostname"].ToString();
            string port = Properties.Settings.Default["Port"].ToString();
            if (port.Equals("22") || port == null)
            {
                return SSH + " " + userName + "@" + host;
            }
            else
                return SSH + " " + userName + "@" + host + " -p " + port;
        }

        private void StartSSHButton_Click(object sender, EventArgs e)
        {
            CMDConsole.WriteInput(BuildSSHConnectionString(), System.Drawing.Color.Green, echo);
        }


        //
    }
}
