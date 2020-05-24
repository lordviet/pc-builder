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
    public partial class FormBrowseRam : Form
    {
        public FormBrowseRam()
        {
            InitializeComponent();
        }

        private void CloseRamBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBrowseRam_Load(object sender, EventArgs e)
        {
            var dt = r.Select(componentName);
            ramBrowseGV.DataSource = dt;
        }

        RAM r = new RAM();
        Methods helperMethods = new Methods();
        string componentName = "RAM";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            r.Id = int.Parse(textBoxRamId.Text);
            r.Manufacturer = textBoxRamManufacturer.Text;
            r.Name = textBoxRamName.Text;
            r.Speed = textBoxRamSpeed.Text;
            r.Size = int.Parse(textBoxRamSize.Text);
            r.Price = double.Parse(textBoxRamPrice.Text);

            bool success = addOrUpdate == "added" ? r.Insert(r) : r.Update(r);
            helperMethods.DisplayMessage(success, addOrUpdate, this, r, componentName, ramBrowseGV);
        }

        private void AddRamButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateRamButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteRamButton_Click(object sender, EventArgs e)
        {
            r.Id = int.Parse(textBoxRamId.Text);
            bool success = r.Delete(r);
            helperMethods.DisplayMessage(success, "deleted", this, r, componentName, ramBrowseGV);
        }

        private void ClearRamButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void RamBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxRamId,
                                    textBoxRamManufacturer,
                                    textBoxRamName,
                                    textBoxRamSpeed,
                                    textBoxRamSize,
                                    textBoxRamPrice };

            helperMethods.FillTextBoxes(textBoxes, ramBrowseGV, e.RowIndex);
        }

        private void TextBoxRamSearch_TextChanged(object sender, EventArgs e)
        {
            ramBrowseGV.DataSource = helperMethods.SearchQuery(textBoxRamSearch.Text, componentName);
        }
    }
}
