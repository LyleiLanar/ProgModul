using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teglalap
{
    public partial class negyzetForm : Form
    {
        public negyzetForm()
        {
            InitializeComponent();
        }

        private void BtnSzamol_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(fldA.Text);
            double b = Convert.ToDouble(fldB.Text);

            double kerület = 2 * (a + b);
            double terület = a * b;

            fldKerulet.Text = kerület.ToString();
            fldTerulet.Text = terület.ToString();

        }
    }
}
