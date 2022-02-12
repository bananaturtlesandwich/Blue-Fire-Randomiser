
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
            this.Abilities = new System.Windows.Forms.CheckBox();
            this.RandoOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.Tunics = new System.Windows.Forms.CheckBox();
            this.Emotes = new System.Windows.Forms.CheckBox();
            this.Items = new System.Windows.Forms.CheckBox();
            this.Spirits = new System.Windows.Forms.CheckBox();
            this.Ducks = new System.Windows.Forms.CheckBox();
            this.American = new System.Windows.Forms.CheckBox();
            this.modfoldercheck = new System.Windows.Forms.FolderBrowserDialog();
            this.DeletePak = new System.Windows.Forms.Button();
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
            this.Weapons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Weapons.AutoSize = true;
            this.Weapons.BackColor = System.Drawing.Color.Transparent;
            this.Weapons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapons.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weapons.ForeColor = System.Drawing.SystemColors.Control;
            this.Weapons.Location = new System.Drawing.Point(3, 3);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(412, 48);
            this.Weapons.TabIndex = 7;
            this.Weapons.Text = "Randomise Weapons?";
            this.Weapons.UseVisualStyleBackColor = false;
            // 
            // Abilities
            // 
            this.Abilities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Abilities.AutoSize = true;
            this.Abilities.BackColor = System.Drawing.Color.Transparent;
            this.Abilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abilities.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Abilities.ForeColor = System.Drawing.SystemColors.Control;
            this.Abilities.Location = new System.Drawing.Point(3, 57);
            this.Abilities.Name = "Abilities";
            this.Abilities.Size = new System.Drawing.Size(400, 48);
            this.Abilities.TabIndex = 10;
            this.Abilities.Text = "Randomise Abilities?";
            this.Abilities.UseVisualStyleBackColor = false;
            // 
            // RandoOptions
            // 
            this.RandoOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RandoOptions.BackColor = System.Drawing.Color.Transparent;
            this.RandoOptions.Controls.Add(this.Weapons);
            this.RandoOptions.Controls.Add(this.Abilities);
            this.RandoOptions.Controls.Add(this.Tunics);
            this.RandoOptions.Controls.Add(this.Emotes);
            this.RandoOptions.Controls.Add(this.Items);
            this.RandoOptions.Controls.Add(this.Spirits);
            this.RandoOptions.Controls.Add(this.Ducks);
            this.RandoOptions.Location = new System.Drawing.Point(400, 288);
            this.RandoOptions.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.RandoOptions.Name = "RandoOptions";
            this.RandoOptions.Size = new System.Drawing.Size(412, 463);
            this.RandoOptions.TabIndex = 11;
            // 
            // Tunics
            // 
            this.Tunics.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tunics.AutoSize = true;
            this.Tunics.BackColor = System.Drawing.Color.Transparent;
            this.Tunics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tunics.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tunics.ForeColor = System.Drawing.SystemColors.Control;
            this.Tunics.Location = new System.Drawing.Point(3, 111);
            this.Tunics.Name = "Tunics";
            this.Tunics.Size = new System.Drawing.Size(374, 48);
            this.Tunics.TabIndex = 11;
            this.Tunics.Text = "Randomise Tunics?";
            this.Tunics.UseVisualStyleBackColor = false;
            // 
            // Emotes
            // 
            this.Emotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Emotes.AutoSize = true;
            this.Emotes.BackColor = System.Drawing.Color.Transparent;
            this.Emotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emotes.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emotes.ForeColor = System.Drawing.SystemColors.Control;
            this.Emotes.Location = new System.Drawing.Point(3, 165);
            this.Emotes.Name = "Emotes";
            this.Emotes.Size = new System.Drawing.Size(381, 48);
            this.Emotes.TabIndex = 12;
            this.Emotes.Text = "Randomise Emotes?";
            this.Emotes.UseVisualStyleBackColor = false;
            // 
            // Items
            // 
            this.Items.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Items.AutoSize = true;
            this.Items.BackColor = System.Drawing.Color.Transparent;
            this.Items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Items.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Items.ForeColor = System.Drawing.SystemColors.Control;
            this.Items.Location = new System.Drawing.Point(3, 219);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(348, 48);
            this.Items.TabIndex = 13;
            this.Items.Text = "Randomise Items?";
            this.Items.UseVisualStyleBackColor = false;
            // 
            // Spirits
            // 
            this.Spirits.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Spirits.AutoSize = true;
            this.Spirits.BackColor = System.Drawing.Color.Transparent;
            this.Spirits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spirits.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spirits.ForeColor = System.Drawing.SystemColors.Control;
            this.Spirits.Location = new System.Drawing.Point(3, 273);
            this.Spirits.Name = "Spirits";
            this.Spirits.Size = new System.Drawing.Size(367, 48);
            this.Spirits.TabIndex = 14;
            this.Spirits.Text = "Randomise Spirits?";
            this.Spirits.UseVisualStyleBackColor = false;
            // 
            // Ducks
            // 
            this.Ducks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ducks.AutoSize = true;
            this.Ducks.BackColor = System.Drawing.Color.Transparent;
            this.Ducks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ducks.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ducks.ForeColor = System.Drawing.SystemColors.Control;
            this.Ducks.Location = new System.Drawing.Point(3, 327);
            this.Ducks.Name = "Ducks";
            this.Ducks.Size = new System.Drawing.Size(365, 48);
            this.Ducks.TabIndex = 15;
            this.Ducks.Text = "Randomise Ducks?";
            this.Ducks.UseVisualStyleBackColor = false;
            // 
            // American
            // 
            this.American.AutoSize = true;
            this.American.BackColor = System.Drawing.Color.Transparent;
            this.American.Cursor = System.Windows.Forms.Cursors.Hand;
            this.American.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.American.ForeColor = System.Drawing.SystemColors.Control;
            this.American.Location = new System.Drawing.Point(4, 4);
            this.American.Margin = new System.Windows.Forms.Padding(4);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(320, 48);
            this.American.TabIndex = 12;
            this.American.Text = "American mode";
            this.American.UseVisualStyleBackColor = false;
            this.American.CheckedChanged += new System.EventHandler(this.American_CheckedChanged);
            // 
            // modfoldercheck
            // 
            this.modfoldercheck.Description = "Please select the mod folder (if you do not have a ~mods folder in Paks make one " +
    "with the button)";
            this.modfoldercheck.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.modfoldercheck.UseDescriptionForTitle = true;
            // 
            // DeletePak
            // 
            this.DeletePak.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeletePak.BackColor = System.Drawing.SystemColors.Control;
            this.DeletePak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletePak.BackgroundImage")));
            this.DeletePak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeletePak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePak.FlatAppearance.BorderSize = 0;
            this.DeletePak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletePak.Font = new System.Drawing.Font("Cinzel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletePak.Location = new System.Drawing.Point(4, 60);
            this.DeletePak.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePak.Name = "DeletePak";
            this.DeletePak.Size = new System.Drawing.Size(373, 178);
            this.DeletePak.TabIndex = 14;
            this.DeletePak.Text = "Delete Mod Pak";
            this.DeletePak.UseVisualStyleBackColor = false;
            this.DeletePak.Click += new System.EventHandler(this.deletePak_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(401, 26);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(869, 217);
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
            this.Randomise.Font = new System.Drawing.Font("Cinzel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.LeftSide.Controls.Add(this.DeletePak);
            this.LeftSide.Location = new System.Drawing.Point(13, 26);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(382, 244);
            this.LeftSide.TabIndex = 15;
            // 
            // Randomiser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
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
            this.Font = new System.Drawing.Font("Cinzel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private System.Windows.Forms.CheckBox Abilities;
        private System.Windows.Forms.FlowLayoutPanel RandoOptions;
        private System.Windows.Forms.CheckBox American;
        public System.Windows.Forms.FolderBrowserDialog modfoldercheck;
        private System.Windows.Forms.CheckBox Tunics;
        private System.Windows.Forms.CheckBox Emotes;
        private System.Windows.Forms.Button DeletePak;
        private System.Windows.Forms.CheckBox Items;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Randomise;
        private System.Windows.Forms.CheckBox Spirits;
        private System.Windows.Forms.FlowLayoutPanel LeftSide;
        private System.Windows.Forms.CheckBox Ducks;
    }
}

