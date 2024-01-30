namespace HomeBudgetManagement.UserForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonBackToUserMenu.TabIndex = 15;
            this.ButtonBackToUserMenu.Text = "Back";
            this.ButtonBackToUserMenu.UseVisualStyleBackColor = false;
            this.ButtonBackToUserMenu.Click += new System.EventHandler(this.ButtonBackToUserMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 32F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 53);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Management";
            // 
            // TextBoxChangePassword
            // 
            this.TextBoxChangePassword.Font = new System.Drawing.Font("Impact", 10F);
            this.TextBoxChangePassword.Location = new System.Drawing.Point(282, 203);
            this.TextBoxChangePassword.Name = "TextBoxChangePassword";
            this.TextBoxChangePassword.Size = new System.Drawing.Size(244, 24);
            this.TextBoxChangePassword.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(275, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Password";
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.ButtonChangePassword.FlatAppearance.BorderSize = 0;
            this.ButtonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Impact", 12F);
            this.ButtonChangePassword.ForeColor = System.Drawing.Color.White;
            this.ButtonChangePassword.Location = new System.Drawing.Point(350, 243);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(107, 37);
            this.ButtonChangePassword.TabIndex = 19;
            this.ButtonChangePassword.Text = "Change";
            this.ButtonChangePassword.UseVisualStyleBackColor = false;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 113);
            this.panel1.TabIndex = 20;
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
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(218)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxChangePassword);
            this.Controls.Add(this.ButtonBackToUserMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackToUserMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
    }
}