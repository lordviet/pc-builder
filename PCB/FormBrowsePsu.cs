using PCB.AppClasses;
using System;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormBrowsePsu : Form
    {
        public FormBrowsePsu()
        {
            InitializeComponent();
        }

        private void FormBrowsePsu_Load(object sender, EventArgs e)
        {
            var dt = p.Select(componentName);
            psuBrowseGV.DataSource = dt;
        }

        private void ClosePsuBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        PSU p = new PSU();
        Methods helperMethods = new Methods();
        string componentName = "PSU";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            p.Id = int.Parse(textBoxPsuId.Text);
            p.Manufacturer = textBoxPsuManufacturer.Text;
            p.Name = textBoxPsuName.Text;
            p.Wattage = int.Parse(textBoxPsuWattage.Text);
            p.Price = double.Parse(textBoxPsuPrice.Text);

            bool success = addOrUpdate == "added" ? p.Insert(p) : p.Update(p);
            helperMethods.DisplayMessage(success, addOrUpdate, this, p, componentName, psuBrowseGV);
        }

        private void AddPsuButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdatePsuButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeletePsuButton_Click(object sender, EventArgs e)
        {
            p.Id = int.Parse(textBoxPsuId.Text);
            bool success = p.Delete(p);
            helperMethods.DisplayMessage(success, "deleted", this, p, componentName, psuBrowseGV);
        }

        private void ClearPsuButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void PsuBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxPsuId,
                                    textBoxPsuManufacturer,
                                    textBoxPsuName,
                                    textBoxPsuWattage,
                                    textBoxPsuPrice };

            helperMethods.FillTextBoxes(textBoxes, psuBrowseGV, e.RowIndex);
        }

        private void TextBoxPsuSearch_TextChanged(object sender, EventArgs e)
        {
            psuBrowseGV.DataSource = helperMethods.SearchQuery(textBoxPsuSearch.Text, componentName);
        }
    }
}