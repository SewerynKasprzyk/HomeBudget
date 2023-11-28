namespace HomeBudgetManagement.User
{
    partial class Manage_Account_Balance
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
            this.ButtonLimitsManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonFinancialGoal = new System.Windows.Forms.Button();
            this.LabelCurrentBalance = new System.Windows.Forms.Label();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.TextBoxAddBalance = new System.Windows.Forms.TextBox();
            this.LabelAddToBalance = new System.Windows.Forms.Label();
            this.ButtonAddToBalance = new System.Windows.Forms.Button();
            this.ButtonBackToUserMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLimitsManagement
            // 
            this.ButtonLimitsManagement.Location = new System.Drawing.Point(80, 137);
            this.ButtonLimitsManagement.Name = "ButtonLimitsManagement";
            this.ButtonLimitsManagement.Size = new System.Drawing.Size(208, 76);
            this.ButtonLimitsManagement.TabIndex = 0;
            this.ButtonLimitsManagement.Text = "Limit Management";
            this.ButtonLimitsManagement.UseVisualStyleBackColor = true;
            this.ButtonLimitsManagement.Click += new System.EventHandler(this.ButtonLimitsManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(146, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Balance Management";
            // 
            // ButtonFinancialGoal
            // 
            this.ButtonFinancialGoal.Location = new System.Drawing.Point(80, 232);
            this.ButtonFinancialGoal.Name = "ButtonFinancialGoal";
            this.ButtonFinancialGoal.Size = new System.Drawing.Size(208, 76);
            this.ButtonFinancialGoal.TabIndex = 8;
            this.ButtonFinancialGoal.Text = "Financial Goal Management";
            this.ButtonFinancialGoal.UseVisualStyleBackColor = true;
            this.ButtonFinancialGoal.Click += new System.EventHandler(this.Button_Click);
            // 
            // LabelCurrentBalance
            // 
            this.LabelCurrentBalance.AutoSize = true;
            this.LabelCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCurrentBalance.Location = new System.Drawing.Point(438, 118);
            this.LabelCurrentBalance.Name = "LabelCurrentBalance";
            this.LabelCurrentBalance.Size = new System.Drawing.Size(214, 29);
            this.LabelCurrentBalance.TabIndex = 9;
            this.LabelCurrentBalance.Text = "Current Balance: ";
            this.LabelCurrentBalance.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBalance.Location = new System.Drawing.Point(488, 157);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(99, 29);
            this.LabelBalance.TabIndex = 10;
            this.LabelBalance.Text = "XXXX$";
            // 
            // TextBoxAddBalance
            // 
            this.TextBoxAddBalance.Location = new System.Drawing.Point(417, 271);
            this.TextBoxAddBalance.Name = "TextBoxAddBalance";
            this.TextBoxAddBalance.Size = new System.Drawing.Size(244, 20);
            this.TextBoxAddBalance.TabIndex = 11;
            // 
            // LabelAddToBalance
            // 
            this.LabelAddToBalance.AutoSize = true;
            this.LabelAddToBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAddToBalance.Location = new System.Drawing.Point(438, 232);
            this.LabelAddToBalance.Name = "LabelAddToBalance";
            this.LabelAddToBalance.Size = new System.Drawing.Size(194, 29);
            this.LabelAddToBalance.TabIndex = 12;
            this.LabelAddToBalance.Text = "Add to balance:";
            // 
            // ButtonAddToBalance
            // 
            this.ButtonAddToBalance.Location = new System.Drawing.Point(478, 311);
            this.ButtonAddToBalance.Name = "ButtonAddToBalance";
            this.ButtonAddToBalance.Size = new System.Drawing.Size(119, 30);
            this.ButtonAddToBalance.TabIndex = 13;
            this.ButtonAddToBalance.Text = "Add";
            this.ButtonAddToBalance.UseVisualStyleBackColor = true;
            // 
            // ButtonBackToUserMenu
            // 
            this.ButtonBackToUserMenu.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackToUserMenu.Name = "ButtonBackToUserMenu";
            this.ButtonBackToUserMenu.Size = new System.Drawing.Size(119, 30);
            this.ButtonBackToUserMenu.TabIndex = 14;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = true;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // Manage_Account_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Controls.Add(this.ButtonAddToBalance);
            this.Controls.Add(this.LabelAddToBalance);
            this.Controls.Add(this.TextBoxAddBalance);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.LabelCurrentBalance);
            this.Controls.Add(this.ButtonFinancialGoal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonLimitsManagement);
            this.Name = "Manage_Account_Balance";
            this.Text = "Manage_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLimitsManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonFinancialGoal;
        private System.Windows.Forms.Label LabelCurrentBalance;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.TextBox TextBoxAddBalance;
        private System.Windows.Forms.Label LabelAddToBalance;
        private System.Windows.Forms.Button ButtonAddToBalance;
        private System.Windows.Forms.Button ButtonBackToUserMenu;
    }
}