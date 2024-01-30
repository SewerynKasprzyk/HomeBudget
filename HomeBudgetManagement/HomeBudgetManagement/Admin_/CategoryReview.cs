using Database.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeBudgetManagement.Admin_
{
    public partial class CategoryReview : Form
    {
        Category categoryRetrieve;
        public CategoryReview()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetAll();

            int i = 1;

            foreach (Category category in categories)
            {
                Label lbl = new Label();
                lbl.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                lbl.Text = category.Name;
                lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)244))));
                lbl.AutoSize = true;
                lbl.Location = new Point(10, i * 30);
                lbl.Visible = true;
                lbl.MouseHover += new EventHandler((sender, e) => {
                    // Add your hover event code here
                    lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)244))));
                });
                lbl.MouseLeave += new EventHandler((sender, e) => {
                    // Add your lost hover event code here
                    lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)244))));
                });
                lbl.Click += new EventHandler((sender, e) => {
                    // Add your click event code here
                    CategoryRetriever((Category)lbl.Tag);
                });
                lbl.Tag = category; // Add the object to the label's Tag property
                panel2.Controls.Add(lbl);
                i++;

            }

            vScrollBar1.Value = panel2.VerticalScroll.Value;
            vScrollBar1.Minimum = panel2.VerticalScroll.Minimum;
            vScrollBar1.Maximum = panel2.VerticalScroll.Maximum;
            vScrollBar1.Scroll += vScrollBar1_Scroll;

            panel2.ControlAdded += panel2_ControlAdded;
            panel2.ControlRemoved += panel2_ControlRemoved;
            vScrollBar1.Enabled = true;
        }

        public void CategoryRetriever(Category category)
        {
            categoryRetrieve = category;
            label6.Text = category.Name;
            label7.Text = category.Limit.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(typeof(LabelBudget));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelCategorySelect_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void panel2_ControlAdded(object sender, ControlEventArgs e)
        {
           vScrollBar1.Minimum = panel2.VerticalScroll.Minimum;
        }

        private void panel2_ControlRemoved(object sender, ControlEventArgs e)
        {
           vScrollBar1.Minimum = panel2.VerticalScroll.Minimum;
        }

        private void CategoryReview_Load(object sender, EventArgs e)
        {

        }
    }
}
