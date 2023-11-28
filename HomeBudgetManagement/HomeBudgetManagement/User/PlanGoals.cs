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
    public partial class PlanGoals : Form
    {
        public PlanGoals()
        {
            InitializeComponent();
        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_menu));
        }

        private void buttonCreateGoal_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(CreateGoal));
        }

        private void buttonModifyGoal_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(ModifyGoals));
        }
    }
}
