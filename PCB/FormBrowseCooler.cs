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
    public partial class FormBrowseCooler : Form
    {
        public FormBrowseCooler()
        {
            InitializeComponent();
        }

        private void CloseCoolerBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
