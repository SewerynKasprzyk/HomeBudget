namespace HomeBudgetManagement.User
{
    partial class FinancialGoalManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSelectGoal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAddToValue = new System.Windows.Forms.TextBox();
            this.ButtonAddToGoal = new System.Windows.Forms.Button();
            this.LabelYourBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonToCashOut = new System.Windows.Forms.Button();
            this.TextBoxValueToCashOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonBackToUserMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Goal Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(270, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add balance to goal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(320, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select goal";
            // 
            // ComboBoxSelectGoal
            // 
            this.ComboBoxSelectGoal.FormattingEnabled = true;
            this.ComboBoxSelectGoal.Location = new System.Drawing.Point(304, 223);
            this.ComboBoxSelectGoal.Name = "ComboBoxSelectGoal";
            this.ComboBoxSelectGoal.Size = new System.Drawing.Size(153, 21);
            this.ComboBoxSelectGoal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(163, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Value to add";
            // 
            // TextBoxAddToValue
            // 
            this.TextBoxAddToValue.Location = new System.Drawing.Point(154, 319);
            this.TextBoxAddToValue.Name = "TextBoxAddToValue";
            this.TextBoxAddToValue.Size = new System.Drawing.Size(153, 20);
            this.TextBoxAddToValue.TabIndex = 6;
            // 
            // ButtonAddToGoal
            // 
            this.ButtonAddToGoal.Location = new System.Drawing.Point(191, 357);
            this.ButtonAddToGoal.Name = "ButtonAddToGoal";
            this.ButtonAddToGoal.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddToGoal.TabIndex = 7;
            this.ButtonAddToGoal.Text = "Add";
            this.ButtonAddToGoal.UseVisualStyleBackColor = true;
            this.ButtonAddToGoal.Click += new System.EventHandler(this.ButtonAddToGoal_Click);
            // 
            // LabelYourBalance
            // 
            this.LabelYourBalance.AutoSize = true;
            this.LabelYourBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelYourBalance.Location = new System.Drawing.Point(246, 100);
            this.LabelYourBalance.Name = "LabelYourBalance";
            this.LabelYourBalance.Size = new System.Drawing.Size(184, 31);
            this.LabelYourBalance.TabIndex = 8;
            this.LabelYourBalance.Text = "Your Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(424, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "XXXX$";
            // 
            // ButtonToCashOut
            // 
            this.ButtonToCashOut.Location = new System.Drawing.Point(475, 357);
            this.ButtonToCashOut.Name = "ButtonToCashOut";
            this.ButtonToCashOut.Size = new System.Drawing.Size(75, 23);
            this.ButtonToCashOut.TabIndex = 12;
            this.ButtonToCashOut.Text = "Cash out";
            this.ButtonToCashOut.UseVisualStyleBackColor = true;
            this.ButtonToCashOut.Click += new System.EventHandler(this.ButtonToCashOut_Click);
            // 
            // TextBoxValueToCashOut
            // 
            this.TextBoxValueToCashOut.Location = new System.Drawing.Point(437, 319);
            this.TextBoxValueToCashOut.Name = "TextBoxValueToCashOut";
            this.TextBoxValueToCashOut.Size = new System.Drawing.Size(153, 20);
            this.TextBoxValueToCashOut.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(424, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Value to cash out";
            // 
            // ButtonBackToUserMenu
            // 
            this.ButtonBackToUserMenu.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackToUserMenu.Name = "ButtonBackToUserMenu";
            this.ButtonBackToUserMenu.Size = new System.Drawing.Size(119, 30);
            this.ButtonBackToUserMenu.TabIndex = 16;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = true;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // FinancialGoalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Controls.Add(this.ButtonToCashOut);
            this.Controls.Add(this.TextBoxValueToCashOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelYourBalance);
            this.Controls.Add(this.ButtonAddToGoal);
            this.Controls.Add(this.TextBoxAddToValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxSelectGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinancialGoalManagement";
            this.Text = "FinancialGoalManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxSelectGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxAddToValue;
        private System.Windows.Forms.Button ButtonAddToGoal;
        private System.Windows.Forms.Label LabelYourBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonToCashOut;
        private System.Windows.Forms.TextBox TextBoxValueToCashOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonBackToUserMenu;
    }
}