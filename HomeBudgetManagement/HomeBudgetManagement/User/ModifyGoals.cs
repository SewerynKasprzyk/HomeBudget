using Database.Entities;
using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.User
{
    public partial class ModifyGoals : Form
    {
        GoalManager _goalManager = new GoalManager();
        public ModifyGoals()
        {
            InitializeComponent();
            initializeGoalComboBox();
        }

        private void initializeGoalComboBox()
        {
            var goals = _goalManager.GetAllMyGoals();
            comboBoxSelectGoal.DataSource = goals;
            comboBoxSelectGoal.DisplayMember = "Name";
        }

        private void EditGoalName()
        {
            var selectedGoal = comboBoxSelectGoal.SelectedItem;
            var newName = textBoxNameGoal.Text;
            _goalManager.UpdateName((Goal)selectedGoal, newName);
            var goals = _goalManager.GetAllMyGoals();
            comboBoxSelectGoal.DataSource = goals;
            comboBoxSelectGoal.SelectedItem = selectedGoal;
            MessageBox.Show($"Name successfully changed", "Goal Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditGoalValue()
        {
            try {
                var selectedGoal = comboBoxSelectGoal.SelectedItem;
                var newAmount = decimal.Parse(textBoxBalanceGoal.Text);
                _goalManager.UpdateAmount((Goal)selectedGoal, newAmount);
                var goals = _goalManager.GetAllMyGoals();
                comboBoxSelectGoal.DataSource = goals;
                comboBoxSelectGoal.SelectedItem = selectedGoal;
                MessageBox.Show($"Amount successfully changed", "Goal Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Amount must be a number", "Goal Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonBackToPlanGoals_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(User_menu));
        }

        private void buttonSetChanges_Click(object sender, EventArgs e)
        {
            EditGoalName();
        }

        private void buttonChangeBalance_Click(object sender, EventArgs e)
        {
            EditGoalValue();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxSelectGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGoal = (Goal)comboBoxSelectGoal.SelectedItem;
            labelGoalName.Text = selectedGoal.Name;
            labelGoalAmount.Text = selectedGoal.Amount.ToString();
        }
    }
}
