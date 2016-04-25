namespace EfWinform
{
    partial class LoginForm
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.radioUserAuth = new System.Windows.Forms.RadioButton();
            this.radioGuestAuth = new System.Windows.Forms.RadioButton();
            this.passwdTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.enterBtn);
            this.loginGroupBox.Controls.Add(this.radioUserAuth);
            this.loginGroupBox.Controls.Add(this.radioGuestAuth);
            this.loginGroupBox.Controls.Add(this.passwdTextbox);
            this.loginGroupBox.Controls.Add(this.nameLabel);
            this.loginGroupBox.Controls.Add(this.passwdLabel);
            this.loginGroupBox.Controls.Add(this.nameTextbox);
            this.loginGroupBox.Location = new System.Drawing.Point(12, 7);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(288, 201);
            this.loginGroupBox.TabIndex = 13;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Enter += new System.EventHandler(this.loginGroupBox_Enter);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(154, 150);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // radioUserAuth
            // 
            this.radioUserAuth.AutoSize = true;
            this.radioUserAuth.Location = new System.Drawing.Point(21, 19);
            this.radioUserAuth.Name = "radioUserAuth";
            this.radioUserAuth.Size = new System.Drawing.Size(93, 17);
            this.radioUserAuth.TabIndex = 6;
            this.radioUserAuth.TabStop = true;
            this.radioUserAuth.Text = "Authentication";
            this.radioUserAuth.UseVisualStyleBackColor = true;
            this.radioUserAuth.CheckedChanged += new System.EventHandler(this.radioUserAuth_CheckedChanged);
            // 
            // radioGuestAuth
            // 
            this.radioGuestAuth.AutoSize = true;
            this.radioGuestAuth.Location = new System.Drawing.Point(154, 19);
            this.radioGuestAuth.Name = "radioGuestAuth";
            this.radioGuestAuth.Size = new System.Drawing.Size(53, 17);
            this.radioGuestAuth.TabIndex = 7;
            this.radioGuestAuth.TabStop = true;
            this.radioGuestAuth.Text = "Guest";
            this.radioGuestAuth.UseVisualStyleBackColor = true;
            this.radioGuestAuth.CheckedChanged += new System.EventHandler(this.radioGuestAuth_CheckedChanged);
            // 
            // passwdTextbox
            // 
            this.passwdTextbox.Location = new System.Drawing.Point(85, 92);
            this.passwdTextbox.Name = "passwdTextbox";
            this.passwdTextbox.Size = new System.Drawing.Size(165, 20);
            this.passwdTextbox.TabIndex = 1;
            this.passwdTextbox.UseSystemPasswordChar = true;
            this.passwdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdTextbox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "User name:";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(18, 95);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(56, 13);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "Password:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(85, 56);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(165, 20);
            this.nameTextbox.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 212);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.RadioButton radioUserAuth;
        private System.Windows.Forms.RadioButton radioGuestAuth;
        private System.Windows.Forms.TextBox passwdTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}