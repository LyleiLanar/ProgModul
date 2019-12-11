using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAblakEletciklus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //esemeny("Load");
        }

        private void esemeny(string txt)
        {
            MessageBox.Show(txt);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //esemeny("Klikk");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
           // esemeny("Leaving");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  esemeny("Closed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Biztos?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;                
            }

        }
    }
}
