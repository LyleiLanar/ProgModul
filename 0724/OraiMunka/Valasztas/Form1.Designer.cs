namespace Valasztas
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
            this.chbxHirlevel = new System.Windows.Forms.CheckBox();
            this.btnElkuld = new System.Windows.Forms.Button();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.rBtnFerfi = new System.Windows.Forms.RadioButton();
            this.rbtnKp = new System.Windows.Forms.RadioButton();
            this.rbtnBk = new System.Windows.Forms.RadioButton();
            this.grpbxNem = new System.Windows.Forms.GroupBox();
            this.grpbxFizMod = new System.Windows.Forms.GroupBox();
            this.grpbxNem.SuspendLayout();
            this.grpbxFizMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxHirlevel
            // 
            this.chbxHirlevel.AutoSize = true;
            this.chbxHirlevel.Location = new System.Drawing.Point(12, 12);
            this.chbxHirlevel.Name = "chbxHirlevel";
            this.chbxHirlevel.Size = new System.Drawing.Size(63, 17);
            this.chbxHirlevel.TabIndex = 0;
            this.chbxHirlevel.Text = "Hírlevél";
            this.chbxHirlevel.UseVisualStyleBackColor = true;
            // 
            // btnElkuld
            // 
            this.btnElkuld.Location = new System.Drawing.Point(12, 35);
            this.btnElkuld.Name = "btnElkuld";
            this.btnElkuld.Size = new System.Drawing.Size(63, 46);
            this.btnElkuld.TabIndex = 1;
            this.btnElkuld.Text = "Elküld";
            this.btnElkuld.UseVisualStyleBackColor = true;
            this.btnElkuld.Click += new System.EventHandler(this.BtnElkuld_Click);
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(6, 19);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(39, 17);
            this.rBtnNo.TabIndex = 2;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "Nő";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // rBtnFerfi
            // 
            this.rBtnFerfi.AutoSize = true;
            this.rBtnFerfi.Location = new System.Drawing.Point(6, 42);
            this.rBtnFerfi.Name = "rBtnFerfi";
            this.rBtnFerfi.Size = new System.Drawing.Size(45, 17);
            this.rBtnFerfi.TabIndex = 3;
            this.rBtnFerfi.TabStop = true;
            this.rBtnFerfi.Text = "Férfi";
            this.rBtnFerfi.UseVisualStyleBackColor = true;
            // 
            // rbtnKp
            // 
            this.rbtnKp.AutoSize = true;
            this.rbtnKp.Checked = true;
            this.rbtnKp.Location = new System.Drawing.Point(6, 19);
            this.rbtnKp.Name = "rbtnKp";
            this.rbtnKp.Size = new System.Drawing.Size(71, 17);
            this.rbtnKp.TabIndex = 4;
            this.rbtnKp.TabStop = true;
            this.rbtnKp.Text = "Készpénz";
            this.rbtnKp.UseVisualStyleBackColor = true;
            // 
            // rbtnBk
            // 
            this.rbtnBk.AutoSize = true;
            this.rbtnBk.Location = new System.Drawing.Point(6, 42);
            this.rbtnBk.Name = "rbtnBk";
            this.rbtnBk.Size = new System.Drawing.Size(79, 17);
            this.rbtnBk.TabIndex = 5;
            this.rbtnBk.TabStop = true;
            this.rbtnBk.Text = "Bankkártya";
            this.rbtnBk.UseVisualStyleBackColor = true;
            // 
            // grpbxNem
            // 
            this.grpbxNem.Controls.Add(this.rBtnNo);
            this.grpbxNem.Controls.Add(this.rBtnFerfi);
            this.grpbxNem.Location = new System.Drawing.Point(81, 12);
            this.grpbxNem.Name = "grpbxNem";
            this.grpbxNem.Size = new System.Drawing.Size(71, 75);
            this.grpbxNem.TabIndex = 6;
            this.grpbxNem.TabStop = false;
            this.grpbxNem.Text = "Nem";
            // 
            // grpbxFizMod
            // 
            this.grpbxFizMod.Controls.Add(this.rbtnKp);
            this.grpbxFizMod.Controls.Add(this.rbtnBk);
            this.grpbxFizMod.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.grpbxFizMod.Location = new System.Drawing.Point(158, 12);
            this.grpbxFizMod.Name = "grpbxFizMod";
            this.grpbxFizMod.Size = new System.Drawing.Size(86, 75);
            this.grpbxFizMod.TabIndex = 7;
            this.grpbxFizMod.TabStop = false;
            this.grpbxFizMod.Text = "Fizetési mód";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 114);
            this.Controls.Add(this.grpbxFizMod);
            this.Controls.Add(this.grpbxNem);
            this.Controls.Add(this.btnElkuld);
            this.Controls.Add(this.chbxHirlevel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxNem.ResumeLayout(false);
            this.grpbxNem.PerformLayout();
            this.grpbxFizMod.ResumeLayout(false);
            this.grpbxFizMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxHirlevel;
        private System.Windows.Forms.Button btnElkuld;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.RadioButton rBtnFerfi;
        private System.Windows.Forms.RadioButton rbtnKp;
        private System.Windows.Forms.RadioButton rbtnBk;
        private System.Windows.Forms.GroupBox grpbxNem;
        private System.Windows.Forms.GroupBox grpbxFizMod;
    }
}

