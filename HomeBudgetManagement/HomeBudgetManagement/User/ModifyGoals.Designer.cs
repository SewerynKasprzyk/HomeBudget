namespace HomeBudgetManagement.User
{
    partial class ModifyGoals
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
            this.ButtonBackToPlanGoals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectGoal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelGoalAmount = new System.Windows.Forms.Label();
            this.textBoxNameGoal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBalanceGoal = new System.Windows.Forms.TextBox();
            this.buttonSetChanges = new System.Windows.Forms.Button();
            this.buttonChangeBalance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBackToPlanGoals
            // 
            this.ButtonBackToPlanGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.ButtonBackToPlanGoals.FlatAppearance.BorderSize = 0;
            this.ButtonBackToPlanGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackToPlanGoals.Font = new System.Drawing.Font("Impact", 12F);
            this.ButtonBackToPlanGoals.ForeColor = System.Drawing.Color.White;
            this.ButtonBackToPlanGoals.Location = new System.Drawing.Point(685, 408);
            this.ButtonBackToPlanGoals.Name = "ButtonBackToPlanGoals";
            this.ButtonBackToPlanGoals.Size = new System.Drawing.Size(103, 30);
            this.ButtonBackToPlanGoals.TabIndex = 19;
            this.ButtonBackToPlanGoals.Text = "Back";
            this.ButtonBackToPlanGoals.UseVisualStyleBackColor = false;
            this.ButtonBackToPlanGoals.Click += new System.EventHandler(this.ButtonBackToPlanGoals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Impact", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 53);
            this.label1.TabIndex = 20;
            this.label1.Text = "Modify Goals";
            // 
            // comboBoxSelectGoal
            // 
            this.comboBoxSelectGoal.Font = new System.Drawing.Font("Impact", 10F);
            this.comboBoxSelectGoal.FormattingEnabled = true;
            this.comboBoxSelectGoal.Location = new System.Drawing.Point(105, 177);
            this.comboBoxSelectGoal.Name = "comboBoxSelectGoal";
            this.comboBoxSelectGoal.Size = new System.Drawing.Size(202, 25);
            this.comboBoxSelectGoal.TabIndex = 30;
            this.comboBoxSelectGoal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGoal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(100, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Select goal to check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(120, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Goal name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(100, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Goal amount: ";
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Impact", 18F);
            this.labelGoalName.ForeColor = System.Drawing.Color.Green;
            this.labelGoalName.Location = new System.Drawing.Point(252, 245);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(97, 29);
            this.labelGoalName.TabIndex = 33;
            this.labelGoalName.Text = "XXXXXXX";
            // 
            // labelGoalAmount
            // 
            this.labelGoalAmount.AutoSize = true;
            this.labelGoalAmount.Font = new System.Drawing.Font("Impact", 18F);
            this.labelGoalAmount.ForeColor = System.Drawing.Color.Green;
            this.labelGoalAmount.Location = new System.Drawing.Point(252, 274);
            this.labelGoalAmount.Name = "labelGoalAmount";
            this.labelGoalAmount.Size = new System.Drawing.Size(97, 29);
            this.labelGoalAmount.TabIndex = 34;
            this.labelGoalAmount.Text = "XXXXXXX";
            // 
            // textBoxNameGoal
            // 
            this.textBoxNameGoal.Font = new System.Drawing.Font("Impact", 10F);
            this.textBoxNameGoal.Location = new System.Drawing.Point(403, 177);
            this.textBoxNameGoal.Name = "textBoxNameGoal";
            this.textBoxNameGoal.Size = new System.Drawing.Size(196, 24);
            this.textBoxNameGoal.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(398, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Change name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(398, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Change balance goal ";
            // 
            // textBoxBalanceGoal
            // 
            this.textBoxBalanceGoal.Font = new System.Drawing.Font("Impact", 10F);
            this.textBoxBalanceGoal.Location = new System.Drawing.Point(403, 282);
            this.textBoxBalanceGoal.Name = "textBoxBalanceGoal";
            this.textBoxBalanceGoal.Size = new System.Drawing.Size(196, 24);
            this.textBoxBalanceGoal.TabIndex = 37;
            // 
            // buttonSetChanges
            // 
            this.buttonSetChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonSetChanges.FlatAppearance.BorderSize = 0;
            this.buttonSetChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetChanges.Font = new System.Drawing.Font("Impact", 12F);
            this.buttonSetChanges.ForeColor = System.Drawing.Color.White;
            this.buttonSetChanges.Location = new System.Drawing.Point(403, 207);
            this.buttonSetChanges.Name = "buttonSetChanges";
            this.buttonSetChanges.Size = new System.Drawing.Size(107, 37);
            this.buttonSetChanges.TabIndex = 39;
            this.buttonSetChanges.Text = "Change";
            this.buttonSetChanges.UseVisualStyleBackColor = false;
            this.buttonSetChanges.Click += new System.EventHandler(this.buttonSetChanges_Click);
            // 
            // buttonChangeBalance
            // 
            this.buttonChangeBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.buttonChangeBalance.FlatAppearance.BorderSize = 0;
            this.buttonChangeBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeBalance.Font = new System.Drawing.Font("Impact", 12F);
            this.buttonChangeBalance.ForeColor = System.Drawing.Color.White;
            this.buttonChangeBalance.Location = new System.Drawing.Point(403, 312);
            this.buttonChangeBalance.Name = "buttonChangeBalance";
            this.buttonChangeBalance.Size = new System.Drawing.Size(107, 37);
            this.buttonChangeBalance.TabIndex = 40;
            this.buttonChangeBalance.Text = "Change";
            this.buttonChangeBalance.UseVisualStyleBackColor = false;
            this.buttonChangeBalance.Click += new System.EventHandler(this.buttonChangeBalance_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 113);
            this.panel1.TabIndex = 41;
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
            // ModifyGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeBalance);
            this.Controls.Add(this.buttonSetChanges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBalanceGoal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameGoal);
            this.Controls.Add(this.labelGoalAmount);
            this.Controls.Add(this.labelGoalName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelectGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonBackToPlanGoals);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyGoals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyGoals";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackToPlanGoals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectGoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelGoalAmount;
        private System.Windows.Forms.TextBox textBoxNameGoal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBalanceGoal;
        private System.Windows.Forms.Button buttonSetChanges;
        private System.Windows.Forms.Button buttonChangeBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
    }
}