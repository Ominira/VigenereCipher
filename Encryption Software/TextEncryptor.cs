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
    public partial class frmEncryptText : Form
    {
        public frmEncryptText()
        {
            InitializeComponent();
        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            if (rtbInputText.Text == "")
            {
                MessageBox.Show("Please Enter Some Text String", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtKey.Text == ""){
                MessageBox.Show("Please Enter Encryption Key", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                String inputString = rtbInputText.Text;
                String key = txtKey.Text;

                VigenereCipher vc = new VigenereCipher();

                String EncryptedText = vc.EncryptText(inputString, key);

                rtbEncryptedText.Text = EncryptedText;
            }
        }
        
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            rtbEncryptedText.Clear();
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
            btnClearAll_Click(sender, e);
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

        private void frmEncryptText_Load(object sender, EventArgs e)
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

        public void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (Clipboard.ContainsText())
                    Clipboard.Clear();

                string textCopied = this.rtbEncryptedText.SelectedText.ToString();

                if (textCopied != String.Empty)
                    Clipboard.SetText(textCopied);
            }
            catch (Exception ex)
                {
                    MessageBox.Show("Clipboard can not be use now\n" + ex.Message + "\nPlease try to copy again","Clipboard Error Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
        }
    }
}
