namespace ISD_13
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ValidEmailCB = new System.Windows.Forms.CheckBox();
            this.PlayerDGV = new System.Windows.Forms.DataGridView();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.AddNewPlayerBtn = new System.Windows.Forms.Button();
            this.TransactionsTab = new System.Windows.Forms.TabPage();
            this.TopTenBySummCB = new System.Windows.Forms.CheckBox();
            this.AddTransactiobBtn = new System.Windows.Forms.Button();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.CombatsTab = new System.Windows.Forms.TabPage();
            this.AddNewCombatBtn = new System.Windows.Forms.Button();
            this.CombatDGV = new System.Windows.Forms.DataGridView();
            this.HitsTab = new System.Windows.Forms.TabPage();
            this.AddNewHitBtn = new System.Windows.Forms.Button();
            this.HitDGV = new System.Windows.Forms.DataGridView();
            this.SelectedPlayerTxt = new System.Windows.Forms.TextBox();
            this.PlayerLbl = new System.Windows.Forms.Label();
            this.CombatIdLbl = new System.Windows.Forms.Label();
            this.SelectedCombatIdTxt = new System.Windows.Forms.TextBox();
            this.ResetFilterBtn = new System.Windows.Forms.Button();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.SaveStatusLbl = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatTypePVPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firstPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.secondPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).BeginInit();
            this.MainTab.SuspendLayout();
            this.PlayersTab.SuspendLayout();
            this.TransactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            this.CombatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).BeginInit();
            this.HitsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).BeginInit();
            this.filterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(713, 314);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ValidEmailCB
            // 
            this.ValidEmailCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidEmailCB.AutoSize = true;
            this.ValidEmailCB.Location = new System.Drawing.Point(690, 241);
            this.ValidEmailCB.Name = "ValidEmailCB";
            this.ValidEmailCB.Size = new System.Drawing.Size(76, 17);
            this.ValidEmailCB.TabIndex = 14;
            this.ValidEmailCB.Text = "Valid email";
            this.ValidEmailCB.UseVisualStyleBackColor = true;
            this.ValidEmailCB.CheckedChanged += new System.EventHandler(this.ValidEmailCB_CheckedChanged);
            // 
            // PlayerDGV
            // 
            this.PlayerDGV.AllowUserToAddRows = false;
            this.PlayerDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDGV.AutoGenerateColumns = false;
            this.PlayerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.eMailValidDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.PlayerDGV.DataSource = this.playerBindingSource;
            this.PlayerDGV.Location = new System.Drawing.Point(6, 6);
            this.PlayerDGV.Name = "PlayerDGV";
            this.PlayerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerDGV.Size = new System.Drawing.Size(760, 223);
            this.PlayerDGV.TabIndex = 16;
            this.PlayerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDGV_CellClick);
            this.PlayerDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.PlayerDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.PlayerDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RowRemoved);
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.PlayersTab);
            this.MainTab.Controls.Add(this.TransactionsTab);
            this.MainTab.Controls.Add(this.CombatsTab);
            this.MainTab.Controls.Add(this.HitsTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.MinimumSize = new System.Drawing.Size(780, 250);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(780, 290);
            this.MainTab.TabIndex = 17;
            this.MainTab.Click += new System.EventHandler(this.MainTab_Click);
            // 
            // PlayersTab
            // 
            this.PlayersTab.Controls.Add(this.AddNewPlayerBtn);
            this.PlayersTab.Controls.Add(this.PlayerDGV);
            this.PlayersTab.Controls.Add(this.ValidEmailCB);
            this.PlayersTab.Location = new System.Drawing.Point(4, 22);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTab.Size = new System.Drawing.Size(772, 264);
            this.PlayersTab.TabIndex = 0;
            this.PlayersTab.Text = "Players";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // AddNewPlayerBtn
            // 
            this.AddNewPlayerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewPlayerBtn.Location = new System.Drawing.Point(6, 236);
            this.AddNewPlayerBtn.Name = "AddNewPlayerBtn";
            this.AddNewPlayerBtn.Size = new System.Drawing.Size(119, 23);
            this.AddNewPlayerBtn.TabIndex = 17;
            this.AddNewPlayerBtn.Text = "Add new player";
            this.AddNewPlayerBtn.UseVisualStyleBackColor = true;
            this.AddNewPlayerBtn.Click += new System.EventHandler(this.AddNewPlayerBtn_Click);
            // 
            // TransactionsTab
            // 
            this.TransactionsTab.Controls.Add(this.TopTenBySummCB);
            this.TransactionsTab.Controls.Add(this.AddTransactiobBtn);
            this.TransactionsTab.Controls.Add(this.TransactionDGV);
            this.TransactionsTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionsTab.Name = "TransactionsTab";
            this.TransactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionsTab.Size = new System.Drawing.Size(772, 264);
            this.TransactionsTab.TabIndex = 1;
            this.TransactionsTab.Text = "Transactions";
            this.TransactionsTab.UseVisualStyleBackColor = true;
            // 
            // TopTenBySummCB
            // 
            this.TopTenBySummCB.AutoSize = true;
            this.TopTenBySummCB.Location = new System.Drawing.Point(648, 240);
            this.TopTenBySummCB.Name = "TopTenBySummCB";
            this.TopTenBySummCB.Size = new System.Drawing.Size(118, 17);
            this.TopTenBySummCB.TabIndex = 24;
            this.TopTenBySummCB.Text = "Top ten transaction";
            this.TopTenBySummCB.UseVisualStyleBackColor = true;
            this.TopTenBySummCB.CheckedChanged += new System.EventHandler(this.TopTenBySummCB_CheckedChanged);
            // 
            // AddTransactiobBtn
            // 
            this.AddTransactiobBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTransactiobBtn.Location = new System.Drawing.Point(6, 236);
            this.AddTransactiobBtn.Name = "AddTransactiobBtn";
            this.AddTransactiobBtn.Size = new System.Drawing.Size(145, 23);
            this.AddTransactiobBtn.TabIndex = 18;
            this.AddTransactiobBtn.Text = "Add new transaction";
            this.AddTransactiobBtn.UseVisualStyleBackColor = true;
            this.AddTransactiobBtn.Click += new System.EventHandler(this.AddTransactiobBtn_Click);
            // 
            // TransactionDGV
            // 
            this.TransactionDGV.AllowUserToAddRows = false;
            this.TransactionDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionDGV.AutoGenerateColumns = false;
            this.TransactionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.playerDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.TransactionDGV.DataSource = this.transactionBindingSource;
            this.TransactionDGV.Location = new System.Drawing.Point(6, 6);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionDGV.Size = new System.Drawing.Size(760, 224);
            this.TransactionDGV.TabIndex = 17;
            this.TransactionDGV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDGV_CellLeave);
            this.TransactionDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.TransactionDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.TransactionDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.TransactionDGV_EditingControlShowing);
            this.TransactionDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RowRemoved);
            // 
            // CombatsTab
            // 
            this.CombatsTab.Controls.Add(this.AddNewCombatBtn);
            this.CombatsTab.Controls.Add(this.CombatDGV);
            this.CombatsTab.Location = new System.Drawing.Point(4, 22);
            this.CombatsTab.Name = "CombatsTab";
            this.CombatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CombatsTab.Size = new System.Drawing.Size(772, 264);
            this.CombatsTab.TabIndex = 2;
            this.CombatsTab.Text = "Combats";
            this.CombatsTab.UseVisualStyleBackColor = true;
            // 
            // AddNewCombatBtn
            // 
            this.AddNewCombatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewCombatBtn.Location = new System.Drawing.Point(6, 236);
            this.AddNewCombatBtn.Name = "AddNewCombatBtn";
            this.AddNewCombatBtn.Size = new System.Drawing.Size(125, 23);
            this.AddNewCombatBtn.TabIndex = 18;
            this.AddNewCombatBtn.Text = "Add new combat";
            this.AddNewCombatBtn.UseVisualStyleBackColor = true;
            this.AddNewCombatBtn.Click += new System.EventHandler(this.AddNewCombatBtn_Click);
            // 
            // CombatDGV
            // 
            this.CombatDGV.AllowUserToAddRows = false;
            this.CombatDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatDGV.AutoGenerateColumns = false;
            this.CombatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CombatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CombatDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.combatTypePVPDataGridViewCheckBoxColumn,
            this.firstPlayerDataGridViewTextBoxColumn,
            this.secondPlayerDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.CombatDGV.DataSource = this.combatBindingSource;
            this.CombatDGV.Location = new System.Drawing.Point(6, 6);
            this.CombatDGV.Name = "CombatDGV";
            this.CombatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CombatDGV.Size = new System.Drawing.Size(760, 224);
            this.CombatDGV.TabIndex = 17;
            this.CombatDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CombatDGV_CellClick);
            this.CombatDGV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CombatDGV_CellLeave);
            this.CombatDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.CombatDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.CombatDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.CombatDGV_EditingControlShowing);
            this.CombatDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RowRemoved);
            // 
            // HitsTab
            // 
            this.HitsTab.Controls.Add(this.AddNewHitBtn);
            this.HitsTab.Controls.Add(this.HitDGV);
            this.HitsTab.Location = new System.Drawing.Point(4, 22);
            this.HitsTab.Name = "HitsTab";
            this.HitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.HitsTab.Size = new System.Drawing.Size(772, 264);
            this.HitsTab.TabIndex = 3;
            this.HitsTab.Text = "Hits";
            this.HitsTab.UseVisualStyleBackColor = true;
            // 
            // AddNewHitBtn
            // 
            this.AddNewHitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewHitBtn.Location = new System.Drawing.Point(6, 236);
            this.AddNewHitBtn.Name = "AddNewHitBtn";
            this.AddNewHitBtn.Size = new System.Drawing.Size(98, 23);
            this.AddNewHitBtn.TabIndex = 18;
            this.AddNewHitBtn.Text = "Add new hit";
            this.AddNewHitBtn.UseVisualStyleBackColor = true;
            this.AddNewHitBtn.Click += new System.EventHandler(this.AddNewHitBtn_Click);
            // 
            // HitDGV
            // 
            this.HitDGV.AllowUserToAddRows = false;
            this.HitDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HitDGV.AutoGenerateColumns = false;
            this.HitDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HitDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Combat,
            this.hitValueDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8});
            this.HitDGV.DataSource = this.hitLogBindingSource;
            this.HitDGV.Location = new System.Drawing.Point(6, 6);
            this.HitDGV.Name = "HitDGV";
            this.HitDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HitDGV.Size = new System.Drawing.Size(760, 224);
            this.HitDGV.TabIndex = 17;
            this.HitDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.HitDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.HitDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RowRemoved);
            // 
            // SelectedPlayerTxt
            // 
            this.SelectedPlayerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedPlayerTxt.Location = new System.Drawing.Point(102, 11);
            this.SelectedPlayerTxt.Name = "SelectedPlayerTxt";
            this.SelectedPlayerTxt.Size = new System.Drawing.Size(144, 20);
            this.SelectedPlayerTxt.TabIndex = 18;
            this.SelectedPlayerTxt.Click += new System.EventHandler(this.CurrentPlayerTxt_Click);
            this.SelectedPlayerTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CurrentPlayerTxt_KeyUp);
            // 
            // PlayerLbl
            // 
            this.PlayerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayerLbl.AutoSize = true;
            this.PlayerLbl.Location = new System.Drawing.Point(12, 14);
            this.PlayerLbl.Name = "PlayerLbl";
            this.PlayerLbl.Size = new System.Drawing.Size(86, 13);
            this.PlayerLbl.TabIndex = 19;
            this.PlayerLbl.Text = "Selected player :";
            // 
            // CombatIdLbl
            // 
            this.CombatIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombatIdLbl.AutoSize = true;
            this.CombatIdLbl.Location = new System.Drawing.Point(260, 14);
            this.CombatIdLbl.Name = "CombatIdLbl";
            this.CombatIdLbl.Size = new System.Drawing.Size(108, 13);
            this.CombatIdLbl.TabIndex = 21;
            this.CombatIdLbl.Text = "Selected combat(Id) :";
            // 
            // SelectedCombatIdTxt
            // 
            this.SelectedCombatIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedCombatIdTxt.Location = new System.Drawing.Point(374, 11);
            this.SelectedCombatIdTxt.Name = "SelectedCombatIdTxt";
            this.SelectedCombatIdTxt.Size = new System.Drawing.Size(144, 20);
            this.SelectedCombatIdTxt.TabIndex = 20;
            this.SelectedCombatIdTxt.Click += new System.EventHandler(this.CurrentCombatIdTxt_Click);
            this.SelectedCombatIdTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CurrentCombatIdTxt_KeyUp);
            // 
            // ResetFilterBtn
            // 
            this.ResetFilterBtn.Location = new System.Drawing.Point(542, 9);
            this.ResetFilterBtn.Name = "ResetFilterBtn";
            this.ResetFilterBtn.Size = new System.Drawing.Size(95, 23);
            this.ResetFilterBtn.TabIndex = 22;
            this.ResetFilterBtn.Text = "Reset Filter";
            this.ResetFilterBtn.UseVisualStyleBackColor = true;
            this.ResetFilterBtn.Click += new System.EventHandler(this.resetFilterBtn_Click);
            // 
            // filterGroup
            // 
            this.filterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterGroup.Controls.Add(this.ResetFilterBtn);
            this.filterGroup.Controls.Add(this.SelectedPlayerTxt);
            this.filterGroup.Controls.Add(this.PlayerLbl);
            this.filterGroup.Controls.Add(this.CombatIdLbl);
            this.filterGroup.Controls.Add(this.SelectedCombatIdTxt);
            this.filterGroup.Location = new System.Drawing.Point(12, 306);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(649, 37);
            this.filterGroup.TabIndex = 23;
            this.filterGroup.TabStop = false;
            // 
            // SaveStatusLbl
            // 
            this.SaveStatusLbl.AutoSize = true;
            this.SaveStatusLbl.Location = new System.Drawing.Point(12, 351);
            this.SaveStatusLbl.Name = "SaveStatusLbl";
            this.SaveStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.SaveStatusLbl.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // eMailValidDataGridViewCheckBoxColumn
            // 
            this.eMailValidDataGridViewCheckBoxColumn.DataPropertyName = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn.HeaderText = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn.Name = "eMailValidDataGridViewCheckBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ISD_13.Data.Player);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            this.playerDataGridViewTextBoxColumn.DataSource = this.playerBindingSource;
            this.playerDataGridViewTextBoxColumn.DisplayMember = "Login";
            this.playerDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerDataGridViewTextBoxColumn.HeaderText = "Player";
            this.playerDataGridViewTextBoxColumn.MaxDropDownItems = 3;
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            this.playerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(ISD_13.Data.Transaction);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // combatTypePVPDataGridViewCheckBoxColumn
            // 
            this.combatTypePVPDataGridViewCheckBoxColumn.DataPropertyName = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.HeaderText = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.Name = "combatTypePVPDataGridViewCheckBoxColumn";
            // 
            // firstPlayerDataGridViewTextBoxColumn
            // 
            this.firstPlayerDataGridViewTextBoxColumn.DataPropertyName = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.DataSource = this.playerBindingSource;
            this.firstPlayerDataGridViewTextBoxColumn.DisplayMember = "Login";
            this.firstPlayerDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firstPlayerDataGridViewTextBoxColumn.HeaderText = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.Name = "firstPlayerDataGridViewTextBoxColumn";
            this.firstPlayerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.firstPlayerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.firstPlayerDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // secondPlayerDataGridViewTextBoxColumn
            // 
            this.secondPlayerDataGridViewTextBoxColumn.DataPropertyName = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.DataSource = this.playerBindingSource;
            this.secondPlayerDataGridViewTextBoxColumn.DisplayMember = "Login";
            this.secondPlayerDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondPlayerDataGridViewTextBoxColumn.HeaderText = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.Name = "secondPlayerDataGridViewTextBoxColumn";
            this.secondPlayerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secondPlayerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secondPlayerDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewTextBoxColumn.DataSource = this.playerBindingSource;
            this.winnerDataGridViewTextBoxColumn.DisplayMember = "Login";
            this.winnerDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.winnerDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            this.winnerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.winnerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.winnerDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // combatBindingSource
            // 
            this.combatBindingSource.DataSource = typeof(ISD_13.Data.Combat);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Combat
            // 
            this.Combat.DataPropertyName = "Combat";
            this.Combat.HeaderText = "Combat";
            this.Combat.Name = "Combat";
            this.Combat.ReadOnly = true;
            // 
            // hitValueDataGridViewTextBoxColumn
            // 
            this.hitValueDataGridViewTextBoxColumn.DataPropertyName = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.HeaderText = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.Name = "hitValueDataGridViewTextBoxColumn";
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Part";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            this.partDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // hitLogBindingSource
            // 
            this.hitLogBindingSource.DataSource = typeof(ISD_13.Data.HitLog);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 373);
            this.Controls.Add(this.SaveStatusLbl);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.SaveBtn);
            this.MinimumSize = new System.Drawing.Size(820, 370);
            this.Name = "MainForm";
            this.Text = "Combats";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.PlayersTab.ResumeLayout(false);
            this.PlayersTab.PerformLayout();
            this.TransactionsTab.ResumeLayout(false);
            this.TransactionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            this.CombatsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).EndInit();
            this.HitsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).EndInit();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox ValidEmailCB;
        private System.Windows.Forms.DataGridView PlayerDGV;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage PlayersTab;
        private System.Windows.Forms.TabPage TransactionsTab;
        private System.Windows.Forms.TabPage CombatsTab;
        private System.Windows.Forms.TabPage HitsTab;
        private System.Windows.Forms.DataGridView TransactionDGV;
        private System.Windows.Forms.DataGridView CombatDGV;
        private System.Windows.Forms.DataGridView HitDGV;
        private System.Windows.Forms.BindingSource combatBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource hitLogBindingSource;
        private System.Windows.Forms.TextBox SelectedPlayerTxt;
        private System.Windows.Forms.Label PlayerLbl;
        private System.Windows.Forms.Label CombatIdLbl;
        private System.Windows.Forms.TextBox SelectedCombatIdTxt;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button ResetFilterBtn;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Button AddTransactiobBtn;
        private System.Windows.Forms.Button AddNewCombatBtn;
        private System.Windows.Forms.Button AddNewHitBtn;
        private System.Windows.Forms.Button AddNewPlayerBtn;
        private System.Windows.Forms.CheckBox TopTenBySummCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label SaveStatusLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combatTypePVPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn firstPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secondPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn winnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}

