namespace FightClubApp.UI.Fight
{
    partial class FightUserControl
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
            this.save = new System.Windows.Forms.Button();
            this.musicOnOf = new System.Windows.Forms.CheckBox();
            this.nextFight = new System.Windows.Forms.Button();
            this.statistBtn = new System.Windows.Forms.Button();
            this.namePlayer = new System.Windows.Forms.Label();
            this.roundLb = new System.Windows.Forms.Label();
            this.logLb = new System.Windows.Forms.Label();
            this.toMenu = new System.Windows.Forms.Button();
            this.fight = new System.Windows.Forms.Button();
            this.logFld = new System.Windows.Forms.TextBox();
            this.botHpProgress = new System.Windows.Forms.ProgressBar();
            this.nameBot = new System.Windows.Forms.Label();
            this.playerHpProgress = new System.Windows.Forms.ProgressBar();
            this.groupProtect = new System.Windows.Forms.GroupBox();
            this.protLegs = new System.Windows.Forms.RadioButton();
            this.protTors = new System.Windows.Forms.RadioButton();
            this.protHead = new System.Windows.Forms.RadioButton();
            this.groupAttack = new System.Windows.Forms.GroupBox();
            this.attLegs = new System.Windows.Forms.RadioButton();
            this.attTors = new System.Windows.Forms.RadioButton();
            this.attHead = new System.Windows.Forms.RadioButton();
            this.groupProtect.SuspendLayout();
            this.groupAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(624, 404);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 30);
            this.save.TabIndex = 34;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // musicOnOf
            // 
            this.musicOnOf.AutoSize = true;
            this.musicOnOf.BackColor = System.Drawing.Color.Transparent;
            this.musicOnOf.Checked = true;
            this.musicOnOf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.musicOnOf.Location = new System.Drawing.Point(44, 404);
            this.musicOnOf.Name = "musicOnOf";
            this.musicOnOf.Size = new System.Drawing.Size(66, 17);
            this.musicOnOf.TabIndex = 33;
            this.musicOnOf.Text = "Музыка";
            this.musicOnOf.UseVisualStyleBackColor = false;
            this.musicOnOf.CheckedChanged += new System.EventHandler(this.musicCb_CheckedChanged);
            // 
            // nextFight
            // 
            this.nextFight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextFight.Enabled = false;
            this.nextFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextFight.Location = new System.Drawing.Point(388, 399);
            this.nextFight.Name = "nextFight";
            this.nextFight.Size = new System.Drawing.Size(90, 39);
            this.nextFight.TabIndex = 32;
            this.nextFight.Text = "Слелующий бой";
            this.nextFight.UseVisualStyleBackColor = true;
            this.nextFight.Click += new System.EventHandler(this.nextFightButton_Click);
            // 
            // statistBtn
            // 
            this.statistBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statistBtn.Enabled = false;
            this.statistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistBtn.Location = new System.Drawing.Point(204, 399);
            this.statistBtn.Name = "statistBtn";
            this.statistBtn.Size = new System.Drawing.Size(90, 39);
            this.statistBtn.TabIndex = 31;
            this.statistBtn.Text = "Статистика боя";
            this.statistBtn.UseVisualStyleBackColor = true;
            this.statistBtn.Click += new System.EventHandler(this.statistButton_Click);
            // 
            // namePlayer
            // 
            this.namePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namePlayer.AutoSize = true;
            this.namePlayer.BackColor = System.Drawing.Color.Transparent;
            this.namePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePlayer.Location = new System.Drawing.Point(188, 73);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(53, 20);
            this.namePlayer.TabIndex = 30;
            this.namePlayer.Text = "Игрок";
            // 
            // roundLb
            // 
            this.roundLb.AutoSize = true;
            this.roundLb.BackColor = System.Drawing.Color.Transparent;
            this.roundLb.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundLb.Location = new System.Drawing.Point(38, 8);
            this.roundLb.Name = "roundLb";
            this.roundLb.Size = new System.Drawing.Size(95, 31);
            this.roundLb.TabIndex = 29;
            this.roundLb.Text = "Раунд 1";
            // 
            // logLb
            // 
            this.logLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLb.AutoSize = true;
            this.logLb.BackColor = System.Drawing.Color.Transparent;
            this.logLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLb.Location = new System.Drawing.Point(297, 203);
            this.logLb.Name = "logLb";
            this.logLb.Size = new System.Drawing.Size(71, 20);
            this.logLb.TabIndex = 28;
            this.logLb.Text = "Ход боя";
            // 
            // toMenu
            // 
            this.toMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMenu.Location = new System.Drawing.Point(624, 47);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(114, 30);
            this.toMenu.TabIndex = 27;
            this.toMenu.Text = "В меню";
            this.toMenu.UseVisualStyleBackColor = true;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // fight
            // 
            this.fight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fight.Location = new System.Drawing.Point(301, 399);
            this.fight.Name = "fight";
            this.fight.Size = new System.Drawing.Size(81, 39);
            this.fight.TabIndex = 26;
            this.fight.Text = "Бой";
            this.fight.UseVisualStyleBackColor = true;
            this.fight.Click += new System.EventHandler(this.butFight_Click);
            // 
            // logFld
            // 
            this.logFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logFld.Location = new System.Drawing.Point(192, 226);
            this.logFld.Multiline = true;
            this.logFld.Name = "logFld";
            this.logFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logFld.Size = new System.Drawing.Size(288, 157);
            this.logFld.TabIndex = 25;
            // 
            // botHpProgress
            // 
            this.botHpProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botHpProgress.Location = new System.Drawing.Point(192, 160);
            this.botHpProgress.Name = "botHpProgress";
            this.botHpProgress.Size = new System.Drawing.Size(288, 22);
            this.botHpProgress.TabIndex = 24;
            this.botHpProgress.Value = 100;
            // 
            // nameBot
            // 
            this.nameBot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBot.AutoSize = true;
            this.nameBot.BackColor = System.Drawing.Color.Transparent;
            this.nameBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBot.Location = new System.Drawing.Point(188, 136);
            this.nameBot.Name = "nameBot";
            this.nameBot.Size = new System.Drawing.Size(38, 20);
            this.nameBot.TabIndex = 23;
            this.nameBot.Text = "Бот";
            // 
            // playerHpProgress
            // 
            this.playerHpProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHpProgress.Location = new System.Drawing.Point(192, 96);
            this.playerHpProgress.Name = "playerHpProgress";
            this.playerHpProgress.Size = new System.Drawing.Size(288, 22);
            this.playerHpProgress.TabIndex = 22;
            this.playerHpProgress.Value = 100;
            // 
            // groupProtect
            // 
            this.groupProtect.BackColor = System.Drawing.Color.Silver;
            this.groupProtect.Controls.Add(this.protLegs);
            this.groupProtect.Controls.Add(this.protTors);
            this.groupProtect.Controls.Add(this.protHead);
            this.groupProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupProtect.Location = new System.Drawing.Point(23, 245);
            this.groupProtect.Name = "groupProtect";
            this.groupProtect.Size = new System.Drawing.Size(126, 153);
            this.groupProtect.TabIndex = 21;
            this.groupProtect.TabStop = false;
            this.groupProtect.Text = "Защита";
            // 
            // protLegs
            // 
            this.protLegs.AutoSize = true;
            this.protLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protLegs.Location = new System.Drawing.Point(21, 114);
            this.protLegs.Name = "protLegs";
            this.protLegs.Size = new System.Drawing.Size(64, 24);
            this.protLegs.TabIndex = 6;
            this.protLegs.Text = "Ноги";
            this.protLegs.UseVisualStyleBackColor = true;
            // 
            // protTors
            // 
            this.protTors.AutoSize = true;
            this.protTors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protTors.Location = new System.Drawing.Point(21, 75);
            this.protTors.Name = "protTors";
            this.protTors.Size = new System.Drawing.Size(79, 24);
            this.protTors.TabIndex = 5;
            this.protTors.Text = "Корпус";
            this.protTors.UseVisualStyleBackColor = true;
            // 
            // protHead
            // 
            this.protHead.AutoSize = true;
            this.protHead.Checked = true;
            this.protHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protHead.Location = new System.Drawing.Point(21, 34);
            this.protHead.Name = "protHead";
            this.protHead.Size = new System.Drawing.Size(82, 24);
            this.protHead.TabIndex = 4;
            this.protHead.TabStop = true;
            this.protHead.Text = "Голова";
            this.protHead.UseVisualStyleBackColor = true;
            // 
            // groupAttack
            // 
            this.groupAttack.BackColor = System.Drawing.Color.Silver;
            this.groupAttack.Controls.Add(this.attLegs);
            this.groupAttack.Controls.Add(this.attTors);
            this.groupAttack.Controls.Add(this.attHead);
            this.groupAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAttack.Location = new System.Drawing.Point(23, 61);
            this.groupAttack.Name = "groupAttack";
            this.groupAttack.Size = new System.Drawing.Size(126, 153);
            this.groupAttack.TabIndex = 20;
            this.groupAttack.TabStop = false;
            this.groupAttack.Text = "Атака";
            // 
            // attLegs
            // 
            this.attLegs.AutoSize = true;
            this.attLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attLegs.Location = new System.Drawing.Point(21, 114);
            this.attLegs.Name = "attLegs";
            this.attLegs.Size = new System.Drawing.Size(64, 24);
            this.attLegs.TabIndex = 6;
            this.attLegs.Text = "Ноги";
            this.attLegs.UseVisualStyleBackColor = true;
            // 
            // attTors
            // 
            this.attTors.AutoSize = true;
            this.attTors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attTors.Location = new System.Drawing.Point(21, 75);
            this.attTors.Name = "attTors";
            this.attTors.Size = new System.Drawing.Size(79, 24);
            this.attTors.TabIndex = 5;
            this.attTors.Text = "Корпус";
            this.attTors.UseVisualStyleBackColor = true;
            // 
            // attHead
            // 
            this.attHead.AutoSize = true;
            this.attHead.Checked = true;
            this.attHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attHead.Location = new System.Drawing.Point(21, 34);
            this.attHead.Name = "attHead";
            this.attHead.Size = new System.Drawing.Size(82, 24);
            this.attHead.TabIndex = 4;
            this.attHead.TabStop = true;
            this.attHead.Text = "Голова";
            this.attHead.UseVisualStyleBackColor = true;
            // 
            // FightUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.tumblr_inline_nlma5dDlRQ1s811jo_12804;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.save);
            this.Controls.Add(this.musicOnOf);
            this.Controls.Add(this.nextFight);
            this.Controls.Add(this.statistBtn);
            this.Controls.Add(this.namePlayer);
            this.Controls.Add(this.roundLb);
            this.Controls.Add(this.logLb);
            this.Controls.Add(this.toMenu);
            this.Controls.Add(this.fight);
            this.Controls.Add(this.logFld);
            this.Controls.Add(this.botHpProgress);
            this.Controls.Add(this.nameBot);
            this.Controls.Add(this.playerHpProgress);
            this.Controls.Add(this.groupProtect);
            this.Controls.Add(this.groupAttack);
            this.Name = "FightUserControl";
            this.Size = new System.Drawing.Size(760, 470);
            this.groupProtect.ResumeLayout(false);
            this.groupProtect.PerformLayout();
            this.groupAttack.ResumeLayout(false);
            this.groupAttack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox musicOnOf;
        private System.Windows.Forms.Button nextFight;
        private System.Windows.Forms.Button statistBtn;
        private System.Windows.Forms.Label namePlayer;
        private System.Windows.Forms.Label roundLb;
        private System.Windows.Forms.Label logLb;
        private System.Windows.Forms.Button toMenu;
        private System.Windows.Forms.Button fight;
        private System.Windows.Forms.TextBox logFld;
        private System.Windows.Forms.ProgressBar botHpProgress;
        private System.Windows.Forms.Label nameBot;
        private System.Windows.Forms.ProgressBar playerHpProgress;
        private System.Windows.Forms.GroupBox groupProtect;
        private System.Windows.Forms.RadioButton protLegs;
        private System.Windows.Forms.RadioButton protTors;
        private System.Windows.Forms.RadioButton protHead;
        private System.Windows.Forms.GroupBox groupAttack;
        private System.Windows.Forms.RadioButton attLegs;
        private System.Windows.Forms.RadioButton attTors;
        private System.Windows.Forms.RadioButton attHead;
        private System.Windows.Forms.Button save;
    }
}
