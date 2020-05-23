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
    public partial class FormBrowseCpu : Form
    {
        public FormBrowseCpu()
        {
            InitializeComponent();
        }

        CPU c = new CPU();

        private void AddCpuButton_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(textBoxCpuId.Text);
            c.Manufacturer = textBoxCpuManufacturer.Text;
            c.Name = textBoxCpuName.Text;
            c.Cores = int.Parse(textBoxCpuCores.Text); // Try Parse
            c.CoreClock = double.Parse(textBoxCpuCoreClock.Text);
            c.BoostClock = double.Parse(textBoxCpuBoostClock.Text);
            c.TDP = int.Parse(textBoxCpuTdp.Text);
            c.IntegratedGraphics = textBoxCpuIntegratedGraphics.Text;
            c.Price = double.Parse(textBoxCpuPrice.Text);

            bool success = c.Insert(c);

            string msg = success == true ? "Successfully added!" : "Failed to add, Try Again!";

            MessageBox.Show(msg);

            // Load data to the grid
            var dt = c.Select("CPU");
            cpuBrowseGV.DataSource = dt;

        }

        private void FormBrowseCpu_Load(object sender, EventArgs e)
        {
            // Loading the data from the db on load
            var dt = c.Select("CPU");
            cpuBrowseGV.DataSource = dt;
        }

        private void CloseCpuBrowseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
