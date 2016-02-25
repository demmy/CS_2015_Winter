namespace FightClub
{
    partial class GameForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userHpLabel = new System.Windows.Forms.Label();
            this.botNameLabel = new System.Windows.Forms.Label();
            this.botHpLabel = new System.Windows.Forms.Label();
            this.userProgressBar = new System.Windows.Forms.ProgressBar();
            this.botProgressBar = new System.Windows.Forms.ProgressBar();
            this.fightButton = new System.Windows.Forms.Button();
            this.AttackBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerRadioButtonLegs = new System.Windows.Forms.RadioButton();
            this.playerRadioButtonBody = new System.Windows.Forms.RadioButton();
            this.playerRadioButtonHead = new System.Windows.Forms.RadioButton();
            this.DefenseBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerBlockedRadioButtonBody = new System.Windows.Forms.RadioButton();
            this.playerBlockedRadioButtonLegs = new System.Windows.Forms.RadioButton();
            this.playerBlockedRadioButtonHead = new System.Windows.Forms.RadioButton();
            this.logBox = new System.Windows.Forms.ListBox();
            this.playerlabelTextDamage = new System.Windows.Forms.Label();
            this.botlabelTextDamage = new System.Windows.Forms.Label();
            this.userdamageLabel = new System.Windows.Forms.Label();
            this.botdamageLabel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.botPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerlabelTextHit = new System.Windows.Forms.Label();
            this.playerlabelTextBlock = new System.Windows.Forms.Label();
            this.botlabelTextHit = new System.Windows.Forms.Label();
            this.botlabelTextBlock = new System.Windows.Forms.Label();
            this.playerHitLabel = new System.Windows.Forms.Label();
            this.playerBlockLabel = new System.Windows.Forms.Label();
            this.botHitLabel = new System.Windows.Forms.Label();
            this.botBlockLabel = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.textLvlLabel = new System.Windows.Forms.Label();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.AttackBox.SuspendLayout();
            this.DefenseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(87, 47);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(27, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "user";
            // 
            // userHpLabel
            // 
            this.userHpLabel.AutoSize = true;
            this.userHpLabel.Location = new System.Drawing.Point(92, 228);
            this.userHpLabel.Name = "userHpLabel";
            this.userHpLabel.Size = new System.Drawing.Size(22, 13);
            this.userHpLabel.TabIndex = 1;
            this.userHpLabel.Text = "HP";
            // 
            // botNameLabel
            // 
            this.botNameLabel.AutoSize = true;
            this.botNameLabel.Location = new System.Drawing.Point(490, 47);
            this.botNameLabel.Name = "botNameLabel";
            this.botNameLabel.Size = new System.Drawing.Size(22, 13);
            this.botNameLabel.TabIndex = 2;
            this.botNameLabel.Text = "bot";
            // 
            // botHpLabel
            // 
            this.botHpLabel.AutoSize = true;
            this.botHpLabel.Location = new System.Drawing.Point(475, 228);
            this.botHpLabel.Name = "botHpLabel";
            this.botHpLabel.Size = new System.Drawing.Size(22, 13);
            this.botHpLabel.TabIndex = 3;
            this.botHpLabel.Text = "HP";
            // 
            // userProgressBar
            // 
            this.userProgressBar.Location = new System.Drawing.Point(37, 189);
            this.userProgressBar.Maximum = 125;
            this.userProgressBar.Name = "userProgressBar";
            this.userProgressBar.Size = new System.Drawing.Size(131, 23);
            this.userProgressBar.TabIndex = 4;
            // 
            // botProgressBar
            // 
            this.botProgressBar.Location = new System.Drawing.Point(432, 191);
            this.botProgressBar.Maximum = 125;
            this.botProgressBar.Name = "botProgressBar";
            this.botProgressBar.Size = new System.Drawing.Size(131, 23);
            this.botProgressBar.TabIndex = 5;
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(257, 200);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(75, 23);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // AttackBox
            // 
            this.AttackBox.Controls.Add(this.label6);
            this.AttackBox.Controls.Add(this.playerRadioButtonLegs);
            this.AttackBox.Controls.Add(this.playerRadioButtonBody);
            this.AttackBox.Controls.Add(this.playerRadioButtonHead);
            this.AttackBox.Location = new System.Drawing.Point(187, 65);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(96, 120);
            this.AttackBox.TabIndex = 14;
            this.AttackBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Attack";
            // 
            // playerRadioButtonLegs
            // 
            this.playerRadioButtonLegs.AutoSize = true;
            this.playerRadioButtonLegs.Location = new System.Drawing.Point(20, 86);
            this.playerRadioButtonLegs.Name = "playerRadioButtonLegs";
            this.playerRadioButtonLegs.Size = new System.Drawing.Size(48, 17);
            this.playerRadioButtonLegs.TabIndex = 8;
            this.playerRadioButtonLegs.TabStop = true;
            this.playerRadioButtonLegs.Text = "Legs";
            this.playerRadioButtonLegs.UseVisualStyleBackColor = true;
            // 
            // playerRadioButtonBody
            // 
            this.playerRadioButtonBody.AutoSize = true;
            this.playerRadioButtonBody.Location = new System.Drawing.Point(20, 63);
            this.playerRadioButtonBody.Name = "playerRadioButtonBody";
            this.playerRadioButtonBody.Size = new System.Drawing.Size(49, 17);
            this.playerRadioButtonBody.TabIndex = 7;
            this.playerRadioButtonBody.TabStop = true;
            this.playerRadioButtonBody.Text = "Body";
            this.playerRadioButtonBody.UseVisualStyleBackColor = true;
            // 
            // playerRadioButtonHead
            // 
            this.playerRadioButtonHead.AutoSize = true;
            this.playerRadioButtonHead.Location = new System.Drawing.Point(20, 40);
            this.playerRadioButtonHead.Name = "playerRadioButtonHead";
            this.playerRadioButtonHead.Size = new System.Drawing.Size(51, 17);
            this.playerRadioButtonHead.TabIndex = 6;
            this.playerRadioButtonHead.TabStop = true;
            this.playerRadioButtonHead.Text = "Head";
            this.playerRadioButtonHead.UseVisualStyleBackColor = true;
            // 
            // DefenseBox
            // 
            this.DefenseBox.Controls.Add(this.label5);
            this.DefenseBox.Controls.Add(this.playerBlockedRadioButtonBody);
            this.DefenseBox.Controls.Add(this.playerBlockedRadioButtonLegs);
            this.DefenseBox.Controls.Add(this.playerBlockedRadioButtonHead);
            this.DefenseBox.Location = new System.Drawing.Point(312, 65);
            this.DefenseBox.Name = "DefenseBox";
            this.DefenseBox.Size = new System.Drawing.Size(100, 120);
            this.DefenseBox.TabIndex = 16;
            this.DefenseBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defense";
            // 
            // playerBlockedRadioButtonBody
            // 
            this.playerBlockedRadioButtonBody.AutoSize = true;
            this.playerBlockedRadioButtonBody.Location = new System.Drawing.Point(23, 63);
            this.playerBlockedRadioButtonBody.Name = "playerBlockedRadioButtonBody";
            this.playerBlockedRadioButtonBody.Size = new System.Drawing.Size(49, 17);
            this.playerBlockedRadioButtonBody.TabIndex = 10;
            this.playerBlockedRadioButtonBody.TabStop = true;
            this.playerBlockedRadioButtonBody.Text = "Body";
            this.playerBlockedRadioButtonBody.UseVisualStyleBackColor = true;
            // 
            // playerBlockedRadioButtonLegs
            // 
            this.playerBlockedRadioButtonLegs.AutoSize = true;
            this.playerBlockedRadioButtonLegs.Location = new System.Drawing.Point(24, 86);
            this.playerBlockedRadioButtonLegs.Name = "playerBlockedRadioButtonLegs";
            this.playerBlockedRadioButtonLegs.Size = new System.Drawing.Size(48, 17);
            this.playerBlockedRadioButtonLegs.TabIndex = 11;
            this.playerBlockedRadioButtonLegs.TabStop = true;
            this.playerBlockedRadioButtonLegs.Text = "Legs";
            this.playerBlockedRadioButtonLegs.UseVisualStyleBackColor = true;
            // 
            // playerBlockedRadioButtonHead
            // 
            this.playerBlockedRadioButtonHead.AutoSize = true;
            this.playerBlockedRadioButtonHead.Location = new System.Drawing.Point(24, 40);
            this.playerBlockedRadioButtonHead.Name = "playerBlockedRadioButtonHead";
            this.playerBlockedRadioButtonHead.Size = new System.Drawing.Size(51, 17);
            this.playerBlockedRadioButtonHead.TabIndex = 9;
            this.playerBlockedRadioButtonHead.TabStop = true;
            this.playerBlockedRadioButtonHead.Text = "Head";
            this.playerBlockedRadioButtonHead.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(168, 245);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(255, 147);
            this.logBox.TabIndex = 17;
            // 
            // playerlabelTextDamage
            // 
            this.playerlabelTextDamage.AutoSize = true;
            this.playerlabelTextDamage.Location = new System.Drawing.Point(34, 284);
            this.playerlabelTextDamage.Name = "playerlabelTextDamage";
            this.playerlabelTextDamage.Size = new System.Drawing.Size(50, 13);
            this.playerlabelTextDamage.TabIndex = 20;
            this.playerlabelTextDamage.Text = "Damage:";
            // 
            // botlabelTextDamage
            // 
            this.botlabelTextDamage.AutoSize = true;
            this.botlabelTextDamage.Location = new System.Drawing.Point(429, 284);
            this.botlabelTextDamage.Name = "botlabelTextDamage";
            this.botlabelTextDamage.Size = new System.Drawing.Size(50, 13);
            this.botlabelTextDamage.TabIndex = 21;
            this.botlabelTextDamage.Text = "Damage:";
            // 
            // userdamageLabel
            // 
            this.userdamageLabel.AutoSize = true;
            this.userdamageLabel.Location = new System.Drawing.Point(484, 284);
            this.userdamageLabel.Name = "userdamageLabel";
            this.userdamageLabel.Size = new System.Drawing.Size(13, 13);
            this.userdamageLabel.TabIndex = 24;
            this.userdamageLabel.Text = "0";
            // 
            // botdamageLabel
            // 
            this.botdamageLabel.AutoSize = true;
            this.botdamageLabel.Location = new System.Drawing.Point(92, 284);
            this.botdamageLabel.Name = "botdamageLabel";
            this.botdamageLabel.Size = new System.Drawing.Size(13, 13);
            this.botdamageLabel.TabIndex = 25;
            this.botdamageLabel.Text = "0";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(30, 373);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save Log";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // botPictureBox
            // 
            this.botPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.botPictureBox.Location = new System.Drawing.Point(432, 65);
            this.botPictureBox.Name = "botPictureBox";
            this.botPictureBox.Size = new System.Drawing.Size(131, 120);
            this.botPictureBox.TabIndex = 7;
            this.botPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.playerPictureBox.Location = new System.Drawing.Point(37, 63);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(131, 120);
            this.playerPictureBox.TabIndex = 6;
            this.playerPictureBox.TabStop = false;
            // 
            // playerlabelTextHit
            // 
            this.playerlabelTextHit.AutoSize = true;
            this.playerlabelTextHit.Location = new System.Drawing.Point(34, 342);
            this.playerlabelTextHit.Name = "playerlabelTextHit";
            this.playerlabelTextHit.Size = new System.Drawing.Size(28, 13);
            this.playerlabelTextHit.TabIndex = 27;
            this.playerlabelTextHit.Text = "HIT:";
            // 
            // playerlabelTextBlock
            // 
            this.playerlabelTextBlock.AutoSize = true;
            this.playerlabelTextBlock.Location = new System.Drawing.Point(34, 319);
            this.playerlabelTextBlock.Name = "playerlabelTextBlock";
            this.playerlabelTextBlock.Size = new System.Drawing.Size(49, 13);
            this.playerlabelTextBlock.TabIndex = 28;
            this.playerlabelTextBlock.Text = "Blocked:";
            // 
            // botlabelTextHit
            // 
            this.botlabelTextHit.AutoSize = true;
            this.botlabelTextHit.Location = new System.Drawing.Point(429, 319);
            this.botlabelTextHit.Name = "botlabelTextHit";
            this.botlabelTextHit.Size = new System.Drawing.Size(28, 13);
            this.botlabelTextHit.TabIndex = 29;
            this.botlabelTextHit.Text = "HIT:";
            // 
            // botlabelTextBlock
            // 
            this.botlabelTextBlock.AutoSize = true;
            this.botlabelTextBlock.Location = new System.Drawing.Point(429, 342);
            this.botlabelTextBlock.Name = "botlabelTextBlock";
            this.botlabelTextBlock.Size = new System.Drawing.Size(49, 13);
            this.botlabelTextBlock.TabIndex = 30;
            this.botlabelTextBlock.Text = "Blocked:";
            // 
            // playerHitLabel
            // 
            this.playerHitLabel.AutoSize = true;
            this.playerHitLabel.Location = new System.Drawing.Point(92, 342);
            this.playerHitLabel.Name = "playerHitLabel";
            this.playerHitLabel.Size = new System.Drawing.Size(13, 13);
            this.playerHitLabel.TabIndex = 31;
            this.playerHitLabel.Text = "0";
            // 
            // playerBlockLabel
            // 
            this.playerBlockLabel.AutoSize = true;
            this.playerBlockLabel.Location = new System.Drawing.Point(92, 319);
            this.playerBlockLabel.Name = "playerBlockLabel";
            this.playerBlockLabel.Size = new System.Drawing.Size(13, 13);
            this.playerBlockLabel.TabIndex = 32;
            this.playerBlockLabel.Text = "0";
            // 
            // botHitLabel
            // 
            this.botHitLabel.AutoSize = true;
            this.botHitLabel.Location = new System.Drawing.Point(484, 319);
            this.botHitLabel.Name = "botHitLabel";
            this.botHitLabel.Size = new System.Drawing.Size(13, 13);
            this.botHitLabel.TabIndex = 33;
            this.botHitLabel.Text = "0";
            // 
            // botBlockLabel
            // 
            this.botBlockLabel.AutoSize = true;
            this.botBlockLabel.Location = new System.Drawing.Point(484, 342);
            this.botBlockLabel.Name = "botBlockLabel";
            this.botBlockLabel.Size = new System.Drawing.Size(13, 13);
            this.botBlockLabel.TabIndex = 34;
            this.botBlockLabel.Text = "0";
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(257, 36);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(75, 23);
            this.RestartBtn.TabIndex = 35;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(273, 9);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(59, 21);
            this.modeLabel.TabIndex = 36;
            this.modeLabel.Text = "Mode";
            // 
            // textLvlLabel
            // 
            this.textLvlLabel.AutoSize = true;
            this.textLvlLabel.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLvlLabel.Location = new System.Drawing.Point(240, 395);
            this.textLvlLabel.Name = "textLvlLabel";
            this.textLvlLabel.Size = new System.Drawing.Size(43, 21);
            this.textLvlLabel.TabIndex = 37;
            this.textLvlLabel.Text = "Lvl:";
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLabel.Location = new System.Drawing.Point(308, 395);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(22, 21);
            this.lvlLabel.TabIndex = 38;
            this.lvlLabel.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 425);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.textLvlLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.botBlockLabel);
            this.Controls.Add(this.botHitLabel);
            this.Controls.Add(this.playerBlockLabel);
            this.Controls.Add(this.playerHitLabel);
            this.Controls.Add(this.botlabelTextBlock);
            this.Controls.Add(this.botlabelTextHit);
            this.Controls.Add(this.playerlabelTextBlock);
            this.Controls.Add(this.playerlabelTextHit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.botdamageLabel);
            this.Controls.Add(this.userdamageLabel);
            this.Controls.Add(this.botlabelTextDamage);
            this.Controls.Add(this.playerlabelTextDamage);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.DefenseBox);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.botPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.botProgressBar);
            this.Controls.Add(this.userProgressBar);
            this.Controls.Add(this.botHpLabel);
            this.Controls.Add(this.botNameLabel);
            this.Controls.Add(this.userHpLabel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.AttackBox.ResumeLayout(false);
            this.AttackBox.PerformLayout();
            this.DefenseBox.ResumeLayout(false);
            this.DefenseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userHpLabel;
        private System.Windows.Forms.Label botNameLabel;
        private System.Windows.Forms.Label botHpLabel;
        private System.Windows.Forms.ProgressBar userProgressBar;
        private System.Windows.Forms.ProgressBar botProgressBar;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox botPictureBox;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.GroupBox AttackBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton playerRadioButtonLegs;
        private System.Windows.Forms.RadioButton playerRadioButtonBody;
        private System.Windows.Forms.RadioButton playerRadioButtonHead;
        private System.Windows.Forms.GroupBox DefenseBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonBody;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonLegs;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonHead;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Label playerlabelTextDamage;
        private System.Windows.Forms.Label botlabelTextDamage;
        private System.Windows.Forms.Label userdamageLabel;
        private System.Windows.Forms.Label botdamageLabel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label playerlabelTextHit;
        private System.Windows.Forms.Label playerlabelTextBlock;
        private System.Windows.Forms.Label botlabelTextHit;
        private System.Windows.Forms.Label botlabelTextBlock;
        private System.Windows.Forms.Label playerHitLabel;
        private System.Windows.Forms.Label playerBlockLabel;
        private System.Windows.Forms.Label botHitLabel;
        private System.Windows.Forms.Label botBlockLabel;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label textLvlLabel;
        private System.Windows.Forms.Label lvlLabel;
    }
}