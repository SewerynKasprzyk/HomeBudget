using Database;
using Database.Enums;
using HomeBudgetManagement.Model.ConfigurationContext;
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
        private UserService _userService;

        public First_Configuration()
        {
            _userService = new UserService(new HomeManagementDbContext());
            InitializeComponent();
        }

        private void textBoxSetAdminLogin_click(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(234, 243, 251);

            textBoxSetAdminLogin.BackColor = Color.White;
            panelSetAdminLogin.BackColor = Color.White;
            panelSetAdminPassword.BackColor = customColor;
            textBoxSetAdminPassword.BackColor = customColor;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(Configuration.FirstConfiguration(textBoxSetAdminLogin.Text, "", "", textBoxSetAdminPassword.Text, textBoxSetAdminPassword.Text) == true)
            {
                Program.ChangeForm(typeof(Admin));
            }
        }
    }
}
