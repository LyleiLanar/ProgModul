using System;
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

            if (Int32.TryParse(szöveg, out int szam) == true)
            {
                if (szöveg != "")
                {
                    lstTetelek.Items.Add(txtTetel.Text);
                }
            }

            txtTetel.Text = "";
            txtTetel.Focus();
        }

        private void BtnMasol_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTetelek.SelectedItems.Count; i++)
            {
                if (txtEredmeny.Text == "")
                {
                    txtEredmeny.Text = txtEredmeny.Text + (string)lstTetelek.SelectedItems[i] + "\r\n";
                }
                else
                {
                    txtEredmeny.Text = txtEredmeny.Text + (string)lstTetelek.SelectedItems[i] + "\r\n";
                }
            }

            lstTetelek.SelectedItems.Clear();
        }

        private void TxtTetel_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMaximum_Click(object sender, EventArgs e)
        {
            string tetelek = txtEredmeny.Text;
            bool vanAdat;
            int adat;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            if (tetelek != "")
            {
                vanAdat = Int32.TryParse(tetelek.Substring(0, tetelek.IndexOf("\r\n")), out adat);
            }
            else
            {
                vanAdat = false;
                adat = 0;
            }


            while (vanAdat)
            {
                if (max < adat) max = adat;
                if (min > adat) min = adat;

                tetelek = tetelek.Remove(0, adat.ToString().Length + 2);

                if (tetelek != "")
                {
                    adat = Convert.ToInt32(tetelek.Substring(0, tetelek.IndexOf("\r\n")));
                }
                else
                {
                    vanAdat = false;
                }
            }
            txtMaxEredmeny.Text = max.ToString() + "/" + min.ToString();
        }

        private void BtnSzum_Click(object sender, EventArgs e)
        {
            string tetelek = txtEredmeny.Text;
            bool vanAdat;
            int adat;
            int szum = 0;

            if (tetelek != "")
            {
                vanAdat = Int32.TryParse(tetelek.Substring(0, tetelek.IndexOf("\r\n")), out adat);
            }
            else
            {
                vanAdat = false;
                adat = 0;
            }

            while (vanAdat)
            {
                szum += adat;

                tetelek = tetelek.Remove(0, adat.ToString().Length + 2);

                if (tetelek != "")
                {
                    adat = Convert.ToInt32(tetelek.Substring(0, tetelek.IndexOf("\r\n")));
                }
                else
                {
                    vanAdat = false;
                }
            }
            txtSzumEredmeny.Text = szum.ToString();
        }

        private void BtnEredmenyTorles_Click(object sender, EventArgs e)
        {
            txtEredmeny.Text = "";
            txtMaxEredmeny.Text = "";
            txtSzumEredmeny.Text = "";
            txtParosEredmeny.Text = "";
        }

        private void BtmParosSzamok_Click(object sender, EventArgs e)
        {
            string tetelek = txtEredmeny.Text;
            bool vanAdat;
            int adat;
            string parosSzamok = "";

            if (tetelek != "")
            {
                vanAdat = Int32.TryParse(tetelek.Substring(0, tetelek.IndexOf("\r\n")), out adat);
            }
            else
            {
                vanAdat = false;
                adat = 0;
            }

            while (vanAdat)
            {
                if (adat % 2 == 0) parosSzamok = parosSzamok + " " +adat.ToString();

                tetelek = tetelek.Remove(0, adat.ToString().Length + 2);

                if (tetelek != "")
                {                    
                    adat = Convert.ToInt32(tetelek.Substring(0, tetelek.IndexOf("\r\n")));                   
                }
                else
                {
                    vanAdat = false;
                }
            }
            txtParosEredmeny.Text = parosSzamok;
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            lstTetelek.Items.Clear();
        }
    }
}
