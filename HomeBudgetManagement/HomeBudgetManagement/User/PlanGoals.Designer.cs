namespace HomeBudgetManagement.User
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(238, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plan Your Goals";
            // 
            // ButtonBackToUserMenu
            // 
            this.ButtonBackToUserMenu.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackToUserMenu.Name = "ButtonBackToUserMenu";
            this.ButtonBackToUserMenu.Size = new System.Drawing.Size(119, 30);
            this.ButtonBackToUserMenu.TabIndex = 17;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = true;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // buttonCreateGoal
            // 
            this.buttonCreateGoal.Location = new System.Drawing.Point(89, 176);
            this.buttonCreateGoal.Name = "buttonCreateGoal";
            this.buttonCreateGoal.Size = new System.Drawing.Size(178, 55);
            this.buttonCreateGoal.TabIndex = 18;
            this.buttonCreateGoal.Text = "Create Goal";
            this.buttonCreateGoal.UseVisualStyleBackColor = true;
            this.buttonCreateGoal.Click += new System.EventHandler(this.buttonCreateGoal_Click);
            // 
            // buttonModifyGoal
            // 
            this.buttonModifyGoal.Location = new System.Drawing.Point(89, 260);
            this.buttonModifyGoal.Name = "buttonModifyGoal";
            this.buttonModifyGoal.Size = new System.Drawing.Size(178, 55);
            this.buttonModifyGoal.TabIndex = 20;
            this.buttonModifyGoal.Text = "Modify goal";
            this.buttonModifyGoal.UseVisualStyleBackColor = true;
            this.buttonModifyGoal.Click += new System.EventHandler(this.buttonModifyGoal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(400, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select goal to check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(401, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Goal name: ";
            // 
            // comboBoxSelectGoal
            // 
            this.comboBoxSelectGoal.FormattingEnabled = true;
            this.comboBoxSelectGoal.Location = new System.Drawing.Point(405, 189);
            this.comboBoxSelectGoal.Name = "comboBoxSelectGoal";
            this.comboBoxSelectGoal.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSelectGoal.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(401, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Goal amount: ";
            // 
            // buttonDeleteGoal
            // 
            this.buttonDeleteGoal.Location = new System.Drawing.Point(405, 286);
            this.buttonDeleteGoal.Name = "buttonDeleteGoal";
            this.buttonDeleteGoal.Size = new System.Drawing.Size(111, 35);
            this.buttonDeleteGoal.TabIndex = 25;
            this.buttonDeleteGoal.Text = "Delete Goal";
            this.buttonDeleteGoal.UseVisualStyleBackColor = true;
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoalName.Location = new System.Drawing.Point(519, 219);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(108, 24);
            this.labelGoalName.TabIndex = 26;
            this.labelGoalName.Text = "XXXXXXX";
            // 
            // labelGoalAmount
            // 
            this.labelGoalAmount.AutoSize = true;
            this.labelGoalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoalAmount.Location = new System.Drawing.Point(519, 249);
            this.labelGoalAmount.Name = "labelGoalAmount";
            this.labelGoalAmount.Size = new System.Drawing.Size(108, 24);
            this.labelGoalAmount.TabIndex = 27;
            this.labelGoalAmount.Text = "XXXXXXX";
            // 
            // PlanGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
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
            this.Controls.Add(this.label1);
            this.Name = "PlanGoals";
            this.Text = "PlanGoals";
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
    }
}