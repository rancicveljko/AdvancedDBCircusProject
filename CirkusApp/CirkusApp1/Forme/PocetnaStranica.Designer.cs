
namespace CirkusApp1
{
    partial class PocetnaStranica
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
            this.btnArtistiForma = new System.Windows.Forms.Button();
            this.btnNastupneTackeForma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArtistiForma
            // 
            this.btnArtistiForma.Location = new System.Drawing.Point(328, 172);
            this.btnArtistiForma.Name = "btnArtistiForma";
            this.btnArtistiForma.Size = new System.Drawing.Size(148, 43);
            this.btnArtistiForma.TabIndex = 0;
            this.btnArtistiForma.Text = "ARTISTI";
            this.btnArtistiForma.UseVisualStyleBackColor = true;
            this.btnArtistiForma.Click += new System.EventHandler(this.btnArtistiForma_Click);
            // 
            // btnNastupneTackeForma
            // 
            this.btnNastupneTackeForma.Location = new System.Drawing.Point(328, 242);
            this.btnNastupneTackeForma.Name = "btnNastupneTackeForma";
            this.btnNastupneTackeForma.Size = new System.Drawing.Size(148, 43);
            this.btnNastupneTackeForma.TabIndex = 1;
            this.btnNastupneTackeForma.Text = "NASTUPNE TACKE";
            this.btnNastupneTackeForma.UseVisualStyleBackColor = true;
            this.btnNastupneTackeForma.Click += new System.EventHandler(this.btnNastupneTackeForma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CIRKUS";
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNastupneTackeForma);
            this.Controls.Add(this.btnArtistiForma);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNastupneTackeForma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArtistiForma;
    }
}