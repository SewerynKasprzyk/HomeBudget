using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
using Model;
using Model.Manager;
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
    public partial class User_Account_Management : Form
    {
        UserService userService;
        public User_Account_Management()
        {
            InitializeComponent();
            InitCombobox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Validation messages
            if(textLogin.Text.Length > 3) 
            {
                UserManager userManager = new UserManager();
                userManager.AddUser(textLogin.Text);
                MessageBox.Show("New user created");
                textLogin.Text = string.Empty;
                
            }
            else
            {
                MessageBox.Show("Invalid new user name");
            }

            InitCombobox();
        }

        private void comboboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void InitCombobox()
        {
            comboboxUsers.Items.Clear();
            foreach (var user in userService.GetAllUsers())
            {
                comboboxUsers.Items.Add(user.Login);
            }
        
        
        }
    }
}
