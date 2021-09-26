using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
// to indicate that we use sql to communicate
namespace WindowsFormsApplication32
{
    public partial class frmsrit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmsrit()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (mskic.Text.Length < 5)
            {
                MessageBox.Show("Wrong length. Check the item code again.", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskic.Clear();
                mskic.Focus();
            }
            else
            {
                try
                {
     
            con.Open();
            //open the database connection
         
            string sql = "select * From AddingItems where ItemCode='" + mskic.Text+"'";
                    //sql is a string type variable to store the sql statement
          
            com = new SqlCommand(sql, con);
                    //sending command to the database
                    
            SqlDataReader dr;
            //checking the command
            dr=com.ExecuteReader();
            //passing data from the table to dr
            if (dr.Read())
            //check the record from the table
            {

                txtit.Text = dr["Item"].ToString();
                //loading data to the form
               
                txtpr.Text = dr["Price"].ToString();
                //loading data to the form
            }
            else
            {
                MessageBox.Show("Item not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskic.Clear();
                mskic.Focus();
            }
                }
                catch(Exception ex)
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

        private void lblic_Click(object sender, EventArgs e)
        {

        }

        private void frmsrit_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
        
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update AddingItems set Item='" + txtit.Text + "',Price='" + txtpr.Text + "' where ItemCode='" + mskic.Text + "'";
            MessageBox.Show(" Successfully Updated","Result",MessageBoxButtons.OK, MessageBoxIcon.Information);
            mskic.Text = "";
            txtit.Text = "";
            txtpr.Text = "";
            mskic.Focus();
            

            
            com=new SqlCommand(sql,con);
            com.ExecuteNonQuery();
            con.Close();
        
        }
    }
}
