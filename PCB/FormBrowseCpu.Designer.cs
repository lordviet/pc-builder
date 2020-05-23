namespace PCB
{
    partial class FormBrowseCpu
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
            this.cpuBrowseGV = new System.Windows.Forms.DataGridView();
            this.DeleteCpuButton = new System.Windows.Forms.Button();
            this.UpdateCpuButton = new System.Windows.Forms.Button();
            this.AddCpuButton = new System.Windows.Forms.Button();
            this.CloseCpuBrowseBtn = new System.Windows.Forms.Button();
            this.labelCpuId = new System.Windows.Forms.Label();
            this.textBoxCpuId = new System.Windows.Forms.TextBox();
            this.labelCpuManufacturer = new System.Windows.Forms.Label();
            this.labelCpuName = new System.Windows.Forms.Label();
            this.labelCpuCores = new System.Windows.Forms.Label();
            this.labelCpuCoreClock = new System.Windows.Forms.Label();
            this.labelCpuBoostClock = new System.Windows.Forms.Label();
            this.labelCpuTdp = new System.Windows.Forms.Label();
            this.labelCpuIntegratedGraphics = new System.Windows.Forms.Label();
            this.labelCpuPrice = new System.Windows.Forms.Label();
            this.textBoxCpuManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxCpuName = new System.Windows.Forms.TextBox();
            this.textBoxCpuCores = new System.Windows.Forms.TextBox();
            this.textBoxCpuCoreClock = new System.Windows.Forms.TextBox();
            this.textBoxCpuBoostClock = new System.Windows.Forms.TextBox();
            this.textBoxCpuTdp = new System.Windows.Forms.TextBox();
            this.textBoxCpuIntegratedGraphics = new System.Windows.Forms.TextBox();
            this.textBoxCpuPrice = new System.Windows.Forms.TextBox();
            this.labelCpuSearch = new System.Windows.Forms.Label();
            this.textBoxCpuSearch = new System.Windows.Forms.TextBox();
            this.ClearCpuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBrowseGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuBrowseGV
            // 
            this.cpuBrowseGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuBrowseGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpuBrowseGV.Location = new System.Drawing.Point(12, 350);
            this.cpuBrowseGV.Name = "cpuBrowseGV";
            this.cpuBrowseGV.Size = new System.Drawing.Size(660, 188);
            this.cpuBrowseGV.TabIndex = 0;
            this.cpuBrowseGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CpuBrowseGV_RowHeaderMouseClick);
            // 
            // DeleteCpuButton
            // 
            this.DeleteCpuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteCpuButton.FlatAppearance.BorderSize = 0;
            this.DeleteCpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCpuButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCpuButton.Location = new System.Drawing.Point(515, 563);
            this.DeleteCpuButton.Name = "DeleteCpuButton";
            this.DeleteCpuButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCpuButton.TabIndex = 1;
            this.DeleteCpuButton.Text = "Delete";
            this.DeleteCpuButton.UseVisualStyleBackColor = false;
            this.DeleteCpuButton.Click += new System.EventHandler(this.DeleteCpuButton_Click);
            // 
            // UpdateCpuButton
            // 
            this.UpdateCpuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateCpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.UpdateCpuButton.FlatAppearance.BorderSize = 0;
            this.UpdateCpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCpuButton.ForeColor = System.Drawing.Color.White;
            this.UpdateCpuButton.Location = new System.Drawing.Point(434, 563);
            this.UpdateCpuButton.Name = "UpdateCpuButton";
            this.UpdateCpuButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCpuButton.TabIndex = 2;
            this.UpdateCpuButton.Text = "Update";
            this.UpdateCpuButton.UseVisualStyleBackColor = false;
            this.UpdateCpuButton.Click += new System.EventHandler(this.UpdateCpuButton_Click);
            // 
            // AddCpuButton
            // 
            this.AddCpuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.AddCpuButton.FlatAppearance.BorderSize = 0;
            this.AddCpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCpuButton.ForeColor = System.Drawing.Color.White;
            this.AddCpuButton.Location = new System.Drawing.Point(353, 563);
            this.AddCpuButton.Name = "AddCpuButton";
            this.AddCpuButton.Size = new System.Drawing.Size(75, 23);
            this.AddCpuButton.TabIndex = 3;
            this.AddCpuButton.Text = "Add";
            this.AddCpuButton.UseVisualStyleBackColor = false;
            this.AddCpuButton.Click += new System.EventHandler(this.AddCpuButton_Click);
            // 
            // CloseCpuBrowseBtn
            // 
            this.CloseCpuBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.CloseCpuBrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCpuBrowseBtn.FlatAppearance.BorderSize = 0;
            this.CloseCpuBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseCpuBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseCpuBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseCpuBrowseBtn.Location = new System.Drawing.Point(1, 1);
            this.CloseCpuBrowseBtn.Name = "CloseCpuBrowseBtn";
            this.CloseCpuBrowseBtn.Size = new System.Drawing.Size(23, 23);
            this.CloseCpuBrowseBtn.TabIndex = 4;
            this.CloseCpuBrowseBtn.Text = "X";
            this.CloseCpuBrowseBtn.UseVisualStyleBackColor = false;
            this.CloseCpuBrowseBtn.Click += new System.EventHandler(this.CloseCpuBrowseBtn_Click);
            // 
            // labelCpuId
            // 
            this.labelCpuId.AutoSize = true;
            this.labelCpuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuId.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuId.Location = new System.Drawing.Point(14, 70);
            this.labelCpuId.Name = "labelCpuId";
            this.labelCpuId.Size = new System.Drawing.Size(51, 17);
            this.labelCpuId.TabIndex = 5;
            this.labelCpuId.Text = "CPU Id";
            // 
            // textBoxCpuId
            // 
            this.textBoxCpuId.Location = new System.Drawing.Point(127, 70);
            this.textBoxCpuId.Name = "textBoxCpuId";
            this.textBoxCpuId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuId.TabIndex = 6;
            // 
            // labelCpuManufacturer
            // 
            this.labelCpuManufacturer.AutoSize = true;
            this.labelCpuManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuManufacturer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuManufacturer.Location = new System.Drawing.Point(14, 116);
            this.labelCpuManufacturer.Name = "labelCpuManufacturer";
            this.labelCpuManufacturer.Size = new System.Drawing.Size(92, 17);
            this.labelCpuManufacturer.TabIndex = 7;
            this.labelCpuManufacturer.Text = "Manufacturer";
            // 
            // labelCpuName
            // 
            this.labelCpuName.AutoSize = true;
            this.labelCpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuName.Location = new System.Drawing.Point(14, 161);
            this.labelCpuName.Name = "labelCpuName";
            this.labelCpuName.Size = new System.Drawing.Size(45, 17);
            this.labelCpuName.TabIndex = 8;
            this.labelCpuName.Text = "Name";
            // 
            // labelCpuCores
            // 
            this.labelCpuCores.AutoSize = true;
            this.labelCpuCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuCores.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuCores.Location = new System.Drawing.Point(11, 210);
            this.labelCpuCores.Name = "labelCpuCores";
            this.labelCpuCores.Size = new System.Drawing.Size(45, 17);
            this.labelCpuCores.TabIndex = 9;
            this.labelCpuCores.Text = "Cores";
            // 
            // labelCpuCoreClock
            // 
            this.labelCpuCoreClock.AutoSize = true;
            this.labelCpuCoreClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuCoreClock.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuCoreClock.Location = new System.Drawing.Point(14, 255);
            this.labelCpuCoreClock.Name = "labelCpuCoreClock";
            this.labelCpuCoreClock.Size = new System.Drawing.Size(76, 17);
            this.labelCpuCoreClock.TabIndex = 10;
            this.labelCpuCoreClock.Text = "Core Clock";
            // 
            // labelCpuBoostClock
            // 
            this.labelCpuBoostClock.AutoSize = true;
            this.labelCpuBoostClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuBoostClock.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuBoostClock.Location = new System.Drawing.Point(298, 119);
            this.labelCpuBoostClock.Name = "labelCpuBoostClock";
            this.labelCpuBoostClock.Size = new System.Drawing.Size(82, 17);
            this.labelCpuBoostClock.TabIndex = 11;
            this.labelCpuBoostClock.Text = "Boost Clock";
            // 
            // labelCpuTdp
            // 
            this.labelCpuTdp.AutoSize = true;
            this.labelCpuTdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuTdp.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuTdp.Location = new System.Drawing.Point(298, 165);
            this.labelCpuTdp.Name = "labelCpuTdp";
            this.labelCpuTdp.Size = new System.Drawing.Size(36, 17);
            this.labelCpuTdp.TabIndex = 12;
            this.labelCpuTdp.Text = "TDP";
            // 
            // labelCpuIntegratedGraphics
            // 
            this.labelCpuIntegratedGraphics.AutoSize = true;
            this.labelCpuIntegratedGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuIntegratedGraphics.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuIntegratedGraphics.Location = new System.Drawing.Point(298, 210);
            this.labelCpuIntegratedGraphics.Name = "labelCpuIntegratedGraphics";
            this.labelCpuIntegratedGraphics.Size = new System.Drawing.Size(130, 17);
            this.labelCpuIntegratedGraphics.TabIndex = 13;
            this.labelCpuIntegratedGraphics.Text = "Integrated graphics";
            // 
            // labelCpuPrice
            // 
            this.labelCpuPrice.AutoSize = true;
            this.labelCpuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuPrice.Location = new System.Drawing.Point(298, 259);
            this.labelCpuPrice.Name = "labelCpuPrice";
            this.labelCpuPrice.Size = new System.Drawing.Size(40, 17);
            this.labelCpuPrice.TabIndex = 14;
            this.labelCpuPrice.Text = "Price";
            // 
            // textBoxCpuManufacturer
            // 
            this.textBoxCpuManufacturer.Location = new System.Drawing.Point(127, 115);
            this.textBoxCpuManufacturer.Name = "textBoxCpuManufacturer";
            this.textBoxCpuManufacturer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuManufacturer.TabIndex = 15;
            // 
            // textBoxCpuName
            // 
            this.textBoxCpuName.Location = new System.Drawing.Point(127, 160);
            this.textBoxCpuName.Name = "textBoxCpuName";
            this.textBoxCpuName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuName.TabIndex = 16;
            // 
            // textBoxCpuCores
            // 
            this.textBoxCpuCores.Location = new System.Drawing.Point(127, 209);
            this.textBoxCpuCores.Name = "textBoxCpuCores";
            this.textBoxCpuCores.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuCores.TabIndex = 17;
            // 
            // textBoxCpuCoreClock
            // 
            this.textBoxCpuCoreClock.Location = new System.Drawing.Point(127, 254);
            this.textBoxCpuCoreClock.Name = "textBoxCpuCoreClock";
            this.textBoxCpuCoreClock.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuCoreClock.TabIndex = 18;
            // 
            // textBoxCpuBoostClock
            // 
            this.textBoxCpuBoostClock.Location = new System.Drawing.Point(402, 116);
            this.textBoxCpuBoostClock.Name = "textBoxCpuBoostClock";
            this.textBoxCpuBoostClock.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuBoostClock.TabIndex = 19;
            // 
            // textBoxCpuTdp
            // 
            this.textBoxCpuTdp.Location = new System.Drawing.Point(402, 164);
            this.textBoxCpuTdp.Name = "textBoxCpuTdp";
            this.textBoxCpuTdp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuTdp.TabIndex = 20;
            // 
            // textBoxCpuIntegratedGraphics
            // 
            this.textBoxCpuIntegratedGraphics.Location = new System.Drawing.Point(402, 207);
            this.textBoxCpuIntegratedGraphics.Name = "textBoxCpuIntegratedGraphics";
            this.textBoxCpuIntegratedGraphics.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuIntegratedGraphics.TabIndex = 21;
            // 
            // textBoxCpuPrice
            // 
            this.textBoxCpuPrice.Location = new System.Drawing.Point(402, 252);
            this.textBoxCpuPrice.Name = "textBoxCpuPrice";
            this.textBoxCpuPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpuPrice.TabIndex = 22;
            // 
            // labelCpuSearch
            // 
            this.labelCpuSearch.AutoSize = true;
            this.labelCpuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuSearch.Location = new System.Drawing.Point(12, 318);
            this.labelCpuSearch.Name = "labelCpuSearch";
            this.labelCpuSearch.Size = new System.Drawing.Size(53, 17);
            this.labelCpuSearch.TabIndex = 23;
            this.labelCpuSearch.Text = "Search";
            // 
            // textBoxCpuSearch
            // 
            this.textBoxCpuSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCpuSearch.Location = new System.Drawing.Point(89, 317);
            this.textBoxCpuSearch.Name = "textBoxCpuSearch";
            this.textBoxCpuSearch.Size = new System.Drawing.Size(583, 20);
            this.textBoxCpuSearch.TabIndex = 24;
            this.textBoxCpuSearch.TextChanged += new System.EventHandler(this.TextBoxCpuSearch_TextChanged);
            // 
            // ClearCpuButton
            // 
            this.ClearCpuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClearCpuButton.FlatAppearance.BorderSize = 0;
            this.ClearCpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCpuButton.ForeColor = System.Drawing.Color.White;
            this.ClearCpuButton.Location = new System.Drawing.Point(597, 563);
            this.ClearCpuButton.Name = "ClearCpuButton";
            this.ClearCpuButton.Size = new System.Drawing.Size(75, 23);
            this.ClearCpuButton.TabIndex = 25;
            this.ClearCpuButton.Text = "Clear";
            this.ClearCpuButton.UseVisualStyleBackColor = false;
            this.ClearCpuButton.Click += new System.EventHandler(this.ClearCpuButton_Click);
            // 
            // FormBrowseCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.ClearCpuButton);
            this.Controls.Add(this.textBoxCpuSearch);
            this.Controls.Add(this.labelCpuSearch);
            this.Controls.Add(this.textBoxCpuPrice);
            this.Controls.Add(this.textBoxCpuIntegratedGraphics);
            this.Controls.Add(this.textBoxCpuTdp);
            this.Controls.Add(this.textBoxCpuBoostClock);
            this.Controls.Add(this.textBoxCpuCoreClock);
            this.Controls.Add(this.textBoxCpuCores);
            this.Controls.Add(this.textBoxCpuName);
            this.Controls.Add(this.textBoxCpuManufacturer);
            this.Controls.Add(this.labelCpuPrice);
            this.Controls.Add(this.labelCpuIntegratedGraphics);
            this.Controls.Add(this.labelCpuTdp);
            this.Controls.Add(this.labelCpuBoostClock);
            this.Controls.Add(this.labelCpuCoreClock);
            this.Controls.Add(this.labelCpuCores);
            this.Controls.Add(this.labelCpuName);
            this.Controls.Add(this.labelCpuManufacturer);
            this.Controls.Add(this.textBoxCpuId);
            this.Controls.Add(this.labelCpuId);
            this.Controls.Add(this.CloseCpuBrowseBtn);
            this.Controls.Add(this.AddCpuButton);
            this.Controls.Add(this.UpdateCpuButton);
            this.Controls.Add(this.DeleteCpuButton);
            this.Controls.Add(this.cpuBrowseGV);
            this.Name = "FormBrowseCpu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormBrowseCpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuBrowseGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cpuBrowseGV;
        private System.Windows.Forms.Button DeleteCpuButton;
        private System.Windows.Forms.Button UpdateCpuButton;
        private System.Windows.Forms.Button AddCpuButton;
        private System.Windows.Forms.Button CloseCpuBrowseBtn;
        private System.Windows.Forms.Label labelCpuId;
        private System.Windows.Forms.TextBox textBoxCpuId;
        private System.Windows.Forms.Label labelCpuManufacturer;
        private System.Windows.Forms.Label labelCpuName;
        private System.Windows.Forms.Label labelCpuCores;
        private System.Windows.Forms.Label labelCpuCoreClock;
        private System.Windows.Forms.Label labelCpuBoostClock;
        private System.Windows.Forms.Label labelCpuTdp;
        private System.Windows.Forms.Label labelCpuIntegratedGraphics;
        private System.Windows.Forms.Label labelCpuPrice;
        private System.Windows.Forms.TextBox textBoxCpuManufacturer;
        private System.Windows.Forms.TextBox textBoxCpuName;
        private System.Windows.Forms.TextBox textBoxCpuCores;
        private System.Windows.Forms.TextBox textBoxCpuCoreClock;
        private System.Windows.Forms.TextBox textBoxCpuBoostClock;
        private System.Windows.Forms.TextBox textBoxCpuTdp;
        private System.Windows.Forms.TextBox textBoxCpuIntegratedGraphics;
        private System.Windows.Forms.TextBox textBoxCpuPrice;
        private System.Windows.Forms.Label labelCpuSearch;
        private System.Windows.Forms.TextBox textBoxCpuSearch;
        private System.Windows.Forms.Button ClearCpuButton;
    }
}