namespace FightClubStatistics.UI.TransactionScene
{
    partial class TransactionUserControl
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
            this.components = new System.ComponentModel.Container();
            this.transactionsDataTableCounterLabel = new System.Windows.Forms.Label();
            this.transactionsDataTableCounter = new System.Windows.Forms.NumericUpDown();
            this.toMenuButton = new System.Windows.Forms.Button();
            this.deleteTransactionButton = new System.Windows.Forms.Button();
            this.editTransactionButton = new System.Windows.Forms.Button();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.transactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.iTransactionUserControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataTableCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransactionUserControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsDataTableCounterLabel
            // 
            this.transactionsDataTableCounterLabel.AutoSize = true;
            this.transactionsDataTableCounterLabel.Location = new System.Drawing.Point(10, 190);
            this.transactionsDataTableCounterLabel.Name = "transactionsDataTableCounterLabel";
            this.transactionsDataTableCounterLabel.Size = new System.Drawing.Size(107, 13);
            this.transactionsDataTableCounterLabel.TabIndex = 14;
            this.transactionsDataTableCounterLabel.Text = "Take first N elements";
            // 
            // transactionsDataTableCounter
            // 
            this.transactionsDataTableCounter.Location = new System.Drawing.Point(13, 206);
            this.transactionsDataTableCounter.Name = "transactionsDataTableCounter";
            this.transactionsDataTableCounter.Size = new System.Drawing.Size(120, 20);
            this.transactionsDataTableCounter.TabIndex = 13;
            this.transactionsDataTableCounter.ValueChanged += new System.EventHandler(this.transactionsDataTableCounter_ValueChanged);
            // 
            // toMenuButton
            // 
            this.toMenuButton.Location = new System.Drawing.Point(13, 399);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(216, 40);
            this.toMenuButton.TabIndex = 12;
            this.toMenuButton.Text = "Back to Menu";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
            // 
            // deleteTransactionButton
            // 
            this.deleteTransactionButton.Location = new System.Drawing.Point(13, 129);
            this.deleteTransactionButton.Name = "deleteTransactionButton";
            this.deleteTransactionButton.Size = new System.Drawing.Size(216, 40);
            this.deleteTransactionButton.TabIndex = 11;
            this.deleteTransactionButton.Text = "Delete Transaction";
            this.deleteTransactionButton.UseVisualStyleBackColor = true;
            this.deleteTransactionButton.Click += new System.EventHandler(this.deleteTransactionButton_Click);
            // 
            // editTransactionButton
            // 
            this.editTransactionButton.Location = new System.Drawing.Point(13, 70);
            this.editTransactionButton.Name = "editTransactionButton";
            this.editTransactionButton.Size = new System.Drawing.Size(216, 40);
            this.editTransactionButton.TabIndex = 10;
            this.editTransactionButton.Text = "Edit Transaction";
            this.editTransactionButton.UseVisualStyleBackColor = true;
            this.editTransactionButton.Click += new System.EventHandler(this.editTransactionButton_Click);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(13, 12);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(216, 40);
            this.addTransactionButton.TabIndex = 9;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // transactionsDataGrid
            // 
            this.transactionsDataGrid.AllowUserToOrderColumns = true;
            this.transactionsDataGrid.AllowUserToResizeRows = false;
            this.transactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionsDataGrid.Location = new System.Drawing.Point(256, 12);
            this.transactionsDataGrid.MultiSelect = false;
            this.transactionsDataGrid.Name = "transactionsDataGrid";
            this.transactionsDataGrid.ReadOnly = true;
            this.transactionsDataGrid.Size = new System.Drawing.Size(764, 427);
            this.transactionsDataGrid.TabIndex = 8;
            // 
            // iTransactionUserControlBindingSource
            // 
            this.iTransactionUserControlBindingSource.DataSource = typeof(FightClubStatistics.UI.TransactionScene.ITransactionUserControl);
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transactionsDataTableCounterLabel);
            this.Controls.Add(this.transactionsDataTableCounter);
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.deleteTransactionButton);
            this.Controls.Add(this.editTransactionButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.transactionsDataGrid);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(1054, 508);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataTableCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransactionUserControlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label transactionsDataTableCounterLabel;
        private System.Windows.Forms.NumericUpDown transactionsDataTableCounter;
        private System.Windows.Forms.Button toMenuButton;
        private System.Windows.Forms.Button deleteTransactionButton;
        private System.Windows.Forms.Button editTransactionButton;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.DataGridView transactionsDataGrid;
        private System.Windows.Forms.BindingSource iTransactionUserControlBindingSource;
    }
}
