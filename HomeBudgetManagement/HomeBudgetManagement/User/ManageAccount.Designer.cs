namespace HomeBudgetManagement.User
{
    partial class ManageAccount
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
            this.ButtonBackToUserMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxChangePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBackToUserMenu
            // 
            this.ButtonBackToUserMenu.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackToUserMenu.Name = "ButtonBackToUserMenu";
            this.ButtonBackToUserMenu.Size = new System.Drawing.Size(119, 30);
            this.ButtonBackToUserMenu.TabIndex = 15;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = true;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(201, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Management";
            // 
            // TextBoxChangePassword
            // 
            this.TextBoxChangePassword.Location = new System.Drawing.Point(281, 202);
            this.TextBoxChangePassword.Name = "TextBoxChangePassword";
            this.TextBoxChangePassword.Size = new System.Drawing.Size(213, 20);
            this.TextBoxChangePassword.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(273, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Password";
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.Location = new System.Drawing.Point(350, 232);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangePassword.TabIndex = 19;
            this.ButtonChangePassword.Text = "Change";
            this.ButtonChangePassword.UseVisualStyleBackColor = true;
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Name = "ManageAccount";
            this.Text = "ManageAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackToUserMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonChangePassword;
    }
}