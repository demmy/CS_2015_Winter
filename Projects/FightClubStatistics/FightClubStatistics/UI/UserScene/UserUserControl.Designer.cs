namespace FightClubStatistics.UI.UserScene
{
    partial class UserUserControl
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
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.toMenuButton = new System.Windows.Forms.Button();
            this.usersDataTableCounter = new System.Windows.Forms.NumericUpDown();
            this.usersDataTableCounterLabel = new System.Windows.Forms.Label();
            this.validationPanel = new System.Windows.Forms.Panel();
            this.choseNonValidEmailsRadioButton = new System.Windows.Forms.RadioButton();
            this.choseValidEmailsRadioButton = new System.Windows.Forms.RadioButton();
            this.choseAllRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataTableCounter)).BeginInit();
            this.validationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToOrderColumns = true;
            this.usersDataGrid.AllowUserToResizeRows = false;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersDataGrid.Location = new System.Drawing.Point(264, 20);
            this.usersDataGrid.MultiSelect = false;
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.Size = new System.Drawing.Size(764, 427);
            this.usersDataGrid.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(21, 20);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(216, 40);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(21, 78);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(216, 40);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(21, 137);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(216, 40);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "DeleteUser";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // toMenuButton
            // 
            this.toMenuButton.Location = new System.Drawing.Point(21, 407);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(216, 40);
            this.toMenuButton.TabIndex = 4;
            this.toMenuButton.Text = "Back to Menu";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
            // 
            // usersDataTableCounter
            // 
            this.usersDataTableCounter.Location = new System.Drawing.Point(21, 214);
            this.usersDataTableCounter.Name = "usersDataTableCounter";
            this.usersDataTableCounter.Size = new System.Drawing.Size(120, 20);
            this.usersDataTableCounter.TabIndex = 5;
            this.usersDataTableCounter.ValueChanged += new System.EventHandler(this.usersDataTableCounter_ValueChanged);
            // 
            // usersDataTableCounterLabel
            // 
            this.usersDataTableCounterLabel.AutoSize = true;
            this.usersDataTableCounterLabel.Location = new System.Drawing.Point(18, 198);
            this.usersDataTableCounterLabel.Name = "usersDataTableCounterLabel";
            this.usersDataTableCounterLabel.Size = new System.Drawing.Size(107, 13);
            this.usersDataTableCounterLabel.TabIndex = 6;
            this.usersDataTableCounterLabel.Text = "Take first N elements";
            // 
            // validationPanel
            // 
            this.validationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validationPanel.Controls.Add(this.choseNonValidEmailsRadioButton);
            this.validationPanel.Controls.Add(this.choseValidEmailsRadioButton);
            this.validationPanel.Controls.Add(this.choseAllRadioButton);
            this.validationPanel.Location = new System.Drawing.Point(21, 253);
            this.validationPanel.Name = "validationPanel";
            this.validationPanel.Size = new System.Drawing.Size(216, 100);
            this.validationPanel.TabIndex = 7;
            // 
            // choseNonValidEmailsRadioButton
            // 
            this.choseNonValidEmailsRadioButton.AutoSize = true;
            this.choseNonValidEmailsRadioButton.Location = new System.Drawing.Point(10, 63);
            this.choseNonValidEmailsRadioButton.Name = "choseNonValidEmailsRadioButton";
            this.choseNonValidEmailsRadioButton.Size = new System.Drawing.Size(192, 17);
            this.choseNonValidEmailsRadioButton.TabIndex = 10;
            this.choseNonValidEmailsRadioButton.Text = "Show elements without valid Emails";
            this.choseNonValidEmailsRadioButton.UseVisualStyleBackColor = true;
            this.choseNonValidEmailsRadioButton.CheckedChanged += new System.EventHandler(this.choseNonValidEmailsRadioButton_CheckedChanged);
            // 
            // choseValidEmailsRadioButton
            // 
            this.choseValidEmailsRadioButton.AutoSize = true;
            this.choseValidEmailsRadioButton.Location = new System.Drawing.Point(10, 40);
            this.choseValidEmailsRadioButton.Name = "choseValidEmailsRadioButton";
            this.choseValidEmailsRadioButton.Size = new System.Drawing.Size(177, 17);
            this.choseValidEmailsRadioButton.TabIndex = 9;
            this.choseValidEmailsRadioButton.Text = "Show elements with valid Emails";
            this.choseValidEmailsRadioButton.UseVisualStyleBackColor = true;
            this.choseValidEmailsRadioButton.CheckedChanged += new System.EventHandler(this.choseValidEmailsRadioButton_CheckedChanged);
            // 
            // choseAllRadioButton
            // 
            this.choseAllRadioButton.AutoSize = true;
            this.choseAllRadioButton.Checked = true;
            this.choseAllRadioButton.Location = new System.Drawing.Point(10, 17);
            this.choseAllRadioButton.Name = "choseAllRadioButton";
            this.choseAllRadioButton.Size = new System.Drawing.Size(110, 17);
            this.choseAllRadioButton.TabIndex = 8;
            this.choseAllRadioButton.TabStop = true;
            this.choseAllRadioButton.Text = "Show all elements";
            this.choseAllRadioButton.UseVisualStyleBackColor = true;
            this.choseAllRadioButton.CheckedChanged += new System.EventHandler(this.choseAllRadioButton_CheckedChanged);
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.validationPanel);
            this.Controls.Add(this.usersDataTableCounterLabel);
            this.Controls.Add(this.usersDataTableCounter);
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(1052, 500);
            this.Load += new System.EventHandler(this.UserUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataTableCounter)).EndInit();
            this.validationPanel.ResumeLayout(false);
            this.validationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button toMenuButton;
        private System.Windows.Forms.NumericUpDown usersDataTableCounter;
        private System.Windows.Forms.Label usersDataTableCounterLabel;
        private System.Windows.Forms.Panel validationPanel;
        private System.Windows.Forms.RadioButton choseNonValidEmailsRadioButton;
        private System.Windows.Forms.RadioButton choseValidEmailsRadioButton;
        private System.Windows.Forms.RadioButton choseAllRadioButton;
    }
}
