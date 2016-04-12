/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.04.2016
 * Time: 9:32
 */
namespace CombatsDataViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton setExternalDB;
        private System.Windows.Forms.RadioButton setLocalDB;
        private System.Windows.Forms.DataGridView usersList;
        private System.Windows.Forms.DataGridView userBattlesList;
        private System.Windows.Forms.GroupBox usersTable;
        private System.Windows.Forms.GroupBox userTransactionTable;
        private System.Windows.Forms.DataGridView userTransactionList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox userForm;
        private System.Windows.Forms.Label IdText;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label PlayerIdText;
        private System.Windows.Forms.TextBox playerId;
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
        private System.Windows.Forms.Label Transactions;
        private System.Windows.Forms.Label Battles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView charStatTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button doSearch;
        private System.Windows.Forms.TextBox userSearch;
        private System.Windows.Forms.ComboBox usersFilter;
        
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.doSearch = new System.Windows.Forms.Button();
            this.userSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setExternalDB = new System.Windows.Forms.RadioButton();
            this.setLocalDB = new System.Windows.Forms.RadioButton();
            this.usersTable = new System.Windows.Forms.GroupBox();
            this.usersList = new System.Windows.Forms.DataGridView();
            this.userTransactionTable = new System.Windows.Forms.GroupBox();
            this.userTransactionList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userBattlesList = new System.Windows.Forms.DataGridView();
            this.userForm = new System.Windows.Forms.GroupBox();
            this.IdText = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.PlayerIdText = new System.Windows.Forms.Label();
            this.playerId = new System.Windows.Forms.TextBox();
            this.UserIdText = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.Battles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Label();
            this.usersFilter = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.usersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
            this.userTransactionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBattlesList)).BeginInit();
            this.userForm.SuspendLayout();
            this.charStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charStatTable)).BeginInit();
            this.filtersTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.usersFilter);
            this.panel1.Controls.Add(this.doSearch);
            this.panel1.Controls.Add(this.userSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 74);
            this.panel1.TabIndex = 0;
            // 
            // doSearch
            // 
            this.doSearch.Location = new System.Drawing.Point(201, 44);
            this.doSearch.Name = "doSearch";
            this.doSearch.Size = new System.Drawing.Size(53, 20);
            this.doSearch.TabIndex = 3;
            this.doSearch.Text = "Search";
            this.doSearch.UseVisualStyleBackColor = true;
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(108, 44);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(87, 20);
            this.userSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setExternalDB);
            this.groupBox1.Controls.Add(this.setLocalDB);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // setExternalDB
            // 
            this.setExternalDB.Location = new System.Drawing.Point(6, 40);
            this.setExternalDB.Name = "setExternalDB";
            this.setExternalDB.Size = new System.Drawing.Size(87, 24);
            this.setExternalDB.TabIndex = 0;
            this.setExternalDB.TabStop = true;
            this.setExternalDB.Text = "External DB";
            this.setExternalDB.UseVisualStyleBackColor = true;
            // 
            // setLocalDB
            // 
            this.setLocalDB.Location = new System.Drawing.Point(6, 19);
            this.setLocalDB.Name = "setLocalDB";
            this.setLocalDB.Size = new System.Drawing.Size(87, 24);
            this.setLocalDB.TabIndex = 0;
            this.setLocalDB.TabStop = true;
            this.setLocalDB.Text = "Local DB";
            this.setLocalDB.UseVisualStyleBackColor = true;
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
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.Location = new System.Drawing.Point(3, 16);
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.Size = new System.Drawing.Size(886, 396);
            this.usersList.TabIndex = 0;
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
            this.userTransactionTable.Size = new System.Drawing.Size(441, 320);
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
            this.userTransactionList.Name = "userTransactionList";
            this.userTransactionList.ReadOnly = true;
            this.userTransactionList.Size = new System.Drawing.Size(435, 301);
            this.userTransactionList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.userBattlesList);
            this.groupBox2.Location = new System.Drawing.Point(717, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Battles";
            // 
            // userBattlesList
            // 
            this.userBattlesList.AllowUserToAddRows = false;
            this.userBattlesList.AllowUserToDeleteRows = false;
            this.userBattlesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBattlesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBattlesList.Location = new System.Drawing.Point(3, 16);
            this.userBattlesList.Name = "userBattlesList";
            this.userBattlesList.ReadOnly = true;
            this.userBattlesList.Size = new System.Drawing.Size(435, 301);
            this.userBattlesList.TabIndex = 0;
            // 
            // userForm
            // 
            this.userForm.Controls.Add(this.IdText);
            this.userForm.Controls.Add(this.id);
            this.userForm.Controls.Add(this.DateText);
            this.userForm.Controls.Add(this.date);
            this.userForm.Controls.Add(this.PlayerIdText);
            this.userForm.Controls.Add(this.playerId);
            this.userForm.Controls.Add(this.UserIdText);
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
            this.userForm.Location = new System.Drawing.Point(8, 83);
            this.userForm.Name = "userForm";
            this.userForm.Size = new System.Drawing.Size(252, 244);
            this.userForm.TabIndex = 3;
            this.userForm.TabStop = false;
            this.userForm.Text = "User";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(7, 19);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(79, 20);
            this.IdText.TabIndex = 17;
            this.IdText.Text = "DataBase ID";
            this.IdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(92, 19);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(154, 20);
            this.id.TabIndex = 16;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(7, 97);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(79, 20);
            this.DateText.TabIndex = 15;
            this.DateText.Text = "Date";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(92, 97);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(154, 20);
            this.date.TabIndex = 14;
            // 
            // PlayerIdText
            // 
            this.PlayerIdText.Location = new System.Drawing.Point(7, 71);
            this.PlayerIdText.Name = "PlayerIdText";
            this.PlayerIdText.Size = new System.Drawing.Size(79, 20);
            this.PlayerIdText.TabIndex = 13;
            this.PlayerIdText.Text = "Player ID";
            this.PlayerIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerId
            // 
            this.playerId.Location = new System.Drawing.Point(92, 71);
            this.playerId.Name = "playerId";
            this.playerId.ReadOnly = true;
            this.playerId.Size = new System.Drawing.Size(154, 20);
            this.playerId.TabIndex = 12;
            // 
            // UserIdText
            // 
            this.UserIdText.Location = new System.Drawing.Point(7, 45);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(79, 20);
            this.UserIdText.TabIndex = 11;
            this.UserIdText.Text = "UserID";
            this.UserIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(92, 45);
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
            this.DeleteUser.Location = new System.Drawing.Point(171, 213);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUserClick);
            // 
            // EditUser
            // 
            this.EditUser.Enabled = false;
            this.EditUser.Location = new System.Drawing.Point(90, 213);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(75, 23);
            this.EditUser.TabIndex = 8;
            this.EditUser.Text = "Edit";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUserClick);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(9, 213);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 7;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUserClick);
            // 
            // isEmailValid
            // 
            this.isEmailValid.Location = new System.Drawing.Point(75, 177);
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
            this.UserEmailText.Location = new System.Drawing.Point(7, 175);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(79, 20);
            this.UserEmailText.TabIndex = 5;
            this.UserEmailText.Text = "E-Mail";
            this.UserEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(92, 175);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(154, 20);
            this.userEmail.TabIndex = 4;
            // 
            // UserPasswordText
            // 
            this.UserPasswordText.Location = new System.Drawing.Point(7, 149);
            this.UserPasswordText.Name = "UserPasswordText";
            this.UserPasswordText.Size = new System.Drawing.Size(79, 20);
            this.UserPasswordText.TabIndex = 3;
            this.UserPasswordText.Text = "Password";
            this.UserPasswordText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(92, 149);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(154, 20);
            this.userPassword.TabIndex = 2;
            // 
            // UserLoginText
            // 
            this.UserLoginText.Location = new System.Drawing.Point(7, 123);
            this.UserLoginText.Name = "UserLoginText";
            this.UserLoginText.Size = new System.Drawing.Size(79, 20);
            this.UserLoginText.TabIndex = 1;
            this.UserLoginText.Text = "Login";
            this.UserLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(92, 123);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(154, 20);
            this.userLogin.TabIndex = 0;
            // 
            // charStatistic
            // 
            this.charStatistic.Controls.Add(this.charStatTable);
            this.charStatistic.Location = new System.Drawing.Point(8, 333);
            this.charStatistic.Name = "charStatistic";
            this.charStatistic.Size = new System.Drawing.Size(252, 84);
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
            this.charStatTable.Name = "charStatTable";
            this.charStatTable.ReadOnly = true;
            this.charStatTable.Size = new System.Drawing.Size(246, 65);
            this.charStatTable.TabIndex = 0;
            // 
            // filtersTable
            // 
            this.filtersTable.Controls.Add(this.button2);
            this.filtersTable.Controls.Add(this.Battles);
            this.filtersTable.Controls.Add(this.button1);
            this.filtersTable.Controls.Add(this.Transactions);
            this.filtersTable.Location = new System.Drawing.Point(8, 423);
            this.filtersTable.Name = "filtersTable";
            this.filtersTable.Size = new System.Drawing.Size(252, 320);
            this.filtersTable.TabIndex = 5;
            this.filtersTable.TabStop = false;
            this.filtersTable.Text = "Filters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Battles
            // 
            this.Battles.Location = new System.Drawing.Point(146, 20);
            this.Battles.Name = "Battles";
            this.Battles.Size = new System.Drawing.Size(100, 23);
            this.Battles.TabIndex = 2;
            this.Battles.Text = "Battles...";
            this.Battles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            this.Transactions.Location = new System.Drawing.Point(9, 20);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(100, 23);
            this.Transactions.TabIndex = 0;
            this.Transactions.Text = "Transactions...";
            this.Transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usersFilter
            // 
            this.usersFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersFilter.FormattingEnabled = true;
            this.usersFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usersFilter.Location = new System.Drawing.Point(108, 14);
            this.usersFilter.Name = "usersFilter";
            this.usersFilter.Size = new System.Drawing.Size(146, 21);
            this.usersFilter.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 747);
            this.Controls.Add(this.filtersTable);
            this.Controls.Add(this.charStatistic);
            this.Controls.Add(this.userForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.userTransactionTable);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1178, 785);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatsDataViewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.usersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.userTransactionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBattlesList)).EndInit();
            this.userForm.ResumeLayout(false);
            this.userForm.PerformLayout();
            this.charStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charStatTable)).EndInit();
            this.filtersTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
