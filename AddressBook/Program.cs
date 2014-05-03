using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var view = new MainFormView();
            var model = new MainFormModel();
            var controller = new MainFormController(model,view);

            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(view);        

        }
    }
}
