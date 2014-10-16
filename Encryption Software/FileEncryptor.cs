using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmEncryptFile : Form
    {
        static String EncryptedText = "";

        public frmEncryptFile()
        {
            InitializeComponent();
        }

        private void lblDone_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmEncryptFile_Load(object sender, EventArgs e)
        {
            btnViewFile.Hide();
            btnClearAll.Hide();
            lblDone.Hide();
            pgsEncryptionBar.Hide();

            txtEnKey.Clear();
            txtFilePath.Clear();
            rtbFileContent.Clear();

        }

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            frmFileViewer ffv = new frmFileViewer();
            ffv.rtbTextPad.Text = EncryptedText;
            ffv.ShowDialog();
         }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //create OFD
            OpenFileDialog ofdOpenfile = new OpenFileDialog();

            //Set OFD Properties
            ofdOpenfile.Title = "Select A File To Load";
            ofdOpenfile.FileName = "";
            ofdOpenfile.Filter = "Text Files (*.txt) |*.txt*"; //| Doc Files (*.doc)|*.doc* | Rich Text Files (*.rtf)|*.rtf*";
            //ofdOpenfile.Filter = "HyperText Markup File (*.html) |*.html*";

            ofdOpenfile.CheckFileExists = true;
            ofdOpenfile.Multiselect = false;
            //Execute
            if (ofdOpenfile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofdOpenfile.FileName;
                //Open the File
                rtbFileContent.LoadFile(ofdOpenfile.FileName, RichTextBoxStreamType.PlainText);
                //rtbFileContent.LoadFile(ofdOpenfile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void btnEncryptFile_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "")
            {
                MessageBox.Show("Please Choose a File to Encrypt", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnBrowse.Focus();
            }
            else if (txtEnKey.Text == "")
            {
                MessageBox.Show("Enter Key for Encryption", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnKey.Focus();
            }
            else
            {
                pgsEncryptionBar.Show();

                Thread.Sleep(500);

                pgsEncryptionBar.Value = 20;
                Thread.Sleep(500);

                String inputString = rtbFileContent.Text;
                String key = txtEnKey.Text;

                VigenereCipher vc = new VigenereCipher();

                EncryptedText = vc.EncryptText(inputString, key);

                pgsEncryptionBar.Value = 60;

                Thread.Sleep(500);

                pgsEncryptionBar.Value = pgsEncryptionBar.Maximum;
                lblDone.Show();

                Thread.Sleep(1500);

                btnViewFile.Show();
                btnClearAll.Show();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            frmEncryptFile_Load(sender, e);
        }
 
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEncryptFile_Load(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecryptingFile fdf = new frmDecryptingFile();
            fdf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEncryptText fet = new frmEncryptText();
            fet.Show();
            this.Hide();
        }

        private void decryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecryptText fdt = new frmDecryptText();
            fdt.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAboutBox fab = new frmAboutBox();
            fab.ShowDialog();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to Exit the application\n(Yes/Close, No/Home, Cancel/To remain)", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (dr == DialogResult.Yes)
                Application.ExitThread();
            else if (dr == DialogResult.No)
                homeToolStripMenuItem_Click(sender, e);
            else if (dr == DialogResult.Cancel)
                this.Refresh();
            else
                this.Refresh();
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
            frmMain fm = new frmMain();
            if (!CheckForm(fm))
            {
                fm.Show();
            }
            else
            {
                fm.WindowState = FormWindowState.Normal;
                fm.BringToFront();
                fm.Activate();
            }
            base.OnFormClosing(e);
        }
    }
}
