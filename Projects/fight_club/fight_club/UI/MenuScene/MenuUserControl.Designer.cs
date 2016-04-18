namespace fight_club
{
    partial class MenuUserControl
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
            this.NameInfoLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.ExpInfoLabel = new System.Windows.Forms.Label();
            this.PlayerExpLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChangePlayerButton = new System.Windows.Forms.Button();
            this.RecordTableButton = new System.Windows.Forms.Button();
            this.PvpEnterButton = new System.Windows.Forms.Button();
            this.PveEnterButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PlayerAvatarPanel = new System.Windows.Forms.Panel();
            this.PlayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayerAvatarPanel.SuspendLayout();
            this.PlayerInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameInfoLabel
            // 
            this.NameInfoLabel.AutoSize = true;
            this.NameInfoLabel.Location = new System.Drawing.Point(15, 16);
            this.NameInfoLabel.Name = "NameInfoLabel";
            this.NameInfoLabel.Size = new System.Drawing.Size(67, 13);
            this.NameInfoLabel.TabIndex = 0;
            this.NameInfoLabel.Text = "Player Name";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(113, 16);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(30, 13);
            this.PlayerNameLabel.TabIndex = 1;
            this.PlayerNameLabel.Text = "Jack";
            // 
            // ExpInfoLabel
            // 
            this.ExpInfoLabel.AutoSize = true;
            this.ExpInfoLabel.Location = new System.Drawing.Point(15, 38);
            this.ExpInfoLabel.Name = "ExpInfoLabel";
            this.ExpInfoLabel.Size = new System.Drawing.Size(57, 13);
            this.ExpInfoLabel.TabIndex = 2;
            this.ExpInfoLabel.Text = "Player Exp";
            // 
            // PlayerExpLabel
            // 
            this.PlayerExpLabel.AutoSize = true;
            this.PlayerExpLabel.Location = new System.Drawing.Point(113, 38);
            this.PlayerExpLabel.Name = "PlayerExpLabel";
            this.PlayerExpLabel.Size = new System.Drawing.Size(25, 13);
            this.PlayerExpLabel.TabIndex = 3;
            this.PlayerExpLabel.Text = "300";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(40, 482);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(310, 44);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangePlayerButton
            // 
            this.ChangePlayerButton.Location = new System.Drawing.Point(40, 374);
            this.ChangePlayerButton.Name = "ChangePlayerButton";
            this.ChangePlayerButton.Size = new System.Drawing.Size(310, 44);
            this.ChangePlayerButton.TabIndex = 24;
            this.ChangePlayerButton.Text = "Change player";
            this.ChangePlayerButton.UseVisualStyleBackColor = true;
            this.ChangePlayerButton.Click += new System.EventHandler(this.ChangePlayerButton_Click);
            // 
            // RecordTableButton
            // 
            this.RecordTableButton.Location = new System.Drawing.Point(40, 299);
            this.RecordTableButton.Name = "RecordTableButton";
            this.RecordTableButton.Size = new System.Drawing.Size(310, 44);
            this.RecordTableButton.TabIndex = 23;
            this.RecordTableButton.Text = "Record Table";
            this.RecordTableButton.UseVisualStyleBackColor = true;
            this.RecordTableButton.Click += new System.EventHandler(this.RecordTableButton_Click);
            // 
            // PvpEnterButton
            // 
            this.PvpEnterButton.Location = new System.Drawing.Point(40, 222);
            this.PvpEnterButton.Name = "PvpEnterButton";
            this.PvpEnterButton.Size = new System.Drawing.Size(310, 44);
            this.PvpEnterButton.TabIndex = 22;
            this.PvpEnterButton.Text = "PvP";
            this.PvpEnterButton.UseVisualStyleBackColor = true;
            this.PvpEnterButton.Click += new System.EventHandler(this.PvpEnterButton_Click);
            // 
            // PveEnterButton
            // 
            this.PveEnterButton.Location = new System.Drawing.Point(40, 147);
            this.PveEnterButton.Name = "PveEnterButton";
            this.PveEnterButton.Size = new System.Drawing.Size(310, 44);
            this.PveEnterButton.TabIndex = 21;
            this.PveEnterButton.Text = "PvE";
            this.PveEnterButton.UseVisualStyleBackColor = true;
            this.PveEnterButton.Click += new System.EventHandler(this.PveEnterButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "place for image";
            // 
            // PlayerAvatarPanel
            // 
            this.PlayerAvatarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerAvatarPanel.Controls.Add(this.label11);
            this.PlayerAvatarPanel.Location = new System.Drawing.Point(215, 16);
            this.PlayerAvatarPanel.Name = "PlayerAvatarPanel";
            this.PlayerAvatarPanel.Size = new System.Drawing.Size(167, 84);
            this.PlayerAvatarPanel.TabIndex = 19;
            // 
            // PlayerInfoPanel
            // 
            this.PlayerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerInfoPanel.Controls.Add(this.NameInfoLabel);
            this.PlayerInfoPanel.Controls.Add(this.PlayerAvatarPanel);
            this.PlayerInfoPanel.Controls.Add(this.PlayerNameLabel);
            this.PlayerInfoPanel.Controls.Add(this.ExpInfoLabel);
            this.PlayerInfoPanel.Controls.Add(this.PlayerExpLabel);
            this.PlayerInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.PlayerInfoPanel.Name = "PlayerInfoPanel";
            this.PlayerInfoPanel.Size = new System.Drawing.Size(396, 117);
            this.PlayerInfoPanel.TabIndex = 26;
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangePlayerButton);
            this.Controls.Add(this.RecordTableButton);
            this.Controls.Add(this.PvpEnterButton);
            this.Controls.Add(this.PveEnterButton);
            this.Controls.Add(this.PlayerInfoPanel);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(405, 563);
            this.Load += new System.EventHandler(this.MenuUserControl_Load);
            this.PlayerAvatarPanel.ResumeLayout(false);
            this.PlayerAvatarPanel.PerformLayout();
            this.PlayerInfoPanel.ResumeLayout(false);
            this.PlayerInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameInfoLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label ExpInfoLabel;
        private System.Windows.Forms.Label PlayerExpLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangePlayerButton;
        private System.Windows.Forms.Button RecordTableButton;
        private System.Windows.Forms.Button PvpEnterButton;
        private System.Windows.Forms.Button PveEnterButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PlayerAvatarPanel;
        private System.Windows.Forms.Panel PlayerInfoPanel;
    }
}
