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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is tick event where after a minumum 3s , goes to startForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpalshLoadingTimer_Tick(object sender, EventArgs e)
        {
            SpalshLoadingTimer.Enabled = false;
            Program.Forms[FormName.StartForm].Show();
            this.Hide();
        }
    }
}
