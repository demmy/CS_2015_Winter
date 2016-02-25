namespace fight_club
{
    partial class SecondPlayerLoadUserControl
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
            this.PlaerNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginSecondPlayerButton = new System.Windows.Forms.Button();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlaerNameTextBox
            // 
            this.PlaerNameTextBox.Location = new System.Drawing.Point(25, 48);
            this.PlaerNameTextBox.MaxLength = 10;
            this.PlaerNameTextBox.Name = "PlaerNameTextBox";
            this.PlaerNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.PlaerNameTextBox.TabIndex = 10;
            this.PlaerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaerNameTextBox_KeyPress);
            // 
            // LoginSecondPlayerButton
            // 
            this.LoginSecondPlayerButton.Location = new System.Drawing.Point(202, 87);
            this.LoginSecondPlayerButton.Name = "LoginSecondPlayerButton";
            this.LoginSecondPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.LoginSecondPlayerButton.TabIndex = 9;
            this.LoginSecondPlayerButton.Text = "Login";
            this.LoginSecondPlayerButton.UseVisualStyleBackColor = true;
            this.LoginSecondPlayerButton.Click += new System.EventHandler(this.LoginSecondPlayerButton_Click);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(22, 19);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(99, 13);
            this.EnterNameLabel.TabIndex = 8;
            this.EnterNameLabel.Text = "Enter player\'s name";
            // 
            // SecondPlayerLoadUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlaerNameTextBox);
            this.Controls.Add(this.LoginSecondPlayerButton);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "SecondPlayerLoadUserControl";
            this.Size = new System.Drawing.Size(302, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaerNameTextBox;
        private System.Windows.Forms.Button LoginSecondPlayerButton;
        private System.Windows.Forms.Label EnterNameLabel;
    }
}
