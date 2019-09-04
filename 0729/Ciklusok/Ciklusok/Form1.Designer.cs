namespace Ciklusok
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbEvek = new System.Windows.Forms.ComboBox();
            this.btnFeltolt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTol = new System.Windows.Forms.TextBox();
            this.lblHiba = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMinusz1900 = new System.Windows.Forms.RadioButton();
            this.rdb2Jegy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSzam = new System.Windows.Forms.Label();
            this.btnVizsgal = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Peti",
            "Petra",
            "Pál",
            "Xénia"});
            this.comboBox1.Location = new System.Drawing.Point(99, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Nevek";
            // 
            // cmbEvek
            // 
            this.cmbEvek.FormattingEnabled = true;
            this.cmbEvek.Location = new System.Drawing.Point(13, 94);
            this.cmbEvek.Name = "cmbEvek";
            this.cmbEvek.Size = new System.Drawing.Size(100, 21);
            this.cmbEvek.TabIndex = 1;
            this.cmbEvek.Text = "Évek";
            // 
            // btnFeltolt
            // 
            this.btnFeltolt.Location = new System.Drawing.Point(119, 94);
            this.btnFeltolt.Name = "btnFeltolt";
            this.btnFeltolt.Size = new System.Drawing.Size(84, 23);
            this.btnFeltolt.TabIndex = 2;
            this.btnFeltolt.Text = "Feltölt";
            this.btnFeltolt.UseVisualStyleBackColor = true;
            this.btnFeltolt.Click += new System.EventHandler(this.btnFeltolt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lblHiba);
            this.groupBox1.Controls.Add(this.txtTol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEvek);
            this.groupBox1.Controls.Add(this.btnFeltolt);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Évek generálása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Néhány fix név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "tól (<=1900):";
            // 
            // txtTol
            // 
            this.txtTol.Location = new System.Drawing.Point(13, 57);
            this.txtTol.Name = "txtTol";
            this.txtTol.Size = new System.Drawing.Size(100, 20);
            this.txtTol.TabIndex = 4;
            // 
            // lblHiba
            // 
            this.lblHiba.AutoSize = true;
            this.lblHiba.ForeColor = System.Drawing.Color.Red;
            this.lblHiba.Location = new System.Drawing.Point(13, 136);
            this.lblHiba.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblHiba.Name = "lblHiba";
            this.lblHiba.Size = new System.Drawing.Size(100, 13);
            this.lblHiba.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVizsgal);
            this.groupBox2.Controls.Add(this.lblSzam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdb2Jegy);
            this.groupBox2.Controls.Add(this.rdbMinusz1900);
            this.groupBox2.Location = new System.Drawing.Point(253, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tökéletes szám vizsgálat";
            // 
            // rdbMinusz1900
            // 
            this.rdbMinusz1900.AutoSize = true;
            this.rdbMinusz1900.Checked = true;
            this.rdbMinusz1900.Location = new System.Drawing.Point(98, 19);
            this.rdbMinusz1900.Name = "rdbMinusz1900";
            this.rdbMinusz1900.Size = new System.Drawing.Size(52, 17);
            this.rdbMinusz1900.TabIndex = 0;
            this.rdbMinusz1900.TabStop = true;
            this.rdbMinusz1900.Text = "-1900";
            this.rdbMinusz1900.UseVisualStyleBackColor = true;
            // 
            // rdb2Jegy
            // 
            this.rdb2Jegy.AutoSize = true;
            this.rdb2Jegy.Location = new System.Drawing.Point(98, 42);
            this.rdb2Jegy.Name = "rdb2Jegy";
            this.rdb2Jegy.Size = new System.Drawing.Size(114, 17);
            this.rdb2Jegy.TabIndex = 1;
            this.rdb2Jegy.Text = "utolsó 2 számjegye";
            this.rdb2Jegy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A kiválasztott év";
            // 
            // lblSzam
            // 
            this.lblSzam.AutoSize = true;
            this.lblSzam.Location = new System.Drawing.Point(7, 72);
            this.lblSzam.Name = "lblSzam";
            this.lblSzam.Size = new System.Drawing.Size(85, 13);
            this.lblSzam.TabIndex = 3;
            this.lblSzam.Text = "A vizsgált szám: ";
            // 
            // btnVizsgal
            // 
            this.btnVizsgal.Location = new System.Drawing.Point(6, 96);
            this.btnVizsgal.Name = "btnVizsgal";
            this.btnVizsgal.Size = new System.Drawing.Size(75, 23);
            this.btnVizsgal.TabIndex = 4;
            this.btnVizsgal.Text = "Vizsgál";
            this.btnVizsgal.UseVisualStyleBackColor = true;
            this.btnVizsgal.Click += new System.EventHandler(this.btnVizsgal_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(121, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ig (<=2000):";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "10-al léptet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 237);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbEvek;
        private System.Windows.Forms.Button btnFeltolt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHiba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVizsgal;
        private System.Windows.Forms.Label lblSzam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb2Jegy;
        private System.Windows.Forms.RadioButton rdbMinusz1900;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

