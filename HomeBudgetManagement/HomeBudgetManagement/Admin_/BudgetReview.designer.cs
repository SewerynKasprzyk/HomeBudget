namespace HomeBudgetManagement
{
    partial class LabelBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonCategoryReview = new System.Windows.Forms.Button();
            this.ButtonUserBudgetReview = new System.Windows.Forms.Button();
            this.LabelBudgetReview = new System.Windows.Forms.Label();
            this.LabelOverallBudget = new System.Windows.Forms.Label();
            this.LabelAllBudget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(103, 30);
            this.ButtonBack.TabIndex = 22;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButtonCategoryReview
            // 
            this.ButtonCategoryReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCategoryReview.Location = new System.Drawing.Point(153, 150);
            this.ButtonCategoryReview.Name = "ButtonCategoryReview";
            this.ButtonCategoryReview.Size = new System.Drawing.Size(209, 90);
            this.ButtonCategoryReview.TabIndex = 23;
            this.ButtonCategoryReview.Text = "Category Review";
            this.ButtonCategoryReview.UseVisualStyleBackColor = true;
            this.ButtonCategoryReview.Click += new System.EventHandler(this.ButtonCategoryReview_Click);
            // 
            // ButtonUserBudgetReview
            // 
            this.ButtonUserBudgetReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonUserBudgetReview.Location = new System.Drawing.Point(428, 150);
            this.ButtonUserBudgetReview.Name = "ButtonUserBudgetReview";
            this.ButtonUserBudgetReview.Size = new System.Drawing.Size(209, 90);
            this.ButtonUserBudgetReview.TabIndex = 24;
            this.ButtonUserBudgetReview.Text = "User Review";
            this.ButtonUserBudgetReview.UseVisualStyleBackColor = true;
            this.ButtonUserBudgetReview.Click += new System.EventHandler(this.ButtonUserBudgetReview_Click);
            // 
            // LabelBudgetReview
            // 
            this.LabelBudgetReview.AutoSize = true;
            this.LabelBudgetReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBudgetReview.Location = new System.Drawing.Point(256, 62);
            this.LabelBudgetReview.Name = "LabelBudgetReview";
            this.LabelBudgetReview.Size = new System.Drawing.Size(287, 46);
            this.LabelBudgetReview.TabIndex = 25;
            this.LabelBudgetReview.Text = "Budget Review";
            this.LabelBudgetReview.Click += new System.EventHandler(this.LabelBudgetReview_Click);
            // 
            // LabelOverallBudget
            // 
            this.LabelOverallBudget.AutoSize = true;
            this.LabelOverallBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelOverallBudget.Location = new System.Drawing.Point(284, 291);
            this.LabelOverallBudget.Name = "LabelOverallBudget";
            this.LabelOverallBudget.Size = new System.Drawing.Size(227, 37);
            this.LabelOverallBudget.TabIndex = 26;
            this.LabelOverallBudget.Text = "Overall Budget";
            // 
            // LabelAllBudget
            // 
            this.LabelAllBudget.AutoSize = true;
            this.LabelAllBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAllBudget.Location = new System.Drawing.Point(344, 340);
            this.LabelAllBudget.Name = "LabelAllBudget";
            this.LabelAllBudget.Size = new System.Drawing.Size(101, 31);
            this.LabelAllBudget.TabIndex = 27;
            this.LabelAllBudget.Text = "XXXX$";
            // 
            // LabelBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelAllBudget);
            this.Controls.Add(this.LabelOverallBudget);
            this.Controls.Add(this.LabelBudgetReview);
            this.Controls.Add(this.ButtonUserBudgetReview);
            this.Controls.Add(this.ButtonCategoryReview);
            this.Controls.Add(this.ButtonBack);
            this.Name = "LabelBudget";
            this.Text = "BudgetReview";
            this.Load += new System.EventHandler(this.LabelBudget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonCategoryReview;
        private System.Windows.Forms.Button ButtonUserBudgetReview;
        private System.Windows.Forms.Label LabelBudgetReview;
        private System.Windows.Forms.Label LabelOverallBudget;
        private System.Windows.Forms.Label LabelAllBudget;
    }
}