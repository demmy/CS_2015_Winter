namespace Combats
{
    partial class Score
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insertNameTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.resultDataGtid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGtid)).BeginInit();
            this.SuspendLayout();
            // 
            // insertNameTxt
            // 
            this.insertNameTxt.Location = new System.Drawing.Point(12, 254);
            this.insertNameTxt.Name = "insertNameTxt";
            this.insertNameTxt.Size = new System.Drawing.Size(303, 20);
            this.insertNameTxt.TabIndex = 0;
            this.insertNameTxt.Text = "Введите ваше имя";
            this.insertNameTxt.Click += new System.EventHandler(this.InsertNameTxt_Click);
            this.insertNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.insertNameTxt_KeyDown);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(332, 254);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(66, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "В бой";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // resultDataGtid
            // 
            this.resultDataGtid.AllowUserToResizeColumns = false;
            this.resultDataGtid.AllowUserToResizeRows = false;
            this.resultDataGtid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.resultDataGtid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGtid.ColumnHeadersVisible = false;
            this.resultDataGtid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGtid.DefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataGtid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.resultDataGtid.Location = new System.Drawing.Point(12, 16);
            this.resultDataGtid.Name = "resultDataGtid";
            this.resultDataGtid.RowHeadersVisible = false;
            this.resultDataGtid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultDataGtid.Size = new System.Drawing.Size(303, 222);
            this.resultDataGtid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hp";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Place";
            this.Column3.Name = "Column3";
            // 
            // rulesBox
            // 
            this.rulesBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rulesBox.Location = new System.Drawing.Point(332, 16);
            this.rulesBox.Multiline = true;
            this.rulesBox.Name = "rulesBox";
            this.rulesBox.ReadOnly = true;
            this.rulesBox.Size = new System.Drawing.Size(240, 222);
            this.rulesBox.TabIndex = 3;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(413, 254);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(159, 23);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Загрузить сохраненный бой";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.rulesBox);
            this.Controls.Add(this.resultDataGtid);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.insertNameTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(600, 330);
            this.MinimumSize = new System.Drawing.Size(600, 330);
            this.Name = "Score";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGtid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertNameTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.DataGridView resultDataGtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox rulesBox;
        private System.Windows.Forms.Button loadBtn;
    }
}