using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikusMiUjsag
{
    public partial class Form1 : Form
    {
        static string[] noiNevek =
           {
                "Lujza","Mónika","Kriszti","Tünde"
            };

        static string[] ffiNevek =
        {
                "János","Ferenc","Béla","Sánsor"
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void novelo_ValueChanged(object sender, EventArgs e)
        {
            this.progBar.Value = (int) novelo.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(txtBxMain.Text);
            sb.Append(cmbBxNevek.Text+" ");
            if (rBtnFfi.Checked)
            {
                sb.Append("egy férfi.");
            }
            else if(rBtnNo.Checked)
            {
                sb.Append("egy nő.");
            }
            else
            {
                sb.Append("még maga sem tudja milyen nemű...");
            }

            txtBxMain.Text=sb.ToString();
        }

        private void cmbBxNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rBtnFfi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbBxNevek_Click(object sender, EventArgs e)
        {
            cmbBxNevek.Items.Clear();
            if (rBtnFfi.Checked)
            {              
                cmbBxNevek.Items.AddRange(ffiNevek);
            }
            else if (rBtnNo.Checked)
            {
                cmbBxNevek.Items.AddRange(noiNevek);
            }

        }
    }
}
