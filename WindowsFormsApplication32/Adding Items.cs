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
    public partial class frm1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frm1()
        {
            InitializeComponent();
        }

       

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (mskic.Text.Length < 7)
            {
                MessageBox.Show("Wrong length. Check the item code again.", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //show the message box
                mskic.Clear();
                txtit.Clear();
                txtpr.Clear();
                //clear details
                mskic.Focus();
                //focus cursor to the mask box
            }
            else
            {
          
            try
            {
                
                con.Open();
                //open the connection
                
                string sql = "Select * from AddingItems where ItemCode='" + mskic.Text + "'";
                //sql is a string type variable to store the sql statement 
            
                com = new SqlCommand(sql, con);
                //sending command to the data base
                
                SqlDataReader dr;
                //checking the database
            
                dr = com.ExecuteReader();
                //passing data from the table to dr

                if (dr.Read())
                    //checks the existance of the table(record)
                {
                    MessageBox.Show("item is already added.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //show the message box
                    txtit.Clear();
                    txtpr.Clear();
                    mskic.Clear();
                    //clear the details
                    mskic.Focus(); 
                    //focus the cursor to the mask box

 }
                else
                        
                {
                    String Sql= "insert into AddingItems(ItemCode,Item,Price)values('" + mskic.Text + "','" + txtit.Text + "','" + txtpr.Text + "')";
                    //requirement
                    dr.Close();
                    
                    com = new SqlCommand(Sql, con);
                    //sending command to the data base
                    com.ExecuteNonQuery();
                    //no output table
                    
                        MessageBox.Show("Item is successfully added.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        lstai.Items.Add(mskic.Text + "  " + txtit.Text + "  " + txtpr.Text);
                    //add details to the list box
                        mskic.Text = "";
                        txtit.Text = "";
                        txtpr.Text = "";
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

      private void btnclr_Click(object sender, EventArgs e)
        {
            lstai.Items.Clear();
            //clear the list box
            mskic.Focus();
            //focus the cursor to the mask box
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

     






    }
}