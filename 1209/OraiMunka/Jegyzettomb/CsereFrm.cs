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
    public partial class CsereFrm : Form
    {
        public CsereFrm()
        {
            InitializeComponent();
        }

        private void megsemCserelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CsereFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
