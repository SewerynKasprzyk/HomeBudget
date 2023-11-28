using HomeBudgetManagement.Admin_;
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
    public partial class LabelBudget : Form
    {
        public LabelBudget()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista użytkowników lub możliwość wyboru ogólnego stanu budżetu
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wybór kategorii wydatków lub wypisanie zsumowanych wydatków ze wszystkich kategorii
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //przycisk do wyświetlenia stanu budżetu dla podanej kategorii i użytkownika
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabela do wyświetlania wydatków dla danego użytkownika
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //wyświetlanie pozostałego salda na koncie danego użytkownika
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //wyświetlanie sumy wydatków danego uzytkownika na wybraną kategorię lub wszytskie kategorie
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }

        private void LabelBudgetReview_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonCategoryReview_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(CategoryReview));
        }

        private void ButtonUserBudgetReview_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(UserReview));
        }

        private void LabelBudget_Load(object sender, EventArgs e)
        {

        }
    }
}
