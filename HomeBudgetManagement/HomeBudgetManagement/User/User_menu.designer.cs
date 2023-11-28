namespace HomeBudgetManagement
{
    partial class User_menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonAccountBalanceManagement = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonManageAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.ButtonPlanYourGoals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(114, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate financial raport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonAccountBalanceManagement
            // 
            this.ButtonAccountBalanceManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAccountBalanceManagement.Location = new System.Drawing.Point(114, 212);
            this.ButtonAccountBalanceManagement.Name = "ButtonAccountBalanceManagement";
            this.ButtonAccountBalanceManagement.Size = new System.Drawing.Size(179, 50);
            this.ButtonAccountBalanceManagement.TabIndex = 1;
            this.ButtonAccountBalanceManagement.Text = "Account balance management";
            this.ButtonAccountBalanceManagement.UseVisualStyleBackColor = true;
            this.ButtonAccountBalanceManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(114, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Expense management";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonManageAccount
            // 
            this.ButtonManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonManageAccount.Location = new System.Drawing.Point(114, 284);
            this.ButtonManageAccount.Name = "ButtonManageAccount";
            this.ButtonManageAccount.Size = new System.Drawing.Size(179, 50);
            this.ButtonManageAccount.TabIndex = 3;
            this.ButtonManageAccount.Text = "Manage your account";
            this.ButtonManageAccount.UseVisualStyleBackColor = true;
            this.ButtonManageAccount.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(412, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "<Name/Nickname>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(443, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expenses:   XXXX$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(443, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "    Income:   XXXX$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(362, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Upcomming bills:   XXXX$";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(454, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 69;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButtonPlanYourGoals
            // 
            this.ButtonPlanYourGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlanYourGoals.Location = new System.Drawing.Point(114, 357);
            this.ButtonPlanYourGoals.Name = "ButtonPlanYourGoals";
            this.ButtonPlanYourGoals.Size = new System.Drawing.Size(179, 50);
            this.ButtonPlanYourGoals.TabIndex = 10;
            this.ButtonPlanYourGoals.Text = "Plan your goals";
            this.ButtonPlanYourGoals.UseVisualStyleBackColor = true;
            this.ButtonPlanYourGoals.Click += new System.EventHandler(this.ButtonPlanYourGoals_Click);
            // 
            // User_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPlanYourGoals);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonManageAccount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonAccountBalanceManagement);
            this.Controls.Add(this.button1);
            this.Name = "User_menu";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonAccountBalanceManagement;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonManageAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ButtonPlanYourGoals;
    }
}

