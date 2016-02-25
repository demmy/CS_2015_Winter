namespace ISD_10
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBot = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.ProgressBar();
            this.bpBot = new System.Windows.Forms.ProgressBar();
            this.lblPlayerXp = new System.Windows.Forms.Label();
            this.lblBotXp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBodyBlock = new System.Windows.Forms.RadioButton();
            this.rbLegsBlock = new System.Windows.Forms.RadioButton();
            this.rbHeadBlock = new System.Windows.Forms.RadioButton();
            this.rbHeadFight = new System.Windows.Forms.RadioButton();
            this.rbLegsFight = new System.Windows.Forms.RadioButton();
            this.rbBodyFight = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.butFight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(27, 26);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Игрок";
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Location = new System.Drawing.Point(327, 26);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(25, 13);
            this.lblBot.TabIndex = 1;
            this.lblBot.Text = "Бот";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(30, 45);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(225, 10);
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.Value = 100;
            // 
            // bpBot
            // 
            this.bpBot.Location = new System.Drawing.Point(325, 45);
            this.bpBot.Name = "bpBot";
            this.bpBot.Size = new System.Drawing.Size(225, 10);
            this.bpBot.TabIndex = 3;
            this.bpBot.Value = 100;
            // 
            // lblPlayerXp
            // 
            this.lblPlayerXp.AutoSize = true;
            this.lblPlayerXp.Location = new System.Drawing.Point(71, 26);
            this.lblPlayerXp.Name = "lblPlayerXp";
            this.lblPlayerXp.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerXp.TabIndex = 4;
            // 
            // lblBotXp
            // 
            this.lblBotXp.AutoSize = true;
            this.lblBotXp.Location = new System.Drawing.Point(358, 26);
            this.lblBotXp.Name = "lblBotXp";
            this.lblBotXp.Size = new System.Drawing.Size(0, 13);
            this.lblBotXp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Блок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Удар";
            // 
            // rbBodyBlock
            // 
            this.rbBodyBlock.AutoSize = true;
            this.rbBodyBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBodyBlock.Location = new System.Drawing.Point(17, 66);
            this.rbBodyBlock.Name = "rbBodyBlock";
            this.rbBodyBlock.Size = new System.Drawing.Size(55, 17);
            this.rbBodyBlock.TabIndex = 9;
            this.rbBodyBlock.Text = "Корус";
            this.rbBodyBlock.UseVisualStyleBackColor = true;
            // 
            // rbLegsBlock
            // 
            this.rbLegsBlock.AutoSize = true;
            this.rbLegsBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbLegsBlock.Location = new System.Drawing.Point(21, 112);
            this.rbLegsBlock.Name = "rbLegsBlock";
            this.rbLegsBlock.Size = new System.Drawing.Size(50, 17);
            this.rbLegsBlock.TabIndex = 10;
            this.rbLegsBlock.Text = "Ноги";
            this.rbLegsBlock.UseVisualStyleBackColor = true;
            // 
            // rbHeadBlock
            // 
            this.rbHeadBlock.AutoSize = true;
            this.rbHeadBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.Location = new System.Drawing.Point(12, 16);
            this.rbHeadBlock.Name = "rbHeadBlock";
            this.rbHeadBlock.Size = new System.Drawing.Size(61, 17);
            this.rbHeadBlock.TabIndex = 11;
            this.rbHeadBlock.Text = "Голова";
            this.rbHeadBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.UseVisualStyleBackColor = true;
            // 
            // rbHeadFight
            // 
            this.rbHeadFight.AutoSize = true;
            this.rbHeadFight.Location = new System.Drawing.Point(13, 16);
            this.rbHeadFight.Name = "rbHeadFight";
            this.rbHeadFight.Size = new System.Drawing.Size(61, 17);
            this.rbHeadFight.TabIndex = 14;
            this.rbHeadFight.Text = "Голова";
            this.rbHeadFight.UseVisualStyleBackColor = true;
            // 
            // rbLegsFight
            // 
            this.rbLegsFight.AutoSize = true;
            this.rbLegsFight.Location = new System.Drawing.Point(13, 112);
            this.rbLegsFight.Name = "rbLegsFight";
            this.rbLegsFight.Size = new System.Drawing.Size(50, 17);
            this.rbLegsFight.TabIndex = 13;
            this.rbLegsFight.Text = "Ноги";
            this.rbLegsFight.UseVisualStyleBackColor = true;
            // 
            // rbBodyFight
            // 
            this.rbBodyFight.AutoSize = true;
            this.rbBodyFight.Location = new System.Drawing.Point(13, 65);
            this.rbBodyFight.Name = "rbBodyFight";
            this.rbBodyFight.Size = new System.Drawing.Size(61, 17);
            this.rbBodyFight.TabIndex = 12;
            this.rbBodyFight.Text = "Корпус";
            this.rbBodyFight.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(30, 280);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(519, 256);
            this.txtLog.TabIndex = 15;
            // 
            // butFight
            // 
            this.butFight.Location = new System.Drawing.Point(252, 245);
            this.butFight.Name = "butFight";
            this.butFight.Size = new System.Drawing.Size(75, 23);
            this.butFight.TabIndex = 16;
            this.butFight.Text = "Бой";
            this.butFight.UseVisualStyleBackColor = true;
            this.butFight.Click += new System.EventHandler(this.butFight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHeadBlock);
            this.groupBox1.Controls.Add(this.rbLegsBlock);
            this.groupBox1.Controls.Add(this.rbBodyBlock);
            this.groupBox1.Location = new System.Drawing.Point(168, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHeadFight);
            this.groupBox2.Controls.Add(this.rbLegsFight);
            this.groupBox2.Controls.Add(this.rbBodyFight);
            this.groupBox2.Location = new System.Drawing.Point(325, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 142);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butFight);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBotXp);
            this.Controls.Add(this.lblPlayerXp);
            this.Controls.Add(this.bpBot);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblBot);
            this.Controls.Add(this.lblPlayer);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.ProgressBar pbPlayer;
        private System.Windows.Forms.ProgressBar bpBot;
        private System.Windows.Forms.Label lblPlayerXp;
        private System.Windows.Forms.Label lblBotXp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBodyBlock;
        private System.Windows.Forms.RadioButton rbLegsBlock;
        private System.Windows.Forms.RadioButton rbHeadBlock;
        private System.Windows.Forms.RadioButton rbHeadFight;
        private System.Windows.Forms.RadioButton rbLegsFight;
        private System.Windows.Forms.RadioButton rbBodyFight;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button butFight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

