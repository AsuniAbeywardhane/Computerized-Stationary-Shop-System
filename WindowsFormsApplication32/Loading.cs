using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class frmload : Form
    {
        public frmload()
        {
            InitializeComponent();
        }

        private void frmload_Load(object sender, EventArgs e)
        {
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 10;
            if (Convert.ToInt32(progressBar1.Value) > 90)
            {
                timer1.Enabled = false;
                MENU f2 = new MENU();
                this.Hide();
                f2.Show();
                //load menu
            }
        }
    }
}
