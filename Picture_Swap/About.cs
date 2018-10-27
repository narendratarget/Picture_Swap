using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picture_Swap
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        int f = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f >= 1)
            {
                button1.Text = "Close ( " + f + " )";
                f--;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("narendratarget@gmail.com");
            
        }

        private void copyMobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("+91-9627950018");
        }

        private void copyFacebookIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("www.facebook.com/narendratarget");
        }

        private void About_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Mail us for the further Help......");
        }
    }
}
