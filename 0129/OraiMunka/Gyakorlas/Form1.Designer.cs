namespace Gyakorlas
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnFormaz = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.BtnUj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Kicsikacsa";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnFormaz
            // 
            this.BtnFormaz.Location = new System.Drawing.Point(263, 114);
            this.BtnFormaz.Name = "BtnFormaz";
            this.BtnFormaz.Size = new System.Drawing.Size(75, 23);
            this.BtnFormaz.TabIndex = 1;
            this.BtnFormaz.Text = "Formaz";
            this.BtnFormaz.UseVisualStyleBackColor = true;
            this.BtnFormaz.Click += new System.EventHandler(this.BtnFormaz_Click);
            // 
            // BtnUj
            // 
            this.BtnUj.Location = new System.Drawing.Point(12, 114);
            this.BtnUj.Name = "BtnUj";
            this.BtnUj.Size = new System.Drawing.Size(75, 23);
            this.BtnUj.TabIndex = 2;
            this.BtnUj.Text = "Új";
            this.BtnUj.UseVisualStyleBackColor = true;
            this.BtnUj.Click += new System.EventHandler(this.BtnUj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 148);
            this.Controls.Add(this.BtnUj);
            this.Controls.Add(this.BtnFormaz);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnFormaz;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button BtnUj;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

