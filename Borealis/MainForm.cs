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
    public partial class MainForm : Form
    {
        private Help helpForm;
        private Settings settingsForm;

        public MainForm()
        {
            InitializeComponent();
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
    }
}
