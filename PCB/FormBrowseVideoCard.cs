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
    public partial class FormBrowseVideoCard : Form
    {
        public FormBrowseVideoCard()
        {
            InitializeComponent();
        }

        private void FormBrowseVideoCard_Load(object sender, EventArgs e)
        {
            var dt = v.Select(componentName);
            videoCardBrowseGV.DataSource = dt;
        }

        private void CloseVideoCardBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        VideoCard v = new VideoCard();
        Methods helperMethods = new Methods();
        string componentName = "VideoCard";

        private void AddOrUpdateColumn(string addOrUpdate)
        {
            v.Id = int.Parse(textBoxVideoCardId.Text);
            v.Manufacturer = textBoxVideoCardManufacturer.Text;
            v.Name = textBoxVideoCardName.Text;
            v.Memory = int.Parse(textBoxVideoCardMemory.Text);
            v.CoreClockMhz = int.Parse(textBoxVideoCardCoreClock.Text);
            v.BoostClockMhz = int.Parse(textBoxVideoCardBoostClock.Text);
            v.Price = double.Parse(textBoxVideoCardPrice.Text);

            bool success = addOrUpdate == "added" ? v.Insert(v) : v.Update(v);
            helperMethods.DisplayMessage(success, addOrUpdate, this, v, componentName, videoCardBrowseGV);
        }

        private void AddVideoCardButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("added");
        }

        private void UpdateVideoCardButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateColumn("updated");
        }

        private void DeleteVideoCardButton_Click(object sender, EventArgs e)
        {
            v.Id = int.Parse(textBoxVideoCardId.Text);
            bool success = v.Delete(v);
            helperMethods.DisplayMessage(success, "deleted", this, v, componentName, videoCardBrowseGV);
        }

        private void ClearVideoCardButton_Click(object sender, EventArgs e)
        {
            helperMethods.Clear(this);
        }

        private void VideoCardBrowseGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] textBoxes = { textBoxVideoCardId,
                textBoxVideoCardManufacturer,
                textBoxVideoCardName,
                textBoxVideoCardMemory,
                textBoxVideoCardCoreClock,
                textBoxVideoCardBoostClock,
                textBoxVideoCardPrice

            };

            helperMethods.FillTextBoxes(textBoxes, videoCardBrowseGV, e.RowIndex);   
        }

        private void TextBoxVideoCardSearch_TextChanged(object sender, EventArgs e)
        {
            videoCardBrowseGV.DataSource = helperMethods.SearchQuery(textBoxVideoCardSearch.Text, componentName);
        }
    }
}