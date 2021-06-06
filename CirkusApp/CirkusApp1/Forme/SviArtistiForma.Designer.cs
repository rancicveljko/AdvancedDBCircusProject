
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
            this.button1 = new System.Windows.Forms.Button();
            this.lvSviArtisti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Obrisi artista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvSviArtisti
            // 
            this.lvSviArtisti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
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
            // SviArtistiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.lvSviArtisti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeniArtista);
            this.Controls.Add(this.btnDodajArtista);
            this.Name = "SviArtistiForma";
            this.Text = "SviArtistiForma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajArtista;
        private System.Windows.Forms.Button btnIzmeniArtista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvSviArtisti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}