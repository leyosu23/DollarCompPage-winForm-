using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Show up AboutBox when aboutToolStripMenuItem is Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.AboutBox].ShowDialog();
        }


        /// <summary>
        /// This is an event where  OrderForm is Activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ///bring up the data from class and assign into TextBox 
            ProductCostDataLabel.Text = "$" + Math.Round(Program.hardwareSpec.Cost, 2).ToString();
            ProductManufacturerDataLabel.Text = Program.hardwareSpec.Manufacturer;
            ProductModelDataLabel.Text = Program.hardwareSpec.Model;
            ProductConditionDatalabel.Text = Program.hardwareSpec.Condition;
            ProductScreensizeDataLabel.Text = Program.hardwareSpec.ScreenSize;
            ProductMemoryDataLabel.Text = Program.hardwareSpec.RamSize;
            ProductCpuBrandDataLabel.Text = Program.hardwareSpec.CpuBrand;
            ProductHDDSizeDataLabel.Text = Program.hardwareSpec.HddSize;
            ProductCpuSpeedDataLabel.Text = Program.hardwareSpec.CpuSpeed;
            ProductCpuTypeDataLabel.Text = Program.hardwareSpec.CpuType;
            ProductResolutionDataLabel.Text = Program.hardwareSpec.Resolution;
            ProductGPUTypeDataLabel.Text = Program.hardwareSpec.GpuType;
            ProductOSDataLabel.Text = Program.hardwareSpec.OS;
            ProductPlatformDataLabel.Text = Program.hardwareSpec.Platform;
            ProductCpuNumberDataLabel.Text = Program.hardwareSpec.CpuNumber;
            ProductTaxDataLabel.Text = "$" + (Math.Round(Program.hardwareSpec.Cost * 0.13, 2)).ToString();
            ProductTotalDataLabel.Text = "$" + (Math.Round(Program.hardwareSpec.Cost * 1.13, 2)).ToString();
        }


        /// <summary>
        /// MessageBox shows up when orderFinishButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderFinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! \n\nYour order will be processed in 7 - 10 business days.", "Thank you!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExitToolStripMenuItem_Click(sender, e);
        }


        /// <summary>
        /// MessageBox shows up when printToolStripMenuItem is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing is on the process. Check the print.", "Printing..!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// This terminated program when ExitToolStripMenuItem is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Goes to productInfoForm when BackToolStripMenuItem is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
    }
}
