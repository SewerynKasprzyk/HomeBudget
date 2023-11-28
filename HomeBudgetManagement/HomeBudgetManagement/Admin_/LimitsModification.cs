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
        public LimitsModification()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wybór kategorii do nałożenia limitu
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kwota limitu
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(BudgetStateManagement));
        }
    }
}
