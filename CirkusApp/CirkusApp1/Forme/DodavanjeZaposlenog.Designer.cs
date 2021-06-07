
namespace CirkusApp1.Forme
{
    partial class DodavanjeZaposlenog
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
            this.podaciZaposleni = new System.Windows.Forms.GroupBox();
            this.datumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSviDirektori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DodajZaposlenog = new System.Windows.Forms.Button();
            this.podaciZaposleni.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // podaciZaposleni
            // 
            this.podaciZaposleni.BackColor = System.Drawing.Color.Transparent;
            this.podaciZaposleni.Controls.Add(this.datumRodjenja);
            this.podaciZaposleni.Controls.Add(this.textBox6);
            this.podaciZaposleni.Controls.Add(this.textBox5);
            this.podaciZaposleni.Controls.Add(this.textBox3);
            this.podaciZaposleni.Controls.Add(this.textBox2);
            this.podaciZaposleni.Controls.Add(this.textBox1);
            this.podaciZaposleni.Controls.Add(this.label6);
            this.podaciZaposleni.Controls.Add(this.label5);
            this.podaciZaposleni.Controls.Add(this.label4);
            this.podaciZaposleni.Controls.Add(this.label3);
            this.podaciZaposleni.Controls.Add(this.label2);
            this.podaciZaposleni.Controls.Add(this.label1);
            this.podaciZaposleni.Location = new System.Drawing.Point(12, 12);
            this.podaciZaposleni.Name = "podaciZaposleni";
            this.podaciZaposleni.Size = new System.Drawing.Size(465, 233);
            this.podaciZaposleni.TabIndex = 0;
            this.podaciZaposleni.TabStop = false;
            this.podaciZaposleni.Text = "Podaci o zaposlenom";
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumRodjenja.Location = new System.Drawing.Point(173, 108);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(100, 22);
            this.datumRodjenja.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(173, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maticni broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesto rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Srednje slovo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvSviDirektori);
            this.groupBox1.Location = new System.Drawing.Point(16, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Direktora";
            // 
            // lvSviDirektori
            // 
            this.lvSviDirektori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSviDirektori.FullRowSelect = true;
            this.lvSviDirektori.HideSelection = false;
            this.lvSviDirektori.Location = new System.Drawing.Point(8, 21);
            this.lvSviDirektori.Name = "lvSviDirektori";
            this.lvSviDirektori.Size = new System.Drawing.Size(447, 210);
            this.lvSviDirektori.TabIndex = 0;
            this.lvSviDirektori.UseCompatibleStateImageBehavior = false;
            this.lvSviDirektori.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 97;
            // 
            // DodajZaposlenog
            // 
            this.DodajZaposlenog.Location = new System.Drawing.Point(514, 202);
            this.DodajZaposlenog.Name = "DodajZaposlenog";
            this.DodajZaposlenog.Size = new System.Drawing.Size(140, 43);
            this.DodajZaposlenog.TabIndex = 2;
            this.DodajZaposlenog.Text = "Dodaj Zaposlenog";
            this.DodajZaposlenog.UseVisualStyleBackColor = true;
            this.DodajZaposlenog.Click += new System.EventHandler(this.DodajZaposlenog_Click);
            // 
            // DodavanjeZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CirkusApp1.Properties.Resources.sbpCirkusBackground;
            this.ClientSize = new System.Drawing.Size(682, 494);
            this.Controls.Add(this.DodajZaposlenog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.podaciZaposleni);
            this.Name = "DodavanjeZaposlenog";
            this.Text = "DodavanjeZaposlenog";
            this.Load += new System.EventHandler(this.DodavanjeZaposlenog_Load);
            this.podaciZaposleni.ResumeLayout(false);
            this.podaciZaposleni.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox podaciZaposleni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSviDirektori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DodajZaposlenog;
        private System.Windows.Forms.DateTimePicker datumRodjenja;
    }
}