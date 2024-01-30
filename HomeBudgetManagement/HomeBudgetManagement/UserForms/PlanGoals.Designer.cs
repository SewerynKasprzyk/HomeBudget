namespace HomeBudgetManagement.UserForms
{
    partial class PlanGoals
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
            this.ButtonBackToUserMenu = new System.Windows.Forms.Button();
            this.buttonCreateGoal = new System.Windows.Forms.Button();
            this.buttonModifyGoal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectGoal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteGoal = new System.Windows.Forms.Button();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelGoalAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plan Your Goals";
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
            this.ButtonBackToUserMenu.TabIndex = 17;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = false;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // buttonCreateGoal
            // 
            this.buttonCreateGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonCreateGoal.FlatAppearance.BorderSize = 0;
            this.buttonCreateGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateGoal.Font = new System.Drawing.Font("Impact", 12F);
            this.buttonCreateGoal.ForeColor = System.Drawing.Color.White;
            this.buttonCreateGoal.Location = new System.Drawing.Point(89, 176);
            this.buttonCreateGoal.Name = "buttonCreateGoal";
            this.buttonCreateGoal.Size = new System.Drawing.Size(180, 65);
            this.buttonCreateGoal.TabIndex = 18;
            this.buttonCreateGoal.Text = "Create Goal";
            this.buttonCreateGoal.UseVisualStyleBackColor = false;
            this.buttonCreateGoal.Click += new System.EventHandler(this.buttonCreateGoal_Click);
            // 
            // buttonModifyGoal
            // 
            this.buttonModifyGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonModifyGoal.FlatAppearance.BorderSize = 0;
            this.buttonModifyGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyGoal.Font = new System.Drawing.Font("Impact", 12F);
            this.buttonModifyGoal.ForeColor = System.Drawing.Color.White;
            this.buttonModifyGoal.Location = new System.Drawing.Point(89, 260);
            this.buttonModifyGoal.Name = "buttonModifyGoal";
            this.buttonModifyGoal.Size = new System.Drawing.Size(180, 65);
            this.buttonModifyGoal.TabIndex = 20;
            this.buttonModifyGoal.Text = "Modify goal";
            this.buttonModifyGoal.UseVisualStyleBackColor = false;
            this.buttonModifyGoal.Click += new System.EventHandler(this.buttonModifyGoal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(399, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select goal to check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(401, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Goal name: ";
            // 
            // comboBoxSelectGoal
            // 
            this.comboBoxSelectGoal.Font = new System.Drawing.Font("Impact", 10F);
            this.comboBoxSelectGoal.FormattingEnabled = true;
            this.comboBoxSelectGoal.Location = new System.Drawing.Point(405, 189);
            this.comboBoxSelectGoal.Name = "comboBoxSelectGoal";
            this.comboBoxSelectGoal.Size = new System.Drawing.Size(202, 25);
            this.comboBoxSelectGoal.TabIndex = 23;
            this.comboBoxSelectGoal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGoal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(401, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Goal amount: ";
            // 
            // buttonDeleteGoal
            // 
            this.buttonDeleteGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonDeleteGoal.FlatAppearance.BorderSize = 0;
            this.buttonDeleteGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGoal.Font = new System.Drawing.Font("Impact", 12F);
            this.buttonDeleteGoal.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGoal.Location = new System.Drawing.Point(405, 286);
            this.buttonDeleteGoal.Name = "buttonDeleteGoal";
            this.buttonDeleteGoal.Size = new System.Drawing.Size(111, 35);
            this.buttonDeleteGoal.TabIndex = 25;
            this.buttonDeleteGoal.Text = "Delete Goal";
            this.buttonDeleteGoal.UseVisualStyleBackColor = false;
            this.buttonDeleteGoal.Click += new System.EventHandler(this.buttonDeleteGoal_Click);
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Impact", 18F);
            this.labelGoalName.ForeColor = System.Drawing.Color.Green;
            this.labelGoalName.Location = new System.Drawing.Point(552, 219);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(97, 29);
            this.labelGoalName.TabIndex = 26;
            this.labelGoalName.Text = "XXXXXXX";
            // 
            // labelGoalAmount
            // 
            this.labelGoalAmount.AutoSize = true;
            this.labelGoalAmount.Font = new System.Drawing.Font("Impact", 18F);
            this.labelGoalAmount.ForeColor = System.Drawing.Color.Green;
            this.labelGoalAmount.Location = new System.Drawing.Point(552, 248);
            this.labelGoalAmount.Name = "labelGoalAmount";
            this.labelGoalAmount.Size = new System.Drawing.Size(97, 29);
            this.labelGoalAmount.TabIndex = 27;
            this.labelGoalAmount.Text = "XXXXXXX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 113);
            this.panel1.TabIndex = 28;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.buttonClose.Location = new System.Drawing.Point(751, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 53;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PlanGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoalAmount);
            this.Controls.Add(this.labelGoalName);
            this.Controls.Add(this.buttonDeleteGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelectGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonModifyGoal);
            this.Controls.Add(this.buttonCreateGoal);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanGoals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanGoals";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBackToUserMenu;
        private System.Windows.Forms.Button buttonCreateGoal;
        private System.Windows.Forms.Button buttonModifyGoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteGoal;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelGoalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
    }
}