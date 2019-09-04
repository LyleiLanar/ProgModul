namespace teglalap
{
    partial class negyzetForm
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
            this.txtA = new System.Windows.Forms.Label();
            this.fldA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.Label();
            this.fldB = new System.Windows.Forms.TextBox();
            this.fldKerulet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fldTerulet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Location = new System.Drawing.Point(33, 15);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(17, 13);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "A:";
            // 
            // fldA
            // 
            this.fldA.Location = new System.Drawing.Point(53, 12);
            this.fldA.Name = "fldA";
            this.fldA.Size = new System.Drawing.Size(121, 20);
            this.fldA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.AutoSize = true;
            this.txtB.Location = new System.Drawing.Point(33, 41);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(17, 13);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "B:";
            // 
            // fldB
            // 
            this.fldB.Location = new System.Drawing.Point(53, 38);
            this.fldB.Name = "fldB";
            this.fldB.Size = new System.Drawing.Size(121, 20);
            this.fldB.TabIndex = 3;
            // 
            // fldKerulet
            // 
            this.fldKerulet.Location = new System.Drawing.Point(53, 64);
            this.fldKerulet.Name = "fldKerulet";
            this.fldKerulet.ReadOnly = true;
            this.fldKerulet.Size = new System.Drawing.Size(121, 20);
            this.fldKerulet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kerület:";
            // 
            // fldTerulet
            // 
            this.fldTerulet.Location = new System.Drawing.Point(53, 90);
            this.fldTerulet.Name = "fldTerulet";
            this.fldTerulet.ReadOnly = true;
            this.fldTerulet.Size = new System.Drawing.Size(121, 20);
            this.fldTerulet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Terület:";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(197, 12);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(106, 97);
            this.btnSzamol.TabIndex = 8;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.BtnSzamol_Click);
            // 
            // negyzetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 127);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.fldTerulet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fldKerulet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fldB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.fldA);
            this.Controls.Add(this.txtA);
            this.Name = "negyzetForm";
            this.Text = "Téglalap kerület és terület";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.TextBox fldA;
        private System.Windows.Forms.Label txtB;
        private System.Windows.Forms.TextBox fldB;
        private System.Windows.Forms.TextBox fldKerulet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fldTerulet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSzamol;
    }
}

