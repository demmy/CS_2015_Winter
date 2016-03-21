/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:59
 */
namespace Combats
{
    partial class BattleUserControl
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox BattlePage;
        private System.Windows.Forms.Panel RadioButtons;
        private System.Windows.Forms.Panel AttackPanel;
        private System.Windows.Forms.Panel BlockPanel;
        private System.Windows.Forms.Label TextAttackPanel;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Label TextBlockPanel;
        private System.Windows.Forms.Button NewBattle;
        private System.Windows.Forms.ProgressBar FirstPlayerHP;
        private System.Windows.Forms.PictureBox FirstPlayerInfo;
        private System.Windows.Forms.ProgressBar SecondPlayerHP;
        private System.Windows.Forms.PictureBox SecondPlayerInfo;
        private System.Windows.Forms.Label FirstPlayerName;
        private System.Windows.Forms.PictureBox SecondPlayerPhoto;
        private System.Windows.Forms.Label SecondPlayerName;
        private System.Windows.Forms.PictureBox FirstPlayerPhoto;
        private System.Windows.Forms.RichTextBox BattleLog;
        private System.Windows.Forms.Label BattleResult;
        
        /// <summary>
        /// Disposes resources used by the control.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleUserControl));
            this.BattlePage = new System.Windows.Forms.GroupBox();
            this.RadioButtons = new System.Windows.Forms.Panel();
            this.AttackPanel = new System.Windows.Forms.Panel();
            this.BlockPanel = new System.Windows.Forms.Panel();
            this.TextAttackPanel = new System.Windows.Forms.Label();
            this.Attack = new System.Windows.Forms.Button();
            this.TextBlockPanel = new System.Windows.Forms.Label();
            this.NewBattle = new System.Windows.Forms.Button();
            this.FirstPlayerHP = new System.Windows.Forms.ProgressBar();
            this.FirstPlayerInfo = new System.Windows.Forms.PictureBox();
            this.SecondPlayerHP = new System.Windows.Forms.ProgressBar();
            this.SecondPlayerInfo = new System.Windows.Forms.PictureBox();
            this.FirstPlayerName = new System.Windows.Forms.Label();
            this.SecondPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.SecondPlayerName = new System.Windows.Forms.Label();
            this.FirstPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.BattleLog = new System.Windows.Forms.RichTextBox();
            this.BattleResult = new System.Windows.Forms.Label();
            this.BattlePage.SuspendLayout();
            this.RadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPlayerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPlayerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPlayerPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPlayerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BattlePage
            // 
            this.BattlePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BattlePage.Controls.Add(this.RadioButtons);
            this.BattlePage.Controls.Add(this.NewBattle);
            this.BattlePage.Controls.Add(this.FirstPlayerHP);
            this.BattlePage.Controls.Add(this.FirstPlayerInfo);
            this.BattlePage.Controls.Add(this.SecondPlayerHP);
            this.BattlePage.Controls.Add(this.SecondPlayerInfo);
            this.BattlePage.Controls.Add(this.FirstPlayerName);
            this.BattlePage.Controls.Add(this.SecondPlayerPhoto);
            this.BattlePage.Controls.Add(this.SecondPlayerName);
            this.BattlePage.Controls.Add(this.FirstPlayerPhoto);
            this.BattlePage.Controls.Add(this.BattleLog);
            this.BattlePage.Controls.Add(this.BattleResult);
            this.BattlePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BattlePage.Location = new System.Drawing.Point(0, 0);
            this.BattlePage.Margin = new System.Windows.Forms.Padding(0);
            this.BattlePage.Name = "BattlePage";
            this.BattlePage.Padding = new System.Windows.Forms.Padding(5);
            this.BattlePage.Size = new System.Drawing.Size(800, 600);
            this.BattlePage.TabIndex = 14;
            this.BattlePage.TabStop = false;
            // 
            // RadioButtons
            // 
            this.RadioButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButtons.AutoSize = true;
            this.RadioButtons.Controls.Add(this.AttackPanel);
            this.RadioButtons.Controls.Add(this.BlockPanel);
            this.RadioButtons.Controls.Add(this.TextAttackPanel);
            this.RadioButtons.Controls.Add(this.Attack);
            this.RadioButtons.Controls.Add(this.TextBlockPanel);
            this.RadioButtons.Location = new System.Drawing.Point(280, 39);
            this.RadioButtons.MinimumSize = new System.Drawing.Size(240, 180);
            this.RadioButtons.Name = "RadioButtons";
            this.RadioButtons.Size = new System.Drawing.Size(240, 180);
            this.RadioButtons.TabIndex = 27;
            // 
            // AttackPanel
            // 
            this.AttackPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AttackPanel.AutoSize = true;
            this.AttackPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttackPanel.Location = new System.Drawing.Point(3, 53);
            this.AttackPanel.MinimumSize = new System.Drawing.Size(114, 122);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AttackPanel.Size = new System.Drawing.Size(114, 122);
            this.AttackPanel.TabIndex = 21;
            // 
            // BlockPanel
            // 
            this.BlockPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BlockPanel.AutoSize = true;
            this.BlockPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BlockPanel.Location = new System.Drawing.Point(123, 53);
            this.BlockPanel.MinimumSize = new System.Drawing.Size(114, 122);
            this.BlockPanel.Name = "BlockPanel";
            this.BlockPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlockPanel.Size = new System.Drawing.Size(114, 122);
            this.BlockPanel.TabIndex = 20;
            // 
            // TextAttackPanel
            // 
            this.TextAttackPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextAttackPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAttackPanel.Location = new System.Drawing.Point(3, 32);
            this.TextAttackPanel.Name = "TextAttackPanel";
            this.TextAttackPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TextAttackPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextAttackPanel.Size = new System.Drawing.Size(114, 18);
            this.TextAttackPanel.TabIndex = 23;
            this.TextAttackPanel.Text = "Атака";
            this.TextAttackPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Attack
            // 
            this.Attack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Attack.Location = new System.Drawing.Point(67, 6);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(107, 23);
            this.Attack.TabIndex = 24;
            this.Attack.Text = "Атаковать";
            this.Attack.UseVisualStyleBackColor = false;
            this.Attack.Click += new System.EventHandler(this.AttackClick);
            // 
            // TextBlockPanel
            // 
            this.TextBlockPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBlockPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBlockPanel.Location = new System.Drawing.Point(123, 32);
            this.TextBlockPanel.Name = "TextBlockPanel";
            this.TextBlockPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TextBlockPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBlockPanel.Size = new System.Drawing.Size(114, 18);
            this.TextBlockPanel.TabIndex = 22;
            this.TextBlockPanel.Text = "Блок";
            this.TextBlockPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewBattle
            // 
            this.NewBattle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewBattle.Location = new System.Drawing.Point(347, 339);
            this.NewBattle.MaximumSize = new System.Drawing.Size(107, 23);
            this.NewBattle.MinimumSize = new System.Drawing.Size(107, 23);
            this.NewBattle.Name = "NewBattle";
            this.NewBattle.Size = new System.Drawing.Size(107, 23);
            this.NewBattle.TabIndex = 25;
            this.NewBattle.Text = "Новый бой";
            this.NewBattle.UseVisualStyleBackColor = true;
            this.NewBattle.Visible = false;
            this.NewBattle.Click += new System.EventHandler(this.ButtonNewGameClick);
            // 
            // FirstPlayerHP
            // 
            this.FirstPlayerHP.ForeColor = System.Drawing.Color.Green;
            this.FirstPlayerHP.Location = new System.Drawing.Point(59, 34);
            this.FirstPlayerHP.Name = "FirstPlayerHP";
            this.FirstPlayerHP.Size = new System.Drawing.Size(128, 15);
            this.FirstPlayerHP.Step = 1;
            this.FirstPlayerHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FirstPlayerHP.TabIndex = 18;
            // 
            // FirstPlayerInfo
            // 
            this.FirstPlayerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstPlayerInfo.Image = ((System.Drawing.Image)(resources.GetObject("FirstPlayerInfo.Image")));
            this.FirstPlayerInfo.Location = new System.Drawing.Point(65, 19);
            this.FirstPlayerInfo.Name = "FirstPlayerInfo";
            this.FirstPlayerInfo.Size = new System.Drawing.Size(12, 11);
            this.FirstPlayerInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FirstPlayerInfo.TabIndex = 16;
            this.FirstPlayerInfo.TabStop = false;
            // 
            // SecondPlayerHP
            // 
            this.SecondPlayerHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondPlayerHP.ForeColor = System.Drawing.Color.Green;
            this.SecondPlayerHP.Location = new System.Drawing.Point(611, 34);
            this.SecondPlayerHP.Name = "SecondPlayerHP";
            this.SecondPlayerHP.Size = new System.Drawing.Size(128, 15);
            this.SecondPlayerHP.Step = 1;
            this.SecondPlayerHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SecondPlayerHP.TabIndex = 19;
            // 
            // SecondPlayerInfo
            // 
            this.SecondPlayerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondPlayerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondPlayerInfo.Image = ((System.Drawing.Image)(resources.GetObject("SecondPlayerInfo.Image")));
            this.SecondPlayerInfo.Location = new System.Drawing.Point(617, 19);
            this.SecondPlayerInfo.Name = "SecondPlayerInfo";
            this.SecondPlayerInfo.Size = new System.Drawing.Size(12, 11);
            this.SecondPlayerInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SecondPlayerInfo.TabIndex = 17;
            this.SecondPlayerInfo.TabStop = false;
            // 
            // FirstPlayerName
            // 
            this.FirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPlayerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstPlayerName.Location = new System.Drawing.Point(77, 17);
            this.FirstPlayerName.Name = "FirstPlayerName";
            this.FirstPlayerName.Size = new System.Drawing.Size(110, 14);
            this.FirstPlayerName.TabIndex = 12;
            this.FirstPlayerName.Text = "Player";
            this.FirstPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondPlayerPhoto
            // 
            this.SecondPlayerPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondPlayerPhoto.Image = ((System.Drawing.Image)(resources.GetObject("SecondPlayerPhoto.Image")));
            this.SecondPlayerPhoto.InitialImage = null;
            this.SecondPlayerPhoto.Location = new System.Drawing.Point(611, 55);
            this.SecondPlayerPhoto.Name = "SecondPlayerPhoto";
            this.SecondPlayerPhoto.Size = new System.Drawing.Size(128, 128);
            this.SecondPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SecondPlayerPhoto.TabIndex = 14;
            this.SecondPlayerPhoto.TabStop = false;
            // 
            // SecondPlayerName
            // 
            this.SecondPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPlayerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondPlayerName.Location = new System.Drawing.Point(629, 17);
            this.SecondPlayerName.Name = "SecondPlayerName";
            this.SecondPlayerName.Size = new System.Drawing.Size(110, 14);
            this.SecondPlayerName.TabIndex = 13;
            this.SecondPlayerName.Text = "Player";
            this.SecondPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstPlayerPhoto
            // 
            this.FirstPlayerPhoto.Image = ((System.Drawing.Image)(resources.GetObject("FirstPlayerPhoto.Image")));
            this.FirstPlayerPhoto.InitialImage = null;
            this.FirstPlayerPhoto.Location = new System.Drawing.Point(59, 55);
            this.FirstPlayerPhoto.Name = "FirstPlayerPhoto";
            this.FirstPlayerPhoto.Size = new System.Drawing.Size(128, 128);
            this.FirstPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FirstPlayerPhoto.TabIndex = 15;
            this.FirstPlayerPhoto.TabStop = false;
            // 
            // BattleLog
            // 
            this.BattleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BattleLog.Location = new System.Drawing.Point(8, 387);
            this.BattleLog.MinimumSize = new System.Drawing.Size(600, 162);
            this.BattleLog.Name = "BattleLog";
            this.BattleLog.Size = new System.Drawing.Size(784, 205);
            this.BattleLog.TabIndex = 11;
            this.BattleLog.Text = "";
            this.BattleLog.TextChanged += new System.EventHandler(this.BattleLogTextChanged);
            // 
            // BattleResult
            // 
            this.BattleResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BattleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleResult.ForeColor = System.Drawing.Color.Red;
            this.BattleResult.Location = new System.Drawing.Point(280, 93);
            this.BattleResult.Name = "BattleResult";
            this.BattleResult.Size = new System.Drawing.Size(240, 126);
            this.BattleResult.TabIndex = 28;
            this.BattleResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BattleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.BattlePage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BattleUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.BattlePage.ResumeLayout(false);
            this.BattlePage.PerformLayout();
            this.RadioButtons.ResumeLayout(false);
            this.RadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPlayerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPlayerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPlayerPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPlayerPhoto)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
