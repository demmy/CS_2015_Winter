namespace Combats
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.botNameLbl = new System.Windows.Forms.Label();
            this.playerHpProgress = new System.Windows.Forms.ProgressBar();
            this.botHpProgress = new System.Windows.Forms.ProgressBar();
            this.playerHpLbl = new System.Windows.Forms.Label();
            this.botHpLbl = new System.Windows.Forms.Label();
            this.blockLbl = new System.Windows.Forms.Label();
            this.hitLbl = new System.Windows.Forms.Label();
            this.blockBodyRadioBtn = new System.Windows.Forms.RadioButton();
            this.blockLegsRadioBtn = new System.Windows.Forms.RadioButton();
            this.blockHeadRadioBtn = new System.Windows.Forms.RadioButton();
            this.hitHeadRadioBtn = new System.Windows.Forms.RadioButton();
            this.hitLegsRadioBtn = new System.Windows.Forms.RadioButton();
            this.hitBodyRadioBtn = new System.Windows.Forms.RadioButton();
            this.fightBtn = new System.Windows.Forms.Button();
            this.blockGroupBox = new System.Windows.Forms.GroupBox();
            this.hitGroupBox = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.playerArmorProgress = new System.Windows.Forms.ProgressBar();
            this.playerStrengthProgress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botStrengthProgress = new System.Windows.Forms.ProgressBar();
            this.botArmorProgress = new System.Windows.Forms.ProgressBar();
            this.playerArmorBtn = new System.Windows.Forms.Button();
            this.playerStrengthBtn = new System.Windows.Forms.Button();
            this.bonusStatLbl = new System.Windows.Forms.Label();
            this.playerStrengthLbl = new System.Windows.Forms.Label();
            this.playerArmorLbl = new System.Windows.Forms.Label();
            this.botStrengthLbl = new System.Windows.Forms.Label();
            this.botArmorLbl = new System.Windows.Forms.Label();
            this.nextBatleBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.autoHitCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.blockGroupBox.SuspendLayout();
            this.hitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(27, 26);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(38, 13);
            this.playerNameLbl.TabIndex = 0;
            this.playerNameLbl.Text = "Игрок";
            // 
            // botNameLbl
            // 
            this.botNameLbl.AutoSize = true;
            this.botNameLbl.Location = new System.Drawing.Point(327, 26);
            this.botNameLbl.Name = "botNameLbl";
            this.botNameLbl.Size = new System.Drawing.Size(25, 13);
            this.botNameLbl.TabIndex = 4;
            this.botNameLbl.Text = "Бот";
            // 
            // playerHpProgress
            // 
            this.playerHpProgress.Location = new System.Drawing.Point(30, 45);
            this.playerHpProgress.Name = "playerHpProgress";
            this.playerHpProgress.Size = new System.Drawing.Size(225, 10);
            this.playerHpProgress.Step = 1;
            this.playerHpProgress.TabIndex = 1;
            this.playerHpProgress.Value = 100;
            // 
            // botHpProgress
            // 
            this.botHpProgress.Location = new System.Drawing.Point(325, 45);
            this.botHpProgress.Name = "botHpProgress";
            this.botHpProgress.Size = new System.Drawing.Size(225, 10);
            this.botHpProgress.Step = 1;
            this.botHpProgress.TabIndex = 5;
            this.botHpProgress.Value = 100;
            // 
            // playerHpLbl
            // 
            this.playerHpLbl.AutoSize = true;
            this.playerHpLbl.Location = new System.Drawing.Point(88, 26);
            this.playerHpLbl.Name = "playerHpLbl";
            this.playerHpLbl.Size = new System.Drawing.Size(0, 13);
            this.playerHpLbl.TabIndex = 4;
            // 
            // botHpLbl
            // 
            this.botHpLbl.AutoSize = true;
            this.botHpLbl.Location = new System.Drawing.Point(358, 26);
            this.botHpLbl.Name = "botHpLbl";
            this.botHpLbl.Size = new System.Drawing.Size(0, 13);
            this.botHpLbl.TabIndex = 5;
            // 
            // blockLbl
            // 
            this.blockLbl.AutoSize = true;
            this.blockLbl.Location = new System.Drawing.Point(223, 73);
            this.blockLbl.Name = "blockLbl";
            this.blockLbl.Size = new System.Drawing.Size(32, 13);
            this.blockLbl.TabIndex = 7;
            this.blockLbl.Text = "Блок";
            // 
            // hitLbl
            // 
            this.hitLbl.AutoSize = true;
            this.hitLbl.Location = new System.Drawing.Point(322, 73);
            this.hitLbl.Name = "hitLbl";
            this.hitLbl.Size = new System.Drawing.Size(33, 13);
            this.hitLbl.TabIndex = 8;
            this.hitLbl.Text = "Удар";
            // 
            // blockBodyRadioBtn
            // 
            this.blockBodyRadioBtn.AutoSize = true;
            this.blockBodyRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockBodyRadioBtn.Location = new System.Drawing.Point(18, 44);
            this.blockBodyRadioBtn.Name = "blockBodyRadioBtn";
            this.blockBodyRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.blockBodyRadioBtn.TabIndex = 10;
            this.blockBodyRadioBtn.Text = "Корус";
            this.blockBodyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // blockLegsRadioBtn
            // 
            this.blockLegsRadioBtn.AutoSize = true;
            this.blockLegsRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockLegsRadioBtn.Location = new System.Drawing.Point(23, 70);
            this.blockLegsRadioBtn.Name = "blockLegsRadioBtn";
            this.blockLegsRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.blockLegsRadioBtn.TabIndex = 11;
            this.blockLegsRadioBtn.Text = "Ноги";
            this.blockLegsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // blockHeadRadioBtn
            // 
            this.blockHeadRadioBtn.AutoSize = true;
            this.blockHeadRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockHeadRadioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockHeadRadioBtn.Location = new System.Drawing.Point(12, 16);
            this.blockHeadRadioBtn.Name = "blockHeadRadioBtn";
            this.blockHeadRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.blockHeadRadioBtn.TabIndex = 9;
            this.blockHeadRadioBtn.Text = "Голова";
            this.blockHeadRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockHeadRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hitHeadRadioBtn
            // 
            this.hitHeadRadioBtn.AutoSize = true;
            this.hitHeadRadioBtn.Location = new System.Drawing.Point(13, 16);
            this.hitHeadRadioBtn.Name = "hitHeadRadioBtn";
            this.hitHeadRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.hitHeadRadioBtn.TabIndex = 12;
            this.hitHeadRadioBtn.Text = "Голова";
            this.hitHeadRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hitLegsRadioBtn
            // 
            this.hitLegsRadioBtn.AutoSize = true;
            this.hitLegsRadioBtn.Location = new System.Drawing.Point(13, 70);
            this.hitLegsRadioBtn.Name = "hitLegsRadioBtn";
            this.hitLegsRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.hitLegsRadioBtn.TabIndex = 14;
            this.hitLegsRadioBtn.Text = "Ноги";
            this.hitLegsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hitBodyRadioBtn
            // 
            this.hitBodyRadioBtn.AutoSize = true;
            this.hitBodyRadioBtn.Location = new System.Drawing.Point(13, 44);
            this.hitBodyRadioBtn.Name = "hitBodyRadioBtn";
            this.hitBodyRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.hitBodyRadioBtn.TabIndex = 13;
            this.hitBodyRadioBtn.Text = "Корпус";
            this.hitBodyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fightBtn
            // 
            this.fightBtn.Location = new System.Drawing.Point(252, 245);
            this.fightBtn.Name = "fightBtn";
            this.fightBtn.Size = new System.Drawing.Size(75, 23);
            this.fightBtn.TabIndex = 23;
            this.fightBtn.Text = "Бой";
            this.fightBtn.UseVisualStyleBackColor = true;
            this.fightBtn.Click += new System.EventHandler(this.FightBtn_Click);
            // 
            // blockGroupBox
            // 
            this.blockGroupBox.Controls.Add(this.blockHeadRadioBtn);
            this.blockGroupBox.Controls.Add(this.blockLegsRadioBtn);
            this.blockGroupBox.Controls.Add(this.blockBodyRadioBtn);
            this.blockGroupBox.Location = new System.Drawing.Point(168, 89);
            this.blockGroupBox.Name = "blockGroupBox";
            this.blockGroupBox.Size = new System.Drawing.Size(87, 105);
            this.blockGroupBox.TabIndex = 17;
            this.blockGroupBox.TabStop = false;
            // 
            // hitGroupBox
            // 
            this.hitGroupBox.Controls.Add(this.hitHeadRadioBtn);
            this.hitGroupBox.Controls.Add(this.hitLegsRadioBtn);
            this.hitGroupBox.Controls.Add(this.hitBodyRadioBtn);
            this.hitGroupBox.Location = new System.Drawing.Point(325, 89);
            this.hitGroupBox.Name = "hitGroupBox";
            this.hitGroupBox.Size = new System.Drawing.Size(88, 105);
            this.hitGroupBox.TabIndex = 18;
            this.hitGroupBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // playerArmorProgress
            // 
            this.playerArmorProgress.Location = new System.Drawing.Point(30, 255);
            this.playerArmorProgress.Maximum = 5;
            this.playerArmorProgress.Name = "playerArmorProgress";
            this.playerArmorProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerArmorProgress.Size = new System.Drawing.Size(145, 12);
            this.playerArmorProgress.TabIndex = 19;
            // 
            // playerStrengthProgress
            // 
            this.playerStrengthProgress.Location = new System.Drawing.Point(30, 223);
            this.playerStrengthProgress.Maximum = 5;
            this.playerStrengthProgress.Name = "playerStrengthProgress";
            this.playerStrengthProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerStrengthProgress.Size = new System.Drawing.Size(145, 12);
            this.playerStrengthProgress.Step = 1;
            this.playerStrengthProgress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Атака";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Защита";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Защита";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Атака";
            // 
            // botStrengthProgress
            // 
            this.botStrengthProgress.Location = new System.Drawing.Point(404, 223);
            this.botStrengthProgress.Maximum = 5;
            this.botStrengthProgress.Name = "botStrengthProgress";
            this.botStrengthProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botStrengthProgress.Size = new System.Drawing.Size(145, 12);
            this.botStrengthProgress.TabIndex = 25;
            // 
            // botArmorProgress
            // 
            this.botArmorProgress.Location = new System.Drawing.Point(404, 255);
            this.botArmorProgress.Maximum = 5;
            this.botArmorProgress.Name = "botArmorProgress";
            this.botArmorProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botArmorProgress.Size = new System.Drawing.Size(145, 12);
            this.botArmorProgress.TabIndex = 27;
            // 
            // playerArmorBtn
            // 
            this.playerArmorBtn.Location = new System.Drawing.Point(186, 248);
            this.playerArmorBtn.Name = "playerArmorBtn";
            this.playerArmorBtn.Size = new System.Drawing.Size(28, 20);
            this.playerArmorBtn.TabIndex = 21;
            this.playerArmorBtn.Text = "+1";
            this.playerArmorBtn.UseVisualStyleBackColor = true;
            this.playerArmorBtn.Click += new System.EventHandler(this.PlayerArmorBtn_Click);
            // 
            // playerStrengthBtn
            // 
            this.playerStrengthBtn.Location = new System.Drawing.Point(186, 216);
            this.playerStrengthBtn.Name = "playerStrengthBtn";
            this.playerStrengthBtn.Size = new System.Drawing.Size(28, 20);
            this.playerStrengthBtn.TabIndex = 20;
            this.playerStrengthBtn.Text = "+1";
            this.playerStrengthBtn.UseVisualStyleBackColor = true;
            this.playerStrengthBtn.Click += new System.EventHandler(this.PlayerStrengthBtn_Click);
            // 
            // bonusStatLbl
            // 
            this.bonusStatLbl.AutoSize = true;
            this.bonusStatLbl.Location = new System.Drawing.Point(192, 197);
            this.bonusStatLbl.Name = "bonusStatLbl";
            this.bonusStatLbl.Size = new System.Drawing.Size(0, 13);
            this.bonusStatLbl.TabIndex = 36;
            // 
            // playerStrengthLbl
            // 
            this.playerStrengthLbl.AutoSize = true;
            this.playerStrengthLbl.Location = new System.Drawing.Point(181, 222);
            this.playerStrengthLbl.Name = "playerStrengthLbl";
            this.playerStrengthLbl.Size = new System.Drawing.Size(0, 13);
            this.playerStrengthLbl.TabIndex = 37;
            this.playerStrengthLbl.Visible = false;
            // 
            // playerArmorLbl
            // 
            this.playerArmorLbl.AutoSize = true;
            this.playerArmorLbl.Location = new System.Drawing.Point(181, 254);
            this.playerArmorLbl.Name = "playerArmorLbl";
            this.playerArmorLbl.Size = new System.Drawing.Size(0, 13);
            this.playerArmorLbl.TabIndex = 38;
            this.playerArmorLbl.Visible = false;
            // 
            // botStrengthLbl
            // 
            this.botStrengthLbl.AutoSize = true;
            this.botStrengthLbl.Location = new System.Drawing.Point(388, 223);
            this.botStrengthLbl.Name = "botStrengthLbl";
            this.botStrengthLbl.Size = new System.Drawing.Size(0, 13);
            this.botStrengthLbl.TabIndex = 39;
            this.botStrengthLbl.Visible = false;
            // 
            // botArmorLbl
            // 
            this.botArmorLbl.AutoSize = true;
            this.botArmorLbl.Location = new System.Drawing.Point(388, 254);
            this.botArmorLbl.Name = "botArmorLbl";
            this.botArmorLbl.Size = new System.Drawing.Size(0, 13);
            this.botArmorLbl.TabIndex = 40;
            this.botArmorLbl.Visible = false;
            // 
            // nextBatleBtn
            // 
            this.nextBatleBtn.Enabled = false;
            this.nextBatleBtn.Location = new System.Drawing.Point(252, 215);
            this.nextBatleBtn.Name = "nextBatleBtn";
            this.nextBatleBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBatleBtn.TabIndex = 22;
            this.nextBatleBtn.Text = "След. раунд";
            this.nextBatleBtn.UseVisualStyleBackColor = true;
            this.nextBatleBtn.Click += new System.EventHandler(this.NextBatleBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(261, 33);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(58, 23);
            this.restartBtn.TabIndex = 3;
            this.restartBtn.Text = "Рестарт";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // autoHitCheckBox
            // 
            this.autoHitCheckBox.AutoSize = true;
            this.autoHitCheckBox.Location = new System.Drawing.Point(283, 179);
            this.autoHitCheckBox.Name = "autoHitCheckBox";
            this.autoHitCheckBox.Size = new System.Drawing.Size(15, 14);
            this.autoHitCheckBox.TabIndex = 15;
            this.autoHitCheckBox.UseVisualStyleBackColor = true;
            this.autoHitCheckBox.CheckedChanged += new System.EventHandler(this.autoHitCheckBox_CheckedChanged);
            this.autoHitCheckBox.MouseHover += new System.EventHandler(this.AutoHitcheckBox_MouseHover);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(474, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtLog
            // 
            this.txtLog.HideSelection = false;
            this.txtLog.Location = new System.Drawing.Point(30, 288);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(523, 251);
            this.txtLog.TabIndex = 28;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.autoHitCheckBox);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.nextBatleBtn);
            this.Controls.Add(this.botArmorLbl);
            this.Controls.Add(this.botStrengthLbl);
            this.Controls.Add(this.playerArmorLbl);
            this.Controls.Add(this.playerStrengthLbl);
            this.Controls.Add(this.bonusStatLbl);
            this.Controls.Add(this.playerArmorBtn);
            this.Controls.Add(this.playerStrengthBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botStrengthProgress);
            this.Controls.Add(this.botArmorProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerStrengthProgress);
            this.Controls.Add(this.playerArmorProgress);
            this.Controls.Add(this.hitGroupBox);
            this.Controls.Add(this.blockGroupBox);
            this.Controls.Add(this.fightBtn);
            this.Controls.Add(this.hitLbl);
            this.Controls.Add(this.blockLbl);
            this.Controls.Add(this.botHpLbl);
            this.Controls.Add(this.playerHpLbl);
            this.Controls.Add(this.botHpProgress);
            this.Controls.Add(this.playerHpProgress);
            this.Controls.Add(this.botNameLbl);
            this.Controls.Add(this.playerNameLbl);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Text = " Бойцовский клуб";
            this.blockGroupBox.ResumeLayout(false);
            this.blockGroupBox.PerformLayout();
            this.hitGroupBox.ResumeLayout(false);
            this.hitGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label botNameLbl;
        private System.Windows.Forms.ProgressBar playerHpProgress;
        private System.Windows.Forms.ProgressBar botHpProgress;
        private System.Windows.Forms.Label playerHpLbl;
        private System.Windows.Forms.Label botHpLbl;
        private System.Windows.Forms.Label blockLbl;
        private System.Windows.Forms.Label hitLbl;
        private System.Windows.Forms.RadioButton blockBodyRadioBtn;
        private System.Windows.Forms.RadioButton blockLegsRadioBtn;
        private System.Windows.Forms.RadioButton blockHeadRadioBtn;
        private System.Windows.Forms.RadioButton hitHeadRadioBtn;
        private System.Windows.Forms.RadioButton hitLegsRadioBtn;
        private System.Windows.Forms.RadioButton hitBodyRadioBtn;
        private System.Windows.Forms.Button fightBtn;
        private System.Windows.Forms.GroupBox blockGroupBox;
        private System.Windows.Forms.GroupBox hitGroupBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar playerArmorProgress;
        private System.Windows.Forms.ProgressBar playerStrengthProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar botStrengthProgress;
        private System.Windows.Forms.ProgressBar botArmorProgress;
        private System.Windows.Forms.Button playerArmorBtn;
        private System.Windows.Forms.Button playerStrengthBtn;
        private System.Windows.Forms.Label bonusStatLbl;
        private System.Windows.Forms.Label playerStrengthLbl;
        private System.Windows.Forms.Label playerArmorLbl;
        private System.Windows.Forms.Label botStrengthLbl;
        private System.Windows.Forms.Label botArmorLbl;
        private System.Windows.Forms.Button nextBatleBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.CheckBox autoHitCheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}

