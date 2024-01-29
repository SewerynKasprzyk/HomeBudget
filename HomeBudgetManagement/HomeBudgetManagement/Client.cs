using Database.Enums;
using HomeBudgetManagement.Admin_;
using HomeBudgetManagement.Model.ConfigurationContext;
using Model.Manager;
using System;
using System.Drawing;
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

                if (string.IsNullOrWhiteSpace(textboxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    // Obsługa błędu - jedno z pól tekstowych jest puste
                    throw new Exception("Pole tekstowe nie może być puste.");
                }
                UserManager usr = new UserManager();
                if (usr.LoginProcess(textboxLogin.Text, textBoxPassword.Text))
                {
                    if(Configuration.AccessLevel == Role.User)
                    {
                        Program.ChangeForm(typeof(User_menu));
                    }
                    else if(Configuration.AccessLevel == Role.Admin)
                    {
                        Program.ChangeForm(typeof(Admin));
                    }
                    else if (Configuration.AccessLevel == Role.Guest)
                    { }
                    
                }
                else
                {
                    throw new Exception("Incorrect login details");
                }

                
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(First_Configuration));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));

        }

        private void panelLoginLeftBlue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxLogin_click(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(234, 243, 251);
           
            textboxLogin.BackColor = Color.White;
            panelLogin.BackColor = Color.White;
            panelPassword.BackColor = customColor;
            textBoxPassword.BackColor = customColor;
        }

        private void texBoxPassword_click(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(234, 243, 251);

            textboxLogin.BackColor = customColor;
            panelLogin.BackColor = customColor;
            panelPassword.BackColor = Color.White;
            textBoxPassword.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
