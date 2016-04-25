namespace EfWinform
{
    partial class RatingForm
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
            this.CombatControl = new System.Windows.Forms.TabControl();
            this.PlayersPage = new System.Windows.Forms.TabPage();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.playersOrderDateRdBtn = new System.Windows.Forms.RadioButton();
            this.playersTopLongPasswdRdBtn = new System.Windows.Forms.RadioButton();
            this.playersValidEmailRdBtn = new System.Windows.Forms.RadioButton();
            this.dataPlayersGridView = new System.Windows.Forms.DataGridView();
            this.CombatsPage = new System.Windows.Forms.TabPage();
            this.combatsPanel = new System.Windows.Forms.Panel();
            this.pvpsRdBtn = new System.Windows.Forms.RadioButton();
            this.pvesRdbtn = new System.Windows.Forms.RadioButton();
            this.winnersRdBtn = new System.Windows.Forms.RadioButton();
            this.dataCombatsGridView = new System.Windows.Forms.DataGridView();
            this.TransactionsPage = new System.Windows.Forms.TabPage();
            this.TransactionsPanel = new System.Windows.Forms.Panel();
            this.transactionsOrderDateRdBtn = new System.Windows.Forms.RadioButton();
            this.transactionsTopSumRdBtn = new System.Windows.Forms.RadioButton();
            this.dataTransactionsGridView = new System.Windows.Forms.DataGridView();
            this.HitLogPage = new System.Windows.Forms.TabPage();
            this.dataHitLogsGridView = new System.Windows.Forms.DataGridView();
            this.showBtn = new System.Windows.Forms.Button();
            this.CombatControl.SuspendLayout();
            this.PlayersPage.SuspendLayout();
            this.playersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlayersGridView)).BeginInit();
            this.CombatsPage.SuspendLayout();
            this.combatsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCombatsGridView)).BeginInit();
            this.TransactionsPage.SuspendLayout();
            this.TransactionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactionsGridView)).BeginInit();
            this.HitLogPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHitLogsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CombatControl
            // 
            this.CombatControl.Controls.Add(this.PlayersPage);
            this.CombatControl.Controls.Add(this.CombatsPage);
            this.CombatControl.Controls.Add(this.TransactionsPage);
            this.CombatControl.Controls.Add(this.HitLogPage);
            this.CombatControl.Location = new System.Drawing.Point(10, 12);
            this.CombatControl.Name = "CombatControl";
            this.CombatControl.SelectedIndex = 0;
            this.CombatControl.Size = new System.Drawing.Size(783, 328);
            this.CombatControl.TabIndex = 18;
            // 
            // PlayersPage
            // 
            this.PlayersPage.Controls.Add(this.playersPanel);
            this.PlayersPage.Controls.Add(this.dataPlayersGridView);
            this.PlayersPage.Location = new System.Drawing.Point(4, 22);
            this.PlayersPage.Name = "PlayersPage";
            this.PlayersPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersPage.Size = new System.Drawing.Size(775, 302);
            this.PlayersPage.TabIndex = 0;
            this.PlayersPage.Text = "Players";
            this.PlayersPage.UseVisualStyleBackColor = true;
            // 
            // playersPanel
            // 
            this.playersPanel.Controls.Add(this.playersOrderDateRdBtn);
            this.playersPanel.Controls.Add(this.playersTopLongPasswdRdBtn);
            this.playersPanel.Controls.Add(this.playersValidEmailRdBtn);
            this.playersPanel.Location = new System.Drawing.Point(501, 17);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(216, 118);
            this.playersPanel.TabIndex = 18;
            // 
            // playersOrderDateRdBtn
            // 
            this.playersOrderDateRdBtn.AutoSize = true;
            this.playersOrderDateRdBtn.Location = new System.Drawing.Point(22, 84);
            this.playersOrderDateRdBtn.Name = "playersOrderDateRdBtn";
            this.playersOrderDateRdBtn.Size = new System.Drawing.Size(94, 17);
            this.playersOrderDateRdBtn.TabIndex = 18;
            this.playersOrderDateRdBtn.TabStop = true;
            this.playersOrderDateRdBtn.Text = "Order  by Date";
            this.playersOrderDateRdBtn.UseVisualStyleBackColor = true;
            this.playersOrderDateRdBtn.CheckedChanged += new System.EventHandler(this.playersOrderDateRdBtn_CheckedChanged);
            // 
            // playersTopLongPasswdRdBtn
            // 
            this.playersTopLongPasswdRdBtn.AutoSize = true;
            this.playersTopLongPasswdRdBtn.Location = new System.Drawing.Point(22, 46);
            this.playersTopLongPasswdRdBtn.Name = "playersTopLongPasswdRdBtn";
            this.playersTopLongPasswdRdBtn.Size = new System.Drawing.Size(151, 17);
            this.playersTopLongPasswdRdBtn.TabIndex = 17;
            this.playersTopLongPasswdRdBtn.TabStop = true;
            this.playersTopLongPasswdRdBtn.Text = "Top  by Longest Password";
            this.playersTopLongPasswdRdBtn.UseVisualStyleBackColor = true;
            this.playersTopLongPasswdRdBtn.CheckedChanged += new System.EventHandler(this.playersTopLongPasswdRdBtn_CheckedChanged);
            // 
            // playersValidEmailRdBtn
            // 
            this.playersValidEmailRdBtn.AutoSize = true;
            this.playersValidEmailRdBtn.Location = new System.Drawing.Point(22, 12);
            this.playersValidEmailRdBtn.Name = "playersValidEmailRdBtn";
            this.playersValidEmailRdBtn.Size = new System.Drawing.Size(135, 17);
            this.playersValidEmailRdBtn.TabIndex = 16;
            this.playersValidEmailRdBtn.TabStop = true;
            this.playersValidEmailRdBtn.Text = "Players with Valid Email";
            this.playersValidEmailRdBtn.UseVisualStyleBackColor = true;
            this.playersValidEmailRdBtn.CheckedChanged += new System.EventHandler(this.playersValidEmailRdBtn_CheckedChanged);
            // 
            // dataPlayersGridView
            // 
            this.dataPlayersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlayersGridView.Location = new System.Drawing.Point(16, 17);
            this.dataPlayersGridView.Name = "dataPlayersGridView";
            this.dataPlayersGridView.Size = new System.Drawing.Size(468, 265);
            this.dataPlayersGridView.TabIndex = 9;
            // 
            // CombatsPage
            // 
            this.CombatsPage.Controls.Add(this.combatsPanel);
            this.CombatsPage.Controls.Add(this.dataCombatsGridView);
            this.CombatsPage.Location = new System.Drawing.Point(4, 22);
            this.CombatsPage.Name = "CombatsPage";
            this.CombatsPage.Padding = new System.Windows.Forms.Padding(3);
            this.CombatsPage.Size = new System.Drawing.Size(775, 302);
            this.CombatsPage.TabIndex = 1;
            this.CombatsPage.Text = "Combats";
            this.CombatsPage.UseVisualStyleBackColor = true;
            // 
            // combatsPanel
            // 
            this.combatsPanel.Controls.Add(this.pvpsRdBtn);
            this.combatsPanel.Controls.Add(this.pvesRdbtn);
            this.combatsPanel.Controls.Add(this.winnersRdBtn);
            this.combatsPanel.Location = new System.Drawing.Point(501, 17);
            this.combatsPanel.Name = "combatsPanel";
            this.combatsPanel.Size = new System.Drawing.Size(216, 265);
            this.combatsPanel.TabIndex = 19;
            // 
            // pvpsRdBtn
            // 
            this.pvpsRdBtn.AutoSize = true;
            this.pvpsRdBtn.Location = new System.Drawing.Point(22, 100);
            this.pvpsRdBtn.Name = "pvpsRdBtn";
            this.pvpsRdBtn.Size = new System.Drawing.Size(49, 17);
            this.pvpsRdBtn.TabIndex = 18;
            this.pvpsRdBtn.TabStop = true;
            this.pvpsRdBtn.Text = "Pvps";
            this.pvpsRdBtn.UseVisualStyleBackColor = true;
            this.pvpsRdBtn.CheckedChanged += new System.EventHandler(this.pvpsRdBtn_CheckedChanged);
            // 
            // pvesRdbtn
            // 
            this.pvesRdbtn.AutoSize = true;
            this.pvesRdbtn.Location = new System.Drawing.Point(22, 62);
            this.pvesRdbtn.Name = "pvesRdbtn";
            this.pvesRdbtn.Size = new System.Drawing.Size(49, 17);
            this.pvesRdbtn.TabIndex = 17;
            this.pvesRdbtn.TabStop = true;
            this.pvesRdbtn.Text = "Pves";
            this.pvesRdbtn.UseVisualStyleBackColor = true;
            this.pvesRdbtn.CheckedChanged += new System.EventHandler(this.pvesRdbtn_CheckedChanged);
            // 
            // winnersRdBtn
            // 
            this.winnersRdBtn.AutoSize = true;
            this.winnersRdBtn.Location = new System.Drawing.Point(22, 27);
            this.winnersRdBtn.Name = "winnersRdBtn";
            this.winnersRdBtn.Size = new System.Drawing.Size(64, 17);
            this.winnersRdBtn.TabIndex = 16;
            this.winnersRdBtn.TabStop = true;
            this.winnersRdBtn.Text = "Winners";
            this.winnersRdBtn.UseVisualStyleBackColor = true;
            this.winnersRdBtn.CheckedChanged += new System.EventHandler(this.winnersRdBtn_CheckedChanged);
            // 
            // dataCombatsGridView
            // 
            this.dataCombatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCombatsGridView.Location = new System.Drawing.Point(16, 17);
            this.dataCombatsGridView.Name = "dataCombatsGridView";
            this.dataCombatsGridView.Size = new System.Drawing.Size(468, 265);
            this.dataCombatsGridView.TabIndex = 10;
            // 
            // TransactionsPage
            // 
            this.TransactionsPage.Controls.Add(this.TransactionsPanel);
            this.TransactionsPage.Controls.Add(this.dataTransactionsGridView);
            this.TransactionsPage.Location = new System.Drawing.Point(4, 22);
            this.TransactionsPage.Name = "TransactionsPage";
            this.TransactionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionsPage.Size = new System.Drawing.Size(775, 302);
            this.TransactionsPage.TabIndex = 2;
            this.TransactionsPage.Text = "Transactions";
            this.TransactionsPage.UseVisualStyleBackColor = true;
            // 
            // TransactionsPanel
            // 
            this.TransactionsPanel.Controls.Add(this.transactionsOrderDateRdBtn);
            this.TransactionsPanel.Controls.Add(this.transactionsTopSumRdBtn);
            this.TransactionsPanel.Location = new System.Drawing.Point(496, 19);
            this.TransactionsPanel.Name = "TransactionsPanel";
            this.TransactionsPanel.Size = new System.Drawing.Size(218, 264);
            this.TransactionsPanel.TabIndex = 17;
            // 
            // transactionsOrderDateRdBtn
            // 
            this.transactionsOrderDateRdBtn.AutoSize = true;
            this.transactionsOrderDateRdBtn.Location = new System.Drawing.Point(16, 60);
            this.transactionsOrderDateRdBtn.Name = "transactionsOrderDateRdBtn";
            this.transactionsOrderDateRdBtn.Size = new System.Drawing.Size(94, 17);
            this.transactionsOrderDateRdBtn.TabIndex = 16;
            this.transactionsOrderDateRdBtn.TabStop = true;
            this.transactionsOrderDateRdBtn.Text = "Order  by Date";
            this.transactionsOrderDateRdBtn.UseVisualStyleBackColor = true;
            this.transactionsOrderDateRdBtn.CheckedChanged += new System.EventHandler(this.transactionsOrderDateRdBtn_CheckedChanged);
            // 
            // transactionsTopSumRdBtn
            // 
            this.transactionsTopSumRdBtn.AutoSize = true;
            this.transactionsTopSumRdBtn.Location = new System.Drawing.Point(16, 26);
            this.transactionsTopSumRdBtn.Name = "transactionsTopSumRdBtn";
            this.transactionsTopSumRdBtn.Size = new System.Drawing.Size(100, 17);
            this.transactionsTopSumRdBtn.TabIndex = 15;
            this.transactionsTopSumRdBtn.TabStop = true;
            this.transactionsTopSumRdBtn.Text = "Top  3   by Sum";
            this.transactionsTopSumRdBtn.UseVisualStyleBackColor = true;
            this.transactionsTopSumRdBtn.CheckedChanged += new System.EventHandler(this.transactionsTopSumRdBtn_CheckedChanged);
            // 
            // dataTransactionsGridView
            // 
            this.dataTransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactionsGridView.Location = new System.Drawing.Point(16, 19);
            this.dataTransactionsGridView.Name = "dataTransactionsGridView";
            this.dataTransactionsGridView.Size = new System.Drawing.Size(463, 264);
            this.dataTransactionsGridView.TabIndex = 16;
            // 
            // HitLogPage
            // 
            this.HitLogPage.AutoScroll = true;
            this.HitLogPage.Controls.Add(this.showBtn);
            this.HitLogPage.Controls.Add(this.dataHitLogsGridView);
            this.HitLogPage.Location = new System.Drawing.Point(4, 22);
            this.HitLogPage.Name = "HitLogPage";
            this.HitLogPage.Size = new System.Drawing.Size(775, 302);
            this.HitLogPage.TabIndex = 3;
            this.HitLogPage.Text = "HitLog";
            this.HitLogPage.UseVisualStyleBackColor = true;
            // 
            // dataHitLogsGridView
            // 
            this.dataHitLogsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHitLogsGridView.Location = new System.Drawing.Point(17, 19);
            this.dataHitLogsGridView.Name = "dataHitLogsGridView";
            this.dataHitLogsGridView.Size = new System.Drawing.Size(543, 264);
            this.dataHitLogsGridView.TabIndex = 0;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(633, 134);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 355);
            this.Controls.Add(this.CombatControl);
            this.Name = "RatingForm";
            this.Text = "RatingForm";
            this.CombatControl.ResumeLayout(false);
            this.PlayersPage.ResumeLayout(false);
            this.playersPanel.ResumeLayout(false);
            this.playersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlayersGridView)).EndInit();
            this.CombatsPage.ResumeLayout(false);
            this.combatsPanel.ResumeLayout(false);
            this.combatsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCombatsGridView)).EndInit();
            this.TransactionsPage.ResumeLayout(false);
            this.TransactionsPanel.ResumeLayout(false);
            this.TransactionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactionsGridView)).EndInit();
            this.HitLogPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHitLogsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CombatControl;
        private System.Windows.Forms.TabPage PlayersPage;
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.RadioButton playersOrderDateRdBtn;
        private System.Windows.Forms.RadioButton playersTopLongPasswdRdBtn;
        private System.Windows.Forms.RadioButton playersValidEmailRdBtn;
        private System.Windows.Forms.DataGridView dataPlayersGridView;
        private System.Windows.Forms.TabPage CombatsPage;
        private System.Windows.Forms.Panel combatsPanel;
        private System.Windows.Forms.RadioButton pvpsRdBtn;
        private System.Windows.Forms.RadioButton pvesRdbtn;
        private System.Windows.Forms.RadioButton winnersRdBtn;
        private System.Windows.Forms.DataGridView dataCombatsGridView;
        private System.Windows.Forms.TabPage TransactionsPage;
        private System.Windows.Forms.Panel TransactionsPanel;
        private System.Windows.Forms.RadioButton transactionsOrderDateRdBtn;
        private System.Windows.Forms.RadioButton transactionsTopSumRdBtn;
        private System.Windows.Forms.DataGridView dataTransactionsGridView;
        private System.Windows.Forms.TabPage HitLogPage;
        private System.Windows.Forms.DataGridView dataHitLogsGridView;
        private System.Windows.Forms.Button showBtn;
    }
}