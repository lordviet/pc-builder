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
    public partial class FormBrowsePsu : Form
    {
        public FormBrowsePsu()
        {
            InitializeComponent();
        }

        private void ClosePsuBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
