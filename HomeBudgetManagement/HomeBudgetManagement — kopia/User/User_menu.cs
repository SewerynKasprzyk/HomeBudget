﻿using HomeBudgetManagement.User;
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
    public partial class User_menu : Form
    {
        public User_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Finance_Raport)); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Expense_Management));
        }
    }
}
