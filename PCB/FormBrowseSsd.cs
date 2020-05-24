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
    public partial class FormBrowseSsd : Form
    {
        public FormBrowseSsd()
        {
            InitializeComponent();
        }

        private void FormBrowseSsd_Load(object sender, EventArgs e)
        {

        }

        private void CloseSsdBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}