namespace CombatsDataViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox selectDbSever;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RadioButton setExternalDB;
        private System.Windows.Forms.RadioButton setLocalDB;
        private System.Windows.Forms.DataGridView usersList;
        private System.Windows.Forms.DataGridView userBattlesList;
        private System.Windows.Forms.GroupBox usersTable;
        private System.Windows.Forms.GroupBox userTransactionTable;
        private System.Windows.Forms.DataGridView userTransactionList;
        private System.Windows.Forms.GroupBox userBattlesTab;
        private System.Windows.Forms.GroupBox userForm;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label CharacterIdText;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label UserIdText;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.CheckBox isEmailValid;
        private System.Windows.Forms.Label UserEmailText;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label UserPasswordText;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label UserLoginText;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.GroupBox charStatistic;
        private System.Windows.Forms.GroupBox filtersTable;
        private System.Windows.Forms.Label TransactionsLabel;
        private System.Windows.Forms.Button sortTransactionsByMaxSum;
        private System.Windows.Forms.DataGridView charStatTable;
        private System.Windows.Forms.Button WinBattles;
        private System.Windows.Forms.Button doAutoSearch;
        private System.Windows.Forms.TextBox userSearch;
        private System.Windows.Forms.ComboBox usersFilter;
        private System.Windows.Forms.GroupBox usersFilterTable;
        private System.Windows.Forms.Button clearFilter;
        private System.Windows.Forms.Label BattlesLabel;
        
        /// <summary>
        /// Disposes resources used by the form.
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
            this.usersFilter = new System.Windows.Forms.ComboBox();
            this.doAutoSearch = new System.Windows.Forms.Button();
            this.userSearch = new System.Windows.Forms.TextBox();
            this.selectDbSever = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.setExternalDB = new System.Windows.Forms.RadioButton();
            this.setLocalDB = new System.Windows.Forms.RadioButton();
            this.usersTable = new System.Windows.Forms.GroupBox();
            this.usersList = new System.Windows.Forms.DataGridView();
            this.userTransactionTable = new System.Windows.Forms.GroupBox();
            this.userTransactionList = new System.Windows.Forms.DataGridView();
            this.userBattlesTab = new System.Windows.Forms.GroupBox();
            this.userBattlesList = new System.Windows.Forms.DataGridView();
            this.userForm = new System.Windows.Forms.GroupBox();
            this.CancelUserEdit = new System.Windows.Forms.Button();
            this.DateText = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.CharacterIdText = new System.Windows.Forms.Label();
            this.UserIdText = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.isEmailValid = new System.Windows.Forms.CheckBox();
            this.UserEmailText = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.UserPasswordText = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.UserLoginText = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.charStatistic = new System.Windows.Forms.GroupBox();
            this.charStatTable = new System.Windows.Forms.DataGridView();
            this.filtersTable = new System.Windows.Forms.GroupBox();
            this.DrawBattles = new System.Windows.Forms.Button();
            this.LoseBattles = new System.Windows.Forms.Button();
            this.WinBattles = new System.Windows.Forms.Button();
            this.BattlesLabel = new System.Windows.Forms.Label();
            this.lastFiveItems = new System.Windows.Forms.Button();
            this.sortTransactionsByMaxSum = new System.Windows.Forms.Button();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.usersFilterTable = new System.Windows.Forms.GroupBox();
            this.clearFilter = new System.Windows.Forms.Button();
            this.userTransactionForm = new System.Windows.Forms.GroupBox();
            this.deleteUserTransaction = new System.Windows.Forms.Button();
            this.cancelTransactionEdit = new System.Windows.Forms.Button();
            this.editUserTransaction = new System.Windows.Forms.Button();
            this.transactionSumText = new System.Windows.Forms.Label();
            this.transactionDescriptionText = new System.Windows.Forms.Label();
            this.addUserTransaction = new System.Windows.Forms.Button();
            this.transactionUserText = new System.Windows.Forms.Label();
            this.transactionDateText = new System.Windows.Forms.Label();
            this.transactionIdText = new System.Windows.Forms.Label();
            this.transactionSum = new System.Windows.Forms.TextBox();
            this.transactionDescription = new System.Windows.Forms.TextBox();
            this.transactionUser = new System.Windows.Forms.TextBox();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.transactionId = new System.Windows.Forms.TextBox();
            this.selectDbSever.SuspendLayout();
            this.usersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
            this.userTransactionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionList)).BeginInit();
            this.userBattlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBattlesList)).BeginInit();
            this.userForm.SuspendLayout();
            this.charStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charStatTable)).BeginInit();
            this.filtersTable.SuspendLayout();
            this.usersFilterTable.SuspendLayout();
            this.userTransactionForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersFilter
            // 
            this.usersFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersFilter.FormattingEnabled = true;
            this.usersFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usersFilter.Location = new System.Drawing.Point(6, 42);
            this.usersFilter.Name = "usersFilter";
            this.usersFilter.Size = new System.Drawing.Size(141, 21);
            this.usersFilter.TabIndex = 4;
            // 
            // doAutoSearch
            // 
            this.doAutoSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doAutoSearch.Location = new System.Drawing.Point(105, 17);
            this.doAutoSearch.Name = "doAutoSearch";
            this.doAutoSearch.Size = new System.Drawing.Size(43, 21);
            this.doAutoSearch.TabIndex = 3;
            this.doAutoSearch.Text = "Auto";
            this.doAutoSearch.UseVisualStyleBackColor = true;
            this.doAutoSearch.Click += new System.EventHandler(this.doSearch_Click);
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(6, 17);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(97, 20);
            this.userSearch.TabIndex = 2;
            this.userSearch.TextChanged += new System.EventHandler(this.userSearch_TextChanged);
            // 
            // selectDbSever
            // 
            this.selectDbSever.Controls.Add(this.connectButton);
            this.selectDbSever.Controls.Add(this.setExternalDB);
            this.selectDbSever.Controls.Add(this.setLocalDB);
            this.selectDbSever.Location = new System.Drawing.Point(8, 2);
            this.selectDbSever.Name = "selectDbSever";
            this.selectDbSever.Size = new System.Drawing.Size(96, 94);
            this.selectDbSever.TabIndex = 0;
            this.selectDbSever.TabStop = false;
            this.selectDbSever.Text = "Server";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(6, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(84, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // setExternalDB
            // 
            this.setExternalDB.AutoCheck = false;
            this.setExternalDB.Location = new System.Drawing.Point(6, 35);
            this.setExternalDB.Name = "setExternalDB";
            this.setExternalDB.Size = new System.Drawing.Size(87, 24);
            this.setExternalDB.TabIndex = 0;
            this.setExternalDB.TabStop = true;
            this.setExternalDB.Tag = "dbExternal";
            this.setExternalDB.Text = "External DB";
            this.setExternalDB.UseVisualStyleBackColor = false;
            this.setExternalDB.CheckedChanged += new System.EventHandler(this.SetExternalDBCheckedChanged);
            // 
            // setLocalDB
            // 
            this.setLocalDB.AutoCheck = false;
            this.setLocalDB.BackColor = System.Drawing.SystemColors.Control;
            this.setLocalDB.Location = new System.Drawing.Point(6, 14);
            this.setLocalDB.Name = "setLocalDB";
            this.setLocalDB.Size = new System.Drawing.Size(87, 24);
            this.setLocalDB.TabIndex = 0;
            this.setLocalDB.TabStop = true;
            this.setLocalDB.Tag = "dbLocal";
            this.setLocalDB.Text = "Local DB";
            this.setLocalDB.UseVisualStyleBackColor = false;
            this.setLocalDB.CheckedChanged += new System.EventHandler(this.SetLocalDBCheckedChanged);
            // 
            // usersTable
            // 
            this.usersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersTable.Controls.Add(this.usersList);
            this.usersTable.Location = new System.Drawing.Point(266, 2);
            this.usersTable.Name = "usersTable";
            this.usersTable.Size = new System.Drawing.Size(892, 415);
            this.usersTable.TabIndex = 1;
            this.usersTable.TabStop = false;
            this.usersTable.Text = "Users";
            // 
            // usersList
            // 
            this.usersList.AllowUserToAddRows = false;
            this.usersList.AllowUserToDeleteRows = false;
            this.usersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.Location = new System.Drawing.Point(3, 16);
            this.usersList.MultiSelect = false;
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.RowHeadersWidth = 33;
            this.usersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersList.Size = new System.Drawing.Size(886, 396);
            this.usersList.TabIndex = 0;
            this.usersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersList_CellDoubleClick);
            this.usersList.SelectionChanged += new System.EventHandler(this.usersList_SelectionChanged);
            // 
            // userTransactionTable
            // 
            this.userTransactionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTransactionTable.AutoSize = true;
            this.userTransactionTable.Controls.Add(this.userTransactionList);
            this.userTransactionTable.Location = new System.Drawing.Point(266, 423);
            this.userTransactionTable.Name = "userTransactionTable";
            this.userTransactionTable.Size = new System.Drawing.Size(441, 152);
            this.userTransactionTable.TabIndex = 2;
            this.userTransactionTable.TabStop = false;
            this.userTransactionTable.Text = "Transactions";
            // 
            // userTransactionList
            // 
            this.userTransactionList.AllowUserToAddRows = false;
            this.userTransactionList.AllowUserToDeleteRows = false;
            this.userTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTransactionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTransactionList.Location = new System.Drawing.Point(3, 16);
            this.userTransactionList.MultiSelect = false;
            this.userTransactionList.Name = "userTransactionList";
            this.userTransactionList.ReadOnly = true;
            this.userTransactionList.RowHeadersWidth = 33;
            this.userTransactionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userTransactionList.Size = new System.Drawing.Size(435, 133);
            this.userTransactionList.TabIndex = 0;
            this.userTransactionList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTransactionList_CellDoubleClick);
            // 
            // userBattlesTab
            // 
            this.userBattlesTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userBattlesTab.AutoSize = true;
            this.userBattlesTab.Controls.Add(this.userBattlesList);
            this.userBattlesTab.Location = new System.Drawing.Point(717, 423);
            this.userBattlesTab.Name = "userBattlesTab";
            this.userBattlesTab.Size = new System.Drawing.Size(441, 152);
            this.userBattlesTab.TabIndex = 3;
            this.userBattlesTab.TabStop = false;
            this.userBattlesTab.Text = "Battles";
            // 
            // userBattlesList
            // 
            this.userBattlesList.AllowUserToAddRows = false;
            this.userBattlesList.AllowUserToDeleteRows = false;
            this.userBattlesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBattlesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBattlesList.Location = new System.Drawing.Point(3, 16);
            this.userBattlesList.MultiSelect = false;
            this.userBattlesList.Name = "userBattlesList";
            this.userBattlesList.ReadOnly = true;
            this.userBattlesList.RowHeadersWidth = 33;
            this.userBattlesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userBattlesList.Size = new System.Drawing.Size(435, 133);
            this.userBattlesList.TabIndex = 0;
            // 
            // userForm
            // 
            this.userForm.Controls.Add(this.CancelUserEdit);
            this.userForm.Controls.Add(this.DateText);
            this.userForm.Controls.Add(this.date);
            this.userForm.Controls.Add(this.CharacterIdText);
            this.userForm.Controls.Add(this.UserIdText);
            this.userForm.Controls.Add(this.playerName);
            this.userForm.Controls.Add(this.userId);
            this.userForm.Controls.Add(this.DeleteUser);
            this.userForm.Controls.Add(this.EditUser);
            this.userForm.Controls.Add(this.AddUser);
            this.userForm.Controls.Add(this.isEmailValid);
            this.userForm.Controls.Add(this.UserEmailText);
            this.userForm.Controls.Add(this.userEmail);
            this.userForm.Controls.Add(this.UserPasswordText);
            this.userForm.Controls.Add(this.userPassword);
            this.userForm.Controls.Add(this.UserLoginText);
            this.userForm.Controls.Add(this.userLogin);
            this.userForm.Enabled = false;
            this.userForm.Location = new System.Drawing.Point(8, 102);
            this.userForm.Name = "userForm";
            this.userForm.Size = new System.Drawing.Size(252, 208);
            this.userForm.TabIndex = 3;
            this.userForm.TabStop = false;
            this.userForm.Text = "User";
            // 
            // CancelUserEdit
            // 
            this.CancelUserEdit.Enabled = false;
            this.CancelUserEdit.Location = new System.Drawing.Point(190, 176);
            this.CancelUserEdit.Name = "CancelUserEdit";
            this.CancelUserEdit.Size = new System.Drawing.Size(55, 23);
            this.CancelUserEdit.TabIndex = 16;
            this.CancelUserEdit.Text = "Cancel";
            this.CancelUserEdit.UseVisualStyleBackColor = true;
            this.CancelUserEdit.Click += new System.EventHandler(this.CancelUserEdit_Click);
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(6, 43);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(79, 20);
            this.DateText.TabIndex = 15;
            this.DateText.Text = "Register date";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(91, 43);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(154, 20);
            this.date.TabIndex = 14;
            // 
            // CharacterIdText
            // 
            this.CharacterIdText.Location = new System.Drawing.Point(6, 121);
            this.CharacterIdText.Name = "CharacterIdText";
            this.CharacterIdText.Size = new System.Drawing.Size(79, 20);
            this.CharacterIdText.TabIndex = 13;
            this.CharacterIdText.Text = "Character";
            this.CharacterIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserIdText
            // 
            this.UserIdText.Location = new System.Drawing.Point(6, 17);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(79, 20);
            this.UserIdText.TabIndex = 11;
            this.UserIdText.Text = "UserID";
            this.UserIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(91, 121);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(154, 20);
            this.playerName.TabIndex = 12;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(91, 17);
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Size = new System.Drawing.Size(154, 20);
            this.userId.TabIndex = 10;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Enabled = false;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeleteUser.Location = new System.Drawing.Point(130, 176);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(55, 23);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUserClick);
            // 
            // EditUser
            // 
            this.EditUser.Enabled = false;
            this.EditUser.Location = new System.Drawing.Point(69, 176);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(55, 23);
            this.EditUser.TabIndex = 8;
            this.EditUser.Text = "Edit";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUserClick);
            // 
            // AddUser
            // 
            this.AddUser.Enabled = false;
            this.AddUser.Location = new System.Drawing.Point(8, 176);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(55, 23);
            this.AddUser.TabIndex = 7;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUserClick);
            // 
            // isEmailValid
            // 
            this.isEmailValid.Location = new System.Drawing.Point(74, 149);
            this.isEmailValid.Margin = new System.Windows.Forms.Padding(0);
            this.isEmailValid.Name = "isEmailValid";
            this.isEmailValid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isEmailValid.Size = new System.Drawing.Size(14, 19);
            this.isEmailValid.TabIndex = 6;
            this.isEmailValid.Text = "Validated?";
            this.isEmailValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isEmailValid.UseVisualStyleBackColor = true;
            // 
            // UserEmailText
            // 
            this.UserEmailText.Location = new System.Drawing.Point(6, 147);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(79, 20);
            this.UserEmailText.TabIndex = 5;
            this.UserEmailText.Text = "E-Mail";
            this.UserEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(91, 147);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(154, 20);
            this.userEmail.TabIndex = 4;
            // 
            // UserPasswordText
            // 
            this.UserPasswordText.Location = new System.Drawing.Point(6, 94);
            this.UserPasswordText.Name = "UserPasswordText";
            this.UserPasswordText.Size = new System.Drawing.Size(79, 20);
            this.UserPasswordText.TabIndex = 3;
            this.UserPasswordText.Text = "Password";
            this.UserPasswordText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(91, 94);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(154, 20);
            this.userPassword.TabIndex = 2;
            // 
            // UserLoginText
            // 
            this.UserLoginText.Location = new System.Drawing.Point(6, 68);
            this.UserLoginText.Name = "UserLoginText";
            this.UserLoginText.Size = new System.Drawing.Size(79, 20);
            this.UserLoginText.TabIndex = 1;
            this.UserLoginText.Text = "Login";
            this.UserLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(91, 68);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(154, 20);
            this.userLogin.TabIndex = 0;
            // 
            // charStatistic
            // 
            this.charStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.charStatistic.Controls.Add(this.charStatTable);
            this.charStatistic.Location = new System.Drawing.Point(717, 574);
            this.charStatistic.Name = "charStatistic";
            this.charStatistic.Size = new System.Drawing.Size(438, 84);
            this.charStatistic.TabIndex = 4;
            this.charStatistic.TabStop = false;
            this.charStatistic.Text = "Character statistic";
            // 
            // charStatTable
            // 
            this.charStatTable.AllowUserToAddRows = false;
            this.charStatTable.AllowUserToDeleteRows = false;
            this.charStatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charStatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charStatTable.Location = new System.Drawing.Point(3, 16);
            this.charStatTable.MultiSelect = false;
            this.charStatTable.Name = "charStatTable";
            this.charStatTable.ReadOnly = true;
            this.charStatTable.RowHeadersWidth = 30;
            this.charStatTable.Size = new System.Drawing.Size(432, 65);
            this.charStatTable.TabIndex = 0;
            // 
            // filtersTable
            // 
            this.filtersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filtersTable.Controls.Add(this.DrawBattles);
            this.filtersTable.Controls.Add(this.LoseBattles);
            this.filtersTable.Controls.Add(this.WinBattles);
            this.filtersTable.Controls.Add(this.BattlesLabel);
            this.filtersTable.Controls.Add(this.lastFiveItems);
            this.filtersTable.Controls.Add(this.sortTransactionsByMaxSum);
            this.filtersTable.Controls.Add(this.TransactionsLabel);
            this.filtersTable.Enabled = false;
            this.filtersTable.Location = new System.Drawing.Point(8, 423);
            this.filtersTable.Name = "filtersTable";
            this.filtersTable.Size = new System.Drawing.Size(252, 235);
            this.filtersTable.TabIndex = 5;
            this.filtersTable.TabStop = false;
            this.filtersTable.Text = "Filters";
            // 
            // DrawBattles
            // 
            this.DrawBattles.Enabled = false;
            this.DrawBattles.Location = new System.Drawing.Point(146, 104);
            this.DrawBattles.Name = "DrawBattles";
            this.DrawBattles.Size = new System.Drawing.Size(75, 23);
            this.DrawBattles.TabIndex = 3;
            this.DrawBattles.Text = "Draw";
            this.DrawBattles.UseVisualStyleBackColor = true;
            // 
            // LoseBattles
            // 
            this.LoseBattles.Enabled = false;
            this.LoseBattles.Location = new System.Drawing.Point(146, 75);
            this.LoseBattles.Name = "LoseBattles";
            this.LoseBattles.Size = new System.Drawing.Size(75, 23);
            this.LoseBattles.TabIndex = 3;
            this.LoseBattles.Text = "Lose";
            this.LoseBattles.UseVisualStyleBackColor = true;
            // 
            // WinBattles
            // 
            this.WinBattles.Enabled = false;
            this.WinBattles.Location = new System.Drawing.Point(146, 46);
            this.WinBattles.Name = "WinBattles";
            this.WinBattles.Size = new System.Drawing.Size(75, 23);
            this.WinBattles.TabIndex = 3;
            this.WinBattles.Text = "Win";
            this.WinBattles.UseVisualStyleBackColor = true;
            // 
            // BattlesLabel
            // 
            this.BattlesLabel.Location = new System.Drawing.Point(146, 20);
            this.BattlesLabel.Name = "BattlesLabel";
            this.BattlesLabel.Size = new System.Drawing.Size(100, 23);
            this.BattlesLabel.TabIndex = 2;
            this.BattlesLabel.Text = "Battles...";
            this.BattlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastFiveItems
            // 
            this.lastFiveItems.Location = new System.Drawing.Point(9, 75);
            this.lastFiveItems.Name = "lastFiveItems";
            this.lastFiveItems.Size = new System.Drawing.Size(75, 23);
            this.lastFiveItems.TabIndex = 1;
            this.lastFiveItems.Text = "last 5 items";
            this.lastFiveItems.UseVisualStyleBackColor = true;
            this.lastFiveItems.Click += new System.EventHandler(this.lastFiveItems_Click);
            // 
            // sortTransactionsByMaxSum
            // 
            this.sortTransactionsByMaxSum.Location = new System.Drawing.Point(9, 46);
            this.sortTransactionsByMaxSum.Name = "sortTransactionsByMaxSum";
            this.sortTransactionsByMaxSum.Size = new System.Drawing.Size(75, 23);
            this.sortTransactionsByMaxSum.TabIndex = 1;
            this.sortTransactionsByMaxSum.Text = "by Max Sum";
            this.sortTransactionsByMaxSum.UseVisualStyleBackColor = true;
            this.sortTransactionsByMaxSum.Click += new System.EventHandler(this.sortTransactionsByMaxSum_Click);
            // 
            // TransactionsLabel
            // 
            this.TransactionsLabel.Location = new System.Drawing.Point(9, 20);
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.TransactionsLabel.Size = new System.Drawing.Size(100, 23);
            this.TransactionsLabel.TabIndex = 0;
            this.TransactionsLabel.Text = "Transactions...";
            this.TransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usersFilterTable
            // 
            this.usersFilterTable.Controls.Add(this.clearFilter);
            this.usersFilterTable.Controls.Add(this.doAutoSearch);
            this.usersFilterTable.Controls.Add(this.usersFilter);
            this.usersFilterTable.Controls.Add(this.userSearch);
            this.usersFilterTable.Enabled = false;
            this.usersFilterTable.Location = new System.Drawing.Point(107, 2);
            this.usersFilterTable.Name = "usersFilterTable";
            this.usersFilterTable.Size = new System.Drawing.Size(153, 94);
            this.usersFilterTable.TabIndex = 6;
            this.usersFilterTable.TabStop = false;
            this.usersFilterTable.Text = "Users Filter";
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(6, 66);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(141, 21);
            this.clearFilter.TabIndex = 5;
            this.clearFilter.Text = "Clear filter";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // userTransactionForm
            // 
            this.userTransactionForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTransactionForm.Controls.Add(this.deleteUserTransaction);
            this.userTransactionForm.Controls.Add(this.cancelTransactionEdit);
            this.userTransactionForm.Controls.Add(this.editUserTransaction);
            this.userTransactionForm.Controls.Add(this.transactionSumText);
            this.userTransactionForm.Controls.Add(this.transactionDescriptionText);
            this.userTransactionForm.Controls.Add(this.addUserTransaction);
            this.userTransactionForm.Controls.Add(this.transactionUserText);
            this.userTransactionForm.Controls.Add(this.transactionDateText);
            this.userTransactionForm.Controls.Add(this.transactionIdText);
            this.userTransactionForm.Controls.Add(this.transactionSum);
            this.userTransactionForm.Controls.Add(this.transactionDescription);
            this.userTransactionForm.Controls.Add(this.transactionUser);
            this.userTransactionForm.Controls.Add(this.transactionDate);
            this.userTransactionForm.Controls.Add(this.transactionId);
            this.userTransactionForm.Location = new System.Drawing.Point(266, 574);
            this.userTransactionForm.Name = "userTransactionForm";
            this.userTransactionForm.Size = new System.Drawing.Size(441, 84);
            this.userTransactionForm.TabIndex = 7;
            this.userTransactionForm.TabStop = false;
            this.userTransactionForm.Text = "User Transaction";
            // 
            // deleteUserTransaction
            // 
            this.deleteUserTransaction.Enabled = false;
            this.deleteUserTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserTransaction.ForeColor = System.Drawing.Color.OrangeRed;
            this.deleteUserTransaction.Location = new System.Drawing.Point(216, 55);
            this.deleteUserTransaction.Name = "deleteUserTransaction";
            this.deleteUserTransaction.Size = new System.Drawing.Size(55, 23);
            this.deleteUserTransaction.TabIndex = 18;
            this.deleteUserTransaction.Text = "Delete";
            this.deleteUserTransaction.UseVisualStyleBackColor = true;
            this.deleteUserTransaction.Click += new System.EventHandler(this.DeleteUserTransactionClick);
            // 
            // cancelTransactionEdit
            // 
            this.cancelTransactionEdit.Enabled = false;
            this.cancelTransactionEdit.Location = new System.Drawing.Point(277, 55);
            this.cancelTransactionEdit.Name = "cancelTransactionEdit";
            this.cancelTransactionEdit.Size = new System.Drawing.Size(55, 23);
            this.cancelTransactionEdit.TabIndex = 17;
            this.cancelTransactionEdit.Text = "Cancel";
            this.cancelTransactionEdit.UseVisualStyleBackColor = true;
            this.cancelTransactionEdit.Click += new System.EventHandler(this.CancelTransactionEdit_Click);
            // 
            // editUserTransaction
            // 
            this.editUserTransaction.Enabled = false;
            this.editUserTransaction.Location = new System.Drawing.Point(155, 55);
            this.editUserTransaction.Name = "editUserTransaction";
            this.editUserTransaction.Size = new System.Drawing.Size(55, 23);
            this.editUserTransaction.TabIndex = 17;
            this.editUserTransaction.Text = "Edit";
            this.editUserTransaction.UseVisualStyleBackColor = true;
            this.editUserTransaction.Click += new System.EventHandler(this.EditUserTransactionClick);
            // 
            // transactionSumText
            // 
            this.transactionSumText.AutoSize = true;
            this.transactionSumText.Location = new System.Drawing.Point(397, 17);
            this.transactionSumText.Name = "transactionSumText";
            this.transactionSumText.Size = new System.Drawing.Size(31, 13);
            this.transactionSumText.TabIndex = 9;
            this.transactionSumText.Text = "Total";
            // 
            // transactionDescriptionText
            // 
            this.transactionDescriptionText.AutoSize = true;
            this.transactionDescriptionText.Location = new System.Drawing.Point(285, 17);
            this.transactionDescriptionText.Name = "transactionDescriptionText";
            this.transactionDescriptionText.Size = new System.Drawing.Size(60, 13);
            this.transactionDescriptionText.TabIndex = 8;
            this.transactionDescriptionText.Text = "Description";
            // 
            // addUserTransaction
            // 
            this.addUserTransaction.Enabled = false;
            this.addUserTransaction.Location = new System.Drawing.Point(95, 55);
            this.addUserTransaction.Name = "addUserTransaction";
            this.addUserTransaction.Size = new System.Drawing.Size(55, 23);
            this.addUserTransaction.TabIndex = 16;
            this.addUserTransaction.Text = "Add";
            this.addUserTransaction.UseVisualStyleBackColor = true;
            this.addUserTransaction.Click += new System.EventHandler(this.AddUserTransaction);
            // 
            // transactionUserText
            // 
            this.transactionUserText.AutoSize = true;
            this.transactionUserText.Location = new System.Drawing.Point(181, 17);
            this.transactionUserText.Name = "transactionUserText";
            this.transactionUserText.Size = new System.Drawing.Size(29, 13);
            this.transactionUserText.TabIndex = 7;
            this.transactionUserText.Text = "User";
            // 
            // transactionDateText
            // 
            this.transactionDateText.AutoSize = true;
            this.transactionDateText.Location = new System.Drawing.Point(81, 17);
            this.transactionDateText.Name = "transactionDateText";
            this.transactionDateText.Size = new System.Drawing.Size(30, 13);
            this.transactionDateText.TabIndex = 6;
            this.transactionDateText.Text = "Date";
            // 
            // transactionIdText
            // 
            this.transactionIdText.AutoSize = true;
            this.transactionIdText.Location = new System.Drawing.Point(15, 17);
            this.transactionIdText.Name = "transactionIdText";
            this.transactionIdText.Size = new System.Drawing.Size(16, 13);
            this.transactionIdText.TabIndex = 5;
            this.transactionIdText.Text = "Id";
            // 
            // transactionSum
            // 
            this.transactionSum.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionSum.Location = new System.Drawing.Point(388, 31);
            this.transactionSum.Name = "transactionSum";
            this.transactionSum.Size = new System.Drawing.Size(48, 18);
            this.transactionSum.TabIndex = 4;
            // 
            // transactionDescription
            // 
            this.transactionDescription.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionDescription.Location = new System.Drawing.Point(246, 31);
            this.transactionDescription.Name = "transactionDescription";
            this.transactionDescription.Size = new System.Drawing.Size(136, 18);
            this.transactionDescription.TabIndex = 3;
            // 
            // transactionUser
            // 
            this.transactionUser.Enabled = false;
            this.transactionUser.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionUser.Location = new System.Drawing.Point(157, 31);
            this.transactionUser.Name = "transactionUser";
            this.transactionUser.Size = new System.Drawing.Size(83, 18);
            this.transactionUser.TabIndex = 2;
            // 
            // transactionDate
            // 
            this.transactionDate.CalendarFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionDate.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionDate.Location = new System.Drawing.Point(44, 31);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(107, 18);
            this.transactionDate.TabIndex = 1;
            // 
            // transactionId
            // 
            this.transactionId.Enabled = false;
            this.transactionId.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionId.Location = new System.Drawing.Point(4, 31);
            this.transactionId.Name = "transactionId";
            this.transactionId.Size = new System.Drawing.Size(34, 18);
            this.transactionId.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 662);
            this.Controls.Add(this.userTransactionForm);
            this.Controls.Add(this.usersFilterTable);
            this.Controls.Add(this.filtersTable);
            this.Controls.Add(this.charStatistic);
            this.Controls.Add(this.userForm);
            this.Controls.Add(this.selectDbSever);
            this.Controls.Add(this.userBattlesTab);
            this.Controls.Add(this.userTransactionTable);
            this.Controls.Add(this.usersTable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1178, 700);
            this.MinimumSize = new System.Drawing.Size(1178, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatsDataViewer";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.selectDbSever.ResumeLayout(false);
            this.usersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.userTransactionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionList)).EndInit();
            this.userBattlesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBattlesList)).EndInit();
            this.userForm.ResumeLayout(false);
            this.userForm.PerformLayout();
            this.charStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charStatTable)).EndInit();
            this.filtersTable.ResumeLayout(false);
            this.usersFilterTable.ResumeLayout(false);
            this.usersFilterTable.PerformLayout();
            this.userTransactionForm.ResumeLayout(false);
            this.userTransactionForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox userTransactionForm;
        private System.Windows.Forms.TextBox transactionUser;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.TextBox transactionId;
        private System.Windows.Forms.Button deleteUserTransaction;
        private System.Windows.Forms.Button editUserTransaction;
        private System.Windows.Forms.Label transactionSumText;
        private System.Windows.Forms.Label transactionDescriptionText;
        private System.Windows.Forms.Button addUserTransaction;
        private System.Windows.Forms.Label transactionUserText;
        private System.Windows.Forms.Label transactionDateText;
        private System.Windows.Forms.Label transactionIdText;
        private System.Windows.Forms.TextBox transactionSum;
        private System.Windows.Forms.TextBox transactionDescription;
        private System.Windows.Forms.Button CancelUserEdit;
        private System.Windows.Forms.Button cancelTransactionEdit;
        private System.Windows.Forms.Button lastFiveItems;
        private System.Windows.Forms.Button DrawBattles;
        private System.Windows.Forms.Button LoseBattles;
    }
}
