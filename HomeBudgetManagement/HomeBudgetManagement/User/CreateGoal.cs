using Background;
using Background.Manager;
using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
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
