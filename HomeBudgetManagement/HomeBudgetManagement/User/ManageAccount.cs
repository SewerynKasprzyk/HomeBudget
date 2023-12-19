using Background;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.User
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

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager(Configuration.LoggedUser.Id);
            accountManager.ChangePassword(TextBoxChangePassword.Text);
        }
    }
}
