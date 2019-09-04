using System;
using System.Windows.Forms;

namespace Valasztas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnElkuld_Click(object sender, EventArgs e)
        {
            string valasz = "";

            if ((rBtnFerfi.Checked || rBtnNo.Checked))
            {
                if (chbxHirlevel.Checked)
                {
                    valasz = "Feliratkoztál!\n";
                    if (rbtnKp.Checked)
                    {
                        valasz = valasz + "Készpénzel fizetsz. ";
                    }
                    else
                    {
                        valasz = valasz + "Bankkártyával fizetsz. ";
                    }
                }
                else
                {
                    valasz = "Nem iratkoztál fel!\n";
                }

                if (rBtnFerfi.Checked)
                {
                    valasz = valasz + "A nemed férfi. ";
                }
                else
                {
                    valasz = valasz + "A nemed nő. ";
                }


            }
            else
            {
                MessageBox.Show("Add meg a nemed!", "HIBA");
            }

            MessageBox.Show(valasz, "Hírlevél");




        }
    }
}
