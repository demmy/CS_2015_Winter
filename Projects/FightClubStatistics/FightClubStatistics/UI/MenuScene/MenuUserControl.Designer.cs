namespace FightClubStatistics.UI.MenuScene
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
            this.exitButton = new System.Windows.Forms.Button();
            this.toCombatLogControl = new System.Windows.Forms.Button();
            this.toTransactionsControl = new System.Windows.Forms.Button();
            this.toUsersControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 433);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(269, 59);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toCombatLogControl
            // 
            this.toCombatLogControl.Location = new System.Drawing.Point(16, 196);
            this.toCombatLogControl.Name = "toCombatLogControl";
            this.toCombatLogControl.Size = new System.Drawing.Size(269, 59);
            this.toCombatLogControl.TabIndex = 2;
            this.toCombatLogControl.Text = "Combat logs";
            this.toCombatLogControl.UseVisualStyleBackColor = true;
            this.toCombatLogControl.Click += new System.EventHandler(this.toCombatLogControl_Click);
            // 
            // toTransactionsControl
            // 
            this.toTransactionsControl.Location = new System.Drawing.Point(16, 105);
            this.toTransactionsControl.Name = "toTransactionsControl";
            this.toTransactionsControl.Size = new System.Drawing.Size(269, 59);
            this.toTransactionsControl.TabIndex = 1;
            this.toTransactionsControl.Text = "Transactions";
            this.toTransactionsControl.UseVisualStyleBackColor = true;
            this.toTransactionsControl.Click += new System.EventHandler(this.toTransactionsControl_Click);
            // 
            // toUsersControl
            // 
            this.toUsersControl.Location = new System.Drawing.Point(16, 17);
            this.toUsersControl.Name = "toUsersControl";
            this.toUsersControl.Size = new System.Drawing.Size(269, 59);
            this.toUsersControl.TabIndex = 0;
            this.toUsersControl.Text = "Users";
            this.toUsersControl.UseVisualStyleBackColor = true;
            this.toUsersControl.Click += new System.EventHandler(this.toUsersControl_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toCombatLogControl);
            this.Controls.Add(this.toTransactionsControl);
            this.Controls.Add(this.toUsersControl);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(322, 551);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toUsersControl;
        private System.Windows.Forms.Button toTransactionsControl;
        private System.Windows.Forms.Button toCombatLogControl;
        private System.Windows.Forms.Button exitButton;
    }
}
