using Model.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetManagement.UserForms
{
    public partial class Limit_Management : Form
    {
        public Limit_Management()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBackToUserMenu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Manage_Account_Balance));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSetLimit_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxSetLimit.Text == "" || !Validation.NumbersValue(textBoxSetLimit.Text))
                {
                    throw new Exception("Invalid limit");
                }
                MessageBox.Show("A new limit has been set", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //set limit code
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ButtonSetAccountLimit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxWholeAcc.Text == "" || !Validation.NumbersValue(textBoxWholeAcc.Text))
                {
                    throw new Exception("Invalid account limit");
                }
                //set whole account limit code
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
