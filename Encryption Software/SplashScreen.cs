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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLoading_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       /* protected override void OnActivated(EventArgs e)
        {
            if (timer1.Interval == 500)
                lblLoading.Text = "Loading... Main Form";
            if (timer1.Interval == 1500)
                lblLoading.Text = "Loading... VIgenereCipher.cs";
            if (timer1.Interval == 2500)
                lblLoading.Text = "Loading... Other Forms";
            if (timer1.Interval == 3500)
                lblLoading.Text = "Activating All Other Component";
            if (timer1.Interval == 6500)
                lblLoading.Text = "Done... Opening Application Now..";

            base.OnActivated(e);
        }*/
    }
}
