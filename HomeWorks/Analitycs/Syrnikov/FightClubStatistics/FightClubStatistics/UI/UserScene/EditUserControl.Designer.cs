namespace FightClubStatistics.UI.UserScene
{
    partial class EditUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerDataLabel = new System.Windows.Forms.Label();
            this.playerExpTextBox = new System.Windows.Forms.TextBox();
            this.playerExpLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.userEMailTextBox = new System.Windows.Forms.TextBox();
            this.userEMailLabel = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.validEMailChackBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playerDataLabel
            // 
            this.playerDataLabel.AutoSize = true;
            this.playerDataLabel.Location = new System.Drawing.Point(25, 290);
            this.playerDataLabel.Name = "playerDataLabel";
            this.playerDataLabel.Size = new System.Drawing.Size(62, 13);
            this.playerDataLabel.TabIndex = 12;
            this.playerDataLabel.Text = "Player Data";
            // 
            // playerExpTextBox
            // 
            this.playerExpTextBox.Location = new System.Drawing.Point(54, 411);
            this.playerExpTextBox.MaxLength = 50;
            this.playerExpTextBox.Name = "playerExpTextBox";
            this.playerExpTextBox.Size = new System.Drawing.Size(376, 20);
            this.playerExpTextBox.TabIndex = 11;
            this.playerExpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerExpTextBox_KeyPress);
            // 
            // playerExpLabel
            // 
            this.playerExpLabel.AutoSize = true;
            this.playerExpLabel.Location = new System.Drawing.Point(51, 386);
            this.playerExpLabel.Name = "playerExpLabel";
            this.playerExpLabel.Size = new System.Drawing.Size(57, 13);
            this.playerExpLabel.TabIndex = 10;
            this.playerExpLabel.Text = "Player Exp";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(54, 344);
            this.playerNameTextBox.MaxLength = 50;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(376, 20);
            this.playerNameTextBox.TabIndex = 9;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(51, 319);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 8;
            this.playerNameLabel.Text = "Player Name";
            // 
            // userEMailTextBox
            // 
            this.userEMailTextBox.Location = new System.Drawing.Point(28, 195);
            this.userEMailTextBox.MaxLength = 50;
            this.userEMailTextBox.Name = "userEMailTextBox";
            this.userEMailTextBox.Size = new System.Drawing.Size(406, 20);
            this.userEMailTextBox.TabIndex = 7;
            // 
            // userEMailLabel
            // 
            this.userEMailLabel.AutoSize = true;
            this.userEMailLabel.Location = new System.Drawing.Point(25, 170);
            this.userEMailLabel.Name = "userEMailLabel";
            this.userEMailLabel.Size = new System.Drawing.Size(33, 13);
            this.userEMailLabel.TabIndex = 6;
            this.userEMailLabel.Text = "EMail";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(28, 125);
            this.userPasswordTextBox.MaxLength = 50;
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(406, 20);
            this.userPasswordTextBox.TabIndex = 5;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(25, 100);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.userPasswordLabel.TabIndex = 4;
            this.userPasswordLabel.Text = "Password";
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(28, 52);
            this.userLoginTextBox.MaxLength = 50;
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(406, 20);
            this.userLoginTextBox.TabIndex = 3;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Location = new System.Drawing.Point(25, 27);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(33, 13);
            this.userLoginLabel.TabIndex = 2;
            this.userLoginLabel.Text = "Login";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(28, 484);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 48);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(248, 484);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(186, 48);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // validEMailChackBox
            // 
            this.validEMailChackBox.AutoSize = true;
            this.validEMailChackBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.validEMailChackBox.Location = new System.Drawing.Point(28, 240);
            this.validEMailChackBox.Name = "validEMailChackBox";
            this.validEMailChackBox.Size = new System.Drawing.Size(88, 17);
            this.validEMailChackBox.TabIndex = 14;
            this.validEMailChackBox.Text = "Is EMail valid";
            this.validEMailChackBox.UseVisualStyleBackColor = true;
            // 
            // EditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.validEMailChackBox);
            this.Controls.Add(this.playerDataLabel);
            this.Controls.Add(this.playerExpTextBox);
            this.Controls.Add(this.playerExpLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.userEMailTextBox);
            this.Controls.Add(this.userEMailLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "EditUserControl";
            this.Size = new System.Drawing.Size(470, 594);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userEMailTextBox;
        private System.Windows.Forms.Label userEMailLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerExpTextBox;
        private System.Windows.Forms.Label playerExpLabel;
        private System.Windows.Forms.Label playerDataLabel;
        private System.Windows.Forms.CheckBox validEMailChackBox;
    }
}
