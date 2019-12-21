using Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name : Yoonseop Lee
/// Student number : 301037418
/// Date last Modified : August 13th, 2019 
/// App Name : Dollar Computer Order Form
/// Program description : This application allows users to select products
/// and then finally, will calculate the cost of the Computer in a separate form.
/// 
/// Revision History : 
///     Ver1.0  Created fundamental UI (required for lab11)
///     Ver1.01 Fixed SplashForm interval to 3000ms (required for lab11)
///     Ver1.1  Sorted files into folders, added core logic using systemIO and fixed aboutForm appropriate
///     Ver1.2  Fixed tons of name of labels and textboxs, UI layout , Added in-line omments, internal comments, 
///             fixed openDialog from StartForm, fixed AboutForm, fixed selectForm cellClick event, 
///             fixed Open & Save File Dialog in terms of saving data
///     Ver1.3  Fixed Label name properly and fixed gray-out next button logic      
///     Ver2.0  Fixed gray-out next button logic and checked codes and internal documentations ( Completed )     
///     Ver2.1  Fixed textBox in selectionForm and icon size properly
/// </summary>
namespace Assignment5
{
    static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        public static HardwareSpec hardwareSpec;
        public static ProductInfoForm productInfoForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SplashScreen, new SplashScreen());
            Forms.Add(FormName.StartForm, new StartForm());
            Forms.Add(FormName.SelectForm, new SelectForm());
            Forms.Add(FormName.OrderForm, new OrderForm());
            Forms.Add(FormName.AboutBox, new AboutForm());
            productInfoForm = new ProductInfoForm();
            hardwareSpec = new HardwareSpec();

            Application.Run(Forms[FormName.SplashScreen]);
        }
    }
}
