using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//to indicate that we sql to communicate

namespace WindowsFormsApplication32
{
    public partial class frmssd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmssd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmssd_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (mskic.Text.Length < 7)
            {
                MessageBox.Show("Wrong length. Check the item code again.", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // show the message box
                mskic.Clear();
                // clear the maskbox
                mskic.Focus();
                //focus the cursor to the mask box
            }
            else
            {
                try
                {

                    con.Open();
                    //open the database connection

                    string sql = "select * From Stock where ItemCode='" + mskic.Text + "'";
                    //sql is a string type variable to store the sql statement

                    com = new SqlCommand(sql, con);
                    //sending command to the database

                    SqlDataReader dr;
                    //checking the command
                    dr = com.ExecuteReader();
                    //passing data from the table to dr
                    if (dr.Read())
                    //check the record from the table
                    {

                        txtit.Text = dr["Item"].ToString();
                        //loading data to the form

                        txtcq.Text = dr["CurrentQuantity"].ToString();
                        //loading data to the form
                    }
                    else
                    {
                        MessageBox.Show("Item not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // show the message box
                        mskic.Clear();
                        mskic.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                    

                    


                finally
                {

                    con.Close();
                    //ending the connection
                }






            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            mskic.Clear();
            txtit.Clear();
            txtcq.Clear();
            // clear the details
            mskic.Focus();
            //focus the cursor to the mask box
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
