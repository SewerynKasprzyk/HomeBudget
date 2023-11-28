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
    public partial class AdminAddingFounds : Form
    {
        public AdminAddingFounds()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //środki do dodania na konto
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista użytkowników dla którego chcemy dodać środki. Możliwość wyboru ogólnego stanu budżetu
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }
    }
}
