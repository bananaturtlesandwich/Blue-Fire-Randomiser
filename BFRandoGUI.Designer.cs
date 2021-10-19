
namespace BlueFireRando
{
    partial class BFRandoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BFRandoGUI));
            this.Randomise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Randomise
            // 
            this.Randomise.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Randomise.Location = new System.Drawing.Point(732, 430);
            this.Randomise.Name = "Randomise";
            this.Randomise.Size = new System.Drawing.Size(269, 138);
            this.Randomise.TabIndex = 0;
            this.Randomise.Text = "Randomise";
            this.Randomise.UseVisualStyleBackColor = false;
            this.Randomise.UseWaitCursor = true;
            // 
            // BFRandoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1136, 648);
            this.Controls.Add(this.Randomise);
            this.Name = "BFRandoGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Fire Randomiser";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BFRandoGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Randomise;
    }
}

