using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.Admin_
{
    public partial class User_Account_Management : Form
    {
        public User_Account_Management()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }
    }
}
