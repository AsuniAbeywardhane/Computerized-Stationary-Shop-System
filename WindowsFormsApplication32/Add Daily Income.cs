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
    public partial class frmadi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmadi()
        {
            InitializeComponent();
        }

        private void Add_Daily_Income_Load(object sender, EventArgs e)
        {


            {

              

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                //open the connection

                string sql = "Select * from DailyIncome where Date='" + dtp.Text + "'";
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
                    MessageBox.Show("Details are already added.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //show the message box
                    txtinc.Clear();
                    txtex.Clear();
                    txtprofit.Clear();

                    //clear the details
                    txtinc.Focus();
                    //focus the cursor to the mask box






                }
                else
                {
                    String Sql = "insert into DailyIncome (Date,Income,Expenditure,Profit)values('" + dtp.Text + "','" + txtinc.Text + "','" + txtex.Text + "','"+txtprofit.Text+"')";
                    //requirement
                    dr.Close();

                    com = new SqlCommand(Sql, con);
                    //sending command to the data base
                    com.ExecuteNonQuery();
                    //no output table

                    MessageBox.Show("Details are successfully added.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    txtinc.Text = "";
                    txtex.Text = "";
                    txtprofit.Text = "";
                    //clear the details
                    txtinc.Focus();
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

             int inc, ex, pro;
        

        private void btncal_Click(object sender, EventArgs e)
        {
            inc= int.Parse(txtinc.Text);
            ex = int.Parse(txtex.Text);
            pro = inc-ex;
            txtprofit.Text = pro.ToString();

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {

        }


        }
    }


