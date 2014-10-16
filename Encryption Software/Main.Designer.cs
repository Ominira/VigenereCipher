namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEncryptFileForm = new System.Windows.Forms.Button();
            this.btnDecryptFileForm = new System.Windows.Forms.Button();
            this.btnEncryptTextForm = new System.Windows.Forms.Button();
            this.btnDecryptTextForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.decryptTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.aboutToolStripMenuItem.Text = "Encrypt File";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.exitToolStripMenuItem.Text = "Decrypt File";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.exitToolStripMenuItem1.Text = "Encrypt Text";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // decryptTextToolStripMenuItem
            // 
            this.decryptTextToolStripMenuItem.Name = "decryptTextToolStripMenuItem";
            this.decryptTextToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.decryptTextToolStripMenuItem.Text = "Decrypt Text";
            this.decryptTextToolStripMenuItem.Click += new System.EventHandler(this.decryptTextToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(48, 24);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // btnEncryptFileForm
            // 
            this.btnEncryptFileForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptFileForm.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFileForm.Location = new System.Drawing.Point(97, 220);
            this.btnEncryptFileForm.Name = "btnEncryptFileForm";
            this.btnEncryptFileForm.Size = new System.Drawing.Size(258, 120);
            this.btnEncryptFileForm.TabIndex = 1;
            this.btnEncryptFileForm.Text = "Click to Encrypt a File";
            this.btnEncryptFileForm.UseVisualStyleBackColor = true;
            this.btnEncryptFileForm.Click += new System.EventHandler(this.btnEncryptFileForm_Click);
            // 
            // btnDecryptFileForm
            // 
            this.btnDecryptFileForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptFileForm.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFileForm.Location = new System.Drawing.Point(658, 220);
            this.btnDecryptFileForm.Name = "btnDecryptFileForm";
            this.btnDecryptFileForm.Size = new System.Drawing.Size(258, 120);
            this.btnDecryptFileForm.TabIndex = 2;
            this.btnDecryptFileForm.Text = "Click to Decrypt a File";
            this.btnDecryptFileForm.UseVisualStyleBackColor = true;
            this.btnDecryptFileForm.Click += new System.EventHandler(this.btnDecryptFileForm_Click);
            // 
            // btnEncryptTextForm
            // 
            this.btnEncryptTextForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptTextForm.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptTextForm.Location = new System.Drawing.Point(97, 491);
            this.btnEncryptTextForm.Name = "btnEncryptTextForm";
            this.btnEncryptTextForm.Size = new System.Drawing.Size(258, 120);
            this.btnEncryptTextForm.TabIndex = 3;
            this.btnEncryptTextForm.Text = "Click to Encrypt a Text";
            this.btnEncryptTextForm.UseVisualStyleBackColor = true;
            this.btnEncryptTextForm.Click += new System.EventHandler(this.btnEncryptTextForm_Click);
            // 
            // btnDecryptTextForm
            // 
            this.btnDecryptTextForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptTextForm.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptTextForm.Location = new System.Drawing.Point(658, 491);
            this.btnDecryptTextForm.Name = "btnDecryptTextForm";
            this.btnDecryptTextForm.Size = new System.Drawing.Size(258, 120);
            this.btnDecryptTextForm.TabIndex = 4;
            this.btnDecryptTextForm.Text = "Click to Decrypt a Text";
            this.btnDecryptTextForm.UseVisualStyleBackColor = true;
            this.btnDecryptTextForm.Click += new System.EventHandler(this.btnDecryptTextForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(175, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 113);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ominira CipherSoft";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecryptTextForm);
            this.Controls.Add(this.btnEncryptTextForm);
            this.Controls.Add(this.btnDecryptFileForm);
            this.Controls.Add(this.btnEncryptFileForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1048, 752);
            this.MinimumSize = new System.Drawing.Size(1048, 752);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ominira CipherSoft -  Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btnEncryptFileForm;
        private System.Windows.Forms.Button btnDecryptFileForm;
        private System.Windows.Forms.Button btnEncryptTextForm;
        private System.Windows.Forms.Button btnDecryptTextForm;
        private System.Windows.Forms.ToolStripMenuItem decryptTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
    }
}

