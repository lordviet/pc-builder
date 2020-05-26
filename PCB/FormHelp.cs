using System;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void CloseHelpBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
