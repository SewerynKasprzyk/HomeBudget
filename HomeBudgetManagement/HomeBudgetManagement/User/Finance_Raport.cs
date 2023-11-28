using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.User
{
    public partial class Finance_Raport : Form
    {
        public Finance_Raport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formuła zapisania do pliku PDF
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_menu user_menu = new User_menu();
            user_menu.Show();
        }

        private void BudgetStateManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
