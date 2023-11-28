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
    }
}
