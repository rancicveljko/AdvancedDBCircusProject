
namespace CirkusApp1.Forme
{
    partial class SveNastupneTackeForma
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
            this.lvSveNastupneTacke = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzmeniArtista = new System.Windows.Forms.Button();
            this.btnDodajNastupnuTacku = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSveNastupneTacke
            // 
            this.lvSveNastupneTacke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSveNastupneTacke.HideSelection = false;
            this.lvSveNastupneTacke.Location = new System.Drawing.Point(12, 12);
            this.lvSveNastupneTacke.Name = "lvSveNastupneTacke";
            this.lvSveNastupneTacke.Size = new System.Drawing.Size(605, 426);
            this.lvSveNastupneTacke.TabIndex = 8;
            this.lvSveNastupneTacke.UseCompatibleStateImageBehavior = false;
            this.lvSveNastupneTacke.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Obrisi nastupnu tacku";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniArtista
            // 
            this.btnIzmeniArtista.Location = new System.Drawing.Point(643, 166);
            this.btnIzmeniArtista.Name = "btnIzmeniArtista";
            this.btnIzmeniArtista.Size = new System.Drawing.Size(126, 42);
            this.btnIzmeniArtista.TabIndex = 6;
            this.btnIzmeniArtista.Text = "Izmeni nastupnu tacku";
            this.btnIzmeniArtista.UseVisualStyleBackColor = true;
            // 
            // btnDodajNastupnuTacku
            // 
            this.btnDodajNastupnuTacku.Location = new System.Drawing.Point(643, 105);
            this.btnDodajNastupnuTacku.Name = "btnDodajNastupnuTacku";
            this.btnDodajNastupnuTacku.Size = new System.Drawing.Size(126, 42);
            this.btnDodajNastupnuTacku.TabIndex = 5;
            this.btnDodajNastupnuTacku.Text = "Dodaj nastupnu tacku";
            this.btnDodajNastupnuTacku.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Min godina";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Opasni efekti";
            this.columnHeader5.Width = 101;
            // 
            // SveNastupneTackeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSveNastupneTacke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeniArtista);
            this.Controls.Add(this.btnDodajNastupnuTacku);
            this.Name = "SveNastupneTackeForma";
            this.Text = "SveNastupneTackeForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSveNastupneTacke;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzmeniArtista;
        private System.Windows.Forms.Button btnDodajNastupnuTacku;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}