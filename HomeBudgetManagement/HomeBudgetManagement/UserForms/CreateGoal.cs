using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateGoal_Click(object sender, EventArgs e)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.AddGoal(textBoxGoalName.Text, textBoxBalanceGoal.Text);
            MessageBox.Show($"Goal successfully created", "Goal Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
