using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class Manage_Account_Balance : Form
    {
        public Manage_Account_Balance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(FinancialGoalManagement));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonLimitsManagement_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Limit_Management));
        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_menu));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
