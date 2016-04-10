namespace WinFormsEF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.combatDbDataSet = new WinFormsEF.CombatDbDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new WinFormsEF.CombatDbDataSetTableAdapters.TableAdapterManager();
            this.combatsTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.CombatsTableAdapter();
            this.hitLogsTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.HitLogsTableAdapter();
            this.pvesTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.PvesTableAdapter();
            this.pvpsTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.PvpsTableAdapter();
            this.transcationsTableAdapter = new WinFormsEF.CombatDbDataSetTableAdapters.TranscationsTableAdapter();
            this.playersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.combatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hitLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transcationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvpsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).BeginInit();
            this.playersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvpsBindingSource)).BeginInit();
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
            this.tableAdapterManager.PvesTableAdapter = this.pvesTableAdapter;
            this.tableAdapterManager.PvpsTableAdapter = this.pvpsTableAdapter;
            this.tableAdapterManager.TranscationsTableAdapter = this.transcationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsEF.CombatDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combatsTableAdapter
            // 
            this.combatsTableAdapter.ClearBeforeFill = true;
            // 
            // hitLogsTableAdapter
            // 
            this.hitLogsTableAdapter.ClearBeforeFill = true;
            // 
            // pvesTableAdapter
            // 
            this.pvesTableAdapter.ClearBeforeFill = true;
            // 
            // pvpsTableAdapter
            // 
            this.pvpsTableAdapter.ClearBeforeFill = true;
            // 
            // transcationsTableAdapter
            // 
            this.transcationsTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingNavigator
            // 
            this.playersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playersBindingNavigator.BindingSource = this.playersBindingSource;
            this.playersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playersBindingNavigatorSaveItem});
            this.playersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playersBindingNavigator.Name = "playersBindingNavigator";
            this.playersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playersBindingNavigator.Size = new System.Drawing.Size(736, 25);
            this.playersBindingNavigator.TabIndex = 0;
            this.playersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // playersBindingNavigatorSaveItem
            // 
            this.playersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersBindingNavigatorSaveItem.Image")));
            this.playersBindingNavigatorSaveItem.Name = "playersBindingNavigatorSaveItem";
            this.playersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.playersBindingNavigatorSaveItem.Text = "Save Data";
            this.playersBindingNavigatorSaveItem.Click += new System.EventHandler(this.playersBindingNavigatorSaveItem_Click);
            // 
            // playersGridControl
            // 
            this.playersGridControl.DataSource = this.playersBindingSource;
            this.playersGridControl.Location = new System.Drawing.Point(0, 28);
            this.playersGridControl.MainView = this.gridView1;
            this.playersGridControl.Name = "playersGridControl";
            this.playersGridControl.Size = new System.Drawing.Size(737, 252);
            this.playersGridControl.TabIndex = 1;
            this.playersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.playersGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // combatsBindingSource
            // 
            this.combatsBindingSource.DataMember = "Combats";
            this.combatsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // combatsGridControl
            // 
            this.combatsGridControl.DataSource = this.combatsBindingSource;
            this.combatsGridControl.Location = new System.Drawing.Point(0, 277);
            this.combatsGridControl.MainView = this.gridView2;
            this.combatsGridControl.Name = "combatsGridControl";
            this.combatsGridControl.Size = new System.Drawing.Size(737, 249);
            this.combatsGridControl.TabIndex = 2;
            this.combatsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.combatsGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // hitLogsBindingSource
            // 
            this.hitLogsBindingSource.DataMember = "HitLogs";
            this.hitLogsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // transcationsBindingSource
            // 
            this.transcationsBindingSource.DataMember = "Transcations";
            this.transcationsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // pvesBindingSource
            // 
            this.pvesBindingSource.DataMember = "Pves";
            this.pvesBindingSource.DataSource = this.combatDbDataSet;
            // 
            // pvpsBindingSource
            // 
            this.pvpsBindingSource.DataMember = "Pvps";
            this.pvpsBindingSource.DataSource = this.combatDbDataSet;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 525);
            this.Controls.Add(this.combatsGridControl);
            this.Controls.Add(this.playersGridControl);
            this.Controls.Add(this.playersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combatDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).EndInit();
            this.playersBindingNavigator.ResumeLayout(false);
            this.playersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvpsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CombatDbDataSet combatDbDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private CombatDbDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private CombatDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator playersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playersBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl playersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CombatDbDataSetTableAdapters.CombatsTableAdapter combatsTableAdapter;
        private System.Windows.Forms.BindingSource combatsBindingSource;
        private DevExpress.XtraGrid.GridControl combatsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private CombatDbDataSetTableAdapters.HitLogsTableAdapter hitLogsTableAdapter;
        private System.Windows.Forms.BindingSource hitLogsBindingSource;
        private CombatDbDataSetTableAdapters.TranscationsTableAdapter transcationsTableAdapter;
        private System.Windows.Forms.BindingSource transcationsBindingSource;
        private CombatDbDataSetTableAdapters.PvesTableAdapter pvesTableAdapter;
        private System.Windows.Forms.BindingSource pvesBindingSource;
        private CombatDbDataSetTableAdapters.PvpsTableAdapter pvpsTableAdapter;
        private System.Windows.Forms.BindingSource pvpsBindingSource;
    }
}