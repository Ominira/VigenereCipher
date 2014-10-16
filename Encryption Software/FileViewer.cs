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
    public partial class frmFileViewer : Form
    {
        public frmFileViewer()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdSavefile = new SaveFileDialog();
            //frmEncryptFile fef = new frmEncryptFile();

            //Set SFD Properties
            sfdSavefile.Title = "Select A File To Save";
            sfdSavefile.FileName ="";
            sfdSavefile.Filter = "Text Files (*.txt) |*.txt*";
            //sfdSavefile.CheckFileExists = true;
            //sfdSavefile.Filter = "HyperText Markup File (*.html) |*.html*";
            //Execute
            if (sfdSavefile.ShowDialog() == DialogResult.OK)
            {
                //Save the File
                rtbTextPad.SaveFile(sfdSavefile.FileName+".txt", RichTextBoxStreamType.PlainText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFileViewer_Load(object sender, EventArgs e)
        {
            btnSave.Focus();
        }
    }
}
