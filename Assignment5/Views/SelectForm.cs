using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is an event when selectForm is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Activated(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }

            // This disables default currentCell selection, TextBox 
            HardWareDataGridView.CurrentCell.Selected = false;
            HardWareDataGridView.RowHeadersVisible = false;
            UserSelectionDisabledTextBox.Visible = true;
            UserSelectionTextBox.Visible = false;

            // Next button will be grayed-out until specific row is selected
            SelectFormNextButton.Enabled = false;

            
        }


        /// <summary>
        /// When SelectFormCancelButton is clicked, program is terminated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// When SelectFormNextButto is clicked, goes to productInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }


        /// <summary>
        /// This is an event where HardWareDataGridView selection is changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardWareDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // NextButton enabled when selection is changed
            SelectFormNextButton.Enabled = true;

            // This enables TextBox selection 
            UserSelectionDisabledTextBox.Visible = false;
            UserSelectionTextBox.Visible = true;

            try
            {
                // local scope aliases
                var _rowIndex = HardWareDataGridView.CurrentCell.RowIndex;
                var _rows = HardWareDataGridView.Rows;
                var _columnCount = HardWareDataGridView.ColumnCount;
                var _cells = _rows[_rowIndex].Cells;

                //Store selected data into class
                Program.hardwareSpec.ProductId = int.Parse(_cells[0].Value.ToString());
                float _cost = Program.hardwareSpec.Cost = float.Parse(_cells[1].Value.ToString());
                string _manufacturer = Program.hardwareSpec.Manufacturer = _cells[2].Value.ToString();
                string _model = Program.hardwareSpec.Model = _cells[3].Value.ToString();
                Program.hardwareSpec.RamSize = _cells[4].Value.ToString();
                Program.hardwareSpec.Condition = _cells[13].Value.ToString();
                Program.hardwareSpec.ScreenSize = _cells[6].Value.ToString();
                Program.hardwareSpec.CpuBrand = _cells[9].Value.ToString();
                Program.hardwareSpec.HddSize = _cells[16].Value.ToString();
                Program.hardwareSpec.CpuSpeed = _cells[11].Value.ToString();
                Program.hardwareSpec.CpuType = _cells[10].Value.ToString();
                Program.hardwareSpec.Resolution = _cells[7].Value.ToString();
                Program.hardwareSpec.Platform = _cells[15].Value.ToString();
                Program.hardwareSpec.OS = _cells[14].Value.ToString();
                Program.hardwareSpec.GpuType = _cells[18].Value.ToString();
                Program.hardwareSpec.CpuNumber = _cells[12].Value.ToString();

                // Write cost, manufacturer, model into textBox below
                UserSelectionTextBox.Text = String.Format("{0:c2}  {1}  {2}", _cost, _manufacturer, _model);
            }

            catch (Exception ex)
            {
                UserSelectionTextBox.Text = ex.Message;
            }

        }
    }
}
