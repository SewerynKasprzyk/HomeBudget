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
            reload();
            
        }

        private void reload()
        {
            comboBox1.Items.Clear();
            foreach (Background.Account account in Background.AccountList.Accounts)
            {
                comboBox1.Items.Add(account);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Account account = comboBox1.SelectedItem as Background.Account;

                AccountManager accountManager = new AccountManager(account.AccountId);

                accountManager.Delete();

                reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager(Configuration.LoggedUser.Id);

            accountManager.addUser(login.Text, "1qaz@WSX", "NameDemo", "NameDemo", 1, login.Text);
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Account account = comboBox1.SelectedItem as Background.Account;

                AccountManager accountManager = new AccountManager(account.AccountId);
                accountManager.GivePower();
            }
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Account account = comboBox1.SelectedItem as Background.Account;

                AccountManager accountManager = new AccountManager(account.AccountId);
                accountManager.RemovePower();
            }
            reload();
        }
    }
}
