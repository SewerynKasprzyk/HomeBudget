namespace HomeBudgetManagement.UserForms
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
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSelectGoal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAddToValue = new System.Windows.Forms.TextBox();
            this.ButtonAddToGoal = new System.Windows.Forms.Button();
            this.LabelYourBalance = new System.Windows.Forms.Label();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.ButtonToCashOut = new System.Windows.Forms.Button();
            this.TextBoxValueToCashOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonBackToUserMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ProgressBarGoal = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelCurrentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Impact", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Goal Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(28, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select goal";
            // 
            // ComboBoxSelectGoal
            // 
            this.ComboBoxSelectGoal.Font = new System.Drawing.Font("Impact", 10F);
            this.ComboBoxSelectGoal.FormattingEnabled = true;
            this.ComboBoxSelectGoal.Location = new System.Drawing.Point(34, 218);
            this.ComboBoxSelectGoal.Name = "ComboBoxSelectGoal";
            this.ComboBoxSelectGoal.Size = new System.Drawing.Size(179, 25);
            this.ComboBoxSelectGoal.TabIndex = 4;
            this.ComboBoxSelectGoal.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectGoal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(28, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "The Amount to add";
            // 
            // TextBoxAddToValue
            // 
            this.TextBoxAddToValue.Font = new System.Drawing.Font("Impact", 10F);
            this.TextBoxAddToValue.Location = new System.Drawing.Point(34, 339);
            this.TextBoxAddToValue.Name = "TextBoxAddToValue";
            this.TextBoxAddToValue.Size = new System.Drawing.Size(178, 24);
            this.TextBoxAddToValue.TabIndex = 6;
            // 
            // ButtonAddToGoal
            // 
            this.ButtonAddToGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.ButtonAddToGoal.FlatAppearance.BorderSize = 0;
            this.ButtonAddToGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddToGoal.Font = new System.Drawing.Font("Impact", 12F);
            this.ButtonAddToGoal.ForeColor = System.Drawing.Color.White;
            this.ButtonAddToGoal.Location = new System.Drawing.Point(34, 369);
            this.ButtonAddToGoal.Name = "ButtonAddToGoal";
            this.ButtonAddToGoal.Size = new System.Drawing.Size(179, 50);
            this.ButtonAddToGoal.TabIndex = 7;
            this.ButtonAddToGoal.Text = "Add";
            this.ButtonAddToGoal.UseVisualStyleBackColor = false;
            this.ButtonAddToGoal.Click += new System.EventHandler(this.ButtonAddToGoal_Click);
            // 
            // LabelYourBalance
            // 
            this.LabelYourBalance.AutoSize = true;
            this.LabelYourBalance.Font = new System.Drawing.Font("Impact", 20F);
            this.LabelYourBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.LabelYourBalance.Location = new System.Drawing.Point(28, 133);
            this.LabelYourBalance.Name = "LabelYourBalance";
            this.LabelYourBalance.Size = new System.Drawing.Size(166, 34);
            this.LabelYourBalance.TabIndex = 8;
            this.LabelYourBalance.Text = "Your Balance:";
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Font = new System.Drawing.Font("Impact", 20F);
            this.LabelBalance.ForeColor = System.Drawing.Color.Green;
            this.LabelBalance.Location = new System.Drawing.Point(200, 133);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(78, 34);
            this.LabelBalance.TabIndex = 9;
            this.LabelBalance.Text = "XXXX$";
            // 
            // ButtonToCashOut
            // 
            this.ButtonToCashOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.ButtonToCashOut.FlatAppearance.BorderSize = 0;
            this.ButtonToCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToCashOut.Font = new System.Drawing.Font("Impact", 12F);
            this.ButtonToCashOut.ForeColor = System.Drawing.Color.White;
            this.ButtonToCashOut.Location = new System.Drawing.Point(286, 369);
            this.ButtonToCashOut.Name = "ButtonToCashOut";
            this.ButtonToCashOut.Size = new System.Drawing.Size(179, 50);
            this.ButtonToCashOut.TabIndex = 12;
            this.ButtonToCashOut.Text = "Cash out";
            this.ButtonToCashOut.UseVisualStyleBackColor = false;
            this.ButtonToCashOut.Click += new System.EventHandler(this.ButtonToCashOut_Click);
            // 
            // TextBoxValueToCashOut
            // 
            this.TextBoxValueToCashOut.Font = new System.Drawing.Font("Impact", 10F);
            this.TextBoxValueToCashOut.Location = new System.Drawing.Point(286, 339);
            this.TextBoxValueToCashOut.Name = "TextBoxValueToCashOut";
            this.TextBoxValueToCashOut.Size = new System.Drawing.Size(179, 24);
            this.TextBoxValueToCashOut.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(280, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "The Amount to cash out";
            // 
            // ButtonBackToUserMenu
            // 
            this.ButtonBackToUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.ButtonBackToUserMenu.FlatAppearance.BorderSize = 0;
            this.ButtonBackToUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackToUserMenu.Font = new System.Drawing.Font("Impact", 12F);
            this.ButtonBackToUserMenu.ForeColor = System.Drawing.Color.White;
            this.ButtonBackToUserMenu.Location = new System.Drawing.Point(685, 408);
            this.ButtonBackToUserMenu.Name = "ButtonBackToUserMenu";
            this.ButtonBackToUserMenu.Size = new System.Drawing.Size(103, 30);
            this.ButtonBackToUserMenu.TabIndex = 16;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = false;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 113);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.buttonClose.Location = new System.Drawing.Point(751, -1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 51;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ProgressBarGoal
            // 
            this.ProgressBarGoal.Location = new System.Drawing.Point(286, 220);
            this.ProgressBarGoal.Name = "ProgressBarGoal";
            this.ProgressBarGoal.Size = new System.Drawing.Size(203, 23);
            this.ProgressBarGoal.TabIndex = 52;
            this.ProgressBarGoal.Value = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(280, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 34);
            this.label2.TabIndex = 53;
            this.label2.Text = "Progess Toward End";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 16F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label7.Location = new System.Drawing.Point(281, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 27);
            this.label7.TabIndex = 54;
            this.label7.Text = "Current Value:";
            // 
            // LabelCurrentValue
            // 
            this.LabelCurrentValue.AutoSize = true;
            this.LabelCurrentValue.Font = new System.Drawing.Font("Impact", 16F);
            this.LabelCurrentValue.ForeColor = System.Drawing.Color.Green;
            this.LabelCurrentValue.Location = new System.Drawing.Point(428, 256);
            this.LabelCurrentValue.Name = "LabelCurrentValue";
            this.LabelCurrentValue.Size = new System.Drawing.Size(68, 27);
            this.LabelCurrentValue.TabIndex = 55;
            this.LabelCurrentValue.Text = "XXXX$";
            // 
            // FinancialGoalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelCurrentValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgressBarGoal);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Controls.Add(this.ButtonToCashOut);
            this.Controls.Add(this.TextBoxValueToCashOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.LabelYourBalance);
            this.Controls.Add(this.ButtonAddToGoal);
            this.Controls.Add(this.TextBoxAddToValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxSelectGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinancialGoalManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialGoalManagement";
            this.Load += new System.EventHandler(this.FinancialGoalManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxSelectGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxAddToValue;
        private System.Windows.Forms.Button ButtonAddToGoal;
        private System.Windows.Forms.Label LabelYourBalance;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.Button ButtonToCashOut;
        private System.Windows.Forms.TextBox TextBoxValueToCashOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonBackToUserMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ProgressBar ProgressBarGoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelCurrentValue;
    }
}