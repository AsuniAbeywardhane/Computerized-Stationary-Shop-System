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
    public partial class frmusd2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmusd2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                        txtstq.Text = dr["CurrentQuantity"].ToString();
                        //loading data to the form
                    }
                    else
                    {
                        MessageBox.Show("Item not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Update_Stock_Details_Interaction_with_supplier__Load(object sender, EventArgs e)
        {

        }

        private void txtaq_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
              con.Open();
            string sql = "update Stock set Item='" + txtit.Text + "',CurrentQuantity='" + txtavq.Text + "' where ItemCode='" + mskic.Text + "'";
            MessageBox.Show(" Successfully Updated", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mskic.Text = "";
            txtit.Text = "";
            txtstq.Text = "";
            txtaq.Text = "";
            txtavq.Text = "";
            mskic.Focus();




            com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
        }
        int cq, aq, avq;
        private void btncal_Click(object sender, EventArgs e)
        {
            cq = int.Parse(txtstq.Text);
            aq = int.Parse(txtaq.Text);
            avq = cq + aq;
            txtavq.Text = avq.ToString();
        }
    }
}
