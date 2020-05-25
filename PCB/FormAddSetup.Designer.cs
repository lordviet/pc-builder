namespace PCB
{
    partial class FormAddSetup
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
            this.components = new System.ComponentModel.Container();
            this.CloseCpuBrowseBtn = new System.Windows.Forms.Button();
            this.labelCpuId = new System.Windows.Forms.Label();
            this.comboBoxCpu = new System.Windows.Forms.ComboBox();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCBDataSet = new PCB.PCBDataSet();
            this.cPUTableAdapter = new PCB.PCBDataSetTableAdapters.CPUTableAdapter();
            this.tableAdapterManager = new PCB.PCBDataSetTableAdapters.TableAdapterManager();
            this.coolerTableAdapter = new PCB.PCBDataSetTableAdapters.CoolerTableAdapter();
            this.hDDTableAdapter = new PCB.PCBDataSetTableAdapters.HDDTableAdapter();
            this.motherboardTableAdapter = new PCB.PCBDataSetTableAdapters.MotherboardTableAdapter();
            this.pSUTableAdapter = new PCB.PCBDataSetTableAdapters.PSUTableAdapter();
            this.rAMTableAdapter = new PCB.PCBDataSetTableAdapters.RAMTableAdapter();
            this.sSDTableAdapter = new PCB.PCBDataSetTableAdapters.SSDTableAdapter();
            this.videoCardTableAdapter = new PCB.PCBDataSetTableAdapters.VideoCardTableAdapter();
            this.comboBoxMotherboard = new System.Windows.Forms.ComboBox();
            this.motherboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVideoCard = new System.Windows.Forms.ComboBox();
            this.videoCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHdd1 = new System.Windows.Forms.ComboBox();
            this.hDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRam1 = new System.Windows.Forms.ComboBox();
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPsu = new System.Windows.Forms.ComboBox();
            this.pSUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSsd1 = new System.Windows.Forms.ComboBox();
            this.sSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCooler = new System.Windows.Forms.ComboBox();
            this.coolerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSsd2 = new System.Windows.Forms.ComboBox();
            this.comboBoxHdd2 = new System.Windows.Forms.ComboBox();
            this.comboBoxRam2 = new System.Windows.Forms.ComboBox();
            this.BuildSetupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolerBindingSource)).BeginInit();
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
            // labelCpuId
            // 
            this.labelCpuId.AutoSize = true;
            this.labelCpuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuId.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCpuId.Location = new System.Drawing.Point(12, 41);
            this.labelCpuId.Name = "labelCpuId";
            this.labelCpuId.Size = new System.Drawing.Size(36, 17);
            this.labelCpuId.TabIndex = 6;
            this.labelCpuId.Text = "CPU";
            // 
            // comboBoxCpu
            // 
            this.comboBoxCpu.DataSource = this.cPUBindingSource;
            this.comboBoxCpu.DisplayMember = "Name";
            this.comboBoxCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCpu.FormattingEnabled = true;
            this.comboBoxCpu.Location = new System.Drawing.Point(110, 40);
            this.comboBoxCpu.Name = "comboBoxCpu";
            this.comboBoxCpu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCpu.TabIndex = 9;
            this.comboBoxCpu.ValueMember = "Name";
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.pCBDataSet;
            // 
            // pCBDataSet
            // 
            this.pCBDataSet.DataSetName = "PCBDataSet";
            this.pCBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoolerTableAdapter = this.coolerTableAdapter;
            this.tableAdapterManager.CPUTableAdapter = this.cPUTableAdapter;
            this.tableAdapterManager.HDDTableAdapter = this.hDDTableAdapter;
            this.tableAdapterManager.MotherboardTableAdapter = this.motherboardTableAdapter;
            this.tableAdapterManager.PSUTableAdapter = this.pSUTableAdapter;
            this.tableAdapterManager.RAMTableAdapter = this.rAMTableAdapter;
            this.tableAdapterManager.SSDTableAdapter = this.sSDTableAdapter;
            this.tableAdapterManager.UpdateOrder = PCB.PCBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideoCardTableAdapter = this.videoCardTableAdapter;
            // 
            // coolerTableAdapter
            // 
            this.coolerTableAdapter.ClearBeforeFill = true;
            // 
            // hDDTableAdapter
            // 
            this.hDDTableAdapter.ClearBeforeFill = true;
            // 
            // motherboardTableAdapter
            // 
            this.motherboardTableAdapter.ClearBeforeFill = true;
            // 
            // pSUTableAdapter
            // 
            this.pSUTableAdapter.ClearBeforeFill = true;
            // 
            // rAMTableAdapter
            // 
            this.rAMTableAdapter.ClearBeforeFill = true;
            // 
            // sSDTableAdapter
            // 
            this.sSDTableAdapter.ClearBeforeFill = true;
            // 
            // videoCardTableAdapter
            // 
            this.videoCardTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxMotherboard
            // 
            this.comboBoxMotherboard.DataSource = this.motherboardBindingSource;
            this.comboBoxMotherboard.DisplayMember = "Name";
            this.comboBoxMotherboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotherboard.FormattingEnabled = true;
            this.comboBoxMotherboard.Location = new System.Drawing.Point(110, 100);
            this.comboBoxMotherboard.Name = "comboBoxMotherboard";
            this.comboBoxMotherboard.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMotherboard.TabIndex = 12;
            this.comboBoxMotherboard.ValueMember = "Name";
            // 
            // motherboardBindingSource
            // 
            this.motherboardBindingSource.DataMember = "Motherboard";
            this.motherboardBindingSource.DataSource = this.pCBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Motherboard";
            // 
            // comboBoxVideoCard
            // 
            this.comboBoxVideoCard.DataSource = this.videoCardBindingSource;
            this.comboBoxVideoCard.DisplayMember = "Name";
            this.comboBoxVideoCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoCard.FormattingEnabled = true;
            this.comboBoxVideoCard.Location = new System.Drawing.Point(110, 157);
            this.comboBoxVideoCard.Name = "comboBoxVideoCard";
            this.comboBoxVideoCard.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVideoCard.TabIndex = 14;
            this.comboBoxVideoCard.ValueMember = "Name";
            // 
            // videoCardBindingSource
            // 
            this.videoCardBindingSource.DataMember = "VideoCard";
            this.videoCardBindingSource.DataSource = this.pCBDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Video Card";
            // 
            // comboBoxHdd1
            // 
            this.comboBoxHdd1.DataSource = this.hDDBindingSource;
            this.comboBoxHdd1.DisplayMember = "Manufacturer";
            this.comboBoxHdd1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHdd1.FormattingEnabled = true;
            this.comboBoxHdd1.Location = new System.Drawing.Point(110, 331);
            this.comboBoxHdd1.Name = "comboBoxHdd1";
            this.comboBoxHdd1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHdd1.TabIndex = 20;
            this.comboBoxHdd1.ValueMember = "Manufacturer";
            // 
            // hDDBindingSource
            // 
            this.hDDBindingSource.DataMember = "HDD";
            this.hDDBindingSource.DataSource = this.pCBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "HDD";
            // 
            // comboBoxRam1
            // 
            this.comboBoxRam1.DataSource = this.rAMBindingSource;
            this.comboBoxRam1.DisplayMember = "Manufacturer";
            this.comboBoxRam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRam1.FormattingEnabled = true;
            this.comboBoxRam1.Location = new System.Drawing.Point(110, 274);
            this.comboBoxRam1.Name = "comboBoxRam1";
            this.comboBoxRam1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRam1.TabIndex = 18;
            this.comboBoxRam1.ValueMember = "Manufacturer";
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataMember = "RAM";
            this.rAMBindingSource.DataSource = this.pCBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "RAM";
            // 
            // comboBoxPsu
            // 
            this.comboBoxPsu.DataSource = this.pSUBindingSource;
            this.comboBoxPsu.DisplayMember = "Name";
            this.comboBoxPsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPsu.FormattingEnabled = true;
            this.comboBoxPsu.Location = new System.Drawing.Point(110, 214);
            this.comboBoxPsu.Name = "comboBoxPsu";
            this.comboBoxPsu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPsu.TabIndex = 16;
            this.comboBoxPsu.ValueMember = "Name";
            // 
            // pSUBindingSource
            // 
            this.pSUBindingSource.DataMember = "PSU";
            this.pSUBindingSource.DataSource = this.pCBDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Power Supply";
            // 
            // comboBoxSsd1
            // 
            this.comboBoxSsd1.DataSource = this.sSDBindingSource;
            this.comboBoxSsd1.DisplayMember = "Name";
            this.comboBoxSsd1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSsd1.FormattingEnabled = true;
            this.comboBoxSsd1.Location = new System.Drawing.Point(110, 391);
            this.comboBoxSsd1.Name = "comboBoxSsd1";
            this.comboBoxSsd1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSsd1.TabIndex = 22;
            this.comboBoxSsd1.ValueMember = "Name";
            // 
            // sSDBindingSource
            // 
            this.sSDBindingSource.DataMember = "SSD";
            this.sSDBindingSource.DataSource = this.pCBDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(12, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "SSD";
            // 
            // comboBoxCooler
            // 
            this.comboBoxCooler.DataSource = this.coolerBindingSource;
            this.comboBoxCooler.DisplayMember = "Name";
            this.comboBoxCooler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCooler.FormattingEnabled = true;
            this.comboBoxCooler.Location = new System.Drawing.Point(110, 449);
            this.comboBoxCooler.Name = "comboBoxCooler";
            this.comboBoxCooler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCooler.TabIndex = 24;
            this.comboBoxCooler.ValueMember = "Name";
            // 
            // coolerBindingSource
            // 
            this.coolerBindingSource.DataMember = "Cooler";
            this.coolerBindingSource.DataSource = this.pCBDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(12, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cooler";
            // 
            // comboBoxSsd2
            // 
            this.comboBoxSsd2.DataSource = this.sSDBindingSource;
            this.comboBoxSsd2.DisplayMember = "CapacityGB";
            this.comboBoxSsd2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSsd2.FormattingEnabled = true;
            this.comboBoxSsd2.Location = new System.Drawing.Point(301, 391);
            this.comboBoxSsd2.Name = "comboBoxSsd2";
            this.comboBoxSsd2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSsd2.TabIndex = 27;
            this.comboBoxSsd2.ValueMember = "CapacityGB";
            // 
            // comboBoxHdd2
            // 
            this.comboBoxHdd2.DataSource = this.hDDBindingSource;
            this.comboBoxHdd2.DisplayMember = "CapacityGB";
            this.comboBoxHdd2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHdd2.FormattingEnabled = true;
            this.comboBoxHdd2.Location = new System.Drawing.Point(301, 331);
            this.comboBoxHdd2.Name = "comboBoxHdd2";
            this.comboBoxHdd2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHdd2.TabIndex = 26;
            this.comboBoxHdd2.ValueMember = "CapacityGB";
            // 
            // comboBoxRam2
            // 
            this.comboBoxRam2.DataSource = this.rAMBindingSource;
            this.comboBoxRam2.DisplayMember = "Size";
            this.comboBoxRam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRam2.FormattingEnabled = true;
            this.comboBoxRam2.Location = new System.Drawing.Point(301, 274);
            this.comboBoxRam2.Name = "comboBoxRam2";
            this.comboBoxRam2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRam2.TabIndex = 25;
            this.comboBoxRam2.ValueMember = "Size";
            // 
            // BuildSetupButton
            // 
            this.BuildSetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.BuildSetupButton.FlatAppearance.BorderSize = 0;
            this.BuildSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildSetupButton.ForeColor = System.Drawing.Color.White;
            this.BuildSetupButton.Location = new System.Drawing.Point(597, 576);
            this.BuildSetupButton.Name = "BuildSetupButton";
            this.BuildSetupButton.Size = new System.Drawing.Size(75, 23);
            this.BuildSetupButton.TabIndex = 28;
            this.BuildSetupButton.Text = "Build";
            this.BuildSetupButton.UseVisualStyleBackColor = false;
            this.BuildSetupButton.Click += new System.EventHandler(this.BuildSetupButton_Click);
            // 
            // FormAddSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.BuildSetupButton);
            this.Controls.Add(this.comboBoxSsd2);
            this.Controls.Add(this.comboBoxHdd2);
            this.Controls.Add(this.comboBoxRam2);
            this.Controls.Add(this.comboBoxCooler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSsd1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxHdd1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRam1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPsu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxVideoCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMotherboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCpu);
            this.Controls.Add(this.labelCpuId);
            this.Controls.Add(this.CloseCpuBrowseBtn);
            this.Name = "FormAddSetup";
            this.Text = "FormAddSetup";
            this.Load += new System.EventHandler(this.FormAddSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseCpuBrowseBtn;
        private System.Windows.Forms.Label labelCpuId;
        private System.Windows.Forms.ComboBox comboBoxCpu;
        private PCBDataSet pCBDataSet;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private PCBDataSetTableAdapters.CPUTableAdapter cPUTableAdapter;
        private PCBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxMotherboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVideoCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHdd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSsd1;
        private System.Windows.Forms.Label label7;
        private PCBDataSetTableAdapters.CoolerTableAdapter coolerTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCooler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource coolerBindingSource;
        private PCBDataSetTableAdapters.HDDTableAdapter hDDTableAdapter;
        private System.Windows.Forms.BindingSource hDDBindingSource;
        private PCBDataSetTableAdapters.MotherboardTableAdapter motherboardTableAdapter;
        private System.Windows.Forms.BindingSource motherboardBindingSource;
        private PCBDataSetTableAdapters.PSUTableAdapter pSUTableAdapter;
        private System.Windows.Forms.BindingSource pSUBindingSource;
        private PCBDataSetTableAdapters.RAMTableAdapter rAMTableAdapter;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private PCBDataSetTableAdapters.SSDTableAdapter sSDTableAdapter;
        private System.Windows.Forms.BindingSource sSDBindingSource;
        private PCBDataSetTableAdapters.VideoCardTableAdapter videoCardTableAdapter;
        private System.Windows.Forms.BindingSource videoCardBindingSource;
        private System.Windows.Forms.ComboBox comboBoxSsd2;
        private System.Windows.Forms.ComboBox comboBoxHdd2;
        private System.Windows.Forms.ComboBox comboBoxRam2;
        private System.Windows.Forms.Button BuildSetupButton;
    }
}