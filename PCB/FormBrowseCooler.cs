using PCB.AppClasses;
using System;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormBrowseCooler : Form
    {
        public FormBrowseCooler()
        {
            InitializeComponent();
        }

        private void FormBrowseCooler_Load(object sender, EventArgs e)
        {
            var dt = c.Select(componentName);
            coolerBrowseGV.DataSource = dt;
        }
        
        private void CloseCoolerBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        Cooler c = new Cooler();
        Methods helperMethods = new Methods();
        string componentName = "Cooler";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            c.Id = int.Parse(textBoxCoolerId.Text);
            c.Manufacturer = textBoxCoolerManufacturer.Text;
            c.Name = textBoxCoolerName.Text;
            c.FanRPM = int.Parse(textBoxCoolerFanRpm.Text);
            c.NoiseLevelDb = int.Parse(textBoxCoolerNoiseLevel.Text);
            c.Price = double.Parse(textBoxCoolerPrice.Text);

            bool success = addOrUpdate == "added" ? c.Insert(c) : c.Update(c);
            helperMethods.DisplayMessage(success, addOrUpdate, this, c, componentName, coolerBrowseGV);
        }

        private void AddCoolerButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateCoolerButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteCoolerButton_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(textBoxCoolerId.Text);
            bool success = c.Delete(c);
            helperMethods.DisplayMessage(success, "deleted", this, c, componentName, coolerBrowseGV);
        }

        private void ClearCoolerButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void CoolerBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxCoolerId,
                                    textBoxCoolerManufacturer,
                                    textBoxCoolerName,
                                    textBoxCoolerFanRpm,
                                    textBoxCoolerNoiseLevel,
                                    textBoxCoolerPrice };

            helperMethods.FillTextBoxes(textBoxes, coolerBrowseGV, e.RowIndex);
        }

        private void TextBoxCoolerSearch_TextChanged(object sender, EventArgs e)
        {
            coolerBrowseGV.DataSource = helperMethods.SearchQuery(textBoxCoolerSearch.Text, componentName);
        }
    }
}