﻿namespace EfWinform
{
    partial class RegisterForm
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
            this.registrPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.checkValidEmail = new System.Windows.Forms.CheckBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrPanel
            // 
            this.registrPanel.Controls.Add(this.cancelBtn);
            this.registrPanel.Controls.Add(this.loginLabel);
            this.registrPanel.Controls.Add(this.createBtn);
            this.registrPanel.Controls.Add(this.checkValidEmail);
            this.registrPanel.Controls.Add(this.passwdLabel);
            this.registrPanel.Controls.Add(this.loginTextBox);
            this.registrPanel.Controls.Add(this.passwdTextBox);
            this.registrPanel.Controls.Add(this.emailTextBox);
            this.registrPanel.Controls.Add(this.emailLabel);
            this.registrPanel.Location = new System.Drawing.Point(6, 52);
            this.registrPanel.Name = "registrPanel";
            this.registrPanel.Size = new System.Drawing.Size(423, 202);
            this.registrPanel.TabIndex = 15;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(291, 164);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(18, 26);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Login";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(76, 164);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // checkValidEmail
            // 
            this.checkValidEmail.AutoSize = true;
            this.checkValidEmail.Location = new System.Drawing.Point(76, 130);
            this.checkValidEmail.Name = "checkValidEmail";
            this.checkValidEmail.Size = new System.Drawing.Size(82, 17);
            this.checkValidEmail.TabIndex = 11;
            this.checkValidEmail.Text = "IsValidEmail";
            this.checkValidEmail.UseVisualStyleBackColor = true;
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(17, 58);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(53, 13);
            this.passwdLabel.TabIndex = 8;
            this.passwdLabel.Text = "Password";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(76, 23);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(290, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(76, 55);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(290, 20);
            this.passwdTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(76, 89);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(290, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(18, 92);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registration";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrPanel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.registrPanel.ResumeLayout(false);
            this.registrPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel registrPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.CheckBox checkValidEmail;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label1;
    }
}