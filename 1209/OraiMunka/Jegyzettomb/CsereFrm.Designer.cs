namespace Jegyzettomb
{
    partial class CsereFrm
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
            this.cserelLbl = new System.Windows.Forms.Label();
            this.txtbMitCsere = new System.Windows.Forms.TextBox();
            this.cserelBtn = new System.Windows.Forms.Button();
            this.megsemCserelBtn = new System.Windows.Forms.Button();
            this.lblCsereMire = new System.Windows.Forms.Label();
            this.txtbMireCsere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cserelLbl
            // 
            this.cserelLbl.AutoSize = true;
            this.cserelLbl.Location = new System.Drawing.Point(12, 13);
            this.cserelLbl.Name = "cserelLbl";
            this.cserelLbl.Size = new System.Drawing.Size(24, 13);
            this.cserelLbl.TabIndex = 0;
            this.cserelLbl.Text = "Mit:";
            // 
            // txtbMitCsere
            // 
            this.txtbMitCsere.Location = new System.Drawing.Point(42, 10);
            this.txtbMitCsere.Name = "txtbMitCsere";
            this.txtbMitCsere.Size = new System.Drawing.Size(260, 20);
            this.txtbMitCsere.TabIndex = 1;
            // 
            // cserelBtn
            // 
            this.cserelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cserelBtn.Location = new System.Drawing.Point(308, 7);
            this.cserelBtn.Name = "cserelBtn";
            this.cserelBtn.Size = new System.Drawing.Size(75, 23);
            this.cserelBtn.TabIndex = 2;
            this.cserelBtn.Text = "Cserél";
            this.cserelBtn.UseVisualStyleBackColor = true;
            // 
            // megsemCserelBtn
            // 
            this.megsemCserelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megsemCserelBtn.Location = new System.Drawing.Point(308, 36);
            this.megsemCserelBtn.Name = "megsemCserelBtn";
            this.megsemCserelBtn.Size = new System.Drawing.Size(75, 23);
            this.megsemCserelBtn.TabIndex = 3;
            this.megsemCserelBtn.Text = "Megsem";
            this.megsemCserelBtn.UseVisualStyleBackColor = true;
            this.megsemCserelBtn.Click += new System.EventHandler(this.megsemCserelBtn_Click);
            // 
            // lblCsereMire
            // 
            this.lblCsereMire.AutoSize = true;
            this.lblCsereMire.Location = new System.Drawing.Point(12, 41);
            this.lblCsereMire.Name = "lblCsereMire";
            this.lblCsereMire.Size = new System.Drawing.Size(30, 13);
            this.lblCsereMire.TabIndex = 4;
            this.lblCsereMire.Text = "Mire:";
            // 
            // txtbMireCsere
            // 
            this.txtbMireCsere.Location = new System.Drawing.Point(42, 38);
            this.txtbMireCsere.Name = "txtbMireCsere";
            this.txtbMireCsere.Size = new System.Drawing.Size(260, 20);
            this.txtbMireCsere.TabIndex = 5;
            // 
            // CsereFrm
            // 
            this.AcceptButton = this.cserelBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.megsemCserelBtn;
            this.ClientSize = new System.Drawing.Size(395, 70);
            this.Controls.Add(this.txtbMireCsere);
            this.Controls.Add(this.lblCsereMire);
            this.Controls.Add(this.megsemCserelBtn);
            this.Controls.Add(this.cserelBtn);
            this.Controls.Add(this.txtbMitCsere);
            this.Controls.Add(this.cserelLbl);
            this.Name = "CsereFrm";
            this.Text = "Csere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsereFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cserelLbl;
        private System.Windows.Forms.Button cserelBtn;
        private System.Windows.Forms.Button megsemCserelBtn;
        private System.Windows.Forms.Label lblCsereMire;
        public System.Windows.Forms.TextBox txtbMireCsere;
        public System.Windows.Forms.TextBox txtbMitCsere;
    }
}