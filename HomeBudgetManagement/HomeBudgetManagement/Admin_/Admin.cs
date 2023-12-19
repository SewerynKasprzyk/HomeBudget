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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_Account_Management));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(System_Configuration));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Background.Login.Logout();
            Program.ChangeForm(typeof(Client));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
