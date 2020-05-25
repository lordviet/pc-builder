using PCB.AppClasses;
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
    public partial class FormMySetups : Form
    {
        public FormMySetups()
        {
            InitializeComponent();
        }

        private void FormMySetups_Load(object sender, EventArgs e)
        {
            var dt = s.Select();
            setupsGV.DataSource = dt;
        }

        Setup s = new Setup();
        Methods helperMethods = new Methods();

        private void CloseCpuBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CpuBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            helperMethods.FillTextBoxes(new TextBox[]{ textBoxSetupId}, setupsGV, e.RowIndex);
        }

        private void DeleteSetupButton_Click(object sender, EventArgs e)
        {
            bool success = s.Delete(int.Parse(textBoxSetupId.Text));
            if(success == true)
            {
                MessageBox.Show("Setup Successfully Deleted!");
                var dt = s.Select();
                setupsGV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Operation Failed, Try Again!");
            }
        }

        private void ExportSetupButton_Click(object sender, EventArgs e)
        {
            helperMethods.ExportToExcel(setupsGV);
        }
    }
}
