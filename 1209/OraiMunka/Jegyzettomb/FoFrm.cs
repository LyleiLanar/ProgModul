using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /*MENU*/
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
            

            if (opFileDiaMegnyit.ShowDialog() == DialogResult.OK)
            {
                string fn = opFileDiaMegnyit.FileName;

                if (fn.EndsWith(".txt")) 
                {
                    rtbMain.LoadFile(opFileDiaMegnyit.FileName, RichTextBoxStreamType.PlainText);
                }
                
            }
            
        }
        
        private string fnev = "";
        private void fajlMentMasMnu_Click(object sender, EventArgs e)
        {
            SaveFileDialog mentesSFD = new SaveFileDialog();
            mentesSFD.Filter = "Minden fájl|*.*|Csak szöveg|*.txt";
            mentesSFD.FilterIndex = 0;

            if (mentesSFD.ShowDialog() == DialogResult.OK)
            {               
                fnev = mentesSFD.FileName;
                Text = fnev;
                fajlMentMnu.Enabled = true;
                rtbMain.SaveFile(fnev,RichTextBoxStreamType.PlainText);
            }            
        }
        private void fajlMentMnu_Click(object sender, EventArgs e)
        {
            if (fnev!="")
            {
                rtbMain.SaveFile(fnev);
            }
        }

        /*CONTEXT MENU*/



        /*GOMBOK*/




        private void formatumBetuMnu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbMain.Font = fontDialog.Font;   
            }
            
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

        private void FoFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos bezárod ezt a fost?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tsKivag_Click(object sender, EventArgs e)
        {
            this.szerkKivagMnu_Click(sender,e);
        }

        private void szerkKivagMnu_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectedText != "")
            {
                rtbMain.Cut();
            }
        }
        private void cmnKivagas_Click(object sender, EventArgs e)
        {
            this.szerkKivagMnu_Click(sender, e);
        }

        private void szerkBeillesztMnu_Click(object sender, EventArgs e)
        {
            rtbMain.Paste();
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rtbMain.Paste();
            }            
        }

        private void szerkVisszaMnu_Click(object sender, EventArgs e)
        {
            rtbMain.Undo();
        }

    }
}
