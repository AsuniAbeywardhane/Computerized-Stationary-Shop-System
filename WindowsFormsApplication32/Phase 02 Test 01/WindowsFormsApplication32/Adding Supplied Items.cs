using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//to indicate that we use sql to communicate
namespace WindowsFormsApplication32
{
    public partial class frmsrc : Form
    {
        SqlConnection con=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmsrc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            //open the connection
            string sql="insert into SuppliedItems(Date,Supplier/CompanyName,SuppliedItems,No.ofItems,TotalAmount(Rs.),Discount,AmounttobePaid)values('"+txtdt.Text+"','"+txtspl.Text+"','"+txtsi.Text+"','"+txtnoi.Text+"','"+txttotam.Text+"','"+txtdis.Text+"','"+txtamp.Text+"')";
            //requirements
            com = new SqlCommand(sql,con);
            //sending command to the database
            com.ExecuteNonQuery();
            //no output table
            con.Close();
            //closing the connection




        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void lbldt_Click(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {

        }

        private void lblnoi_Click(object sender, EventArgs e)
        {

        }
    }
}
