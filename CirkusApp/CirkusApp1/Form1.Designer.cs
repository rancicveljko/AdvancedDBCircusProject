﻿
namespace CirkusApp1
{
    partial class frmTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajMesto = new System.Windows.Forms.Button();
            this.btnTEST = new System.Windows.Forms.Button();
            this.btnTEST2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ucitaj MestoBoravka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodajMesto
            // 
            this.btnDodajMesto.Location = new System.Drawing.Point(12, 46);
            this.btnDodajMesto.Name = "btnDodajMesto";
            this.btnDodajMesto.Size = new System.Drawing.Size(155, 28);
            this.btnDodajMesto.TabIndex = 1;
            this.btnDodajMesto.Text = "Dodaj MestoBoravka";
            this.btnDodajMesto.UseVisualStyleBackColor = true;
            this.btnDodajMesto.Click += new System.EventHandler(this.btnDodajMesto_Click);
            // 
            // btnTEST
            // 
            this.btnTEST.Location = new System.Drawing.Point(12, 80);
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.Size = new System.Drawing.Size(155, 28);
            this.btnTEST.TabIndex = 2;
            this.btnTEST.Text = "create TEST";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // btnTEST2
            // 
            this.btnTEST2.Location = new System.Drawing.Point(12, 114);
            this.btnTEST2.Name = "btnTEST2";
            this.btnTEST2.Size = new System.Drawing.Size(155, 28);
            this.btnTEST2.TabIndex = 3;
            this.btnTEST2.Text = "load TEST";
            this.btnTEST2.UseVisualStyleBackColor = true;
            this.btnTEST2.Click += new System.EventHandler(this.btnTEST2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zivotinje m-to-one";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(954, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 466);
            this.button3.TabIndex = 5;
            this.button3.Text = "Otvori pocetnu stranicu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 490);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTEST2);
            this.Controls.Add(this.btnTEST);
            this.Controls.Add(this.btnDodajMesto);
            this.Controls.Add(this.button1);
            this.Name = "frmTest";
            this.Text = "Test forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajMesto;
        private System.Windows.Forms.Button btnTEST;
        private System.Windows.Forms.Button btnTEST2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

