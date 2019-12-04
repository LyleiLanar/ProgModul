namespace GrafikusMiUjsag
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
            this.txtMain = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chbxHirlevel = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNemvalaszto = new System.Windows.Forms.Label();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.rBtnFfi = new System.Windows.Forms.RadioButton();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBxMain = new System.Windows.Forms.TextBox();
            this.cmbBxNevek = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.novelo = new System.Windows.Forms.NumericUpDown();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novelo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.AutoSize = true;
            this.txtMain.Location = new System.Drawing.Point(6, 16);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(47, 13);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "Kiskutya";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(59, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Gomb";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chbxHirlevel
            // 
            this.chbxHirlevel.AutoSize = true;
            this.chbxHirlevel.Checked = true;
            this.chbxHirlevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxHirlevel.Location = new System.Drawing.Point(140, 17);
            this.chbxHirlevel.Name = "chbxHirlevel";
            this.chbxHirlevel.Size = new System.Drawing.Size(63, 17);
            this.chbxHirlevel.TabIndex = 2;
            this.chbxHirlevel.Text = "Hírlevél";
            this.chbxHirlevel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNemvalaszto);
            this.panel1.Controls.Add(this.rBtnNo);
            this.panel1.Controls.Add(this.rBtnFfi);
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 78);
            this.panel1.TabIndex = 3;
            // 
            // txtNemvalaszto
            // 
            this.txtNemvalaszto.AutoSize = true;
            this.txtNemvalaszto.Location = new System.Drawing.Point(4, 8);
            this.txtNemvalaszto.Name = "txtNemvalaszto";
            this.txtNemvalaszto.Size = new System.Drawing.Size(32, 13);
            this.txtNemvalaszto.TabIndex = 2;
            this.txtNemvalaszto.Text = "Nem:";
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(3, 50);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(39, 17);
            this.rBtnNo.TabIndex = 1;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "Nő";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // rBtnFfi
            // 
            this.rBtnFfi.AutoSize = true;
            this.rBtnFfi.Checked = true;
            this.rBtnFfi.Location = new System.Drawing.Point(3, 27);
            this.rBtnFfi.Name = "rBtnFfi";
            this.rBtnFfi.Size = new System.Drawing.Size(36, 17);
            this.rBtnFfi.TabIndex = 0;
            this.rBtnFfi.TabStop = true;
            this.rBtnFfi.Text = "Ffi";
            this.rBtnFfi.UseVisualStyleBackColor = true;
            this.rBtnFfi.CheckedChanged += new System.EventHandler(this.rBtnFfi_CheckedChanged);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(257, 163);
            this.tabCtrl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBxMain);
            this.tabPage1.Controls.Add(this.cmbBxNevek);
            this.tabPage1.Controls.Add(this.txtMain);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnOk);
            this.tabPage1.Controls.Add(this.chbxHirlevel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(249, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alapadatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBxMain
            // 
            this.txtBxMain.Location = new System.Drawing.Point(104, 67);
            this.txtBxMain.Multiline = true;
            this.txtBxMain.Name = "txtBxMain";
            this.txtBxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxMain.Size = new System.Drawing.Size(121, 51);
            this.txtBxMain.TabIndex = 5;
            this.txtBxMain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbBxNevek
            // 
            this.cmbBxNevek.DisplayMember = "hkj";
            this.cmbBxNevek.FormattingEnabled = true;
            this.cmbBxNevek.Location = new System.Drawing.Point(104, 40);
            this.cmbBxNevek.Name = "cmbBxNevek";
            this.cmbBxNevek.Size = new System.Drawing.Size(121, 21);
            this.cmbBxNevek.TabIndex = 4;
            this.cmbBxNevek.SelectedIndexChanged += new System.EventHandler(this.cmbBxNevek_SelectedIndexChanged);
            this.cmbBxNevek.Click += new System.EventHandler(this.cmbBxNevek_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkB);
            this.tabPage2.Controls.Add(this.chkA);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(249, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Egyéb";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.novelo);
            this.panel2.Controls.Add(this.progBar);
            this.panel2.Location = new System.Drawing.Point(43, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 75);
            this.panel2.TabIndex = 2;
            // 
            // novelo
            // 
            this.novelo.Location = new System.Drawing.Point(20, 39);
            this.novelo.Name = "novelo";
            this.novelo.Size = new System.Drawing.Size(120, 20);
            this.novelo.TabIndex = 1;
            this.novelo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.novelo.ValueChanged += new System.EventHandler(this.novelo_ValueChanged);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(29, 10);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(100, 23);
            this.progBar.TabIndex = 0;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Checked = true;
            this.chkA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkA.Location = new System.Drawing.Point(84, 108);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(33, 17);
            this.chkA.TabIndex = 3;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            this.chkA.CheckedChanged += new System.EventHandler(this.chkA_CheckedChanged);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(123, 108);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(33, 17);
            this.chkB.TabIndex = 4;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.CheckedChanged += new System.EventHandler(this.chkB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 181);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Form1";
            this.Text = "MyGoood";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.novelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtMain;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbxHirlevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtNemvalaszto;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.RadioButton rBtnFfi;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBxMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown novelo;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBxNevek;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
    }
}

