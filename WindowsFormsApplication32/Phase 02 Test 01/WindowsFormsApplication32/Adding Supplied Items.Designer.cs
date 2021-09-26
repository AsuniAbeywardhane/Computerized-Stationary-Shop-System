namespace WindowsFormsApplication32
{
    partial class frmsrc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldt = new System.Windows.Forms.Label();
            this.lblscn = new System.Windows.Forms.Label();
            this.lblspi = new System.Windows.Forms.Label();
            this.lblnoi = new System.Windows.Forms.Label();
            this.lbltotam = new System.Windows.Forms.Label();
            this.lbldis = new System.Windows.Forms.Label();
            this.lblamp = new System.Windows.Forms.Label();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtspl = new System.Windows.Forms.TextBox();
            this.txtsi = new System.Windows.Forms.TextBox();
            this.txtnoi = new System.Windows.Forms.TextBox();
            this.txttotam = new System.Windows.Forms.TextBox();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.txtamp = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncal = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.Location = new System.Drawing.Point(33, 31);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(46, 18);
            this.lbldt.TabIndex = 0;
            this.lbldt.Text = "Date";
            this.lbldt.Click += new System.EventHandler(this.lbldt_Click);
            // 
            // lblscn
            // 
            this.lblscn.AutoSize = true;
            this.lblscn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscn.Location = new System.Drawing.Point(33, 79);
            this.lblscn.Name = "lblscn";
            this.lblscn.Size = new System.Drawing.Size(199, 18);
            this.lblscn.TabIndex = 1;
            this.lblscn.Text = "Supplier/CompanyName";
            // 
            // lblspi
            // 
            this.lblspi.AutoSize = true;
            this.lblspi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspi.Location = new System.Drawing.Point(33, 139);
            this.lblspi.Name = "lblspi";
            this.lblspi.Size = new System.Drawing.Size(121, 18);
            this.lblspi.TabIndex = 2;
            this.lblspi.Text = "SuppliedItems";
            this.lblspi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblnoi
            // 
            this.lblnoi.AutoSize = true;
            this.lblnoi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoi.Location = new System.Drawing.Point(33, 190);
            this.lblnoi.Name = "lblnoi";
            this.lblnoi.Size = new System.Drawing.Size(94, 18);
            this.lblnoi.TabIndex = 3;
            this.lblnoi.Text = "No.ofItems";
            this.lblnoi.Click += new System.EventHandler(this.lblnoi_Click);
            // 
            // lbltotam
            // 
            this.lbltotam.AutoSize = true;
            this.lbltotam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotam.Location = new System.Drawing.Point(34, 250);
            this.lbltotam.Name = "lbltotam";
            this.lbltotam.Size = new System.Drawing.Size(148, 18);
            this.lbltotam.TabIndex = 4;
            this.lbltotam.Text = "TotalAmount(Rs.)";
            // 
            // lbldis
            // 
            this.lbldis.AutoSize = true;
            this.lbldis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldis.Location = new System.Drawing.Point(42, 309);
            this.lbldis.Name = "lbldis";
            this.lbldis.Size = new System.Drawing.Size(79, 18);
            this.lbldis.TabIndex = 5;
            this.lbldis.Text = "Discount";
            this.lbldis.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblamp
            // 
            this.lblamp.AutoSize = true;
            this.lblamp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamp.Location = new System.Drawing.Point(42, 367);
            this.lblamp.Name = "lblamp";
            this.lblamp.Size = new System.Drawing.Size(147, 18);
            this.lblamp.TabIndex = 6;
            this.lblamp.Text = "AmountToBePaid";
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(257, 32);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(257, 20);
            this.txtdt.TabIndex = 7;
            // 
            // txtspl
            // 
            this.txtspl.Location = new System.Drawing.Point(257, 77);
            this.txtspl.Name = "txtspl";
            this.txtspl.Size = new System.Drawing.Size(257, 20);
            this.txtspl.TabIndex = 8;
            // 
            // txtsi
            // 
            this.txtsi.Location = new System.Drawing.Point(257, 139);
            this.txtsi.Name = "txtsi";
            this.txtsi.Size = new System.Drawing.Size(257, 20);
            this.txtsi.TabIndex = 9;
            // 
            // txtnoi
            // 
            this.txtnoi.Location = new System.Drawing.Point(257, 191);
            this.txtnoi.Name = "txtnoi";
            this.txtnoi.Size = new System.Drawing.Size(257, 20);
            this.txtnoi.TabIndex = 10;
            // 
            // txttotam
            // 
            this.txttotam.Location = new System.Drawing.Point(257, 248);
            this.txttotam.Name = "txttotam";
            this.txttotam.Size = new System.Drawing.Size(257, 20);
            this.txttotam.TabIndex = 11;
            this.txttotam.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtdis
            // 
            this.txtdis.Location = new System.Drawing.Point(257, 307);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(257, 20);
            this.txtdis.TabIndex = 12;
            this.txtdis.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtamp
            // 
            this.txtamp.Location = new System.Drawing.Point(257, 365);
            this.txtamp.Name = "txtamp";
            this.txtamp.Size = new System.Drawing.Size(257, 20);
            this.txtamp.TabIndex = 13;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(469, 410);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 38);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Silver;
            this.btncal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(310, 410);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(139, 38);
            this.btncal.TabIndex = 15;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 433);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Adding Stock Details 2";
            // 
            // frmsrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(587, 460);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtamp);
            this.Controls.Add(this.txtdis);
            this.Controls.Add(this.txttotam);
            this.Controls.Add(this.txtnoi);
            this.Controls.Add(this.txtsi);
            this.Controls.Add(this.txtspl);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.lblamp);
            this.Controls.Add(this.lbldis);
            this.Controls.Add(this.lbltotam);
            this.Controls.Add(this.lblnoi);
            this.Controls.Add(this.lblspi);
            this.Controls.Add(this.lblscn);
            this.Controls.Add(this.lbldt);
            this.Name = "frmsrc";
            this.Text = "AddingSuppliedItems";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Label lblscn;
        private System.Windows.Forms.Label lblspi;
        private System.Windows.Forms.Label lblnoi;
        private System.Windows.Forms.Label lbltotam;
        private System.Windows.Forms.Label lbldis;
        private System.Windows.Forms.Label lblamp;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtspl;
        private System.Windows.Forms.TextBox txtsi;
        private System.Windows.Forms.TextBox txtnoi;
        private System.Windows.Forms.TextBox txttotam;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.TextBox txtamp;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}