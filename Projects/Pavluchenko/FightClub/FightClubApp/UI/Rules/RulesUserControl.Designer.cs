namespace FightClubApp.UI.Rules
{
    partial class RulesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesUserControl));
            this.toMenu = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toMenu
            // 
            this.toMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMenu.Location = new System.Drawing.Point(283, 388);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(114, 30);
            this.toMenu.TabIndex = 29;
            this.toMenu.Text = "В меню";
            this.toMenu.UseVisualStyleBackColor = true;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rules.Location = new System.Drawing.Point(102, 84);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(539, 120);
            this.Rules.TabIndex = 30;
            this.Rules.Text = resources.GetString("Rules.Text");
            // 
            // RulesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.toMenu);
            this.Name = "RulesUserControl";
            this.Size = new System.Drawing.Size(740, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toMenu;
        private System.Windows.Forms.Label Rules;
    }
}
