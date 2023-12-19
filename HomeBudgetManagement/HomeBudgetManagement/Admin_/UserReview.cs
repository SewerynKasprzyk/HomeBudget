using Background;
using Background.Budget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeBudgetManagement.Admin_
{
    public partial class UserReview : Form
    {
        public UserReview()
        {
            InitializeComponent();
            reload();
        }

        private void reload()
        {
            ComboBoxSelectUser.Items.Clear();
            foreach (Background.Account account in Background.AccountList.Accounts)
            {
                ComboBoxSelectUser.Items.Add(account);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(LabelBudget));
        }

        private void ComboBoxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSelectUser.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Account account = ComboBoxSelectUser.SelectedItem as Background.Account;
                BudgetManager manager = new BudgetManager();
                ComboBoxSelectUser.Text = account.ToString();

                LabelCategory1Budget.Text = manager.ShowUserDetails(account.AccountName);
            }
            reload();
        }
    }
}
