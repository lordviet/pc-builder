using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormBrowseRam : Form
    {
        public FormBrowseRam()
        {
            InitializeComponent();
        }

        private void CloseRamBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
