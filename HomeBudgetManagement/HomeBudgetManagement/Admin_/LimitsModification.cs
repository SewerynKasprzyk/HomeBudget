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

namespace HomeBudgetManagement
{
    public partial class LimitsModification : Form
    {
        private List<Category> categories;
        public LimitsModification()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            CategoryManager categoryManager = new CategoryManager();
            categories = categoryManager.GetAll();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wybór kategorii do nałożenia limitu
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kwota limitu
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSetLimit_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSetLimit.Text == "" || !Validation.NumbersValue(textBoxSetLimit.Text))
                {
                    throw new Exception("Invalid set limit");
                }
                comboBox1.SelectedItem = categories.FirstOrDefault();
                CategoryManager categoryManager = new CategoryManager((Category)comboBox1.SelectedItem);
                categoryManager.ChangeLimit(decimal.Parse(textBoxSetLimit.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
