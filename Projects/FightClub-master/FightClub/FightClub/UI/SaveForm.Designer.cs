namespace FightClub
{
    partial class SaveForm
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
            this.dataRecords = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRecords
            // 
            this.dataRecords.AllowUserToAddRows = false;
            this.dataRecords.AllowUserToDeleteRows = false;
            this.dataRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRecords.Location = new System.Drawing.Point(12, 12);
            this.dataRecords.Name = "dataRecords";
            this.dataRecords.ReadOnly = true;
            this.dataRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataRecords.Size = new System.Drawing.Size(243, 69);
            this.dataRecords.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 105);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save Player";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdate.Location = new System.Drawing.Point(103, 105);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(65, 36);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Table Records";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // pveButton
            // 
            this.pveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pveButton.Location = new System.Drawing.Point(191, 105);
            this.pveButton.Name = "pveButton";
            this.pveButton.Size = new System.Drawing.Size(64, 23);
            this.pveButton.TabIndex = 4;
            this.pveButton.Text = "PVE";
            this.pveButton.UseVisualStyleBackColor = true;
            this.pveButton.Click += new System.EventHandler(this.pveButton_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 145);
            this.Controls.Add(this.pveButton);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveForm";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRecords;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button pveButton;
    }
}