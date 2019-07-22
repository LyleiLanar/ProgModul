using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KedvencFogyasztas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFelvesz_Click(object sender, EventArgs e)
        {
            string szöveg = txtTetel.Text;

            if (szöveg != "")
            {                
                    lstTetelek.Items.Add(txtTetel.Text);                                                          
            }

            txtTetel.Text = "";
            txtTetel.Focus();
        }

        private void BtnMasol_Click(object sender, EventArgs e)
        {
            if (txtTetel.Text != "")
            {
                
            }
        }

        private void TxtTetel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
