using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciklusok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFeltolt_Click(object sender, EventArgs e)
        {
            cmbEvek.Items.Clear();
            lblHiba.Text = "";
            /*
            cmbEvek.Items.Add(1900);
            cmbEvek.Items.Add(1901);
            //...
            cmbEvek.Items.Add(2000);*/
            //int tol = int.Parse(txtTol.Text);
            int.TryParse(txtTol.Text, out int tol);
            bool jo = tol >= 1900;
            if (!jo) {
                //MessageBox.Show("Az értékek 1900-2000 között legyenek!", "HIBÁS ADATOK!");
                lblHiba.Text = "Az értékek 1900 - 2000 között legyenek!";
                txtTol.Text = "";
                txtTol.Focus();
            }
            for (int i = tol; i <= 2000 && jo; i++)
            {
                cmbEvek.Items.Add(i);
            }
        }

        private void btnVizsgal_Click(object sender, EventArgs e)
        {
            int szam = 1928;//a kiválasztott Év
            if (rdbMinusz1900.Checked) { szam -= 1900; }
            //else
            //tökéletes szám e?
            lblSzam.Text = $"A vizsgált szám: {szam}, tökéletes szám";
        }
    }
}
