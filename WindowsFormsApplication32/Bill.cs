using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//To indicate that we use sql to communicate

namespace WindowsFormsApplication32
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\HP\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication32\\WindowsFormsApplication32\\Database1.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand com;

        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
           timer1.Start();
            txttime.Text = DateTime.Now.ToLongTimeString();
            cbocs.Items.Add("Sakunthala");
            cbocs.Items.Add("Deepika");
            cbocs.Items.Add("Ruvini");
            cbocs.Items.Add("Ishara");

            cboics.Items.Add("Pens-Atlas");
            cboics.Items.Add("Pens-Linc");
            cboics.Items.Add("Pens-Rotomac");
            cboics.Items.Add("Pens-Cial");
            cboics.Items.Add("Books-Atlas");
            cboics.Items.Add("Books-Richard");
            cboics.Items.Add("Books-Weerodara");
            cboics.Items.Add("Books-SPC");
            cboics.Items.Add("Pencils-Nataraj");
            cboics.Items.Add("Pencils-Weerodara");
            cboics.Items.Add("Pencils-Atlas");
            cboics.Items.Add("Pencils-Drawing pencils");
            cboics.Items.Add("Mathematical Instument Boxes-Nataraj");
            cboics.Items.Add("Mathematical Instument Boxes-Oxford");
            cboics.Items.Add("Sheets-A4");
            cboics.Items.Add("Sheets-color");
            cboics.Items.Add("Sheets-Wrapping Papers");
            cboics.Items.Add("Sheets-Halfsheets");
            cboics.Items.Add("Mobile Phone Accessories-Recharge Cards");
            cboics.Items.Add("Mobile Phone Accessories-Sims");
            cboics.Items.Add("Mobile Phone Accessories-Batteries");
            cboics.Items.Add("Mobile Phone Accessories-Charges");
            cboics.Items.Add("Other Stationary");
            cboics.Items.Add("Services");
           





        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskisc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void txtis_TextChanged(object sender, EventArgs e)
        {





        }

        private void mskisc_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtisc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "Select * from AddingItems where ItemCode='" + txtisc.Text + "'";
                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (txtisc.Text.Length >= 7)
                {
                    dr.Read();
                    txtis.Text = dr["Item"].ToString();
                    txtisp.Text = dr["Price"].ToString();
                    dr.Close();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            finally

            { 
                con.Close();
           }
            
        }

        int qty, pr, amt;


        
        private void txtqt_TextChanged(object sender, EventArgs e)
        {

            qty = int.Parse(txtqt.Text);
            pr = int.Parse(txtisp.Text);
        
            amt = pr * qty;
            txtam.Text = amt.ToString();
           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnrfr_Click(object sender, EventArgs e)
        {
           
            
     }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
                String Sql = "insert into Bill_Details(Category,Code,ItemORService,Price,Quantity,Amount)values('"+cboics.Text+"','"+txtisc.Text+"','"+txtis.Text+"','"+txtisp.Text+"','" + txtqt.Text+"','"+txtam.Text+"')";
                //requirement
               
                com = new SqlCommand(Sql, con);
                //sending command to the data base
                com.ExecuteNonQuery();
                //no output table
               Sql= "Select Category,Code,ItemORService,Price,Quantity,Amount From Bill_Details";
                com = new SqlCommand(Sql, con);
                //sending command to the data base

                SqlDataReader dr;
                //checking the database
               
                dr = com.ExecuteReader();
                //passing data from the table to dr
              

                DataTable dt = new DataTable();
                dt.Load(dr);
                
                dataGridView1.DataSource = dt;
                dr.Close();
                txtisc.Text = "";
                txtisp.Text="";
                txtqt.Text="";
                txtam.Text = "";
                txtisc.Focus();
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

        private void txtnoi_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
         

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //conditions
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                //to add above details to the grid.
            }
            txtnoi.Text = sum.ToString();
            //to show total on textbox.
        }
       
        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            
        
         
        }

      
        private void btngt_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //conditions
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                //to add above details to the grid.
            }
            txtgt.Text = sum.ToString();
            //to show total on textbox.
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
          

        }

        private void btnref_Click(object sender, EventArgs e)
        {
            con.Open();
            string Sql = "delete from Bill_Details";
            com = new SqlCommand(Sql, con);
            com.ExecuteNonQuery();
            txtisc.Clear();
            txtis.Clear();
            txtisp.Clear();
            txtqt.Clear();
            txtam.Clear();
            txtnoi.Clear();
            txtgt.Clear();
            txtdis.Clear();
            txtna.Clear();
            txtisc.Focus();
         
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
            con.Close();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }
        int gt, dis, na;
        private void button2_Click(object sender, EventArgs e)
        {
            gt = int.Parse(txtgt.Text);
            dis = int.Parse(txtdis.Text);

            na = gt - dis;
            txtna.Text = na.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        

        }

        private void txtam_TextChanged(object sender, EventArgs e)
        {

        }
      
       
    }
}
