namespace FightClubApp.UI.Raiting
{
    partial class RaitingUserControl
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
            this.tie = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.fight = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.toMenu = new System.Windows.Forms.Button();
            this.raitingTable = new System.Windows.Forms.DataGridView();
            this.loos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raitingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tie
            // 
            this.tie.AutoSize = true;
            this.tie.BackColor = System.Drawing.Color.Transparent;
            this.tie.ForeColor = System.Drawing.SystemColors.Control;
            this.tie.Location = new System.Drawing.Point(354, 21);
            this.tie.Name = "tie";
            this.tie.Size = new System.Drawing.Size(38, 13);
            this.tie.TabIndex = 32;
            this.tie.Text = "Ничьи";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.ForeColor = System.Drawing.SystemColors.Control;
            this.win.Location = new System.Drawing.Point(251, 21);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(47, 13);
            this.win.TabIndex = 31;
            this.win.Text = "Победы";
            // 
            // fight
            // 
            this.fight.AutoSize = true;
            this.fight.BackColor = System.Drawing.Color.Transparent;
            this.fight.ForeColor = System.Drawing.SystemColors.Control;
            this.fight.Location = new System.Drawing.Point(556, 21);
            this.fight.Name = "fight";
            this.fight.Size = new System.Drawing.Size(26, 13);
            this.fight.TabIndex = 30;
            this.fight.Text = "Бои";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.SystemColors.Control;
            this.name.Location = new System.Drawing.Point(170, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 29;
            this.name.Text = "Имя";
            // 
            // toMenu
            // 
            this.toMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMenu.Location = new System.Drawing.Point(299, 409);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(114, 30);
            this.toMenu.TabIndex = 28;
            this.toMenu.Text = "В меню";
            this.toMenu.UseVisualStyleBackColor = true;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // raitingTable
            // 
            this.raitingTable.AllowUserToResizeColumns = false;
            this.raitingTable.AllowUserToResizeRows = false;
            this.raitingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raitingTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.raitingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raitingTable.ColumnHeadersVisible = false;
            this.raitingTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.raitingTable.Location = new System.Drawing.Point(64, 46);
            this.raitingTable.Name = "raitingTable";
            this.raitingTable.RowHeadersVisible = false;
            this.raitingTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.raitingTable.Size = new System.Drawing.Size(595, 340);
            this.raitingTable.TabIndex = 2;
            // 
            // loos
            // 
            this.loos.AutoSize = true;
            this.loos.BackColor = System.Drawing.Color.Transparent;
            this.loos.ForeColor = System.Drawing.SystemColors.Control;
            this.loos.Location = new System.Drawing.Point(438, 21);
            this.loos.Name = "loos";
            this.loos.Size = new System.Drawing.Size(65, 13);
            this.loos.TabIndex = 33;
            this.loos.Text = "Поражения";
            // 
            // RaitingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.loos);
            this.Controls.Add(this.tie);
            this.Controls.Add(this.win);
            this.Controls.Add(this.fight);
            this.Controls.Add(this.name);
            this.Controls.Add(this.toMenu);
            this.Controls.Add(this.raitingTable);
            this.Name = "RaitingUserControl";
            this.Size = new System.Drawing.Size(740, 460);
            ((System.ComponentModel.ISupportInitialize)(this.raitingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView raitingTable;
        private System.Windows.Forms.Button toMenu;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label fight;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label tie;
        private System.Windows.Forms.Label loos;
    }
}
