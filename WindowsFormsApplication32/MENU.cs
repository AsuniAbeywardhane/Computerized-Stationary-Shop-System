using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

     

       

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1 frm = new frm1();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdit frm = new frmdit();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void searchUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsrit frm = new frmsrit();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmssd frm = new frmssd();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void interactionWithCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusd1 frm = new frmusd1();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void interactionWithSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusd2 frm = new frmusd2();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator frm = new calculator();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill frm = new Bill();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmds frm = new frmds();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void addToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
             frmast frm = new frmast();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmadi frm = new frmadi();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmsdi frm = new frmsdi();
            frm.MdiParent = this;
            //to indicate that form belongs to its parent mdi
            frm.Show();
        }

       
    }
}
