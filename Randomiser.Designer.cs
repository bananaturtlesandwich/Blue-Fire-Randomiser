
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
            this.UmbyPet = new System.Windows.Forms.PictureBox();
            this.Weapons = new System.Windows.Forms.CheckBox();
            this.KeyItems = new System.Windows.Forms.CheckBox();
            this.RandoOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.Tunics = new System.Windows.Forms.CheckBox();
            this.Emotes = new System.Windows.Forms.CheckBox();
            this.Items = new System.Windows.Forms.CheckBox();
            this.Spirits = new System.Windows.Forms.CheckBox();
            this.American = new System.Windows.Forms.CheckBox();
            this.modfoldercheck = new System.Windows.Forms.FolderBrowserDialog();
            this.deletePak = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Randomise = new System.Windows.Forms.Button();
            this.LeftSide = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).BeginInit();
            this.RandoOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.LeftSide.SuspendLayout();
            this.SuspendLayout();
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
            // Weapons
            // 
            this.Weapons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weapons.AutoSize = true;
            this.Weapons.BackColor = System.Drawing.Color.Transparent;
            this.Weapons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapons.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapons.ForeColor = System.Drawing.SystemColors.Control;
            this.Weapons.Location = new System.Drawing.Point(25, 25);
            this.Weapons.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(497, 52);
            this.Weapons.TabIndex = 7;
            this.Weapons.Text = "Randomise Weapons?";
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
            this.KeyItems.Location = new System.Drawing.Point(25, 105);
            this.KeyItems.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.KeyItems.Name = "KeyItems";
            this.KeyItems.Size = new System.Drawing.Size(503, 52);
            this.KeyItems.TabIndex = 10;
            this.KeyItems.Text = "Randomise Key Items?";
            this.KeyItems.UseVisualStyleBackColor = false;
            // 
            // RandoOptions
            // 
            this.RandoOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RandoOptions.BackColor = System.Drawing.Color.Transparent;
            this.RandoOptions.Controls.Add(this.Weapons);
            this.RandoOptions.Controls.Add(this.KeyItems);
            this.RandoOptions.Controls.Add(this.Tunics);
            this.RandoOptions.Controls.Add(this.Emotes);
            this.RandoOptions.Controls.Add(this.Items);
            this.RandoOptions.Controls.Add(this.Spirits);
            this.RandoOptions.Location = new System.Drawing.Point(393, 288);
            this.RandoOptions.Name = "RandoOptions";
            this.RandoOptions.Size = new System.Drawing.Size(412, 463);
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
            this.Tunics.Location = new System.Drawing.Point(25, 185);
            this.Tunics.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.Tunics.Name = "Tunics";
            this.Tunics.Size = new System.Drawing.Size(450, 52);
            this.Tunics.TabIndex = 11;
            this.Tunics.Text = "Randomise Tunics?";
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
            this.Emotes.Location = new System.Drawing.Point(25, 265);
            this.Emotes.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.Emotes.Name = "Emotes";
            this.Emotes.Size = new System.Drawing.Size(459, 52);
            this.Emotes.TabIndex = 12;
            this.Emotes.Text = "Randomise Emotes?";
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
            this.Items.Location = new System.Drawing.Point(25, 345);
            this.Items.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(419, 52);
            this.Items.TabIndex = 13;
            this.Items.Text = "Randomise Items?";
            this.Items.UseVisualStyleBackColor = false;
            // 
            // Spirits
            // 
            this.Spirits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spirits.AutoSize = true;
            this.Spirits.BackColor = System.Drawing.Color.Transparent;
            this.Spirits.CausesValidation = false;
            this.Spirits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spirits.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spirits.ForeColor = System.Drawing.SystemColors.Control;
            this.Spirits.Location = new System.Drawing.Point(25, 425);
            this.Spirits.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.Spirits.Name = "Spirits";
            this.Spirits.Size = new System.Drawing.Size(440, 52);
            this.Spirits.TabIndex = 14;
            this.Spirits.Text = "Randomise Spirits?";
            this.Spirits.UseVisualStyleBackColor = false;
            // 
            // American
            // 
            this.American.AutoSize = true;
            this.American.BackColor = System.Drawing.Color.Transparent;
            this.American.Cursor = System.Windows.Forms.Cursors.Hand;
            this.American.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.American.ForeColor = System.Drawing.SystemColors.Control;
            this.American.Location = new System.Drawing.Point(4, 4);
            this.American.Margin = new System.Windows.Forms.Padding(4);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(383, 52);
            this.American.TabIndex = 12;
            this.American.Text = "American mode";
            this.American.UseVisualStyleBackColor = false;
            this.American.CheckedChanged += new System.EventHandler(this.American_CheckedChanged);
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
            this.deletePak.Location = new System.Drawing.Point(4, 64);
            this.deletePak.Margin = new System.Windows.Forms.Padding(4);
            this.deletePak.Name = "deletePak";
            this.deletePak.Size = new System.Drawing.Size(373, 178);
            this.deletePak.TabIndex = 14;
            this.deletePak.Text = "Delete Mod Pak";
            this.deletePak.UseVisualStyleBackColor = false;
            this.deletePak.Click += new System.EventHandler(this.deletePak_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(393, 26);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(877, 217);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
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
            this.Randomise.Location = new System.Drawing.Point(819, 393);
            this.Randomise.Margin = new System.Windows.Forms.Padding(4, 50, 4, 4);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(458, 311);
            this.Randomise.TabIndex = 0;
            this.Randomise.Text = "Randomise";
            this.Randomise.UseVisualStyleBackColor = false;
            this.Randomise.Click += new System.EventHandler(this.Randomise_Click);
            // 
            // LeftSide
            // 
            this.LeftSide.BackColor = System.Drawing.Color.Transparent;
            this.LeftSide.Controls.Add(this.American);
            this.LeftSide.Controls.Add(this.deletePak);
            this.LeftSide.Location = new System.Drawing.Point(13, 26);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(382, 240);
            this.LeftSide.TabIndex = 15;
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 763);
            this.Controls.Add(this.LeftSide);
            this.Controls.Add(this.Randomise);
            this.Controls.Add(this.Logo);
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
            this.LeftSide.ResumeLayout(false);
            this.LeftSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox UmbyPet;
        private System.Windows.Forms.CheckBox Weapons;
        private System.Windows.Forms.CheckBox KeyItems;
        private System.Windows.Forms.FlowLayoutPanel RandoOptions;
        private System.Windows.Forms.CheckBox American;
        public System.Windows.Forms.FolderBrowserDialog modfoldercheck;
        private System.Windows.Forms.CheckBox Tunics;
        private System.Windows.Forms.CheckBox Emotes;
        private System.Windows.Forms.Button deletePak;
        private System.Windows.Forms.CheckBox Items;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Randomise;
        private System.Windows.Forms.CheckBox Spirits;
        private System.Windows.Forms.FlowLayoutPanel LeftSide;
    }
}

