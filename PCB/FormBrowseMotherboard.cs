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
    public partial class FormBrowseMotherboard : Form
    {
        public FormBrowseMotherboard()
        {
            InitializeComponent();
        }

        private void FormBrowseMotherboard_Load(object sender, EventArgs e)
        {
            var dt = mb.Select(componentName);
            mbBrowseGV.DataSource = dt;
        }

        private void CloseMbBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        Motherboard mb = new Motherboard();
        Methods helperMethods = new Methods();
        string componentName = "Motherboard";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            mb.Id = int.Parse(textBoxMbId.Text);
            mb.Manufacturer = textBoxMbManufacturer.Text;
            mb.Name = textBoxMbName.Text;
            mb.SocketCPU = textBoxMbSocketCpu.Text;
            mb.FormFactor = textBoxMbFormFactor.Text;
            mb.MemoryMax = int.Parse(textBoxMbMemoryMax.Text);
            mb.MemorySlots = int.Parse(textBoxMbMemorySlots.Text); // Try Parse
            mb.Price = double.Parse(textBoxMbPrice.Text);

            bool success = addOrUpdate == "added" ? mb.Insert(mb) : mb.Update(mb);
            helperMethods.DisplayMessage(success, addOrUpdate, this, mb, componentName, mbBrowseGV);
        }

        private void AddMbButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateMbButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteMbButton_Click(object sender, EventArgs e)
        {
            mb.Id = int.Parse(textBoxMbId.Text);
            bool success = mb.Delete(mb);
            helperMethods.DisplayMessage(success, "deleted", this, mb, componentName, mbBrowseGV);
        }

        private void ClearMbButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void MbBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxMbId,
                                    textBoxMbManufacturer,
                                    textBoxMbName,
                                    textBoxMbSocketCpu,
                                    textBoxMbFormFactor,
                                    textBoxMbMemoryMax,
                                    textBoxMbMemorySlots,
                                    textBoxMbPrice };

            helperMethods.FillTextBoxes(textBoxes, mbBrowseGV, e.RowIndex);
        }

        private void TextBoxMbSearch_TextChanged(object sender, EventArgs e)
        {
            mbBrowseGV.DataSource = helperMethods.SearchQuery(textBoxMbSearch.Text, componentName);
        }
    }
}