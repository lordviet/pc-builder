namespace PCB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.panelSetupsSubmenu = new System.Windows.Forms.Panel();
            this.btnAddSetup = new System.Windows.Forms.Button();
            this.btnMySetups = new System.Windows.Forms.Button();
            this.btnSetups = new System.Windows.Forms.Button();
            this.panelBrowseSubmenu = new System.Windows.Forms.Panel();
            this.btnBrowseCooler = new System.Windows.Forms.Button();
            this.btnBrowseSsd = new System.Windows.Forms.Button();
            this.btnBrowseHdd = new System.Windows.Forms.Button();
            this.btnBrowseRam = new System.Windows.Forms.Button();
            this.btnBrowsePsu = new System.Windows.Forms.Button();
            this.btnBrowseVideoCard = new System.Windows.Forms.Button();
            this.btnBrowseMotherboard = new System.Windows.Forms.Button();
            this.btnBrowseCpu = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSetupsSubmenu.SuspendLayout();
            this.panelBrowseSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.ExitBtn);
            this.panelSideMenu.Controls.Add(this.helpBtn);
            this.panelSideMenu.Controls.Add(this.panelSetupsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnSetups);
            this.panelSideMenu.Controls.Add(this.panelBrowseSubmenu);
            this.panelSideMenu.Controls.Add(this.btnBrowse);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 611);
            this.panelSideMenu.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitBtn.Location = new System.Drawing.Point(0, 635);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(233, 45);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.helpBtn.Location = new System.Drawing.Point(0, 590);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.helpBtn.Size = new System.Drawing.Size(233, 45);
            this.helpBtn.TabIndex = 5;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // panelSetupsSubmenu
            // 
            this.panelSetupsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSetupsSubmenu.Controls.Add(this.btnAddSetup);
            this.panelSetupsSubmenu.Controls.Add(this.btnMySetups);
            this.panelSetupsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetupsSubmenu.Location = new System.Drawing.Point(0, 507);
            this.panelSetupsSubmenu.Name = "panelSetupsSubmenu";
            this.panelSetupsSubmenu.Size = new System.Drawing.Size(233, 83);
            this.panelSetupsSubmenu.TabIndex = 4;
            // 
            // btnAddSetup
            // 
            this.btnAddSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSetup.FlatAppearance.BorderSize = 0;
            this.btnAddSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSetup.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddSetup.Location = new System.Drawing.Point(0, 40);
            this.btnAddSetup.Name = "btnAddSetup";
            this.btnAddSetup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddSetup.Size = new System.Drawing.Size(233, 40);
            this.btnAddSetup.TabIndex = 8;
            this.btnAddSetup.Text = "Add Setup";
            this.btnAddSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSetup.UseVisualStyleBackColor = true;
            this.btnAddSetup.Click += new System.EventHandler(this.BtnAddSetup_Click);
            // 
            // btnMySetups
            // 
            this.btnMySetups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMySetups.FlatAppearance.BorderSize = 0;
            this.btnMySetups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySetups.ForeColor = System.Drawing.Color.LightGray;
            this.btnMySetups.Location = new System.Drawing.Point(0, 0);
            this.btnMySetups.Name = "btnMySetups";
            this.btnMySetups.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMySetups.Size = new System.Drawing.Size(233, 40);
            this.btnMySetups.TabIndex = 7;
            this.btnMySetups.Text = "My Setups";
            this.btnMySetups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMySetups.UseVisualStyleBackColor = true;
            this.btnMySetups.Click += new System.EventHandler(this.BtnMySetups_Click);
            // 
            // btnSetups
            // 
            this.btnSetups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetups.FlatAppearance.BorderSize = 0;
            this.btnSetups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetups.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetups.Location = new System.Drawing.Point(0, 462);
            this.btnSetups.Name = "btnSetups";
            this.btnSetups.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetups.Size = new System.Drawing.Size(233, 45);
            this.btnSetups.TabIndex = 3;
            this.btnSetups.Text = "Setups";
            this.btnSetups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetups.UseVisualStyleBackColor = true;
            this.btnSetups.Click += new System.EventHandler(this.BtnSetups_Click);
            // 
            // panelBrowseSubmenu
            // 
            this.panelBrowseSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseCooler);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseSsd);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseHdd);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseRam);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowsePsu);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseVideoCard);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseMotherboard);
            this.panelBrowseSubmenu.Controls.Add(this.btnBrowseCpu);
            this.panelBrowseSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrowseSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelBrowseSubmenu.Name = "panelBrowseSubmenu";
            this.panelBrowseSubmenu.Size = new System.Drawing.Size(233, 317);
            this.panelBrowseSubmenu.TabIndex = 2;
            // 
            // btnBrowseCooler
            // 
            this.btnBrowseCooler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseCooler.FlatAppearance.BorderSize = 0;
            this.btnBrowseCooler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCooler.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseCooler.Location = new System.Drawing.Point(0, 280);
            this.btnBrowseCooler.Name = "btnBrowseCooler";
            this.btnBrowseCooler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseCooler.Size = new System.Drawing.Size(233, 37);
            this.btnBrowseCooler.TabIndex = 7;
            this.btnBrowseCooler.Text = "Cooler";
            this.btnBrowseCooler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseCooler.UseVisualStyleBackColor = true;
            this.btnBrowseCooler.Click += new System.EventHandler(this.BtnBrowseCooler_Click);
            // 
            // btnBrowseSsd
            // 
            this.btnBrowseSsd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseSsd.FlatAppearance.BorderSize = 0;
            this.btnBrowseSsd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSsd.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseSsd.Location = new System.Drawing.Point(0, 240);
            this.btnBrowseSsd.Name = "btnBrowseSsd";
            this.btnBrowseSsd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseSsd.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseSsd.TabIndex = 6;
            this.btnBrowseSsd.Text = "SSD";
            this.btnBrowseSsd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseSsd.UseVisualStyleBackColor = true;
            this.btnBrowseSsd.Click += new System.EventHandler(this.BtnBrowseSsd_Click);
            // 
            // btnBrowseHdd
            // 
            this.btnBrowseHdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseHdd.FlatAppearance.BorderSize = 0;
            this.btnBrowseHdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseHdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseHdd.Location = new System.Drawing.Point(0, 200);
            this.btnBrowseHdd.Name = "btnBrowseHdd";
            this.btnBrowseHdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseHdd.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseHdd.TabIndex = 5;
            this.btnBrowseHdd.Text = "HDD";
            this.btnBrowseHdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseHdd.UseVisualStyleBackColor = true;
            this.btnBrowseHdd.Click += new System.EventHandler(this.BtnBrowseHdd_Click);
            // 
            // btnBrowseRam
            // 
            this.btnBrowseRam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseRam.FlatAppearance.BorderSize = 0;
            this.btnBrowseRam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRam.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseRam.Location = new System.Drawing.Point(0, 160);
            this.btnBrowseRam.Name = "btnBrowseRam";
            this.btnBrowseRam.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseRam.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseRam.TabIndex = 4;
            this.btnBrowseRam.Text = "RAM";
            this.btnBrowseRam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseRam.UseVisualStyleBackColor = true;
            this.btnBrowseRam.Click += new System.EventHandler(this.BtnBrowseRam_Click);
            // 
            // btnBrowsePsu
            // 
            this.btnBrowsePsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowsePsu.FlatAppearance.BorderSize = 0;
            this.btnBrowsePsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePsu.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowsePsu.Location = new System.Drawing.Point(0, 120);
            this.btnBrowsePsu.Name = "btnBrowsePsu";
            this.btnBrowsePsu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowsePsu.Size = new System.Drawing.Size(233, 40);
            this.btnBrowsePsu.TabIndex = 3;
            this.btnBrowsePsu.Text = "Power Supply";
            this.btnBrowsePsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowsePsu.UseVisualStyleBackColor = true;
            this.btnBrowsePsu.Click += new System.EventHandler(this.BtnBrowsePsu_Click);
            // 
            // btnBrowseVideoCard
            // 
            this.btnBrowseVideoCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseVideoCard.FlatAppearance.BorderSize = 0;
            this.btnBrowseVideoCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseVideoCard.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseVideoCard.Location = new System.Drawing.Point(0, 80);
            this.btnBrowseVideoCard.Name = "btnBrowseVideoCard";
            this.btnBrowseVideoCard.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseVideoCard.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseVideoCard.TabIndex = 2;
            this.btnBrowseVideoCard.Text = "Video Card";
            this.btnBrowseVideoCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseVideoCard.UseVisualStyleBackColor = true;
            this.btnBrowseVideoCard.Click += new System.EventHandler(this.BtnBrowseVideoCard_Click);
            // 
            // btnBrowseMotherboard
            // 
            this.btnBrowseMotherboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseMotherboard.FlatAppearance.BorderSize = 0;
            this.btnBrowseMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseMotherboard.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseMotherboard.Location = new System.Drawing.Point(0, 40);
            this.btnBrowseMotherboard.Name = "btnBrowseMotherboard";
            this.btnBrowseMotherboard.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseMotherboard.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseMotherboard.TabIndex = 1;
            this.btnBrowseMotherboard.Text = "Motherboard";
            this.btnBrowseMotherboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseMotherboard.UseVisualStyleBackColor = true;
            this.btnBrowseMotherboard.Click += new System.EventHandler(this.BtnBrowseMotherboard_Click);
            // 
            // btnBrowseCpu
            // 
            this.btnBrowseCpu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseCpu.FlatAppearance.BorderSize = 0;
            this.btnBrowseCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCpu.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseCpu.Location = new System.Drawing.Point(0, 0);
            this.btnBrowseCpu.Name = "btnBrowseCpu";
            this.btnBrowseCpu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrowseCpu.Size = new System.Drawing.Size(233, 40);
            this.btnBrowseCpu.TabIndex = 0;
            this.btnBrowseCpu.Text = "CPU";
            this.btnBrowseCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseCpu.UseVisualStyleBackColor = true;
            this.btnBrowseCpu.Click += new System.EventHandler(this.BtnBrowseCpu_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBrowse.Location = new System.Drawing.Point(0, 100);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBrowse.Size = new System.Drawing.Size(233, 45);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::PCB.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 611);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.Text = "PCB";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSetupsSubmenu.ResumeLayout(false);
            this.panelBrowseSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelBrowseSubmenu;
        private System.Windows.Forms.Button btnBrowseSsd;
        private System.Windows.Forms.Button btnBrowseHdd;
        private System.Windows.Forms.Button btnBrowseRam;
        private System.Windows.Forms.Button btnBrowsePsu;
        private System.Windows.Forms.Button btnBrowseVideoCard;
        private System.Windows.Forms.Button btnBrowseMotherboard;
        private System.Windows.Forms.Button btnBrowseCpu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel panelSetupsSubmenu;
        private System.Windows.Forms.Button btnAddSetup;
        private System.Windows.Forms.Button btnMySetups;
        private System.Windows.Forms.Button btnSetups;
        private System.Windows.Forms.Button btnBrowseCooler;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

