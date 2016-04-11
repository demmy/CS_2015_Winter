namespace WinFormsNoDevExp
{
    partial class DataForm
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
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.TableAdapterManager();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transcationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transcationsTableAdapter = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.TranscationsTableAdapter();
            this.transcationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdboTranscationsdboPlayersPlayerIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatsTableAdapter = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.CombatsTableAdapter();
            this.fKdboPlayersdboCombatsCombatIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hitLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hitLogsTableAdapter = new WinFormsNoDevExp.CombatDbDataSetTableAdapters.HitLogsTableAdapter();
            this.fKdboHitLogsdboCombatsCombatIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTranscationsdboPlayersPlayerIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboPlayersdboCombatsCombatIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboHitLogsdboCombatsCombatIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combatDbDataSet
            // 
            this.combatDbDataSet.DataSetName = "CombatDbDataSet";
            this.combatDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.combatDbDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombatsTableAdapter = this.combatsTableAdapter;
            this.tableAdapterManager.HitLogsTableAdapter = this.hitLogsTableAdapter;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.PvesTableAdapter = null;
            this.tableAdapterManager.PvpsTableAdapter = null;
            this.tableAdapterManager.TranscationsTableAdapter = this.transcationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsNoDevExp.CombatDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AllowUserToAddRows = false;
            this.playersDataGridView.AllowUserToDeleteRows = false;
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(0, 2);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.ReadOnly = true;
            this.playersDataGridView.Size = new System.Drawing.Size(742, 244);
            this.playersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsValidEmail";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsValidEmail";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CombatId";
            this.dataGridViewTextBoxColumn6.HeaderText = "CombatId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // transcationsBindingSource
            // 
            this.transcationsBindingSource.DataMember = "Transcations";
            this.transcationsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // transcationsTableAdapter
            // 
            this.transcationsTableAdapter.ClearBeforeFill = true;
            // 
            // transcationsDataGridView
            // 
            this.transcationsDataGridView.AllowUserToAddRows = false;
            this.transcationsDataGridView.AllowUserToDeleteRows = false;
            this.transcationsDataGridView.AutoGenerateColumns = false;
            this.transcationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transcationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.transcationsDataGridView.DataSource = this.fKdboTranscationsdboPlayersPlayerIdBindingSource;
            this.transcationsDataGridView.Location = new System.Drawing.Point(0, 252);
            this.transcationsDataGridView.Name = "transcationsDataGridView";
            this.transcationsDataGridView.ReadOnly = true;
            this.transcationsDataGridView.Size = new System.Drawing.Size(444, 42);
            this.transcationsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactId";
            this.dataGridViewTextBoxColumn7.HeaderText = "TransactId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sum";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PlayerId";
            this.dataGridViewTextBoxColumn10.HeaderText = "PlayerId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // fKdboTranscationsdboPlayersPlayerIdBindingSource
            // 
            this.fKdboTranscationsdboPlayersPlayerIdBindingSource.DataMember = "FK_dbo.Transcations_dbo.Players_PlayerId";
            this.fKdboTranscationsdboPlayersPlayerIdBindingSource.DataSource = this.playersBindingSource;
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
            // fKdboPlayersdboCombatsCombatIdBindingSource
            // 
            this.fKdboPlayersdboCombatsCombatIdBindingSource.DataMember = "FK_dbo.Players_dbo.Combats_CombatId";
            this.fKdboPlayersdboCombatsCombatIdBindingSource.DataSource = this.combatsBindingSource;
            // 
            // hitLogsBindingSource
            // 
            this.hitLogsBindingSource.DataMember = "HitLogs";
            this.hitLogsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // hitLogsTableAdapter
            // 
            this.hitLogsTableAdapter.ClearBeforeFill = true;
            // 
            // fKdboHitLogsdboCombatsCombatIdBindingSource
            // 
            this.fKdboHitLogsdboCombatsCombatIdBindingSource.DataMember = "FK_dbo.HitLogs_dbo.Combats_CombatId";
            this.fKdboHitLogsdboCombatsCombatIdBindingSource.DataSource = this.combatsBindingSource;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 306);
            this.Controls.Add(this.transcationsDataGridView);
            this.Controls.Add(this.playersDataGridView);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTranscationsdboPlayersPlayerIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboPlayersdboCombatsCombatIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboHitLogsdboCombatsCombatIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CombatDbDataSet combatDbDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private CombatDbDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private CombatDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CombatDbDataSetTableAdapters.TranscationsTableAdapter transcationsTableAdapter;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource transcationsBindingSource;
        private System.Windows.Forms.DataGridView transcationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource fKdboTranscationsdboPlayersPlayerIdBindingSource;
        private CombatDbDataSetTableAdapters.CombatsTableAdapter combatsTableAdapter;
        private System.Windows.Forms.BindingSource combatsBindingSource;
        private System.Windows.Forms.BindingSource fKdboPlayersdboCombatsCombatIdBindingSource;
        private CombatDbDataSetTableAdapters.HitLogsTableAdapter hitLogsTableAdapter;
        private System.Windows.Forms.BindingSource hitLogsBindingSource;
        private System.Windows.Forms.BindingSource fKdboHitLogsdboCombatsCombatIdBindingSource;

    }
}