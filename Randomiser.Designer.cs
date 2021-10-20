
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
            this.RandoOptions = new System.Windows.Forms.CheckedListBox();
            this.Disclaimer = new System.Windows.Forms.TextBox();
            this.UmbyPet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).BeginInit();
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
            this.Randomise.Location = new System.Drawing.Point(1524, 840);
            this.Randomise.Margin = new System.Windows.Forms.Padding(4);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(343, 167);
            this.Randomise.TabIndex = 0;
            this.Randomise.Text = "Randomise";
            this.Randomise.UseVisualStyleBackColor = false;
            this.Randomise.Click += new System.EventHandler(this.Randomise_Click);
            // 
            // RandoOptions
            // 
            this.RandoOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandoOptions.BackColor = System.Drawing.SystemColors.WindowText;
            this.RandoOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RandoOptions.Font = new System.Drawing.Font("Cinzel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandoOptions.ForeColor = System.Drawing.Color.LightGreen;
            this.RandoOptions.FormattingEnabled = true;
            this.RandoOptions.Items.AddRange(new object[] {
            "Mix Randomisation?*",
            "Randomise Spirits?",
            "Randomise Weapons?*",
            "Randomise Key items?*",
            "Randomise Keys?*",
            "Randomise Items?*"});
            this.RandoOptions.Location = new System.Drawing.Point(1379, 283);
            this.RandoOptions.Name = "RandoOptions";
            this.RandoOptions.Size = new System.Drawing.Size(488, 282);
            this.RandoOptions.TabIndex = 2;
            this.RandoOptions.SelectedIndexChanged += new System.EventHandler(this.RandoOptions_SelectedIndexChanged);
            // 
            // Disclaimer
            // 
            this.Disclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Disclaimer.BackColor = System.Drawing.SystemColors.MenuText;
            this.Disclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disclaimer.Font = new System.Drawing.Font("Cinzel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disclaimer.ForeColor = System.Drawing.Color.LightGreen;
            this.Disclaimer.Location = new System.Drawing.Point(1379, 118);
            this.Disclaimer.Multiline = true;
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(488, 172);
            this.Disclaimer.TabIndex = 3;
            this.Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them " +
    "it will have no effect.\r\nMix randomisation mean key items can be in weapon locat" +
    "ions etc.";
            // 
            // UmbyPet
            // 
            this.UmbyPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UmbyPet.BackColor = System.Drawing.Color.Transparent;
            this.UmbyPet.Image = ((System.Drawing.Image)(resources.GetObject("UmbyPet.Image")));
            this.UmbyPet.InitialImage = ((System.Drawing.Image)(resources.GetObject("UmbyPet.InitialImage")));
            this.UmbyPet.Location = new System.Drawing.Point(0, 764);
            this.UmbyPet.Name = "UmbyPet";
            this.UmbyPet.Size = new System.Drawing.Size(315, 294);
            this.UmbyPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UmbyPet.TabIndex = 4;
            this.UmbyPet.TabStop = false;
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.UmbyPet);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.RandoOptions);
            this.Controls.Add(this.Randomise);
            this.Font = new System.Drawing.Font("Cinzel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Randomiser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Fire Randomiser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BFRandoGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UmbyPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Randomise;
        private System.Windows.Forms.CheckedListBox RandoOptions;
        private System.Windows.Forms.TextBox Disclaimer;
        private System.Windows.Forms.PictureBox UmbyPet;
    }
}

