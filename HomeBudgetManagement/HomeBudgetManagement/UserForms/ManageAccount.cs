using Database;
using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
using Model;
using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class ManageAccount : Form
    {

        public ManageAccount()
        {
            InitializeComponent();
        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_menu));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            //no logged user yet
            UserManager userManager = new UserManager();

            User user = userManager.FindUserByID(Configuration.LoggedUserID);
            userManager.ManageUser(user);
            //no textfield for confirm password
            //second textbox chnge to confirmpassword text box
            if (userManager.ChangePassword(TextBoxChangePassword.Text, TextBoxChangePassword.Text))
            {
                MessageBox.Show("Password changed successfully");
            }
            else
            {
                MessageBox.Show("Password change failed");
            }
        }
    }
}
