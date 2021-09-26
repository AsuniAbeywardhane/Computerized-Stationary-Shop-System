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
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"c:\\users\\hp\\documents\\visual studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frm1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            //open the connection
            string Sql = "insert into AddingItems(ItemCode,Item,Price)values('" + mskic.Text + "','" + txtit.Text + "','" + txtpr.Text + "')";
            //requirement
            com = new SqlCommand(Sql, con);
            //sending command to the data base
            com.ExecuteNonQuery();
            //no output table
            con.Close();
            //closing the connection


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstai.Items.Add(mskic.Text + " " + txtit.Text + " " + txtpr.Text);
            mskic.Text = "";
            txtit.Text = "";
            txtpr.Text = "";


        }
    }
}
