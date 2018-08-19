using System;
using System.Windows.Forms;

namespace Borealis
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void HelpOk_Click(object sender, EventArgs e) => Close();
    }
}
