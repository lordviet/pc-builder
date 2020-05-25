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
    public partial class FormAddSetup : Form
    {
        public FormAddSetup()
        {
            InitializeComponent();
        }

        private void FormAddSetup_Load(object sender, EventArgs e)
        {
            this.videoCardTableAdapter.Fill(this.pCBDataSet.VideoCard);   
            this.sSDTableAdapter.Fill(this.pCBDataSet.SSD);
            this.rAMTableAdapter.Fill(this.pCBDataSet.RAM);
            this.pSUTableAdapter.Fill(this.pCBDataSet.PSU);            
            this.motherboardTableAdapter.Fill(this.pCBDataSet.Motherboard);            
            this.hDDTableAdapter.Fill(this.pCBDataSet.HDD);                        
            this.coolerTableAdapter.Fill(this.pCBDataSet.Cooler);
            this.cPUTableAdapter.Fill(this.pCBDataSet.CPU);
        }

        private void CloseCpuBrowseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuildSetupButton_Click(object sender, EventArgs e)
        {
            Setup s = new Setup();
            s.CPU = comboBoxCpu.Text;
            s.Motherboard = comboBoxMotherboard.Text;
            s.VideoCard = comboBoxVideoCard.Text;
            s.PSU = comboBoxPsu.Text;
            s.RAM = $"{comboBoxRam1.Text} {comboBoxRam2.Text} GB";
            s.HDD = $"{comboBoxHdd1.Text} {comboBoxHdd2.Text} GB";
            s.SSD = $"{comboBoxSsd1.Text} {comboBoxSsd2.Text} GB";
            s.Cooler = comboBoxCooler.Text;
            s.Price = CalcPriceOfSetup();

            s.Insert(s);
            MessageBox.Show("Setup added successfully!");
        }

        private decimal CalcPriceOfSetup()
        {
            decimal price = 0;
            price += this.pCBDataSet.CPU.Where(c => c.Name == comboBoxCpu.Text).ToList()[0].Price;
            price += this.pCBDataSet.Motherboard.Where(c => c.Name == comboBoxMotherboard.Text).ToList()[0].Price;
            price += this.pCBDataSet.VideoCard.Where(c => c.Name == comboBoxVideoCard.Text).ToList()[0].Price;

            price += this.pCBDataSet.RAM.Where(c => c.Manufacturer == comboBoxRam1.Text &&
                                               c.Size == int.Parse(comboBoxRam2.Text))
                                        .ToList()[0].Price;

            price += this.pCBDataSet.HDD.Where(c => c.Manufacturer == comboBoxHdd1.Text &&
                                               c.CapacityGB == int.Parse(comboBoxHdd2.Text))
                                        .ToList()[0].Price;

            price += this.pCBDataSet.SSD.Where(c => c.Name == comboBoxSsd1.Text &&
                                               c.CapacityGB == int.Parse(comboBoxSsd2.Text))
                                        .ToList()[0].Price;

            price += this.pCBDataSet.Cooler.Where(c => c.Name == comboBoxCooler.Text).ToList()[0].Price;

            return price;
        }
    }
}
