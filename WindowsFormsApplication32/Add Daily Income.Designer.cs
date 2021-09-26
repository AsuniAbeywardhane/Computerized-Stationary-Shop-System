namespace WindowsFormsApplication32
{
    partial class frmadi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadi));
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtprofit = new System.Windows.Forms.TextBox();
            this.txtex = new System.Windows.Forms.TextBox();
            this.txtinc = new System.Windows.Forms.TextBox();
            this.lblpf = new System.Windows.Forms.Label();
            this.lblvsi = new System.Windows.Forms.Label();
            this.lbltv = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(292, 67);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(201, 20);
            this.dtp.TabIndex = 22;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(322, 374);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 38);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtprofit
            // 
            this.txtprofit.Location = new System.Drawing.Point(293, 298);
            this.txtprofit.Name = "txtprofit";
            this.txtprofit.Size = new System.Drawing.Size(202, 20);
            this.txtprofit.TabIndex = 19;
            // 
            // txtex
            // 
            this.txtex.Location = new System.Drawing.Point(293, 224);
            this.txtex.Name = "txtex";
            this.txtex.Size = new System.Drawing.Size(202, 20);
            this.txtex.TabIndex = 18;
            // 
            // txtinc
            // 
            this.txtinc.Location = new System.Drawing.Point(292, 139);
            this.txtinc.Name = "txtinc";
            this.txtinc.Size = new System.Drawing.Size(202, 20);
            this.txtinc.TabIndex = 17;
            // 
            // lblpf
            // 
            this.lblpf.AutoSize = true;
            this.lblpf.BackColor = System.Drawing.Color.Transparent;
            this.lblpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpf.Location = new System.Drawing.Point(39, 300);
            this.lblpf.Name = "lblpf";
            this.lblpf.Size = new System.Drawing.Size(51, 18);
            this.lblpf.TabIndex = 16;
            this.lblpf.Text = "Profit";
            // 
            // lblvsi
            // 
            this.lblvsi.AutoSize = true;
            this.lblvsi.BackColor = System.Drawing.Color.Transparent;
            this.lblvsi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvsi.Location = new System.Drawing.Point(39, 208);
            this.lblvsi.Name = "lblvsi";
            this.lblvsi.Size = new System.Drawing.Size(234, 36);
            this.lblvsi.TabIndex = 15;
            this.lblvsi.Text = "Paid value for supplied items\r\n(Expenditure)";
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.BackColor = System.Drawing.Color.Transparent;
            this.lbltv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltv.Location = new System.Drawing.Point(39, 123);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(205, 36);
            this.lbltv.TabIndex = 14;
            this.lbltv.Text = "Total value of issued bills\r\n(Income)";
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.BackColor = System.Drawing.Color.Transparent;
            this.lbldt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.Location = new System.Drawing.Point(39, 58);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(46, 18);
            this.lbldt.TabIndex = 13;
            this.lbldt.Text = "Date";
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Silver;
            this.btncal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(110, 363);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(106, 61);
            this.btncal.TabIndex = 23;
            this.btncal.Text = "Calculate Profit";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add Daily Income";
            // 
            // frmadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtprofit);
            this.Controls.Add(this.txtex);
            this.Controls.Add(this.txtinc);
            this.Controls.Add(this.lblpf);
            this.Controls.Add(this.lblvsi);
            this.Controls.Add(this.lbltv);
            this.Controls.Add(this.lbldt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadi";
            this.Text = "Add_Daily_Income";
            this.Load += new System.EventHandler(this.Add_Daily_Income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtprofit;
        private System.Windows.Forms.TextBox txtex;
        private System.Windows.Forms.TextBox txtinc;
        private System.Windows.Forms.Label lblpf;
        private System.Windows.Forms.Label lblvsi;
        private System.Windows.Forms.Label lbltv;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label1;

    }
}