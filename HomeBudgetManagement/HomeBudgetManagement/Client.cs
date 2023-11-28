using Background;
using HomeBudgetManagement.Admin_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //formuła logowania

                if (string.IsNullOrWhiteSpace(labelLogin.Text) || string.IsNullOrWhiteSpace(labelPassword.Text))
                {
                    // Obsługa błędu - jedno z pól tekstowych jest puste
                    throw new Exception("Pole tekstowe nie może być puste.");
                }
                else
                {

                    Login.Authenticate(labelLogin.Text, labelPassword.Text);

                    switch (Configuration.AccessLevel)
                    {

                        case 1:
                            Program.ChangeForm(typeof(User_menu));
                            break;

                        case 2:
                            Program.ChangeForm(typeof(Admin));
                            break;

                        default:
                            break;
                    }

                }
           
            }
            catch (Exception ex)
            {
                // Obsługa wyjątku i wyświetlenie komunikatu w oknie dialogowym
                MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(First_Configuration));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }
    }
}
