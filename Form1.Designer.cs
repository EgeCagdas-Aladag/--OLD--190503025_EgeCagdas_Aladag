using System;

namespace Private_Musikschule_Verwaltungsanwendung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginPagePanel = new System.Windows.Forms.Panel();
            this.createUserButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.loginPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Roboto Cn", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(490, 86);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(205, 57);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // loginPagePanel
            // 
            this.loginPagePanel.Controls.Add(this.warningLabel);
            this.loginPagePanel.Controls.Add(this.createUserButton);
            this.loginPagePanel.Controls.Add(this.loginButton);
            this.loginPagePanel.Controls.Add(this.passwordField);
            this.loginPagePanel.Controls.Add(this.usernameField);
            this.loginPagePanel.Controls.Add(this.welcomeLabel);
            this.loginPagePanel.Location = new System.Drawing.Point(3, 3);
            this.loginPagePanel.Name = "loginPagePanel";
            this.loginPagePanel.Size = new System.Drawing.Size(1183, 758);
            this.loginPagePanel.TabIndex = 1;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(490, 437);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(205, 33);
            this.createUserButton.TabIndex = 4;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(490, 388);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(205, 43);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(490, 313);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(205, 23);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(490, 264);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(205, 23);
            this.usernameField.TabIndex = 1;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(439, 473);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(315, 15);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "Username and Password must be longer than 4 characters.";
            this.warningLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.loginPagePanel);
            this.Name = "Form1";
            this.Text = "Musikschule Verwaltungsanwendung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPagePanel.ResumeLayout(false);
            this.loginPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel loginPagePanel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warningLabel;
    }
}

