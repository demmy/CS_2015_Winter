/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:58
 */
using System.Windows.Forms;
namespace Combats
{
    partial class MainUserControl
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.PictureBox StartLogo;
        private System.Windows.Forms.DataGridView TopPlayesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordsTablePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordsTablePlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordsTableWins;
        private System.Windows.Forms.TextBox InputPlayerName;
        private System.Windows.Forms.Label TopPlayers;
        private System.Windows.Forms.GroupBox StartPage;
        
        /// <summary>
        /// Disposes resources used by the control.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StartPage = new System.Windows.Forms.GroupBox();
            this.StartLogo = new System.Windows.Forms.PictureBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.TopPlayesTable = new System.Windows.Forms.DataGridView();
            this.RecordsTablePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordsTablePlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordsTableWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPlayerName = new System.Windows.Forms.TextBox();
            this.TopPlayers = new System.Windows.Forms.Label();
            this.StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPlayesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPage
            // 
            this.StartPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartPage.Controls.Add(this.StartLogo);
            this.StartPage.Controls.Add(this.StartGame);
            this.StartPage.Controls.Add(this.TopPlayesTable);
            this.StartPage.Controls.Add(this.InputPlayerName);
            this.StartPage.Controls.Add(this.TopPlayers);
            this.StartPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPage.Location = new System.Drawing.Point(0, 0);
            this.StartPage.Margin = new System.Windows.Forms.Padding(0);
            this.StartPage.MinimumSize = new System.Drawing.Size(640, 600);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(0);
            this.StartPage.Size = new System.Drawing.Size(800, 600);
            this.StartPage.TabIndex = 14;
            this.StartPage.TabStop = false;
            // 
            // StartLogo
            // 
            this.StartLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartLogo.Image = ((System.Drawing.Image)(resources.GetObject("StartLogo.Image")));
            this.StartLogo.Location = new System.Drawing.Point(173, 11);
            this.StartLogo.Name = "StartLogo";
            this.StartLogo.Size = new System.Drawing.Size(428, 217);
            this.StartLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartLogo.TabIndex = 12;
            this.StartLogo.TabStop = false;
            // 
            // StartGame
            // 
            this.StartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartGame.Location = new System.Drawing.Point(303, 527);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(181, 23);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "В бой!";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGameClick);
            // 
            // TopPlayesTable
            // 
            this.TopPlayesTable.AllowUserToAddRows = false;
            this.TopPlayesTable.AllowUserToDeleteRows = false;
            this.TopPlayesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TopPlayesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TopPlayesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TopPlayesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopPlayesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordsTablePlace,
            this.RecordsTablePlayerName,
            this.RecordsTableWins});
            this.TopPlayesTable.Location = new System.Drawing.Point(93, 257);
            this.TopPlayesTable.Name = "TopPlayesTable";
            this.TopPlayesTable.ReadOnly = true;
            this.TopPlayesTable.RowHeadersVisible = false;
            this.TopPlayesTable.Size = new System.Drawing.Size(600, 232);
            this.TopPlayesTable.TabIndex = 2;
            // 
            // Place
            // 
            this.RecordsTablePlace.FillWeight = 8F;
            this.RecordsTablePlace.HeaderText = "Место";
            this.RecordsTablePlace.MinimumWidth = 50;
            this.RecordsTablePlace.Name = "RecordsTablePlace";
            this.RecordsTablePlace.ReadOnly = true;
            this.RecordsTablePlace.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordsTablePlace.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RecordsTablePlace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlayerName
            // 
            this.RecordsTablePlayerName.FillWeight = 84F;
            this.RecordsTablePlayerName.HeaderText = "Имя игрока";
            this.RecordsTablePlayerName.Name = "RecordsTablePlayerName";
            this.RecordsTablePlayerName.ReadOnly = true;
            this.RecordsTablePlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Wins
            // 
            this.RecordsTableWins.FillWeight = 8F;
            this.RecordsTableWins.HeaderText = "Побед";
            this.RecordsTableWins.MinimumWidth = 50;
            this.RecordsTableWins.Name = "RecordsTableWins";
            this.RecordsTableWins.ReadOnly = true;
            this.RecordsTableWins.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordsTableWins.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InputPlayerName
            // 
            this.InputPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InputPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPlayerName.Location = new System.Drawing.Point(303, 499);
            this.InputPlayerName.Name = "InputPlayerName";
            this.InputPlayerName.Size = new System.Drawing.Size(181, 22);
            this.InputPlayerName.TabIndex = 11;
            this.InputPlayerName.Text = "Player";
            this.InputPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopPlayers
            // 
            this.TopPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPlayers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPlayers.Location = new System.Drawing.Point(93, 231);
            this.TopPlayers.Name = "TopPlayers";
            this.TopPlayers.Size = new System.Drawing.Size(600, 23);
            this.TopPlayers.TabIndex = 1;
            this.TopPlayers.Text = "Таблица рекордов";
            this.TopPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartPage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPlayesTable)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
