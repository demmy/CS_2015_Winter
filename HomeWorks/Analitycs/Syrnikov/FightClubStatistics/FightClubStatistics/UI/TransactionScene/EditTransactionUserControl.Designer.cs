namespace FightClubStatistics.UI.TransactionScene
{
    partial class EditTransactionUserControl
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
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.transactionSumTextBox = new System.Windows.Forms.TextBox();
            this.transactionSumLabel = new System.Windows.Forms.Label();
            this.transactionUserLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.transactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactonUserComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Location = new System.Drawing.Point(32, 167);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(89, 13);
            this.transactionDateLabel.TabIndex = 21;
            this.transactionDateLabel.Text = "Transaction Date";
            // 
            // transactionSumTextBox
            // 
            this.transactionSumTextBox.Location = new System.Drawing.Point(35, 122);
            this.transactionSumTextBox.MaxLength = 50;
            this.transactionSumTextBox.Name = "transactionSumTextBox";
            this.transactionSumTextBox.Size = new System.Drawing.Size(406, 20);
            this.transactionSumTextBox.TabIndex = 20;
            this.transactionSumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transactionSumTextBox_KeyPress);
            // 
            // transactionSumLabel
            // 
            this.transactionSumLabel.AutoSize = true;
            this.transactionSumLabel.Location = new System.Drawing.Point(32, 97);
            this.transactionSumLabel.Name = "transactionSumLabel";
            this.transactionSumLabel.Size = new System.Drawing.Size(87, 13);
            this.transactionSumLabel.TabIndex = 19;
            this.transactionSumLabel.Text = "Transaction Sum";
            // 
            // transactionUserLabel
            // 
            this.transactionUserLabel.AutoSize = true;
            this.transactionUserLabel.Location = new System.Drawing.Point(32, 24);
            this.transactionUserLabel.Name = "transactionUserLabel";
            this.transactionUserLabel.Size = new System.Drawing.Size(60, 13);
            this.transactionUserLabel.TabIndex = 17;
            this.transactionUserLabel.Text = "User Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(35, 481);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 48);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(255, 481);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(186, 48);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // transactionDateTimePicker
            // 
            this.transactionDateTimePicker.Location = new System.Drawing.Point(35, 194);
            this.transactionDateTimePicker.Name = "transactionDateTimePicker";
            this.transactionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.transactionDateTimePicker.TabIndex = 22;
            // 
            // transactonUserComboBox
            // 
            this.transactonUserComboBox.FormattingEnabled = true;
            this.transactonUserComboBox.Location = new System.Drawing.Point(35, 53);
            this.transactonUserComboBox.Name = "transactonUserComboBox";
            this.transactonUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.transactonUserComboBox.TabIndex = 23;
            // 
            // EditTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transactonUserComboBox);
            this.Controls.Add(this.transactionDateTimePicker);
            this.Controls.Add(this.transactionDateLabel);
            this.Controls.Add(this.transactionSumTextBox);
            this.Controls.Add(this.transactionSumLabel);
            this.Controls.Add(this.transactionUserLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "EditTransactionUserControl";
            this.Size = new System.Drawing.Size(477, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.TextBox transactionSumTextBox;
        private System.Windows.Forms.Label transactionSumLabel;
        private System.Windows.Forms.Label transactionUserLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DateTimePicker transactionDateTimePicker;
        private System.Windows.Forms.ComboBox transactonUserComboBox;
    }
}
