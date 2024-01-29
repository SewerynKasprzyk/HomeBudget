using Background;
using Database;
using HomeBudgetManagement.Model.ConfigurationContext;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.User
{
    public partial class ManageAccount : Form
    {
        private UserService _userService;

        public ManageAccount()
        {
            _userService= new UserService(new HomeManagementDbContext());
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
            UserManager userManager = new UserManager(Configuration.LoggedUser);
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
