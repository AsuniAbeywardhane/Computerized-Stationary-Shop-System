using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;
//To indicate that we're using sql language to communicate.


namespace WindowsFormsApplication32
{
    public partial class LOGIN : Form
    {
        SqlConnection con = new SqlConnection("");
        //Setting up the connection with the database.
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
                this.Hide();
                frmload ss = new frmload();
                ss.Show();


                txtun.Text = " ";
                txtpwd.Text = " ";
                txtun.Focus();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                //show the message

                txtun.Text = " ";
                txtpwd.Text = " ";
                txtun.Focus();
            }






        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnchangepw1_Click(object sender, EventArgs e)
        {
        }

      
    }
}
