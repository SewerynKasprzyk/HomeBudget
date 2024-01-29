using Background.Manager;
using Database.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HomeBudgetManagement.User
{
    public partial class PlanGoals : Form
    {
        GoalManager _goalManager = new GoalManager();
        public PlanGoals()
        {
            InitializeComponent();
            InitializeGoalComboBox();
        }
        private void InitializeGoalComboBox()
        {
            var goals = _goalManager.GetAllMyGoals();
            comboBoxSelectGoal.DataSource = goals;
            comboBoxSelectGoal.DisplayMember = "Name";
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeleteGoal_Click(object sender, EventArgs e)
        {
            var selectedGoal = (Goal)comboBoxSelectGoal.SelectedItem;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedGoal.Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _goalManager.DeleteGoal(selectedGoal);
                var goals = _goalManager.GetAllMyGoals();
                comboBoxSelectGoal.DataSource = goals;
                var firstGoal = goals.FirstOrDefault();
                if (firstGoal == null)
                {
                    comboBoxSelectGoal.Text = "";
                    comboBoxSelectGoal.SelectedItem = null;
                    labelGoalAmount.Text = "";
                    labelGoalName.Text = "";
                }
                else
                {
                    comboBoxSelectGoal.SelectedItem = goals.FirstOrDefault();

                }
                MessageBox.Show($"Goal successfully deleted", "Goal Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxSelectGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGoal = (Goal)comboBoxSelectGoal.SelectedItem;
            labelGoalAmount.Text = selectedGoal.Amount.ToString();
            labelGoalName.Text = selectedGoal.Name;
        }
    }
}
