using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement
{
    internal static class Program
    {

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            currentForm = new Client();

            Application.Run(currentForm);

            //How to use
            //Program.ChangeForm(typeof(Admin));
        }
        public static void ChangeFormHide(Form newForm)
        {
            currentForm.Hide();  // Hide the current form
            currentForm = newForm;
            currentForm.Show();  // Show the new form
        }

        public static void ChangeForm(Type formType)
        {
            currentForm.Hide();  // Hide the current form
            currentForm = (Form)Activator.CreateInstance(formType);
            currentForm.Show();  // Show the new form
        }

        private static Form currentForm;
    }

}
