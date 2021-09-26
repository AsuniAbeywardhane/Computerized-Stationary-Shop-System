namespace WindowsFormsApplication32
{
    partial class frmsdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsdi));
            this.lbldt = new System.Windows.Forms.Label();
            this.lbltv = new System.Windows.Forms.Label();
            this.lblvsi = new System.Windows.Forms.Label();
            this.lblpf = new System.Windows.Forms.Label();
            this.txtinc = new System.Windows.Forms.TextBox();
            this.txtex = new System.Windows.Forms.TextBox();
            this.txtprofit = new System.Windows.Forms.TextBox();
            this.btnsrc = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lstsdi = new System.Windows.Forms.ListBox();
            this.btndis = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.BackColor = System.Drawing.Color.Transparent;
            this.lbldt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.Location = new System.Drawing.Point(62, 85);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(46, 18);
            this.lbldt.TabIndex = 0;
            this.lbldt.Text = "Date";
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.BackColor = System.Drawing.Color.Transparent;
            this.lbltv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltv.Location = new System.Drawing.Point(52, 140);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(205, 36);
            this.lbltv.TabIndex = 2;
            this.lbltv.Text = "Total value of issued bills\r\n(Income)";
            // 
            // lblvsi
            // 
            this.lblvsi.AutoSize = true;
            this.lblvsi.BackColor = System.Drawing.Color.Transparent;
            this.lblvsi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvsi.Location = new System.Drawing.Point(52, 208);
            this.lblvsi.Name = "lblvsi";
            this.lblvsi.Size = new System.Drawing.Size(234, 36);
            this.lblvsi.TabIndex = 3;
            this.lblvsi.Text = "Paid value for supplied items\r\n(Expenditure)";
            // 
            // lblpf
            // 
            this.lblpf.AutoSize = true;
            this.lblpf.BackColor = System.Drawing.Color.Transparent;
            this.lblpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpf.Location = new System.Drawing.Point(62, 280);
            this.lblpf.Name = "lblpf";
            this.lblpf.Size = new System.Drawing.Size(51, 18);
            this.lblpf.TabIndex = 4;
            this.lblpf.Text = "Profit";
            // 
            // txtinc
            // 
            this.txtinc.Location = new System.Drawing.Point(305, 152);
            this.txtinc.Name = "txtinc";
            this.txtinc.Size = new System.Drawing.Size(202, 20);
            this.txtinc.TabIndex = 7;
            // 
            // txtex
            // 
            this.txtex.Location = new System.Drawing.Point(306, 224);
            this.txtex.Name = "txtex";
            this.txtex.Size = new System.Drawing.Size(202, 20);
            this.txtex.TabIndex = 8;
            // 
            // txtprofit
            // 
            this.txtprofit.Location = new System.Drawing.Point(306, 278);
            this.txtprofit.Name = "txtprofit";
            this.txtprofit.Size = new System.Drawing.Size(202, 20);
            this.txtprofit.TabIndex = 9;
            // 
            // btnsrc
            // 
            this.btnsrc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsrc.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc.Location = new System.Drawing.Point(600, 111);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(106, 38);
            this.btnsrc.TabIndex = 10;
            this.btnsrc.Text = "Search";
            this.btnsrc.UseVisualStyleBackColor = false;
            this.btnsrc.Click += new System.EventHandler(this.btnsrc_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(305, 98);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(201, 20);
            this.dtp.TabIndex = 12;
            // 
            // lstsdi
            // 
            this.lstsdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsdi.FormattingEnabled = true;
            this.lstsdi.ItemHeight = 19;
            this.lstsdi.Location = new System.Drawing.Point(55, 317);
            this.lstsdi.Name = "lstsdi";
            this.lstsdi.Size = new System.Drawing.Size(651, 194);
            this.lstsdi.TabIndex = 13;
            // 
            // btndis
            // 
            this.btndis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btndis.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.Location = new System.Drawing.Point(600, 178);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(106, 38);
            this.btndis.TabIndex = 14;
            this.btndis.Text = "Display";
            this.btndis.UseVisualStyleBackColor = false;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnclr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(600, 248);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(106, 38);
            this.btnclr.TabIndex = 15;
            this.btnclr.Text = "Clear List";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(252, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Daily Income";
            // 
            // frmsdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.lstsdi);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnsrc);
            this.Controls.Add(this.txtprofit);
            this.Controls.Add(this.txtex);
            this.Controls.Add(this.txtinc);
            this.Controls.Add(this.lblpf);
            this.Controls.Add(this.lblvsi);
            this.Controls.Add(this.lbltv);
            this.Controls.Add(this.lbldt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsdi";
            this.Text = "Search_Daily_Income";
            this.Load += new System.EventHandler(this.Search_Daily_Income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Label lbltv;
        private System.Windows.Forms.Label lblvsi;
        private System.Windows.Forms.Label lblpf;
        private System.Windows.Forms.TextBox txtinc;
        private System.Windows.Forms.TextBox txtex;
        private System.Windows.Forms.TextBox txtprofit;
        private System.Windows.Forms.Button btnsrc;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ListBox lstsdi;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label label1;
    }
}