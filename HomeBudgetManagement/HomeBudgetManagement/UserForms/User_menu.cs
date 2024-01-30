using HomeBudgetManagement.Model.ConfigurationContext;
using HomeBudgetManagement.UserForms;
using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement
{
    public partial class User_menu : Form
    {
        public User_menu()
        {
            InitializeComponent();
            UpdateView();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.Logout();
            Program.ChangeForm(typeof(Client));
        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Finance_Raport));
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Expense_Management));
        }

        private void ButtonAccountBalanceManagement_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Manage_Account_Balance));
        }

        private void ButtonManageAccount_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(ManageAccount)); 
        }

        private void ButtonPlanYourGoals_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(PlanGoals));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateView()
        {
            labelNickname.Text = Configuration.LoggedUser.Login;
        }
    }
}