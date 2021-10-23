
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
            this.Keys = new System.Windows.Forms.CheckBox();
            this.Items = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Disclaimer = new System.Windows.Forms.TextBox();
            this.American = new System.Windows.Forms.CheckBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Randomise
            // 
            this.Randomise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Randomise.BackColor = System.Drawing.SystemColors.Control;
            this.Randomise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Randomise.BackgroundImage")));
            this.Randomise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Randomise.FlatAppearance.BorderSize = 0;
            this.Randomise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Randomise.Font = new System.Drawing.Font("Cinzel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomise.Location = new System.Drawing.Point(952, 564);
            this.Randomise.Margin = new System.Windows.Forms.Padding(4);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(443, 206);
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
            this.UmbyPet.Location = new System.Drawing.Point(-11, 406);
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
            this.Spirits.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spirits.ForeColor = System.Drawing.SystemColors.Control;
            this.Spirits.Location = new System.Drawing.Point(3, 430);
            this.Spirits.Name = "Spirits";
            this.Spirits.Size = new System.Drawing.Size(368, 48);
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
            this.Mix.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mix.ForeColor = System.Drawing.SystemColors.Control;
            this.Mix.Location = new System.Drawing.Point(3, 160);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(417, 48);
            this.Mix.TabIndex = 6;
            this.Mix.Text = "Mix Randomisation?*";
            this.Mix.UseVisualStyleBackColor = false;
            // 
            // Weapons
            // 
            this.Weapons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weapons.AutoSize = true;
            this.Weapons.BackColor = System.Drawing.Color.Transparent;
            this.Weapons.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapons.ForeColor = System.Drawing.SystemColors.Control;
            this.Weapons.Location = new System.Drawing.Point(3, 214);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(426, 48);
            this.Weapons.TabIndex = 7;
            this.Weapons.Text = "Randomise Weapons?*";
            this.Weapons.UseVisualStyleBackColor = false;
            // 
            // KeyItems
            // 
            this.KeyItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyItems.AutoSize = true;
            this.KeyItems.BackColor = System.Drawing.Color.Transparent;
            this.KeyItems.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyItems.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyItems.Location = new System.Drawing.Point(3, 268);
            this.KeyItems.Name = "KeyItems";
            this.KeyItems.Size = new System.Drawing.Size(431, 48);
            this.KeyItems.TabIndex = 8;
            this.KeyItems.Text = "Randomise Key Items?*";
            this.KeyItems.UseVisualStyleBackColor = false;
            // 
            // Keys
            // 
            this.Keys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keys.AutoSize = true;
            this.Keys.BackColor = System.Drawing.Color.Transparent;
            this.Keys.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keys.ForeColor = System.Drawing.SystemColors.Control;
            this.Keys.Location = new System.Drawing.Point(3, 322);
            this.Keys.Name = "Keys";
            this.Keys.Size = new System.Drawing.Size(346, 48);
            this.Keys.TabIndex = 9;
            this.Keys.Text = "Randomise Keys?*";
            this.Keys.UseVisualStyleBackColor = false;
            // 
            // Items
            // 
            this.Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Items.AutoSize = true;
            this.Items.BackColor = System.Drawing.Color.Transparent;
            this.Items.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.ForeColor = System.Drawing.SystemColors.Control;
            this.Items.Location = new System.Drawing.Point(3, 376);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(362, 48);
            this.Items.TabIndex = 10;
            this.Items.Text = "Randomise Items?*";
            this.Items.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.Disclaimer);
            this.flowLayoutPanel1.Controls.Add(this.Mix);
            this.flowLayoutPanel1.Controls.Add(this.Weapons);
            this.flowLayoutPanel1.Controls.Add(this.KeyItems);
            this.flowLayoutPanel1.Controls.Add(this.Keys);
            this.flowLayoutPanel1.Controls.Add(this.Items);
            this.flowLayoutPanel1.Controls.Add(this.Spirits);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(949, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 514);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Disclaimer
            // 
            this.Disclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Disclaimer.BackColor = System.Drawing.SystemColors.MenuText;
            this.Disclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disclaimer.Font = new System.Drawing.Font("Cinzel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disclaimer.ForeColor = System.Drawing.Color.LightGreen;
            this.Disclaimer.Location = new System.Drawing.Point(3, 3);
            this.Disclaimer.Multiline = true;
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(437, 151);
            this.Disclaimer.TabIndex = 3;
            this.Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them " +
    "it will have no effect.\r\nMix randomisation means key items can be in weapon loca" +
    "tions etc.";
            // 
            // American
            // 
            this.American.AutoSize = true;
            this.American.BackColor = System.Drawing.Color.Transparent;
            this.American.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.American.ForeColor = System.Drawing.SystemColors.Control;
            this.American.Location = new System.Drawing.Point(12, 257);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(321, 48);
            this.American.TabIndex = 12;
            this.American.Text = "American mode";
            this.American.UseVisualStyleBackColor = false;
            this.American.CheckedChanged += new System.EventHandler(this.American_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(-11, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(588, 243);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 783);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.American);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UmbyPet);
            this.Controls.Add(this.Randomise);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.CheckBox Keys;
        private System.Windows.Forms.CheckBox Items;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Disclaimer;
        private System.Windows.Forms.CheckBox American;
        private System.Windows.Forms.PictureBox Logo;
    }
}

