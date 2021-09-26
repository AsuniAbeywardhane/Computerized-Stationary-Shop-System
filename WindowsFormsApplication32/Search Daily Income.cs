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
    public partial class frmsdi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmsdi()
        {
            InitializeComponent();
        }

        private void Search_Daily_Income_Load(object sender, EventArgs e)
        {

        }

        private void btnsrc_Click(object sender, EventArgs e)
        {

            {
                try
                {

                    con.Open();
                    //open the database connection

                    string sql = "select * From DailyIncome Where Date='" + dtp.Text + "'";
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

                        txtinc.Text = dr["Income"].ToString();
                        //loading data to the form

                        txtex.Text = dr["Expenditure"].ToString();
                        //loading data to the form
                        txtprofit.Text = dr["Profit"].ToString();
                        //loading data to the form
                    }
                    else
                    {
                        MessageBox.Show("Date not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // show the message box
                        txtinc.Focus();
                        //focus cursor to the textbox
                       

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

        private void btndis_Click(object sender, EventArgs e)
        {
            lstsdi.Items.Add(dtp.Text +"    "+ "Income - " + txtinc.Text +"    "+ "Expenditure -  " + txtex.Text+"     "+" Profit - "+txtprofit.Text+" ");
            // add details to the list box
            txtinc.Text = "";
            txtex.Text = ""; 
            txtprofit.Text = "";
            // clear the details
            

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            lstsdi.Items.Clear();
            //clear the list box
            
        }

      
    }
}
