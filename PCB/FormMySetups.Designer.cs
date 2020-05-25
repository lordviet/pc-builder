namespace PCB
{
    partial class FormMySetups
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
            this.CloseCpuBrowseBtn = new System.Windows.Forms.Button();
            this.setupsGV = new System.Windows.Forms.DataGridView();
            this.labelMySetups = new System.Windows.Forms.Label();
            this.textBoxSetupId = new System.Windows.Forms.TextBox();
            this.labelSetupId = new System.Windows.Forms.Label();
            this.DeleteSetupButton = new System.Windows.Forms.Button();
            this.ExportSetupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setupsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseCpuBrowseBtn
            // 
            this.CloseCpuBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.CloseCpuBrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCpuBrowseBtn.FlatAppearance.BorderSize = 0;
            this.CloseCpuBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseCpuBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseCpuBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseCpuBrowseBtn.Location = new System.Drawing.Point(0, 0);
            this.CloseCpuBrowseBtn.Name = "CloseCpuBrowseBtn";
            this.CloseCpuBrowseBtn.Size = new System.Drawing.Size(23, 23);
            this.CloseCpuBrowseBtn.TabIndex = 5;
            this.CloseCpuBrowseBtn.Text = "X";
            this.CloseCpuBrowseBtn.UseVisualStyleBackColor = false;
            this.CloseCpuBrowseBtn.Click += new System.EventHandler(this.CloseCpuBrowseBtn_Click);
            // 
            // setupsGV
            // 
            this.setupsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setupsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setupsGV.Location = new System.Drawing.Point(12, 76);
            this.setupsGV.Name = "setupsGV";
            this.setupsGV.Size = new System.Drawing.Size(660, 421);
            this.setupsGV.TabIndex = 6;
            this.setupsGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CpuBrowseGV_RowHeaderMouseClick);
            // 
            // labelMySetups
            // 
            this.labelMySetups.AutoSize = true;
            this.labelMySetups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMySetups.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMySetups.Location = new System.Drawing.Point(12, 46);
            this.labelMySetups.Name = "labelMySetups";
            this.labelMySetups.Size = new System.Drawing.Size(74, 17);
            this.labelMySetups.TabIndex = 7;
            this.labelMySetups.Text = "My Setups";
            // 
            // textBoxSetupId
            // 
            this.textBoxSetupId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSetupId.Location = new System.Drawing.Point(122, 500);
            this.textBoxSetupId.Name = "textBoxSetupId";
            this.textBoxSetupId.ReadOnly = true;
            this.textBoxSetupId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetupId.TabIndex = 9;
            // 
            // labelSetupId
            // 
            this.labelSetupId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSetupId.AutoSize = true;
            this.labelSetupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetupId.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSetupId.Location = new System.Drawing.Point(9, 500);
            this.labelSetupId.Name = "labelSetupId";
            this.labelSetupId.Size = new System.Drawing.Size(60, 17);
            this.labelSetupId.TabIndex = 8;
            this.labelSetupId.Text = "Setup Id";
            // 
            // DeleteSetupButton
            // 
            this.DeleteSetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteSetupButton.FlatAppearance.BorderSize = 0;
            this.DeleteSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSetupButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSetupButton.Location = new System.Drawing.Point(597, 576);
            this.DeleteSetupButton.Name = "DeleteSetupButton";
            this.DeleteSetupButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSetupButton.TabIndex = 10;
            this.DeleteSetupButton.Text = "Delete";
            this.DeleteSetupButton.UseVisualStyleBackColor = false;
            this.DeleteSetupButton.Click += new System.EventHandler(this.DeleteSetupButton_Click);
            // 
            // ExportSetupButton
            // 
            this.ExportSetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.ExportSetupButton.FlatAppearance.BorderSize = 0;
            this.ExportSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportSetupButton.ForeColor = System.Drawing.Color.White;
            this.ExportSetupButton.Location = new System.Drawing.Point(516, 576);
            this.ExportSetupButton.Name = "ExportSetupButton";
            this.ExportSetupButton.Size = new System.Drawing.Size(75, 23);
            this.ExportSetupButton.TabIndex = 11;
            this.ExportSetupButton.Text = "Export";
            this.ExportSetupButton.UseVisualStyleBackColor = false;
            this.ExportSetupButton.Click += new System.EventHandler(this.ExportSetupButton_Click);
            // 
            // FormMySetups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.ExportSetupButton);
            this.Controls.Add(this.DeleteSetupButton);
            this.Controls.Add(this.textBoxSetupId);
            this.Controls.Add(this.labelSetupId);
            this.Controls.Add(this.labelMySetups);
            this.Controls.Add(this.setupsGV);
            this.Controls.Add(this.CloseCpuBrowseBtn);
            this.Name = "FormMySetups";
            this.Text = "FormMySetups";
            this.Load += new System.EventHandler(this.FormMySetups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setupsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseCpuBrowseBtn;
        private System.Windows.Forms.DataGridView setupsGV;
        private System.Windows.Forms.Label labelMySetups;
        private System.Windows.Forms.TextBox textBoxSetupId;
        private System.Windows.Forms.Label labelSetupId;
        private System.Windows.Forms.Button DeleteSetupButton;
        private System.Windows.Forms.Button ExportSetupButton;
    }
}