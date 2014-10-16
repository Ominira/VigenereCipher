using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDecryptText : Form
    {
        public frmDecryptText()
        {
            InitializeComponent();
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if (rtbInputText.Text == "")
            {
                MessageBox.Show("Please Enter the text to Decrypt","Alert",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else if (txtKey.Text == "")
            {
                    MessageBox.Show("Please Enter Decryption Key","Alert",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {

                String inputString = rtbInputText.Text;
                String key = txtKey.Text;

                VigenereCipher vc = new VigenereCipher();

                String DecryptedText = vc.DecryptText(inputString, key);

                rtbDecryptedText.Text = DecryptedText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            rtbDecryptedText.Clear();
            rtbInputText.Clear();
            rtbInputText.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncryptFile fef = new frmEncryptFile();
            fef.Show();
            this.Hide();
           
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
            button1_Click(sender, e);
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

        private void frmDecryptText_Load(object sender, EventArgs e)
        {

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

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ClipText = Clipboard.GetText();

            if (this.rtbInputText.SelectedText != String.Empty)
                this.rtbInputText.SelectedText = this.rtbInputText.SelectedText.Replace(this.rtbInputText.SelectedText, ClipText);
            else
            {
                rtbInputText.Text = ClipText;
               //Clipboard.Clear();
            }
        }
    }
}
