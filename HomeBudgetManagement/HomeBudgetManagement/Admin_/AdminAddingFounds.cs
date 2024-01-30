using Database.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeBudgetManagement
{
    public partial class AdminAddingFounds : Form
    {
        private List<User> users;
        public AdminAddingFounds()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            UserManager userManager = new UserManager();
            users = userManager.GetAllUsers();
            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "Login";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //środki do dodania na konto
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista użytkowników dla którego chcemy dodać środki. Możliwość wyboru ogólnego stanu budżetu
            comboBox1.SelectedItem = users.FirstOrDefault();
            UserManager userManager = new UserManager();
            userManager.ManageUser((User)comboBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BalanceManager _balanceManager = new BalanceManager();
                _balanceManager.AddBalance(decimal.Parse(textBox1.Text));
                MessageBox.Show($"Amount successfully added", "Balance Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Amount must be a number", "Balance Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
