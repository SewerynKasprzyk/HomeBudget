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

namespace HomeBudgetManagement.Admin_
{
    public partial class User_Account_Management : Form
    {
        public User_Account_Management()
        {
            InitializeComponent();
            ReinitCombo();
        }

        public void ReinitCombo()
        {
            listViewUser.Items.Clear();

            foreach (var user in UserList.Users)
            {

                listViewUser.Items.Add(user.Login);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager(listViewUser.SelectedItem.ToString());
            accountManager.Delete();

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();

            accountManager.addUser(textfieldCreate.Text, "!QAZ2wsx", "", "", 1, "12");
            ReinitCombo();
        }

        private void User_Account_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
