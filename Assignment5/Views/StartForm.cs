using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class StartForm : Form 
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When ExitButton is clicked, terminates program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When StartOrderButton is clicked, selectForm shows up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SelectForm].Show();
        }

        /// <summary>
        /// When OpenSavedOrderButton is clicked, goes to productInfoForm and then openfileDialog pops up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
            Program.productInfoForm.openToolStripMenuItem_Click(sender, e);
        }


    }
}
