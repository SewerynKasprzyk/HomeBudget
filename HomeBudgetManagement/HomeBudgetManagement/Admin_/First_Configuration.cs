using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.Admin_
{
    public partial class First_Configuration : Form
    {
        public First_Configuration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void login_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSetAdminLogin_click(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(234, 243, 251);

            textBoxSetAdminLogin.BackColor = Color.White;
            panelSetAdminLogin.BackColor = Color.White;
            panelSetAdminPassword.BackColor = customColor;
            textBoxSetAdminPassword.BackColor =customColor;
        }

        private void textBoxSetAdminPassword_click(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(234, 243, 251);

            textBoxSetAdminLogin.BackColor = customColor;
            panelSetAdminLogin.BackColor = customColor;
            panelSetAdminPassword.BackColor = Color.White;
            textBoxSetAdminPassword.BackColor = Color.White;
        }

        private void buttonClose_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
