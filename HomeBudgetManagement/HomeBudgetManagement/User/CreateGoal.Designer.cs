namespace HomeBudgetManagement.User
{
    partial class CreateGoal
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
            this.ButtonBackToPlanGoals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGoalName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBalanceGoal = new System.Windows.Forms.TextBox();
            this.buttonCreateGoal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plan Your Goals";
            // 
            // ButtonBackToPlanGoals
            // 
            this.ButtonBackToPlanGoals.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackToPlanGoals.Name = "ButtonBackToPlanGoals";
            this.ButtonBackToPlanGoals.Size = new System.Drawing.Size(119, 30);
            this.ButtonBackToPlanGoals.TabIndex = 18;
            this.ButtonBackToPlanGoals.Text = "Back";
            this.ButtonBackToPlanGoals.UseVisualStyleBackColor = true;
            this.ButtonBackToPlanGoals.Click += new System.EventHandler(this.ButtonBackToPlanGoals_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(250, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add name of the new goal ";
            // 
            // textBoxGoalName
            // 
            this.textBoxGoalName.Location = new System.Drawing.Point(275, 163);
            this.textBoxGoalName.Name = "textBoxGoalName";
            this.textBoxGoalName.Size = new System.Drawing.Size(209, 20);
            this.textBoxGoalName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(279, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Set a balance goal ";
            // 
            // textBoxBalanceGoal
            // 
            this.textBoxBalanceGoal.Location = new System.Drawing.Point(271, 239);
            this.textBoxBalanceGoal.Name = "textBoxBalanceGoal";
            this.textBoxBalanceGoal.Size = new System.Drawing.Size(209, 20);
            this.textBoxBalanceGoal.TabIndex = 22;
            // 
            // buttonCreateGoal
            // 
            this.buttonCreateGoal.Location = new System.Drawing.Point(328, 284);
            this.buttonCreateGoal.Name = "buttonCreateGoal";
            this.buttonCreateGoal.Size = new System.Drawing.Size(90, 34);
            this.buttonCreateGoal.TabIndex = 23;
            this.buttonCreateGoal.Text = "Create";
            this.buttonCreateGoal.UseVisualStyleBackColor = true;
            this.buttonCreateGoal.Click += new System.EventHandler(this.buttonCreateGoal_Click);
            // 
            // CreateGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateGoal);
            this.Controls.Add(this.textBoxBalanceGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGoalName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonBackToPlanGoals);
            this.Controls.Add(this.label1);
            this.Name = "CreateGoal";
            this.Text = "CreateGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBackToPlanGoals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGoalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBalanceGoal;
        private System.Windows.Forms.Button buttonCreateGoal;
    }
}