
namespace CirkusApp1.Forme
{
    partial class SviArtistiForma
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
            this.btnDodajArtista = new System.Windows.Forms.Button();
            this.btnIzmeniArtista = new System.Windows.Forms.Button();
            this.ObrisiArtista = new System.Windows.Forms.Button();
            this.lvSviArtisti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDodajArtista
            // 
            this.btnDodajArtista.Location = new System.Drawing.Point(623, 105);
            this.btnDodajArtista.Name = "btnDodajArtista";
            this.btnDodajArtista.Size = new System.Drawing.Size(126, 42);
            this.btnDodajArtista.TabIndex = 1;
            this.btnDodajArtista.Text = "Dodaj artista";
            this.btnDodajArtista.UseVisualStyleBackColor = true;
            this.btnDodajArtista.Click += new System.EventHandler(this.btnDodajArtista_Click);
            // 
            // btnIzmeniArtista
            // 
            this.btnIzmeniArtista.Location = new System.Drawing.Point(623, 166);
            this.btnIzmeniArtista.Name = "btnIzmeniArtista";
            this.btnIzmeniArtista.Size = new System.Drawing.Size(126, 42);
            this.btnIzmeniArtista.TabIndex = 2;
            this.btnIzmeniArtista.Text = "Izmeni artista";
            this.btnIzmeniArtista.UseVisualStyleBackColor = true;
            // 
            // ObrisiArtista
            // 
            this.ObrisiArtista.Location = new System.Drawing.Point(623, 226);
            this.ObrisiArtista.Name = "ObrisiArtista";
            this.ObrisiArtista.Size = new System.Drawing.Size(126, 42);
            this.ObrisiArtista.TabIndex = 3;
            this.ObrisiArtista.Text = "Obrisi artista";
            this.ObrisiArtista.UseVisualStyleBackColor = true;
            this.ObrisiArtista.Click += new System.EventHandler(this.ObrisiArtista_Click);
            // 
            // lvSviArtisti
            // 
            this.lvSviArtisti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSviArtisti.HideSelection = false;
            this.lvSviArtisti.Location = new System.Drawing.Point(12, 12);
            this.lvSviArtisti.Name = "lvSviArtisti";
            this.lvSviArtisti.Size = new System.Drawing.Size(585, 426);
            this.lvSviArtisti.TabIndex = 4;
            this.lvSviArtisti.UseCompatibleStateImageBehavior = false;
            this.lvSviArtisti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Umetnicko ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pol";
            // 
            // SviArtistiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.lvSviArtisti);
            this.Controls.Add(this.ObrisiArtista);
            this.Controls.Add(this.btnIzmeniArtista);
            this.Controls.Add(this.btnDodajArtista);
            this.Name = "SviArtistiForma";
            this.Text = "SviArtistiForma";
            this.Load += new System.EventHandler(this.SviArtistiForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajArtista;
        private System.Windows.Forms.Button btnIzmeniArtista;
        private System.Windows.Forms.Button ObrisiArtista;
        private System.Windows.Forms.ListView lvSviArtisti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}