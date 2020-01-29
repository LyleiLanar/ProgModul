using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFormaz_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
            
        }
        private void BtnUj_Click(object sender, EventArgs e)
        {
            UjForm ujForm = new UjForm();
            ujForm.richTextBox1.Font = fontDialog1.Font;
            ujForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
