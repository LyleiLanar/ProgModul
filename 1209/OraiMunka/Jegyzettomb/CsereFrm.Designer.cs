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
            this.cserelTxtBx = new System.Windows.Forms.TextBox();
            this.cserelBtn = new System.Windows.Forms.Button();
            this.megsemCserelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cserelLbl
            // 
            this.cserelLbl.AutoSize = true;
            this.cserelLbl.Location = new System.Drawing.Point(12, 9);
            this.cserelLbl.Name = "cserelLbl";
            this.cserelLbl.Size = new System.Drawing.Size(37, 13);
            this.cserelLbl.TabIndex = 0;
            this.cserelLbl.Text = "Csere:";
            // 
            // cserelTxtBx
            // 
            this.cserelTxtBx.Location = new System.Drawing.Point(56, 9);
            this.cserelTxtBx.Name = "cserelTxtBx";
            this.cserelTxtBx.Size = new System.Drawing.Size(100, 20);
            this.cserelTxtBx.TabIndex = 1;
            // 
            // cserelBtn
            // 
            this.cserelBtn.Location = new System.Drawing.Point(162, 7);
            this.cserelBtn.Name = "cserelBtn";
            this.cserelBtn.Size = new System.Drawing.Size(75, 23);
            this.cserelBtn.TabIndex = 2;
            this.cserelBtn.Text = "Cserél";
            this.cserelBtn.UseVisualStyleBackColor = true;
            // 
            // megsemCserelBtn
            // 
            this.megsemCserelBtn.Location = new System.Drawing.Point(162, 36);
            this.megsemCserelBtn.Name = "megsemCserelBtn";
            this.megsemCserelBtn.Size = new System.Drawing.Size(75, 23);
            this.megsemCserelBtn.TabIndex = 3;
            this.megsemCserelBtn.Text = "Megsem";
            this.megsemCserelBtn.UseVisualStyleBackColor = true;
            this.megsemCserelBtn.Click += new System.EventHandler(this.megsemCserelBtn_Click);
            // 
            // CsereFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 63);
            this.Controls.Add(this.megsemCserelBtn);
            this.Controls.Add(this.cserelBtn);
            this.Controls.Add(this.cserelTxtBx);
            this.Controls.Add(this.cserelLbl);
            this.Name = "CsereFrm";
            this.Text = "Csere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsereFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cserelLbl;
        private System.Windows.Forms.TextBox cserelTxtBx;
        private System.Windows.Forms.Button cserelBtn;
        private System.Windows.Forms.Button megsemCserelBtn;
    }
}