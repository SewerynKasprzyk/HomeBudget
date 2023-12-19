using Background;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace HomeBudgetManagement.Admin_
{
    public partial class System_Configuration : Form
    {
        public System_Configuration()
        {
            InitializeComponent();
            reload();
        }

        private void reload()
        {
            comboBox1.Items.Clear();
            foreach (Background.Category category in Background.CategoryList.Categories)
            {
                comboBox1.Items.Add(category);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(Admin));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            else
            {
                Background.Category category = comboBox1.SelectedItem as Background.Category;

                foreach (Category cat in CategoryList.Categories)
                {
                    if(category.Name == cat.Name)
                    {
                        cat.Name = login.Text;
                        reload();
                        return;
                    }
                }
            }
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1 != null)
            {
                CategoryList.AddToList(new Category(textBox1.Text));
            }

            reload();
        }
    }
}
