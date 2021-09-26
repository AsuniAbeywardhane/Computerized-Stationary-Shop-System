using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication32
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string un = "SagaraElectronics";
            string pwd = "0777244255";
            if (txtun.Text == un && txtpwd.Text == pwd)
            {
                MessageBox.Show("Login Successful");

                txtun.Text = " ";
                txtpwd.Text = " ";
                txtun.Focus();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");

                txtun.Text = " ";
                txtpwd.Text = " ";
                txtun.Focus();
            }
            

           



        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
