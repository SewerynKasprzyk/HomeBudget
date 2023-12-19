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
    public partial class ModifyGoals : Form
    {
        public ModifyGoals()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBackToPlanGoals_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(PlanGoals));
        }

        private void buttonSetChanges_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
