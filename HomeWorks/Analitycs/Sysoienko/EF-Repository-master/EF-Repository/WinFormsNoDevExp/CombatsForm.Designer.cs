namespace WinFormsNoDevExp
{
    partial class CombatsForm
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
            this.combatDbDataSet = new WinFormsNoDevExp.CombatDbDataSet();
            this.combatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatsTableAdapter = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.CombatsTableAdapter();
            this.tableAdapterManager = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.TableAdapterManager();
            this.combatsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // combatDbDataSet
            // 
            this.combatDbDataSet.DataSetName = "CombatDbDataSet";
            this.combatDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combatsBindingSource
            // 
            this.combatsBindingSource.DataMember = "Combats";
            this.combatsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // combatsTableAdapter
            // 
            this.combatsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombatsTableAdapter = this.combatsTableAdapter;
            this.tableAdapterManager.HitLogsTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.PvesTableAdapter = null;
            this.tableAdapterManager.PvpsTableAdapter = null;
            this.tableAdapterManager.TranscationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinFormsNoDevExp.CombatDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combatsDataGridView
            // 
            this.combatsDataGridView.AllowUserToAddRows = false;
            this.combatsDataGridView.AllowUserToDeleteRows = false;
            this.combatsDataGridView.AutoGenerateColumns = false;
            this.combatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.combatsDataGridView.DataSource = this.combatsBindingSource;
            this.combatsDataGridView.Location = new System.Drawing.Point(1, 3);
            this.combatsDataGridView.Name = "combatsDataGridView";
            this.combatsDataGridView.ReadOnly = true;
            this.combatsDataGridView.Size = new System.Drawing.Size(330, 267);
            this.combatsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CombatId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CombatId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Winner";
            this.dataGridViewTextBoxColumn2.HeaderText = "Winner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // CombatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 268);
            this.Controls.Add(this.combatsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CombatsForm";
            this.Text = "CombatsForm";
            this.Load += new System.EventHandler(this.CombatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CombatDbDataSet combatDbDataSet;
        private System.Windows.Forms.BindingSource combatsBindingSource;
        private CombatDbDataSetTableAdapters.CombatsTableAdapter combatsTableAdapter;
        private CombatDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView combatsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}