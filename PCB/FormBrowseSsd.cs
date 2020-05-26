using PCB.AppClasses;
using System;
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
            var dt = m.Select(componentName);
            ssdBrowseGV.DataSource = dt;
        }

        private void CloseSsdBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        SSD m = new SSD();
        Methods helperMethods = new Methods();
        string componentName = "SSD";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            m.Id = int.Parse(textBoxSsdId.Text);
            m.Manufacturer = textBoxSsdManufacturer.Text;
            m.Name = textBoxSsdName.Text;
            m.CapacityGB = int.Parse(textBoxSsdCapacity.Text);
            m.CacheMb = int.Parse(textBoxSsdCache.Text);
            m.Interface = textBoxSsdInterface.Text;
            m.Price = double.Parse(textBoxSsdPrice.Text);

            bool success = addOrUpdate == "added" ? m.Insert(m) : m.Update(m);
            helperMethods.DisplayMessage(success, addOrUpdate, this, m, componentName, ssdBrowseGV);
        }

        private void AddSsdButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateSsdButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteSsdButton_Click(object sender, EventArgs e)
        {
            m.Id = int.Parse(textBoxSsdId.Text);
            bool success = m.Delete(m);
            helperMethods.DisplayMessage(success, "deleted", this, m, componentName, ssdBrowseGV);
        }

        private void ClearSsdButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void SsdBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxSsdId,
                                    textBoxSsdManufacturer,
                                    textBoxSsdName,
                                    textBoxSsdCapacity,
                                    textBoxSsdCache,
                                    textBoxSsdInterface,
                                    textBoxSsdPrice };

            helperMethods.FillTextBoxes(textBoxes, ssdBrowseGV, e.RowIndex);
        }

        private void TextBoxSsdSearch_TextChanged(object sender, EventArgs e)
        {
            ssdBrowseGV.DataSource = helperMethods.SearchQuery(textBoxSsdSearch.Text, componentName);
        }
    }
}