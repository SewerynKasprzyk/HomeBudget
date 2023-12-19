using Background;
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
    public partial class FinancialGoalManagement : Form
    {
        public FinancialGoalManagement()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            ComboBoxSelectGoal.Items.Clear();
            foreach (Background.Budget.Goal goal in Background.Budget.GoalsList.Goals)
            {
                ComboBoxSelectGoal.Items.Add(goal);
            }

            //label5.Text = BudgetList.GetBudget(int.Parse(Configuration.LoggedUser.Id)).BudgetValue.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Manage_Account_Balance));
        }

        private void ButtonAddToGoal_Click(object sender, EventArgs e)
        {
            if (ComboBoxSelectGoal.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Budget.Goal goal = ComboBoxSelectGoal.SelectedItem as Background.Budget.Goal;
                goal.AddToValue(float.Parse(TextBoxAddToValue.Text));
            }
            Reload();
        }

        private void ButtonToCashOut_Click(object sender, EventArgs e)
        {
            if (ComboBoxSelectGoal.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Budget.Goal goal = ComboBoxSelectGoal.SelectedItem as Background.Budget.Goal;
                goal.SubFromValue(float.Parse(TextBoxValueToCashOut.Text));

            }
            Reload();
        }
    }
}
