﻿using Database.Entities;
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

namespace HomeBudgetManagement.Admin_
{
    public partial class System_Configuration : Form
    {
        private List<Category> categories;
        public System_Configuration()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = categories.FirstOrDefault();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.ManageCategory((Category)comboBox1.SelectedItem);
            categoryManager.ChangeName(login.Text);
            Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.AddCategory(new Category { Name = textBox1.Text, Limit = 1000 });
            Reload();
        }
    }
}
