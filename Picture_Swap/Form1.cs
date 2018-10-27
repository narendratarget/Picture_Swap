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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int inc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            inc++;
            if (inc >= 10)
            {
                timer1.Enabled = false;
                inc = 0;
                Picture_Swap p = new Picture_Swap();
                p.Show();
                this.Hide();
            }
        }
    }
}
