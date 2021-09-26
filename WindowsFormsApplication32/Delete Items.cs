using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//to indicate that use sql to communicate

namespace WindowsFormsApplication32
{
    public partial class frmdit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmdit()
        {
            InitializeComponent();
        }

        private void mskic_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdit_Load(object sender, EventArgs e)
        {

        }

        private void btnsrc_Click(object sender, EventArgs e)
        {

            if (mskic.Text.Length < 7)
            {
                MessageBox.Show("Wrong length", "length Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //show the message box
                mskic.Clear();
                //clear details
                mskic.Focus();
                //focus the cursor to the mask box
            }
            else
            {
                try
                {
                    con.Open();
                    // //open the connection
                    string sql = "select * from  AddingItems where ItemCode='" + mskic.Text + "'";
                    //sql is a string type variable to store the sql statement 
            
                    com = new SqlCommand(sql, con);
                    //sending command to the data base
                    SqlDataReader dr;
                    // //checking the database
                    dr = com.ExecuteReader();
                    //passing data from the table to dr

                    if (dr.Read())
                    //checks the existance of the table(record)
                    {
                        txtit.Text = dr["Item"].ToString();
                        txtpr.Text = dr["Price"].ToString();
                        
                    }

                    else
                    {
                        MessageBox.Show("Item not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //show the message box
                        mskic.Clear();
                        //clear the details
                        mskic.Focus();
                        //focus the cursor to the mask box


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    //closing the connection

                }



            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to Delete this item details?", "Confirm Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //confirmation dialog box

            if (ans == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    //open the connection
                    string sql = "Delete from AddingItems where ItemCode='" + mskic.Text + "'";
                    //requirement
                    com = new SqlCommand(sql, con);
                    //sending command to the data base
                    com.ExecuteNonQuery();
                    //no output table
                    MessageBox.Show("Item details deleted successfully");
                    mskic.Clear();
                    txtit.Clear();
                    txtpr.Clear();
                    //clear details
                    mskic.Focus();
                    //focus cursor to the mask box
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    //closing the connection
                }
            }
            else
            {
                mskic.Clear();
                txtit.Clear();
                txtpr.Clear();

                //clear details
                mskic.Focus();
                 //focus cursor to the mask box
                
                }
            {

        
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskic_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

    
