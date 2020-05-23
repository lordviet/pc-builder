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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        // A method that hides the submenu panels
        private void customizeDesign()
        {
            panelBrowseSubmenu.Visible = false;
            panelSetupsSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelBrowseSubmenu.Visible == true)
            {
                panelBrowseSubmenu.Visible = false;
            }
            if (panelSetupsSubmenu.Visible == true)
            {
                panelSetupsSubmenu.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #region Browse Components
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBrowseSubmenu);
        }


        private void BtnBrowseCpu_Click(object sender, EventArgs e)
        {
            // Opening next form
            openChildForm(new FormBrowseCpu());
            hideSubmenu();
        }

        private void BtnBrowseMotherboard_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowseVideoCard_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowsePsu_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowseRam_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowseHdd_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowseSsd_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnBrowseCooler_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }
        #endregion

        #region Setups
        private void BtnSetups_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSetupsSubmenu);
        }

        private void BtnMySetups_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void BtnAddSetup_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }
        #endregion
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            // Code Logic
            hideSubmenu();
        }

        // Keeps track of what form is active
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                // Close the current active form if there is one
                activeForm.Close();
            }

            // Open the new form 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
