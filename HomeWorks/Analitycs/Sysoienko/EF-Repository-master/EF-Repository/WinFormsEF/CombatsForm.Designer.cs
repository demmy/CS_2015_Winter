namespace WinFormsEF
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
            this.combatDbDataSet = new WinFormsEF.CombatDbDataSet();
            this.combatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatsTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.CombatsTableAdapter();
            this.tableAdapterManager = new WinFormsEF.CombatDbDataSetTableAdapters.TableAdapterManager();
            this.combatsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tableAdapterManager.UpdateOrder = WinFormsEF.CombatDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combatsGridControl
            // 
            this.combatsGridControl.DataSource = this.combatsBindingSource;
            this.combatsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combatsGridControl.Location = new System.Drawing.Point(0, 0);
            this.combatsGridControl.MainView = this.gridView1;
            this.combatsGridControl.Name = "combatsGridControl";
            this.combatsGridControl.Size = new System.Drawing.Size(600, 315);
            this.combatsGridControl.TabIndex = 1;
            this.combatsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.combatsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // CombatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.Controls.Add(this.combatsGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CombatsForm";
            this.Text = "Combats";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CombatDbDataSet combatDbDataSet;
        private System.Windows.Forms.BindingSource combatsBindingSource;
        private CombatDbDataSetTableAdapters.CombatsTableAdapter combatsTableAdapter;
        private CombatDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl combatsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;


    }
}