﻿
namespace CirkusApp1.Forme
{
    partial class TipArtistaForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dreser = new System.Windows.Forms.RadioButton();
            this.GutacPlamena = new System.Windows.Forms.RadioButton();
            this.BacacNozeva = new System.Windows.Forms.RadioButton();
            this.Zongler = new System.Windows.Forms.RadioButton();
            this.Klovn = new System.Windows.Forms.RadioButton();
            this.Akrobata = new System.Windows.Forms.RadioButton();
            this.IzaberiTip = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dreser);
            this.groupBox1.Controls.Add(this.GutacPlamena);
            this.groupBox1.Controls.Add(this.BacacNozeva);
            this.groupBox1.Controls.Add(this.Zongler);
            this.groupBox1.Controls.Add(this.Klovn);
            this.groupBox1.Controls.Add(this.Akrobata);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite tip artista";
            // 
            // Dreser
            // 
            this.Dreser.AutoSize = true;
            this.Dreser.Location = new System.Drawing.Point(6, 157);
            this.Dreser.Name = "Dreser";
            this.Dreser.Size = new System.Drawing.Size(72, 21);
            this.Dreser.TabIndex = 5;
            this.Dreser.TabStop = true;
            this.Dreser.Text = "Dreser";
            this.Dreser.UseVisualStyleBackColor = true;
            // 
            // GutacPlamena
            // 
            this.GutacPlamena.AutoSize = true;
            this.GutacPlamena.Location = new System.Drawing.Point(6, 130);
            this.GutacPlamena.Name = "GutacPlamena";
            this.GutacPlamena.Size = new System.Drawing.Size(126, 21);
            this.GutacPlamena.TabIndex = 4;
            this.GutacPlamena.TabStop = true;
            this.GutacPlamena.Text = "Gutac Plamena";
            this.GutacPlamena.UseVisualStyleBackColor = true;
            // 
            // BacacNozeva
            // 
            this.BacacNozeva.AutoSize = true;
            this.BacacNozeva.Location = new System.Drawing.Point(6, 103);
            this.BacacNozeva.Name = "BacacNozeva";
            this.BacacNozeva.Size = new System.Drawing.Size(120, 21);
            this.BacacNozeva.TabIndex = 3;
            this.BacacNozeva.TabStop = true;
            this.BacacNozeva.Text = "Bacac Nozeva";
            this.BacacNozeva.UseVisualStyleBackColor = true;
            // 
            // Zongler
            // 
            this.Zongler.AutoSize = true;
            this.Zongler.Location = new System.Drawing.Point(6, 76);
            this.Zongler.Name = "Zongler";
            this.Zongler.Size = new System.Drawing.Size(78, 21);
            this.Zongler.TabIndex = 2;
            this.Zongler.TabStop = true;
            this.Zongler.Text = "Zongler";
            this.Zongler.UseVisualStyleBackColor = true;
            // 
            // Klovn
            // 
            this.Klovn.AutoSize = true;
            this.Klovn.Location = new System.Drawing.Point(6, 49);
            this.Klovn.Name = "Klovn";
            this.Klovn.Size = new System.Drawing.Size(64, 21);
            this.Klovn.TabIndex = 1;
            this.Klovn.TabStop = true;
            this.Klovn.Text = "Klovn";
            this.Klovn.UseVisualStyleBackColor = true;
            // 
            // Akrobata
            // 
            this.Akrobata.AutoSize = true;
            this.Akrobata.Location = new System.Drawing.Point(7, 22);
            this.Akrobata.Name = "Akrobata";
            this.Akrobata.Size = new System.Drawing.Size(86, 21);
            this.Akrobata.TabIndex = 0;
            this.Akrobata.TabStop = true;
            this.Akrobata.Text = "Akrobata";
            this.Akrobata.UseVisualStyleBackColor = true;
            // 
            // IzaberiTip
            // 
            this.IzaberiTip.Location = new System.Drawing.Point(12, 251);
            this.IzaberiTip.Name = "IzaberiTip";
            this.IzaberiTip.Size = new System.Drawing.Size(230, 57);
            this.IzaberiTip.TabIndex = 2;
            this.IzaberiTip.Text = "Izaberi tip";
            this.IzaberiTip.UseVisualStyleBackColor = true;
            this.IzaberiTip.Click += new System.EventHandler(this.IzaberiTip_Click);
            // 
            // TipArtistaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 450);
            this.Controls.Add(this.IzaberiTip);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(272, 497);
            this.MinimumSize = new System.Drawing.Size(272, 497);
            this.Name = "TipArtistaForma";
            this.Text = "Izaberi tip artista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Dreser;
        private System.Windows.Forms.RadioButton GutacPlamena;
        private System.Windows.Forms.RadioButton BacacNozeva;
        private System.Windows.Forms.RadioButton Zongler;
        private System.Windows.Forms.RadioButton Klovn;
        private System.Windows.Forms.RadioButton Akrobata;
        private System.Windows.Forms.Button IzaberiTip;
    }
}