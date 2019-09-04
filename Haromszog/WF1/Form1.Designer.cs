namespace WF1
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.btnGreatings = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.radChartView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Controls.Add(this.txtName);
            this.radChartView1.Controls.Add(this.lblName);
            this.radChartView1.Controls.Add(this.btnGreatings);
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(274, 85);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            // 
            // btnGreatings
            // 
            this.btnGreatings.Location = new System.Drawing.Point(159, 38);
            this.btnGreatings.Name = "btnGreatings";
            this.btnGreatings.Size = new System.Drawing.Size(97, 34);
            this.btnGreatings.TabIndex = 0;
            this.btnGreatings.Text = "Köszön!";
            this.btnGreatings.UseVisualStyleBackColor = true;
            this.btnGreatings.Click += new System.EventHandler(this.BtnGreatings_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Név";
            this.lblName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "";
            this.txtName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 87);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Első formom";
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.radChartView1.ResumeLayout(false);
            this.radChartView1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private System.Windows.Forms.Button btnGreatings;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

