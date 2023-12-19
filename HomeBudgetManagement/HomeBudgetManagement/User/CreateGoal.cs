using Background.Budget;
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
    public partial class CreateGoal : Form
    {
        public CreateGoal()
        {
            InitializeComponent();
        }

        private void ButtonBackToPlanGoals_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(PlanGoals));
        }

        private void buttonCreateGoal_Click(object sender, EventArgs e)
        {
            GoalsList.AddToList(new Goal(GoalsList.Goals.Count + 1, textBoxGoalName.Text, float.Parse(textBoxBalanceGoal.Text)));
        }
    }
}
