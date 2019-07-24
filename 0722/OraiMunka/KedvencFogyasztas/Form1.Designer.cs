namespace KedvencFogyasztas
{
    partial class Form1
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
            this.fogyasztas = new System.Windows.Forms.Label();
            this.txtTetel = new System.Windows.Forms.TextBox();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.txtEredmeny = new System.Windows.Forms.TextBox();
            this.lstTetelek = new System.Windows.Forms.ListBox();
            this.btnMasol = new System.Windows.Forms.Button();
            this.txtMaxEredmeny = new System.Windows.Forms.TextBox();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnSzum = new System.Windows.Forms.Button();
            this.txtSzumEredmeny = new System.Windows.Forms.TextBox();
            this.btnEredmenyTorles = new System.Windows.Forms.Button();
            this.btmParosSzamok = new System.Windows.Forms.Button();
            this.txtParosEredmeny = new System.Windows.Forms.TextBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fogyasztas
            // 
            this.fogyasztas.AutoSize = true;
            this.fogyasztas.Location = new System.Drawing.Point(16, 11);
            this.fogyasztas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fogyasztas.Name = "fogyasztas";
            this.fogyasztas.Size = new System.Drawing.Size(84, 17);
            this.fogyasztas.TabIndex = 0;
            this.fogyasztas.Text = "Fogyasztás:";
            // 
            // txtTetel
            // 
            this.txtTetel.Location = new System.Drawing.Point(20, 34);
            this.txtTetel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTetel.Name = "txtTetel";
            this.txtTetel.Size = new System.Drawing.Size(165, 22);
            this.txtTetel.TabIndex = 1;
            this.txtTetel.TextChanged += new System.EventHandler(this.TxtTetel_TextChanged);
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(195, 33);
            this.btnFelvesz.Margin = new System.Windows.Forms.Padding(4);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(69, 25);
            this.btnFelvesz.TabIndex = 2;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.BtnFelvesz_Click);
            // 
            // txtEredmeny
            // 
            this.txtEredmeny.Location = new System.Drawing.Point(272, 81);
            this.txtEredmeny.Margin = new System.Windows.Forms.Padding(4);
            this.txtEredmeny.Multiline = true;
            this.txtEredmeny.Name = "txtEredmeny";
            this.txtEredmeny.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEredmeny.Size = new System.Drawing.Size(165, 164);
            this.txtEredmeny.TabIndex = 3;
            // 
            // lstTetelek
            // 
            this.lstTetelek.FormattingEnabled = true;
            this.lstTetelek.ItemHeight = 16;
            this.lstTetelek.Location = new System.Drawing.Point(20, 81);
            this.lstTetelek.Margin = new System.Windows.Forms.Padding(4);
            this.lstTetelek.Name = "lstTetelek";
            this.lstTetelek.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTetelek.Size = new System.Drawing.Size(165, 164);
            this.lstTetelek.TabIndex = 4;
            // 
            // btnMasol
            // 
            this.btnMasol.Location = new System.Drawing.Point(195, 143);
            this.btnMasol.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasol.Name = "btnMasol";
            this.btnMasol.Size = new System.Drawing.Size(69, 42);
            this.btnMasol.TabIndex = 5;
            this.btnMasol.Text = "Másol";
            this.btnMasol.UseVisualStyleBackColor = true;
            this.btnMasol.Click += new System.EventHandler(this.BtnMasol_Click);
            // 
            // txtMaxEredmeny
            // 
            this.txtMaxEredmeny.Enabled = false;
            this.txtMaxEredmeny.Location = new System.Drawing.Point(272, 278);
            this.txtMaxEredmeny.Name = "txtMaxEredmeny";
            this.txtMaxEredmeny.Size = new System.Drawing.Size(165, 22);
            this.txtMaxEredmeny.TabIndex = 6;
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(195, 277);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(69, 25);
            this.btnMaximum.TabIndex = 7;
            this.btnMaximum.Text = "Max/Min";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.BtnMaximum_Click);
            // 
            // btnSzum
            // 
            this.btnSzum.Location = new System.Drawing.Point(195, 311);
            this.btnSzum.Name = "btnSzum";
            this.btnSzum.Size = new System.Drawing.Size(69, 25);
            this.btnSzum.TabIndex = 8;
            this.btnSzum.Text = "Szum";
            this.btnSzum.UseVisualStyleBackColor = true;
            this.btnSzum.Click += new System.EventHandler(this.BtnSzum_Click);
            // 
            // txtSzumEredmeny
            // 
            this.txtSzumEredmeny.Enabled = false;
            this.txtSzumEredmeny.Location = new System.Drawing.Point(272, 312);
            this.txtSzumEredmeny.Name = "txtSzumEredmeny";
            this.txtSzumEredmeny.Size = new System.Drawing.Size(165, 22);
            this.txtSzumEredmeny.TabIndex = 9;
            // 
            // btnEredmenyTorles
            // 
            this.btnEredmenyTorles.Location = new System.Drawing.Point(368, 34);
            this.btnEredmenyTorles.Name = "btnEredmenyTorles";
            this.btnEredmenyTorles.Size = new System.Drawing.Size(69, 25);
            this.btnEredmenyTorles.TabIndex = 10;
            this.btnEredmenyTorles.Text = "Törlés";
            this.btnEredmenyTorles.UseVisualStyleBackColor = true;
            this.btnEredmenyTorles.Click += new System.EventHandler(this.BtnEredmenyTorles_Click);
            // 
            // btmParosSzamok
            // 
            this.btmParosSzamok.Location = new System.Drawing.Point(195, 342);
            this.btmParosSzamok.Name = "btmParosSzamok";
            this.btmParosSzamok.Size = new System.Drawing.Size(69, 25);
            this.btmParosSzamok.TabIndex = 11;
            this.btmParosSzamok.Text = "Párosak";
            this.btmParosSzamok.UseVisualStyleBackColor = true;
            this.btmParosSzamok.Click += new System.EventHandler(this.BtmParosSzamok_Click);
            // 
            // txtParosEredmeny
            // 
            this.txtParosEredmeny.Enabled = false;
            this.txtParosEredmeny.Location = new System.Drawing.Point(272, 343);
            this.txtParosEredmeny.Name = "txtParosEredmeny";
            this.txtParosEredmeny.Size = new System.Drawing.Size(165, 22);
            this.txtParosEredmeny.TabIndex = 12;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(193, 81);
            this.btnTorles.Margin = new System.Windows.Forms.Padding(4);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(69, 42);
            this.btnTorles.TabIndex = 13;
            this.btnTorles.Text = "Töröl";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 433);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.txtParosEredmeny);
            this.Controls.Add(this.btmParosSzamok);
            this.Controls.Add(this.btnEredmenyTorles);
            this.Controls.Add(this.txtSzumEredmeny);
            this.Controls.Add(this.btnSzum);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.txtMaxEredmeny);
            this.Controls.Add(this.btnMasol);
            this.Controls.Add(this.lstTetelek);
            this.Controls.Add(this.txtEredmeny);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.txtTetel);
            this.Controls.Add(this.fogyasztas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fogyasztás Kezelő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fogyasztas;
        private System.Windows.Forms.TextBox txtTetel;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.TextBox txtEredmeny;
        private System.Windows.Forms.ListBox lstTetelek;
        private System.Windows.Forms.Button btnMasol;
        private System.Windows.Forms.TextBox txtMaxEredmeny;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnSzum;
        private System.Windows.Forms.TextBox txtSzumEredmeny;
        private System.Windows.Forms.Button btnEredmenyTorles;
        private System.Windows.Forms.Button btmParosSzamok;
        private System.Windows.Forms.TextBox txtParosEredmeny;
        private System.Windows.Forms.Button btnTorles;
    }
}

