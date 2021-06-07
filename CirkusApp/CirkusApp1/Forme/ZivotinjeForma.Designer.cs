
namespace CirkusApp1.Forme
{
    partial class ZivotinjeForma
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
            this.lvSveZivotinje = new System.Windows.Forms.ListView();
            this.btnObrisiZivotinju = new System.Windows.Forms.Button();
            this.btnIzmeniZivotinju = new System.Windows.Forms.Button();
            this.btnDodajZivotinju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSveZivotinje
            // 
            this.lvSveZivotinje.FullRowSelect = true;
            this.lvSveZivotinje.HideSelection = false;
            this.lvSveZivotinje.Location = new System.Drawing.Point(23, 44);
            this.lvSveZivotinje.Name = "lvSveZivotinje";
            this.lvSveZivotinje.Size = new System.Drawing.Size(449, 363);
            this.lvSveZivotinje.TabIndex = 8;
            this.lvSveZivotinje.UseCompatibleStateImageBehavior = false;
            // 
            // btnObrisiZivotinju
            // 
            this.btnObrisiZivotinju.Enabled = false;
            this.btnObrisiZivotinju.Location = new System.Drawing.Point(605, 235);
            this.btnObrisiZivotinju.Name = "btnObrisiZivotinju";
            this.btnObrisiZivotinju.Size = new System.Drawing.Size(172, 46);
            this.btnObrisiZivotinju.TabIndex = 9;
            this.btnObrisiZivotinju.Text = "Obrisi zivotinju";
            this.btnObrisiZivotinju.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniZivotinju
            // 
            this.btnIzmeniZivotinju.Location = new System.Drawing.Point(605, 155);
            this.btnIzmeniZivotinju.Name = "btnIzmeniZivotinju";
            this.btnIzmeniZivotinju.Size = new System.Drawing.Size(172, 48);
            this.btnIzmeniZivotinju.TabIndex = 7;
            this.btnIzmeniZivotinju.Text = "Izmeni zivotinju";
            this.btnIzmeniZivotinju.UseVisualStyleBackColor = true;
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Location = new System.Drawing.Point(605, 86);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(172, 46);
            this.btnDodajZivotinju.TabIndex = 6;
            this.btnDodajZivotinju.Text = "Dodaj zivotinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            // 
            // ZivotinjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSveZivotinje);
            this.Controls.Add(this.btnObrisiZivotinju);
            this.Controls.Add(this.btnIzmeniZivotinju);
            this.Controls.Add(this.btnDodajZivotinju);
            this.Name = "ZivotinjeForma";
            this.Text = "ZivotinjeForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSveZivotinje;
        private System.Windows.Forms.Button btnObrisiZivotinju;
        private System.Windows.Forms.Button btnIzmeniZivotinju;
        private System.Windows.Forms.Button btnDodajZivotinju;
    }
}