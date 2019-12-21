using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is an event when ProductInfoForm is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            // bring data from class and store into textbox
            ProductIDDataLabel.Text = Program.hardwareSpec.ProductId.ToString();
            ProductCostDataLabel.Text = Program.hardwareSpec.Cost.ToString();
            ProductManufacturerDataLabel.Text= Program.hardwareSpec.Manufacturer;
            ProductModelDataLabel.Text = Program.hardwareSpec.Model;
            ProductConditionDatalabel.Text = Program.hardwareSpec.Condition;
            ProductScreensizeDataLabel.Text = Program.hardwareSpec.ScreenSize;
            ProductMemoryDataLabel.Text = Program.hardwareSpec.RamSize;
            ProductHDDSizeDataLabel.Text = Program.hardwareSpec.HddSize;
            ProductCpuNumberDataLabel.Text = Program.hardwareSpec.CpuNumber;
            ProductCpuSpeedDataLabel.Text = Program.hardwareSpec.CpuSpeed;
            ProductCpuTypeDataLabel.Text = Program.hardwareSpec.CpuType;
            ProductResolutionDataLabel.Text = Program.hardwareSpec.Resolution;
            ProductGPUTypeDataLabel.Text = Program.hardwareSpec.GpuType;
            ProductOSDataLabel.Text = Program.hardwareSpec.OS;
            ProductPlatformDataLabel.Text = Program.hardwareSpec.Platform;
            ProductCpuBrandDataLabel.Text = Program.hardwareSpec.CpuBrand;

            // This will gray-out NextButton until the user selection is fulfilled
            NextButton.Enabled = (ProductModelDataLabel.Text != string.Empty) ? true : false;
        }


        /// <summary>
        /// This is an event when NextButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.OrderForm].Show();
            Program.Forms[FormName.SelectForm].Hide();
        }


        /// <summary>
        /// This is an event when saveToolStripMenuItem is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            productSaveFileDialog.FileName = "Product.txt";
            productSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open file dialog 
            var _dialogResult = productSaveFileDialog.ShowDialog();
            if (_dialogResult != DialogResult.Cancel)
            {
                // open file to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(productSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputStream.WriteLine(Program.hardwareSpec.ProductId.ToString());
                    outputStream.WriteLine(Program.hardwareSpec.Cost);
                    outputStream.WriteLine(Program.hardwareSpec.Manufacturer);
                    outputStream.WriteLine(Program.hardwareSpec.Model);
                    outputStream.WriteLine(Program.hardwareSpec.RamSize);
                    outputStream.WriteLine(Program.hardwareSpec.Condition);
                    outputStream.WriteLine(Program.hardwareSpec.ScreenSize);
                    outputStream.WriteLine(Program.hardwareSpec.CpuBrand);
                    outputStream.WriteLine(Program.hardwareSpec.HddSize);
                    outputStream.WriteLine(Program.hardwareSpec.CpuSpeed);
                    outputStream.WriteLine(Program.hardwareSpec.CpuType);
                    outputStream.WriteLine(Program.hardwareSpec.Resolution);
                    outputStream.WriteLine(Program.hardwareSpec.Platform);
                    outputStream.WriteLine(Program.hardwareSpec.OS);
                    outputStream.WriteLine(Program.hardwareSpec.GpuType);
                    outputStream.WriteLine(Program.hardwareSpec.CpuNumber);

                    // cleanup
                    outputStream.Flush();
                    outputStream.Close();
                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved", "Saving File..",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// This is an event when openToolStripMenuItem is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            productOpenFileDialog.FileName = "Product.txt";
            productOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var _dialogResult = productOpenFileDialog.ShowDialog();
            if (_dialogResult != DialogResult.Cancel)
            {

                try
                {
                    // NextButton is enabled when file is successfully loaded
                    NextButton.Enabled = true;

                    // Open stream to read file
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(productOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // Read stuff into the Student class
                        Program.hardwareSpec.ProductId = int.Parse(inputStream.ReadLine());
                        Program.hardwareSpec.Cost = float.Parse(inputStream.ReadLine());
                        Program.hardwareSpec.Manufacturer = inputStream.ReadLine();
                        Program.hardwareSpec.Model = inputStream.ReadLine();
                        Program.hardwareSpec.RamSize = inputStream.ReadLine();
                        Program.hardwareSpec.Condition = inputStream.ReadLine();
                        Program.hardwareSpec.ScreenSize = inputStream.ReadLine();
                        Program.hardwareSpec.CpuBrand = inputStream.ReadLine();
                        Program.hardwareSpec.HddSize = inputStream.ReadLine();
                        Program.hardwareSpec.CpuSpeed = inputStream.ReadLine();
                        Program.hardwareSpec.CpuType = inputStream.ReadLine();
                        Program.hardwareSpec.Resolution = inputStream.ReadLine();
                        Program.hardwareSpec.Platform = inputStream.ReadLine();
                        Program.hardwareSpec.OS = inputStream.ReadLine();
                        Program.hardwareSpec.GpuType = inputStream.ReadLine();
                        Program.hardwareSpec.CpuNumber = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();

                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Write into the TextBox based on file
            ProductIDDataLabel.Text = Program.hardwareSpec.ProductId.ToString();
            ProductCostDataLabel.Text = Program.hardwareSpec.Cost.ToString();
            ProductManufacturerDataLabel.Text = Program.hardwareSpec.Manufacturer;
            ProductModelDataLabel.Text = Program.hardwareSpec.Model;
            ProductConditionDatalabel.Text = Program.hardwareSpec.Condition;
            ProductScreensizeDataLabel.Text = Program.hardwareSpec.ScreenSize;
            ProductMemoryDataLabel.Text = Program.hardwareSpec.RamSize;
            ProductHDDSizeDataLabel.Text = Program.hardwareSpec.HddSize;
            ProductCpuNumberDataLabel.Text = Program.hardwareSpec.CpuNumber;
            ProductCpuSpeedDataLabel.Text = Program.hardwareSpec.CpuSpeed;
            ProductCpuTypeDataLabel.Text = Program.hardwareSpec.CpuType;
            ProductResolutionDataLabel.Text = Program.hardwareSpec.Resolution;
            ProductGPUTypeDataLabel.Text = Program.hardwareSpec.GpuType;
            ProductOSDataLabel.Text = Program.hardwareSpec.OS;
            ProductPlatformDataLabel.Text = Program.hardwareSpec.Platform;
            ProductCpuBrandDataLabel.Text = Program.hardwareSpec.CpuBrand;
        }


        /// <summary>
        /// This Terminated program when ExitToolStripMenuItem is Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Goes to SelectForm when SelectAnotherProductToolStripMenuItem is Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SelectForm].Show();
        }
    }
}

