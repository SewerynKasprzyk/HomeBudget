using Database.Entities;
using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class Manage_Account_Balance : Form
    {
        private BalanceManager _balanceManager  = new BalanceManager();

        public Manage_Account_Balance()
        {
            InitializeComponent();
            InitializeBalance();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(FinancialGoalManagement));
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

        private void ButtonAddToBalance_Click(object sender, EventArgs e)
        {
            try
            {
                var newamount = decimal.Parse(TextBoxAddBalance.Text);
                _balanceManager.AddBalance(newamount);
                MessageBox.Show($"Amount successfully changed", "Balance Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
            }
            catch
            {
                MessageBox.Show($"Amount must be a number", "Balance Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeBalance()
        {
            LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
        }
    }
}
