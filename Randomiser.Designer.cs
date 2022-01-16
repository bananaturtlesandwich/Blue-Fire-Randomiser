
namespace BlueFireRando
{
    partial class Randomiser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomiser));
            this.Randomise = new System.Windows.Forms.Button();
            this.UmbyPet = new System.Windows.Forms.PictureBox();
            this.Spirits = new System.Windows.Forms.CheckBox();
            this.Mix = new System.Windows.Forms.CheckBox();
            this.Weapons = new System.Windows.Forms.CheckBox();
            this.KeyItems = new System.Windows.Forms.CheckBox();
            this.RandoOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.Tunics = new System.Windows.Forms.CheckBox();
            this.Emotes = new System.Windows.Forms.CheckBox();
            this.Items = new System.Windows.Forms.CheckBox();
            this.Disclaimer = new System.Windows.Forms.TextBox();
            this.American = new System.Windows.Forms.CheckBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.modfoldercheck = new System.Windows.Forms.FolderBrowserDialog();
            this.deletePak = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).BeginInit();
            this.RandoOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // Randomise
            // 
            this.Randomise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Randomise.BackColor = System.Drawing.SystemColors.Control;
            this.Randomise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Randomise.BackgroundImage")));
            this.Randomise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Randomise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Randomise.FlatAppearance.BorderSize = 0;
            this.Randomise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Randomise.Font = new System.Drawing.Font("Cinzel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomise.Location = new System.Drawing.Point(4, 395);
            this.Randomise.Margin = new System.Windows.Forms.Padding(4, 50, 4, 4);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(458, 259);
            this.Randomise.TabIndex = 0;
            this.Randomise.Text = "Randomise";
            this.Randomise.UseVisualStyleBackColor = false;
            this.Randomise.Click += new System.EventHandler(this.Randomise_Click);
            // 
            // UmbyPet
            // 
            this.UmbyPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UmbyPet.BackColor = System.Drawing.Color.Transparent;
            this.UmbyPet.ErrorImage = ((System.Drawing.Image)(resources.GetObject("UmbyPet.ErrorImage")));
            this.UmbyPet.Image = ((System.Drawing.Image)(resources.GetObject("UmbyPet.Image")));
            this.UmbyPet.InitialImage = ((System.Drawing.Image)(resources.GetObject("UmbyPet.InitialImage")));
            this.UmbyPet.Location = new System.Drawing.Point(-11, 386);
            this.UmbyPet.Name = "UmbyPet";
            this.UmbyPet.Size = new System.Drawing.Size(406, 382);
            this.UmbyPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UmbyPet.TabIndex = 4;
            this.UmbyPet.TabStop = false;
            // 
            // Spirits
            // 
            this.Spirits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spirits.AutoSize = true;
            this.Spirits.BackColor = System.Drawing.Color.Transparent;
            this.Spirits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spirits.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spirits.ForeColor = System.Drawing.SystemColors.Control;
            this.Spirits.Location = new System.Drawing.Point(3, 253);
            this.Spirits.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Spirits.Name = "Spirits";
            this.Spirits.Size = new System.Drawing.Size(367, 48);
            this.Spirits.TabIndex = 5;
            this.Spirits.Text = "Randomise Spirits?";
            this.Spirits.UseVisualStyleBackColor = false;
            this.Spirits.CheckedChanged += new System.EventHandler(this.Spirits_CheckedChanged);
            // 
            // Mix
            // 
            this.Mix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mix.AutoSize = true;
            this.Mix.BackColor = System.Drawing.Color.Transparent;
            this.Mix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mix.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mix.ForeColor = System.Drawing.SystemColors.Control;
            this.Mix.Location = new System.Drawing.Point(3, 25);
            this.Mix.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(416, 48);
            this.Mix.TabIndex = 6;
            this.Mix.Text = "Mix Randomisation?*";
            this.Mix.UseVisualStyleBackColor = false;
            // 
            // Weapons
            // 
            this.Weapons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weapons.AutoSize = true;
            this.Weapons.BackColor = System.Drawing.Color.Transparent;
            this.Weapons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapons.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapons.ForeColor = System.Drawing.SystemColors.Control;
            this.Weapons.Location = new System.Drawing.Point(3, 101);
            this.Weapons.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(425, 48);
            this.Weapons.TabIndex = 7;
            this.Weapons.Text = "Randomise Weapons?*";
            this.Weapons.UseVisualStyleBackColor = false;
            // 
            // KeyItems
            // 
            this.KeyItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyItems.AutoSize = true;
            this.KeyItems.BackColor = System.Drawing.Color.Transparent;
            this.KeyItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyItems.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyItems.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyItems.Location = new System.Drawing.Point(3, 177);
            this.KeyItems.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.KeyItems.Name = "KeyItems";
            this.KeyItems.Size = new System.Drawing.Size(417, 48);
            this.KeyItems.TabIndex = 10;
            this.KeyItems.Text = "Randomise Key Items?";
            this.KeyItems.UseVisualStyleBackColor = false;
            // 
            // RandoOptions
            // 
            this.RandoOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RandoOptions.BackColor = System.Drawing.Color.Transparent;
            this.RandoOptions.Controls.Add(this.Mix);
            this.RandoOptions.Controls.Add(this.Weapons);
            this.RandoOptions.Controls.Add(this.KeyItems);
            this.RandoOptions.Controls.Add(this.Spirits);
            this.RandoOptions.Controls.Add(this.Tunics);
            this.RandoOptions.Controls.Add(this.Emotes);
            this.RandoOptions.Controls.Add(this.Items);
            this.RandoOptions.Location = new System.Drawing.Point(393, 23);
            this.RandoOptions.Name = "RandoOptions";
            this.RandoOptions.Size = new System.Drawing.Size(420, 728);
            this.RandoOptions.TabIndex = 11;
            // 
            // Tunics
            // 
            this.Tunics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tunics.AutoSize = true;
            this.Tunics.BackColor = System.Drawing.Color.Transparent;
            this.Tunics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tunics.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tunics.ForeColor = System.Drawing.SystemColors.Control;
            this.Tunics.Location = new System.Drawing.Point(3, 329);
            this.Tunics.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Tunics.Name = "Tunics";
            this.Tunics.Size = new System.Drawing.Size(387, 48);
            this.Tunics.TabIndex = 11;
            this.Tunics.Text = "Randomise Tunics?*";
            this.Tunics.UseVisualStyleBackColor = false;
            // 
            // Emotes
            // 
            this.Emotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Emotes.AutoSize = true;
            this.Emotes.BackColor = System.Drawing.Color.Transparent;
            this.Emotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emotes.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emotes.ForeColor = System.Drawing.SystemColors.Control;
            this.Emotes.Location = new System.Drawing.Point(3, 405);
            this.Emotes.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Emotes.Name = "Emotes";
            this.Emotes.Size = new System.Drawing.Size(394, 48);
            this.Emotes.TabIndex = 12;
            this.Emotes.Text = "Randomise Emotes?*";
            this.Emotes.UseVisualStyleBackColor = false;
            // 
            // Items
            // 
            this.Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Items.AutoSize = true;
            this.Items.BackColor = System.Drawing.Color.Transparent;
            this.Items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Items.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.ForeColor = System.Drawing.SystemColors.Control;
            this.Items.Location = new System.Drawing.Point(3, 481);
            this.Items.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(348, 48);
            this.Items.TabIndex = 13;
            this.Items.Text = "Randomise Items?";
            this.Items.UseVisualStyleBackColor = false;
            // 
            // Disclaimer
            // 
            this.Disclaimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Disclaimer.BackColor = System.Drawing.SystemColors.MenuText;
            this.Disclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disclaimer.Font = new System.Drawing.Font("Cinzel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disclaimer.ForeColor = System.Drawing.Color.LightGreen;
            this.Disclaimer.Location = new System.Drawing.Point(3, 174);
            this.Disclaimer.Multiline = true;
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.ShortcutsEnabled = false;
            this.Disclaimer.Size = new System.Drawing.Size(459, 168);
            this.Disclaimer.TabIndex = 3;
            this.Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them " +
    "it will have no effect.\r\nMix randomisation means key items can be in weapon loca" +
    "tions etc.";
            // 
            // American
            // 
            this.American.AutoSize = true;
            this.American.BackColor = System.Drawing.Color.Transparent;
            this.American.Cursor = System.Windows.Forms.Cursors.Hand;
            this.American.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.American.ForeColor = System.Drawing.SystemColors.Control;
            this.American.Location = new System.Drawing.Point(13, 64);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(320, 48);
            this.American.TabIndex = 12;
            this.American.Text = "American mode";
            this.American.UseVisualStyleBackColor = false;
            this.American.CheckedChanged += new System.EventHandler(this.American_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(459, 165);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // modfoldercheck
            // 
            this.modfoldercheck.Description = "Please select the mod folder location-this is Blue Fire/Content/Paks/~mods (if yo" +
    "u do not have a ~mods folder in Paks then make one)";
            this.modfoldercheck.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // deletePak
            // 
            this.deletePak.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deletePak.BackColor = System.Drawing.SystemColors.Control;
            this.deletePak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletePak.BackgroundImage")));
            this.deletePak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletePak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePak.FlatAppearance.BorderSize = 0;
            this.deletePak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletePak.Font = new System.Drawing.Font("Cinzel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePak.Location = new System.Drawing.Point(13, 173);
            this.deletePak.Margin = new System.Windows.Forms.Padding(4);
            this.deletePak.Name = "deletePak";
            this.deletePak.Size = new System.Drawing.Size(373, 178);
            this.deletePak.TabIndex = 14;
            this.deletePak.Text = "Delete Mod Pak";
            this.deletePak.UseVisualStyleBackColor = false;
            this.deletePak.Click += new System.EventHandler(this.deletePak_Click);
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Controls.Add(this.Logo);
            this.Description.Controls.Add(this.Disclaimer);
            this.Description.Controls.Add(this.Randomise);
            this.Description.Location = new System.Drawing.Point(819, 23);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(466, 728);
            this.Description.TabIndex = 15;
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 763);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.deletePak);
            this.Controls.Add(this.American);
            this.Controls.Add(this.RandoOptions);
            this.Controls.Add(this.UmbyPet);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cinzel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Randomiser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Fire Randomiser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BFRandoGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).EndInit();
            this.RandoOptions.ResumeLayout(false);
            this.RandoOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Description.ResumeLayout(false);
            this.Description.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Randomise;
        private System.Windows.Forms.PictureBox UmbyPet;
        private System.Windows.Forms.CheckBox Spirits;
        private System.Windows.Forms.CheckBox Mix;
        private System.Windows.Forms.CheckBox Weapons;
        private System.Windows.Forms.CheckBox KeyItems;
        private System.Windows.Forms.FlowLayoutPanel RandoOptions;
        private System.Windows.Forms.TextBox Disclaimer;
        private System.Windows.Forms.CheckBox American;
        private System.Windows.Forms.PictureBox Logo;
        public System.Windows.Forms.FolderBrowserDialog modfoldercheck;
        private System.Windows.Forms.CheckBox Tunics;
        private System.Windows.Forms.CheckBox Emotes;
        private System.Windows.Forms.Button deletePak;
        private System.Windows.Forms.CheckBox Items;
        private System.Windows.Forms.FlowLayoutPanel Description;
    }
}

