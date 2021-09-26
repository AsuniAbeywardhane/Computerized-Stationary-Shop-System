using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication32
{
    public partial class frmadds : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;User Instance=True");
        //setting up the connection
        SqlCommand com;
        //declaring command
        public frmadds()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Frmadds_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            //open the connection
            string sql = "insert into AddingServices(ServiceCode,Service,Charges(Rs.))values('" + msksc.Text + "','" + txts.Text + "','" + txtchr.Text + "')";
            //requirement
            com = new SqlCommand(sql, con);
            //sending command to the database
            com.ExecuteNonQuery();
            //no output table
            con.Close();
            //closing the connection
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            lstas.Items.Add(msksc.Text + " " + txts.Text + " " + txtchr.Text);
            msksc.Text = "";
            txts.Text = "";
            txtchr.Text = "";

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
