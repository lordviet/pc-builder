using PCB.AppClasses;
using System;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormBrowseCpu : Form
    {
        public FormBrowseCpu()
        {
            InitializeComponent();
        }

        private void FormBrowseCpu_Load(object sender, EventArgs e)
        {
            var dt = c.Select(componentName);
            cpuBrowseGV.DataSource = dt;
        }

        private void CloseCpuBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        CPU c = new CPU();
        Methods helperMethods = new Methods();
        string componentName = "CPU";

        private void AddOrUpdateColumn(string addOrUpdate)
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

            bool success = addOrUpdate == "added" ? c.Insert(c) : c.Update(c);
            helperMethods.DisplayMessage(success, addOrUpdate, this, c, componentName, cpuBrowseGV);
        }

        private void AddCpuButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateCpuButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteCpuButton_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(textBoxCpuId.Text);
            bool success = c.Delete(c);
            helperMethods.DisplayMessage(success, "deleted", this, c, componentName, cpuBrowseGV);
        }

        private void ClearCpuButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void CpuBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxCpuId,
                                    textBoxCpuManufacturer,
                                    textBoxCpuName,
                                    textBoxCpuCores,
                                    textBoxCpuCoreClock,
                                    textBoxCpuBoostClock,
                                    textBoxCpuTdp,
                                    textBoxCpuIntegratedGraphics,
                                    textBoxCpuPrice };

            helperMethods.FillTextBoxes(textBoxes, cpuBrowseGV, e.RowIndex);
        }

        private void TextBoxCpuSearch_TextChanged(object sender, EventArgs e)
        {
            cpuBrowseGV.DataSource = helperMethods.SearchQuery(textBoxCpuSearch.Text, componentName);
        }
    }
}