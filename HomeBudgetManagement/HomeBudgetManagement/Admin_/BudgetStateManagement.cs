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
    public partial class BudgetStateManagement : Form
    {
        public BudgetStateManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modyfikacja limitów
            Program.ChangeForm(typeof(LimitsModification));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Przeglądanie budżetu
            Program.ChangeForm(typeof(LabelBudget));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dodawanie środków
            Program.ChangeForm(typeof(AdminAddingFounds));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
