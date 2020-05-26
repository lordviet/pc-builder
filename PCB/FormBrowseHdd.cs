using PCB.AppClasses;
using System;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormBrowseHdd : Form
    {
        public FormBrowseHdd()
        {
            InitializeComponent();
        }

        private void FormBrowseHdd_Load(object sender, EventArgs e)
        {
            var dt = m.Select(componentName);
            hddBrowseGV.DataSource = dt;
        }

        private void CloseHddBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        HDD m = new HDD();
        Methods helperMethods = new Methods();
        string componentName = "HDD";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            m.Id = int.Parse(textBoxHddId.Text);
            m.Manufacturer = textBoxHddManufacturer.Text;
            m.Name = textBoxHddName.Text;
            m.CapacityGB = int.Parse(textBoxHddCapacity.Text);
            m.CacheMb = int.Parse(textBoxHddCache.Text);
            m.Interface = textBoxHddInterface.Text;
            m.Price = double.Parse(textBoxHddPrice.Text);

            bool success = addOrUpdate == "added" ? m.Insert(m) : m.Update(m);
            helperMethods.DisplayMessage(success, addOrUpdate, this, m, componentName, hddBrowseGV);
        }
        private void AddHddButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateHddButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteHddButton_Click(object sender, EventArgs e)
        {
            m.Id = int.Parse(textBoxHddId.Text);
            bool success = m.Delete(m);
            helperMethods.DisplayMessage(success, "deleted", this, m, componentName, hddBrowseGV);
        }

        private void ClearHddButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void HddBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxHddId,
                                    textBoxHddManufacturer,
                                    textBoxHddName,
                                    textBoxHddCapacity,
                                    textBoxHddCache,
                                    textBoxHddInterface,
                                    textBoxHddPrice };

            helperMethods.FillTextBoxes(textBoxes, hddBrowseGV, e.RowIndex);
        }

        private void TextBoxHddSearch_TextChanged(object sender, EventArgs e)
        {
            hddBrowseGV.DataSource = helperMethods.SearchQuery(textBoxHddSearch.Text, componentName);
        }
    }
}