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
    public partial class FormBrowseVideoCard : Form
    {
        public FormBrowseVideoCard()
        {
            InitializeComponent();
        }

        private void CloseVideoCardBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
