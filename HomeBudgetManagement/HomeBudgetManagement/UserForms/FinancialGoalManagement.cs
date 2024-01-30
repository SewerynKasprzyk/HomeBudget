using Database.Entities;
using Model.Manager;
using System;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class FinancialGoalManagement : Form
    {
        GoalManager _goalManager = new GoalManager();
        BalanceManager _balanceManager = new BalanceManager();
        public FinancialGoalManagement()
        {
            InitializeComponent();
            InitializeGoalComboBox();
        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Manage_Account_Balance));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinancialGoalManagement_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxSelectGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGoal = (Goal)ComboBoxSelectGoal.SelectedItem;
            LabelCurrentValue.Text = selectedGoal.CurrentAmount.ToString();
            LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
            ProgressBarGoal.Maximum = (int)(selectedGoal.Amount);
            ProgressBarGoal.Value = (int)(selectedGoal.CurrentAmount);
        }

        private void InitializeGoalComboBox()
        {
            var goals = _goalManager.GetAllMyGoals();
            ComboBoxSelectGoal.DataSource = goals;
            ComboBoxSelectGoal.DisplayMember = "Name";
            LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
            ProgressBarGoal.Value = 0;
        }

        private void ButtonAddToGoal_Click(object sender, EventArgs e)
        {
            var selectedGoal = ComboBoxSelectGoal.SelectedItem;
            ProgressBarGoal.Value = (int)(((Goal)selectedGoal).CurrentAmount);
            var newAmount = decimal.Parse(TextBoxAddToValue.Text);
            //var amountToFillBar = ((Goal)selectedGoal).Amount - newAmount;

            if(((((Goal)selectedGoal).CurrentAmount) + newAmount) > ((Goal)selectedGoal).Amount)
            {
                decimal x = ((Goal)selectedGoal).CurrentAmount + newAmount;
                decimal y = Math.Abs(((Goal)selectedGoal).Amount - x);
                _balanceManager.SubBalance(newAmount);
                _balanceManager.AddBalance(y);
                _goalManager.AddToGoal((Goal)selectedGoal, ((Goal)selectedGoal).Amount - ((Goal)selectedGoal).CurrentAmount);
            }
            else 
            {
                _balanceManager.SubBalance(newAmount);
                //_balanceManager.AddBalance(newAmount);
                _goalManager.AddToGoal((Goal)selectedGoal, newAmount);
            }

            Reload();
            MessageBox.Show($"Amount successfully changed", "Goal Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_goalManager.UpdateCurrentAmount((Goal)selectedGoal, newAmount);
            
        }

        public void Reload()
        {
            var goals = _goalManager.GetAllMyGoals();
            ComboBoxSelectGoal.DataSource = goals;
            ComboBoxSelectGoal.DisplayMember = "Name";
            LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
            ProgressBarGoal.Value = 0;

            var selectedGoal = (Goal)ComboBoxSelectGoal.SelectedItem;
            LabelCurrentValue.Text = selectedGoal.CurrentAmount.ToString();
            LabelBalance.Text = _balanceManager.GetBalance().Value.ToString();
            ProgressBarGoal.Maximum = (int)(selectedGoal.Amount);
            ProgressBarGoal.Value = (int)(selectedGoal.CurrentAmount);
        }
    }
}
