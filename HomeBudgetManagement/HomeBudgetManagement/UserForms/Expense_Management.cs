using Database.Entities;
using Model.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class Expense_Management : Form
    {
        private List<Category> categories;
        private List<Transaction> transactions;
        private TransactionManager transactionManager;
        private CategoryManager categoryManager;
        private BalanceManager balanceManager;
        private UserManager userManager;
        private User user;

        public Expense_Management()
        {
            InitializeComponent();
            transactionManager = new TransactionManager();
            categoryManager = new CategoryManager();
            balanceManager = new BalanceManager();
            userManager = new UserManager();
            user = userManager.GetLoggedUser();
            Reload();
        }

        public void Reload() 
        { 
            decimal expense = 0;
            label13.Text = balanceManager.GetBalance().Value.ToString();

            transactions = transactionManager.GetAll();
            categories = categoryManager.GetAll();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";

            comboBox2.DataSource = categories;
            comboBox2.DisplayMember = "Name";

            foreach (Transaction transaction in transactions)
            {
                    expense += transaction.Value;
            }

            label12.Text = expense.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_menu));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;

            Transaction transaction = new Transaction()
            {
                User = user,
                Category = category,
                Name = textBox1.Text,
                Value = Convert.ToDecimal(login.Text),
            };

            transactionManager.AddTransaction(transaction);

            //Reload();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal expense = 0;
            Category category = (Category)comboBox2.SelectedItem;

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Category.Id == category.Id)
                {
                    expense += transaction.Value;
                }
            }

            label5.Text = expense.ToString();
        }
    }
}
