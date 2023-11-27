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

                if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    // Obsługa błędu - jedno z pól tekstowych jest puste
                    throw new Exception("Pole tekstowe nie może być puste.");
                }

                User user = new User();
                user.Show();
            }
            catch (Exception ex)
            {
                // Obsługa wyjątku i wyświetlenie komunikatu w oknie dialogowym
                MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
