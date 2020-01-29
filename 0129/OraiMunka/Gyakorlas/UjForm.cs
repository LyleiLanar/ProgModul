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
    public partial class UjForm : Form
    {
        public UjForm()
        {
            InitializeComponent();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = Program.form1.richTextBox1.Font;
        }
    }
}
