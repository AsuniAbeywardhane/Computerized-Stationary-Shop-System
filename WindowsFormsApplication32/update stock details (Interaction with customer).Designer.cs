namespace WindowsFormsApplication32
{
    partial class frmusd1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusd1));
            this.lblic = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblstq = new System.Windows.Forms.Label();
            this.lblsoq = new System.Windows.Forms.Label();
            this.lblavq = new System.Windows.Forms.Label();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtstq = new System.Windows.Forms.TextBox();
            this.txtsoq = new System.Windows.Forms.TextBox();
            this.txtavq = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.Color.Transparent;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(63, 117);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "ItemCode";
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.BackColor = System.Drawing.Color.Transparent;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(65, 168);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblstq
            // 
            this.lblstq.AutoSize = true;
            this.lblstq.BackColor = System.Drawing.Color.Transparent;
            this.lblstq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstq.Location = new System.Drawing.Point(65, 227);
            this.lblstq.Name = "lblstq";
            this.lblstq.Size = new System.Drawing.Size(130, 18);
            this.lblstq.TabIndex = 2;
            this.lblstq.Text = "StoredQuantity";
            // 
            // lblsoq
            // 
            this.lblsoq.AutoSize = true;
            this.lblsoq.BackColor = System.Drawing.Color.Transparent;
            this.lblsoq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoq.Location = new System.Drawing.Point(65, 289);
            this.lblsoq.Name = "lblsoq";
            this.lblsoq.Size = new System.Drawing.Size(111, 18);
            this.lblsoq.TabIndex = 3;
            this.lblsoq.Text = "SoldQuantity";
            // 
            // lblavq
            // 
            this.lblavq.AutoSize = true;
            this.lblavq.BackColor = System.Drawing.Color.Transparent;
            this.lblavq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavq.Location = new System.Drawing.Point(65, 352);
            this.lblavq.Name = "lblavq";
            this.lblavq.Size = new System.Drawing.Size(149, 18);
            this.lblavq.TabIndex = 4;
            this.lblavq.Text = "AvailableQuantity";
            this.lblavq.Click += new System.EventHandler(this.lblavq_Click);
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(227, 165);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(102, 20);
            this.txtit.TabIndex = 6;
            // 
            // txtstq
            // 
            this.txtstq.Location = new System.Drawing.Point(227, 224);
            this.txtstq.Name = "txtstq";
            this.txtstq.Size = new System.Drawing.Size(102, 20);
            this.txtstq.TabIndex = 7;
            this.txtstq.TextChanged += new System.EventHandler(this.txtstq_TextChanged);
            // 
            // txtsoq
            // 
            this.txtsoq.Location = new System.Drawing.Point(227, 286);
            this.txtsoq.Name = "txtsoq";
            this.txtsoq.Size = new System.Drawing.Size(102, 20);
            this.txtsoq.TabIndex = 8;
            this.txtsoq.TextChanged += new System.EventHandler(this.txtsoq_TextChanged);
            // 
            // txtavq
            // 
            this.txtavq.Location = new System.Drawing.Point(227, 350);
            this.txtavq.Name = "txtavq";
            this.txtavq.Size = new System.Drawing.Size(102, 20);
            this.txtavq.TabIndex = 9;
            this.txtavq.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Silver;
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(196, 417);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 44);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(227, 109);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(101, 20);
            this.mskic.TabIndex = 0;
            this.mskic.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskic_MaskInputRejected);
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Silver;
            this.btncal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(367, 289);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(139, 42);
            this.btncal.TabIndex = 13;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(133, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "      Update Stock Details\r\n(Interaction with customer)";
            // 
            // frmusd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_3109711;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtavq);
            this.Controls.Add(this.txtsoq);
            this.Controls.Add(this.txtstq);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblavq);
            this.Controls.Add(this.lblsoq);
            this.Controls.Add(this.lblstq);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmusd1";
            this.Text = "UpdateStockDetails 1";
            this.Load += new System.EventHandler(this.frmsd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblstq;
        private System.Windows.Forms.Label lblsoq;
        private System.Windows.Forms.Label lblavq;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtstq;
        private System.Windows.Forms.TextBox txtsoq;
        private System.Windows.Forms.TextBox txtavq;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label1;
    }
}