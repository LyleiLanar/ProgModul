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
    public partial class FoFrm : Form
    {
        private bool isFileOpened;

        public FoFrm()
        {
            InitializeComponent();
            isFileOpened = false;
        }

        private void fileMnu_Click(object sender, EventArgs e)
        {

        }

        private void fajlKilepMnu_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void fajlUjMnu_Click(object sender, EventArgs e)
        {
            rtbMain.Text = "";
        }

        private void fajlMegynitMnu_Click(object sender, EventArgs e)
        {
            opFileDiaMegnyit.ShowDialog();
        }

        private void fajlMentMasMnu_Click(object sender, EventArgs e)
        {
            SaveFileDialog mentesSFD = new SaveFileDialog();
            mentesSFD.ShowDialog();
        }

        private void formatumBetuMnu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
        }

        private void formatumIrasvedettMnu_Click(object sender, EventArgs e)
        {
            formatumIrasvedettMnu.Checked = !formatumIrasvedettMnu.Checked;
        }

        private void szerkKeresMnu_Click(object sender, EventArgs e)
        {
            new KeresForm().Show();
        }

        private void szerkCsereMnu_Click(object sender, EventArgs e)
        {
            new CsereFrm().Show();
        }
    }
}
