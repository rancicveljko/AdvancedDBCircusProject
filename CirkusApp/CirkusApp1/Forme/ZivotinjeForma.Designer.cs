
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSveZivotinje
            // 
            this.lvSveZivotinje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSveZivotinje.FullRowSelect = true;
            this.lvSveZivotinje.HideSelection = false;
            this.lvSveZivotinje.Location = new System.Drawing.Point(23, 44);
            this.lvSveZivotinje.Name = "lvSveZivotinje";
            this.lvSveZivotinje.Size = new System.Drawing.Size(449, 363);
            this.lvSveZivotinje.TabIndex = 8;
            this.lvSveZivotinje.UseCompatibleStateImageBehavior = false;
            this.lvSveZivotinje.View = System.Windows.Forms.View.Details;
            // 
            // btnObrisiZivotinju
            // 
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
            this.btnIzmeniZivotinju.Click += new System.EventHandler(this.btnIzmeniZivotinju_Click_1);
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Location = new System.Drawing.Point(605, 86);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(172, 46);
            this.btnDodajZivotinju.TabIndex = 6;
            this.btnDodajZivotinju.Text = "Dodaj zivotinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            this.btnDodajZivotinju.Click += new System.EventHandler(this.btnDodajZivotinju_Click_1);
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Starost";
            // 
            // ZivotinjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CirkusApp1.Properties.Resources.sbpCirkusBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSveZivotinje);
            this.Controls.Add(this.btnObrisiZivotinju);
            this.Controls.Add(this.btnIzmeniZivotinju);
            this.Controls.Add(this.btnDodajZivotinju);
            this.Name = "ZivotinjeForma";
            this.Text = "ZivotinjeForma";
            this.Load += new System.EventHandler(this.ZivotinjeForma_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSveZivotinje;
        private System.Windows.Forms.Button btnObrisiZivotinju;
        private System.Windows.Forms.Button btnIzmeniZivotinju;
        private System.Windows.Forms.Button btnDodajZivotinju;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}