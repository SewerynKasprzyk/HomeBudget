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
    public partial class FinancialGoalManagement : Form
    {
        public FinancialGoalManagement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Manage_Account_Balance));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FinancialGoalManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
