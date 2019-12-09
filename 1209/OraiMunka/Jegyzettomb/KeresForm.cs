using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegyzettomb
{
    public partial class KeresForm : Form
    {
        public KeresForm()
        {
            InitializeComponent();
        }

        private void megsemKeresBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
