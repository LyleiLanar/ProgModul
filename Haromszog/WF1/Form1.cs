using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGreatings_Click(object sender, EventArgs e)
        {
            String nev = txtName.Text;
            String uzenet = $"Szia, {nev}!";
            //Text = uzenet;
            this.Text = uzenet;
        }
    }
}
