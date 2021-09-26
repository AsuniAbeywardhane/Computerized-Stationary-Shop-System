namespace WindowsFormsApplication32
{
    partial class frmadds
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
            this.lblscd = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lblchr = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtchr = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lstas = new System.Windows.Forms.ListBox();
            this.btndis = new System.Windows.Forms.Button();
            this.msksc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblscd
            // 
            this.lblscd.AutoSize = true;
            this.lblscd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscd.Location = new System.Drawing.Point(23, 39);
            this.lblscd.Name = "lblscd";
            this.lblscd.Size = new System.Drawing.Size(111, 18);
            this.lblscd.TabIndex = 0;
            this.lblscd.Text = "ServiceCode";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(234, 39);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(69, 18);
            this.lbls.TabIndex = 1;
            this.lbls.Text = "Service";
            // 
            // lblchr
            // 
            this.lblchr.AutoSize = true;
            this.lblchr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchr.Location = new System.Drawing.Point(399, 39);
            this.lblchr.Name = "lblchr";
            this.lblchr.Size = new System.Drawing.Size(114, 18);
            this.lblchr.TabIndex = 2;
            this.lblchr.Text = "Charges(Rs.)";
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(222, 73);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 20);
            this.txts.TabIndex = 4;
            this.txts.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // txtchr
            // 
            this.txtchr.Location = new System.Drawing.Point(402, 73);
            this.txtchr.Name = "txtchr";
            this.txtchr.Size = new System.Drawing.Size(100, 20);
            this.txtchr.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(69, 337);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(167, 60);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lstas
            // 
            this.lstas.FormattingEnabled = true;
            this.lstas.Location = new System.Drawing.Point(32, 127);
            this.lstas.Name = "lstas";
            this.lstas.Size = new System.Drawing.Size(469, 147);
            this.lstas.TabIndex = 7;
            // 
            // btndis
            // 
            this.btndis.BackColor = System.Drawing.Color.Silver;
            this.btndis.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.Location = new System.Drawing.Point(326, 335);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(186, 61);
            this.btndis.TabIndex = 8;
            this.btndis.Text = "Display";
            this.btndis.UseVisualStyleBackColor = false;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // msksc
            // 
            this.msksc.Location = new System.Drawing.Point(26, 73);
            this.msksc.Mask = "#####";
            this.msksc.Name = "msksc";
            this.msksc.Size = new System.Drawing.Size(108, 20);
            this.msksc.TabIndex = 9;
            // 
            // frmadds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(592, 444);
            this.Controls.Add(this.msksc);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.lstas);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtchr);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.lblchr);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lblscd);
            this.Name = "frmadds";
            this.Text = "AddingServices";
            this.Load += new System.EventHandler(this.Frmadds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscd;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblchr;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txtchr;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox lstas;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.MaskedTextBox msksc;
    }
}