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
    public partial class frmast : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command

        public frmast()
        {
            InitializeComponent();
        }

      private void btnadd_Click(object sender, EventArgs e)
        {
            if (mskic.Text.Length < 7)
            {
                MessageBox.Show("Wrong length. Check the item code again.", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskic.Clear();
                txtit.Clear();
                txtq.Clear();
                mskic.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    //open the database connection
                    string sql = "select * from Stock where ItemCode ='" + mskic.Text + "'";
                    //sql is a string type variable to store the sql statement
                    com = new SqlCommand(sql, con);
                    //sending command to the database
                    SqlDataReader dr;
                    //checking the command
                    dr = com.ExecuteReader();
                    //passing data from the table to dr
                    if (dr.Read())
                    //check the recorde from the table
                    {
                        MessageBox.Show("Item Code already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mskic.Clear();
                        txtit.Clear();
                        txtq.Clear();
                        mskic.Focus();
                        
                         }

                    else
                    {
                          string sql1 = "insert into Stock(ItemCode,Item,CurrentQuantity)values('" + mskic.Text + "','" + txtit.Text + "','" + txtq.Text + "')";
                        //sql is a string type variable to store the sql statement
                        dr.Close();

                        com = new SqlCommand(sql1, con);
                        //sending command to the database

                        com.ExecuteNonQuery();
                        //No output table
                        MessageBox.Show("Successfully added to the stock ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstast.Items.Add(mskic.Text + "  " + txtit.Text + "  " + txtq.Text);
                       
                        mskic.Text = "";
                        txtit.Text = "";
                        txtq.Text = "";
                        //clear details
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

      

        private void btnclr_Click(object sender, EventArgs e)
        {
            lstast.Items.Clear();
            //clear the list box
            mskic.Focus();
            //focus the cursor to the mask box
        }

        private void frmast_Load(object sender, EventArgs e)
        {

        }

       
     
    }
}