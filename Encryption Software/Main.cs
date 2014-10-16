using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncryptTextForm_Click(object sender, EventArgs e)
        {
            frmEncryptText fet = new frmEncryptText();
            fet.Show();
            this.Hide();
           
            //fet.MdiParent = this;
        }

        private void btnDecryptTextForm_Click(object sender, EventArgs e)
        {
            frmDecryptText fdt = new frmDecryptText();
            fdt.Show();
            this.Hide();
            //fdt.MdiParent = this;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //IsMdiContainer = true;
            //BackColor = Color.Maroon;
        }

        private void btnEncryptFileForm_Click(object sender, EventArgs e)
        {
            frmEncryptFile fef = new frmEncryptFile();
            fef.Show();
            this.Hide();
            //fef.MdiParent = this;
        }

        private void btnDecryptFileForm_Click(object sender, EventArgs e)
        {
            frmDecryptingFile fdf = new frmDecryptingFile();
            fdf.Show();
            this.Hide();
            //fdf.MdiParent = this;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEncryptFileForm_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDecryptFileForm_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnEncryptTextForm_Click(sender, e);
        }

        private void decryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDecryptTextForm_Click(sender, e);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to Exit the application", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dr == DialogResult.No)
                this.Refresh();
            else
                this.Refresh();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAboutBox fab = new frmAboutBox();
            fab.ShowDialog();
        }

        private bool CheckForm(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           
            frmDecryptingFile fdf = new frmDecryptingFile();
            if (CheckForm(fdf))
                fdf.Dispose();
          
            frmDecryptText fdt = new frmDecryptText();
            if(CheckForm(fdt))
                fdt.Dispose();

            frmEncryptFile fef = new frmEncryptFile();
            if (CheckForm(fef))
                fef.Dispose();

            frmEncryptText fet = new frmEncryptText();
            if (CheckForm(fet))
                fet.Dispose();

            Clipboard.Clear();
            
            Application.ExitThread();

            base.OnFormClosing(e);
        }

       /* protected override void OnFormClosed(FormClosedEventArgs e)
        {
            //Application.Exit();
            base.OnFormClosed(e);
        }*/
    }
}
