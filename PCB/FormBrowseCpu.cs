using PCB.AppClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            DisplayMessage(success, "added");
        }

        private void FormBrowseCpu_Load(object sender, EventArgs e)
        {
            // Loading the data from the db on load
            var dt = c.Select("CPU");
            cpuBrowseGV.DataSource = dt;
        }

        private void CloseCpuBrowseBtn_Click(object sender, EventArgs e)
        {
            // Close the opened form
            Close();
        }

        // Method for clearing the fields
        public void Clear()
        {
            textBoxCpuId.Text = "";
            textBoxCpuManufacturer.Text = "";
            textBoxCpuName.Text = "";
            textBoxCpuCores.Text = "";
            textBoxCpuCoreClock.Text = "";
            textBoxCpuBoostClock.Text = "";
            textBoxCpuTdp.Text = "";
            textBoxCpuIntegratedGraphics.Text = "";
            textBoxCpuPrice.Text = "";
        }

        private void UpdateCpuButton_Click(object sender, EventArgs e)
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

            bool success = c.Update(c);
            DisplayMessage(success, "updated");
        }

        private void CpuBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from the gridview and load it to the textbox
            int rowIndex = e.RowIndex;

            textBoxCpuId.Text = cpuBrowseGV.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxCpuManufacturer.Text = cpuBrowseGV.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxCpuName.Text = cpuBrowseGV.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxCpuCores.Text = cpuBrowseGV.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxCpuCoreClock.Text = cpuBrowseGV.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxCpuBoostClock.Text = cpuBrowseGV.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxCpuTdp.Text = cpuBrowseGV.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxCpuIntegratedGraphics.Text = cpuBrowseGV.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxCpuPrice.Text = cpuBrowseGV.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void ClearCpuButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteCpuButton_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(textBoxCpuId.Text);
            bool success = c.Delete(c);
            DisplayMessage(success, "deleted");
        }

        public void DisplayMessage(bool success, string operation)
        {
            string msg;

            if (success == true)
            {
                msg = $"Successfully {operation}!";
                // Clear all fields if successful
                Clear();

                // Load data to the grid
                var dt = c.Select("CPU");
                cpuBrowseGV.DataSource = dt;
            }

            else
            {
                msg = "Operation failed, Try Again!";
            }

            MessageBox.Show(msg);
        }

        static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        private void TextBoxCpuSearch_TextChanged(object sender, EventArgs e)
        {
            // Searches db by name and manufacturer
            string keyword = "'%" + textBoxCpuSearch.Text + "%'";

            var connection = new SqlConnection(connectionString);

            var dataAdapter = new SqlDataAdapter($"SELECT * FROM CPU WHERE Manufacturer LIKE {keyword}" +
                                                 $"OR Name LIKE {keyword}", connection);

            var dt = new DataTable();
            dataAdapter.Fill(dt);
            cpuBrowseGV.DataSource = dt;
        }
    }
}
