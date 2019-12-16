namespace Jegyzettomb
{
    partial class KeresForm
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
            this.keresLbl = new System.Windows.Forms.Label();
            this.keresTxtBx = new System.Windows.Forms.TextBox();
            this.keresBtm = new System.Windows.Forms.Button();
            this.megsemKeresBtn = new System.Windows.Forms.Button();
            this.rdbEleje = new System.Windows.Forms.RadioButton();
            this.rdbAktualisPoz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // keresLbl
            // 
            this.keresLbl.AutoSize = true;
            this.keresLbl.Location = new System.Drawing.Point(8, 12);
            this.keresLbl.Name = "keresLbl";
            this.keresLbl.Size = new System.Drawing.Size(37, 13);
            this.keresLbl.TabIndex = 0;
            this.keresLbl.Text = "Keres:";
            // 
            // keresTxtBx
            // 
            this.keresTxtBx.Location = new System.Drawing.Point(49, 12);
            this.keresTxtBx.Name = "keresTxtBx";
            this.keresTxtBx.Size = new System.Drawing.Size(178, 20);
            this.keresTxtBx.TabIndex = 1;
            // 
            // keresBtm
            // 
            this.keresBtm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.keresBtm.Location = new System.Drawing.Point(247, 12);
            this.keresBtm.Name = "keresBtm";
            this.keresBtm.Size = new System.Drawing.Size(75, 23);
            this.keresBtm.TabIndex = 2;
            this.keresBtm.Text = "Keres";
            this.keresBtm.UseVisualStyleBackColor = true;
            // 
            // megsemKeresBtn
            // 
            this.megsemKeresBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megsemKeresBtn.Location = new System.Drawing.Point(247, 41);
            this.megsemKeresBtn.Name = "megsemKeresBtn";
            this.megsemKeresBtn.Size = new System.Drawing.Size(75, 23);
            this.megsemKeresBtn.TabIndex = 3;
            this.megsemKeresBtn.Text = "Megsem";
            this.megsemKeresBtn.UseVisualStyleBackColor = true;
            this.megsemKeresBtn.Click += new System.EventHandler(this.megsemKeresBtn_Click);
            // 
            // rdbEleje
            // 
            this.rdbEleje.AutoSize = true;
            this.rdbEleje.Checked = true;
            this.rdbEleje.Location = new System.Drawing.Point(13, 44);
            this.rdbEleje.Name = "rdbEleje";
            this.rdbEleje.Size = new System.Drawing.Size(97, 17);
            this.rdbEleje.TabIndex = 4;
            this.rdbEleje.TabStop = true;
            this.rdbEleje.Text = "Szöveg elejétől";
            this.rdbEleje.UseVisualStyleBackColor = true;
            // 
            // rdbAktualisPoz
            // 
            this.rdbAktualisPoz.AutoSize = true;
            this.rdbAktualisPoz.Location = new System.Drawing.Point(116, 44);
            this.rdbAktualisPoz.Name = "rdbAktualisPoz";
            this.rdbAktualisPoz.Size = new System.Drawing.Size(111, 17);
            this.rdbAktualisPoz.TabIndex = 5;
            this.rdbAktualisPoz.Text = "Aktuális pozíciótól";
            this.rdbAktualisPoz.UseVisualStyleBackColor = true;
            // 
            // KeresForm
            // 
            this.AcceptButton = this.keresBtm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.megsemKeresBtn;
            this.ClientSize = new System.Drawing.Size(334, 71);
            this.Controls.Add(this.rdbAktualisPoz);
            this.Controls.Add(this.rdbEleje);
            this.Controls.Add(this.megsemKeresBtn);
            this.Controls.Add(this.keresBtm);
            this.Controls.Add(this.keresTxtBx);
            this.Controls.Add(this.keresLbl);
            this.Name = "KeresForm";
            this.Text = "KeresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keresLbl;
        private System.Windows.Forms.TextBox keresTxtBx;
        private System.Windows.Forms.Button keresBtm;
        private System.Windows.Forms.Button megsemKeresBtn;
        private System.Windows.Forms.RadioButton rdbEleje;
        private System.Windows.Forms.RadioButton rdbAktualisPoz;
    }
}