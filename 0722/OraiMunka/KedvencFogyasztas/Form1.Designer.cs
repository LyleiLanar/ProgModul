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
            this.SuspendLayout();
            // 
            // fogyasztas
            // 
            this.fogyasztas.AutoSize = true;
            this.fogyasztas.Location = new System.Drawing.Point(12, 9);
            this.fogyasztas.Name = "fogyasztas";
            this.fogyasztas.Size = new System.Drawing.Size(63, 13);
            this.fogyasztas.TabIndex = 0;
            this.fogyasztas.Text = "Fogyasztás:";
            // 
            // txtTetel
            // 
            this.txtTetel.Location = new System.Drawing.Point(15, 28);
            this.txtTetel.Name = "txtTetel";
            this.txtTetel.Size = new System.Drawing.Size(125, 20);
            this.txtTetel.TabIndex = 1;
            this.txtTetel.TextChanged += new System.EventHandler(this.TxtTetel_TextChanged);
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(146, 21);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(52, 34);
            this.btnFelvesz.TabIndex = 2;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.BtnFelvesz_Click);
            // 
            // txtEredmeny
            // 
            this.txtEredmeny.Location = new System.Drawing.Point(204, 66);
            this.txtEredmeny.Multiline = true;
            this.txtEredmeny.Name = "txtEredmeny";
            this.txtEredmeny.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEredmeny.Size = new System.Drawing.Size(125, 134);
            this.txtEredmeny.TabIndex = 3;
            // 
            // lstTetelek
            // 
            this.lstTetelek.FormattingEnabled = true;
            this.lstTetelek.Location = new System.Drawing.Point(15, 66);
            this.lstTetelek.Name = "lstTetelek";
            this.lstTetelek.Size = new System.Drawing.Size(125, 134);
            this.lstTetelek.TabIndex = 4;
            // 
            // btnMasol
            // 
            this.btnMasol.Location = new System.Drawing.Point(146, 116);
            this.btnMasol.Name = "btnMasol";
            this.btnMasol.Size = new System.Drawing.Size(52, 34);
            this.btnMasol.TabIndex = 5;
            this.btnMasol.Text = "Másol";
            this.btnMasol.UseVisualStyleBackColor = true;
            this.btnMasol.Click += new System.EventHandler(this.BtnMasol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 380);
            this.Controls.Add(this.btnMasol);
            this.Controls.Add(this.lstTetelek);
            this.Controls.Add(this.txtEredmeny);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.txtTetel);
            this.Controls.Add(this.fogyasztas);
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
    }
}

