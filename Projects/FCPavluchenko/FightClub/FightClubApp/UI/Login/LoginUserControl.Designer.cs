namespace FightClubApp.UI.Login
{
    partial class LoginUserControl
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
            this.choosePlayerName = new System.Windows.Forms.TextBox();
            this.exitGame = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.Button();
            this.toFightMenu = new System.Windows.Forms.Button();
            this.records = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosePlayerName
            // 
            this.choosePlayerName.Location = new System.Drawing.Point(497, 96);
            this.choosePlayerName.Name = "choosePlayerName";
            this.choosePlayerName.Size = new System.Drawing.Size(153, 20);
            this.choosePlayerName.TabIndex = 18;
            // 
            // exitGame
            // 
            this.exitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitGame.Location = new System.Drawing.Point(16, 110);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(110, 31);
            this.exitGame.TabIndex = 17;
            this.exitGame.Text = "Выход";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // signIn
            // 
            this.signIn.AutoSize = true;
            this.signIn.BackColor = System.Drawing.Color.Transparent;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(472, 48);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(221, 32);
            this.signIn.TabIndex = 14;
            this.signIn.Text = "Авторизируйтесь \r\nили создайте нового персонажа\r\n";
            this.signIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rules
            // 
            this.rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules.Location = new System.Drawing.Point(16, 65);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(110, 31);
            this.rules.TabIndex = 13;
            this.rules.Text = "Правила";
            this.rules.UseVisualStyleBackColor = true;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // toFightMenu
            // 
            this.toFightMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFightMenu.Location = new System.Drawing.Point(521, 381);
            this.toFightMenu.Name = "toFightMenu";
            this.toFightMenu.Size = new System.Drawing.Size(107, 31);
            this.toFightMenu.TabIndex = 12;
            this.toFightMenu.Text = "Играть";
            this.toFightMenu.UseVisualStyleBackColor = true;
            this.toFightMenu.Click += new System.EventHandler(this.toFightMenu_Click);
            // 
            // records
            // 
            this.records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.records.Location = new System.Drawing.Point(16, 20);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(110, 31);
            this.records.TabIndex = 10;
            this.records.Text = "Рекорды";
            this.records.UseVisualStyleBackColor = true;
            this.records.Click += new System.EventHandler(this.records_Click);
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.fight_club_rule_you_do_not_talk_about_fight_club_336_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.choosePlayerName);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.toFightMenu);
            this.Controls.Add(this.records);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(740, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signIn;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Button toFightMenu;
        private System.Windows.Forms.Button records;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.TextBox choosePlayerName;
    }
}
