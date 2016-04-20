namespace fight_club
{ 
    partial class PlayerCreationUserControl
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
            this.PlayerCreateButton = new System.Windows.Forms.Button();
            this.StaminaValue = new System.Windows.Forms.NumericUpDown();
            this.AgilityValue = new System.Windows.Forms.NumericUpDown();
            this.StraightValue = new System.Windows.Forms.NumericUpDown();
            this.StaminaLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.StraightLabel = new System.Windows.Forms.Label();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.LastStatsLabel = new System.Windows.Forms.Label();
            this.ChosingStatsPanel = new System.Windows.Forms.Panel();
            this.LastStatsPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PlayerAvatarPanel = new System.Windows.Forms.Panel();
            this.LoadAvatarButton = new System.Windows.Forms.Button();
            this.LaodAvatarLabel = new System.Windows.Forms.Label();
            this.NewPlayerTextBox = new System.Windows.Forms.TextBox();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaminaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StraightValue)).BeginInit();
            this.ChosingStatsPanel.SuspendLayout();
            this.LastStatsPanel.SuspendLayout();
            this.PlayerAvatarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerCreateButton
            // 
            this.PlayerCreateButton.Location = new System.Drawing.Point(259, 234);
            this.PlayerCreateButton.Name = "PlayerCreateButton";
            this.PlayerCreateButton.Size = new System.Drawing.Size(184, 47);
            this.PlayerCreateButton.TabIndex = 31;
            this.PlayerCreateButton.Text = "Create";
            this.PlayerCreateButton.UseVisualStyleBackColor = true;
            this.PlayerCreateButton.Click += new System.EventHandler(this.PlayerCreateButton_Click);
            // 
            // StaminaValue
            // 
            this.StaminaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaminaValue.Location = new System.Drawing.Point(94, 82);
            this.StaminaValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.StaminaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StaminaValue.Name = "StaminaValue";
            this.StaminaValue.ReadOnly = true;
            this.StaminaValue.Size = new System.Drawing.Size(47, 22);
            this.StaminaValue.TabIndex = 9;
            this.StaminaValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.StaminaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StaminaValue.ValueChanged += new System.EventHandler(this.StaminaValue_ValueChanged);
            // 
            // AgilityValue
            // 
            this.AgilityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityValue.Location = new System.Drawing.Point(94, 53);
            this.AgilityValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.AgilityValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgilityValue.Name = "AgilityValue";
            this.AgilityValue.ReadOnly = true;
            this.AgilityValue.Size = new System.Drawing.Size(47, 22);
            this.AgilityValue.TabIndex = 8;
            this.AgilityValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.AgilityValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgilityValue.ValueChanged += new System.EventHandler(this.AgilityValue_ValueChanged);
            // 
            // StraightValue
            // 
            this.StraightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StraightValue.Location = new System.Drawing.Point(94, 23);
            this.StraightValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.StraightValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StraightValue.Name = "StraightValue";
            this.StraightValue.ReadOnly = true;
            this.StraightValue.Size = new System.Drawing.Size(47, 22);
            this.StraightValue.TabIndex = 7;
            this.StraightValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.StraightValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StraightValue.ValueChanged += new System.EventHandler(this.StraightValue_ValueChanged);
            // 
            // StaminaLabel
            // 
            this.StaminaLabel.AutoSize = true;
            this.StaminaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaminaLabel.Location = new System.Drawing.Point(27, 84);
            this.StaminaLabel.Name = "StaminaLabel";
            this.StaminaLabel.Size = new System.Drawing.Size(57, 16);
            this.StaminaLabel.TabIndex = 2;
            this.StaminaLabel.Text = "Stamina";
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityLabel.Location = new System.Drawing.Point(27, 55);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(44, 16);
            this.AgilityLabel.TabIndex = 1;
            this.AgilityLabel.Text = "Agility";
            // 
            // StraightLabel
            // 
            this.StraightLabel.AutoSize = true;
            this.StraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StraightLabel.Location = new System.Drawing.Point(27, 25);
            this.StraightLabel.Name = "StraightLabel";
            this.StraightLabel.Size = new System.Drawing.Size(53, 16);
            this.StraightLabel.TabIndex = 0;
            this.StraightLabel.Text = "Straight";
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.Location = new System.Drawing.Point(17, 234);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(196, 47);
            this.ToMenuButton.TabIndex = 30;
            this.ToMenuButton.Text = "Back";
            this.ToMenuButton.UseVisualStyleBackColor = true;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // LastStatsLabel
            // 
            this.LastStatsLabel.AutoSize = true;
            this.LastStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastStatsLabel.Location = new System.Drawing.Point(15, 6);
            this.LastStatsLabel.Name = "LastStatsLabel";
            this.LastStatsLabel.Size = new System.Drawing.Size(15, 16);
            this.LastStatsLabel.TabIndex = 6;
            this.LastStatsLabel.Text = "5";
            // 
            // ChosingStatsPanel
            // 
            this.ChosingStatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChosingStatsPanel.Controls.Add(this.LastStatsPanel);
            this.ChosingStatsPanel.Controls.Add(this.StaminaValue);
            this.ChosingStatsPanel.Controls.Add(this.AgilityValue);
            this.ChosingStatsPanel.Controls.Add(this.StraightValue);
            this.ChosingStatsPanel.Controls.Add(this.StaminaLabel);
            this.ChosingStatsPanel.Controls.Add(this.AgilityLabel);
            this.ChosingStatsPanel.Controls.Add(this.StraightLabel);
            this.ChosingStatsPanel.Location = new System.Drawing.Point(259, 14);
            this.ChosingStatsPanel.Name = "ChosingStatsPanel";
            this.ChosingStatsPanel.Size = new System.Drawing.Size(184, 204);
            this.ChosingStatsPanel.TabIndex = 29;
            // 
            // LastStatsPanel
            // 
            this.LastStatsPanel.Controls.Add(this.LastStatsLabel);
            this.LastStatsPanel.Location = new System.Drawing.Point(93, 128);
            this.LastStatsPanel.Name = "LastStatsPanel";
            this.LastStatsPanel.Size = new System.Drawing.Size(48, 27);
            this.LastStatsPanel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "place for image";
            // 
            // PlayerAvatarPanel
            // 
            this.PlayerAvatarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerAvatarPanel.Controls.Add(this.label11);
            this.PlayerAvatarPanel.Location = new System.Drawing.Point(17, 112);
            this.PlayerAvatarPanel.Name = "PlayerAvatarPanel";
            this.PlayerAvatarPanel.Size = new System.Drawing.Size(196, 106);
            this.PlayerAvatarPanel.TabIndex = 28;
            // 
            // LoadAvatarButton
            // 
            this.LoadAvatarButton.Location = new System.Drawing.Point(107, 69);
            this.LoadAvatarButton.Name = "LoadAvatarButton";
            this.LoadAvatarButton.Size = new System.Drawing.Size(106, 23);
            this.LoadAvatarButton.TabIndex = 27;
            this.LoadAvatarButton.Text = "Load";
            this.LoadAvatarButton.UseVisualStyleBackColor = true;
            // 
            // LaodAvatarLabel
            // 
            this.LaodAvatarLabel.AutoSize = true;
            this.LaodAvatarLabel.Location = new System.Drawing.Point(14, 74);
            this.LaodAvatarLabel.Name = "LaodAvatarLabel";
            this.LaodAvatarLabel.Size = new System.Drawing.Size(87, 13);
            this.LaodAvatarLabel.TabIndex = 26;
            this.LaodAvatarLabel.Text = "Load your avatar";
            // 
            // NewPlayerTextBox
            // 
            this.NewPlayerTextBox.Location = new System.Drawing.Point(17, 39);
            this.NewPlayerTextBox.MaxLength = 10;
            this.NewPlayerTextBox.Name = "NewPlayerTextBox";
            this.NewPlayerTextBox.Size = new System.Drawing.Size(196, 20);
            this.NewPlayerTextBox.TabIndex = 25;
            this.NewPlayerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPlayerTextBox_KeyPress);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(14, 14);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(63, 13);
            this.EnterNameLabel.TabIndex = 24;
            this.EnterNameLabel.Text = "Enter Name";
            // 
            // PlayerCreationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerCreateButton);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.ChosingStatsPanel);
            this.Controls.Add(this.PlayerAvatarPanel);
            this.Controls.Add(this.LoadAvatarButton);
            this.Controls.Add(this.LaodAvatarLabel);
            this.Controls.Add(this.NewPlayerTextBox);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "PlayerCreationUserControl";
            this.Size = new System.Drawing.Size(456, 312);
            this.Load += new System.EventHandler(this.PlayerCreationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaminaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StraightValue)).EndInit();
            this.ChosingStatsPanel.ResumeLayout(false);
            this.ChosingStatsPanel.PerformLayout();
            this.LastStatsPanel.ResumeLayout(false);
            this.LastStatsPanel.PerformLayout();
            this.PlayerAvatarPanel.ResumeLayout(false);
            this.PlayerAvatarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerCreateButton;
        private System.Windows.Forms.NumericUpDown StaminaValue;
        private System.Windows.Forms.NumericUpDown AgilityValue;
        private System.Windows.Forms.NumericUpDown StraightValue;
        private System.Windows.Forms.Label StaminaLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label StraightLabel;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.Label LastStatsLabel;
        private System.Windows.Forms.Panel ChosingStatsPanel;
        private System.Windows.Forms.Panel LastStatsPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PlayerAvatarPanel;
        private System.Windows.Forms.Button LoadAvatarButton;
        private System.Windows.Forms.Label LaodAvatarLabel;
        private System.Windows.Forms.TextBox NewPlayerTextBox;
        private System.Windows.Forms.Label EnterNameLabel;
    }
}
