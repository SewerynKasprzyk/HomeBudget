using Background;
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

namespace HomeBudgetManagement.User
{
    public partial class PlanGoals : Form
    {
        public PlanGoals()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            comboBoxSelectGoal.Items.Clear();
            foreach (Background.Budget.Goal goal in Background.Budget.GoalsList.Goals)
            {
                comboBoxSelectGoal.Items.Add(goal);
            }

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

        private void comboBoxSelectGoal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectGoal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSelectGoal.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Budget.Goal goal = comboBoxSelectGoal.SelectedItem as Background.Budget.Goal;

                labelGoalLimit.Text = goal.Limit.ToString();
                labelGoalAmount.Text = goal.Value.ToString();
            }
            Reload();
        }
    }
}
