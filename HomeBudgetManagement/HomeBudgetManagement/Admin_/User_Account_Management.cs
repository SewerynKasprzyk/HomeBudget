using Database.Entities;
using Database.Enums;
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
        private List<User> users;
        public User_Account_Management()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            UserManager userManager = new UserManager();
            users = userManager.GetAllUsers();
            comboBox2.DataSource = users;
            comboBox2.DisplayMember = "Name";
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
            UserManager userManager = new UserManager();
            userManager.AddUser(new User { Login = login.Text, Password = "1qaz@WSX", Role = Role.User});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = users.FirstOrDefault();
            UserManager userManager = new UserManager();
            userManager.ManageUser((User)comboBox2.SelectedItem);
            //userManager.GiveAccess(();
        }
    }
}
