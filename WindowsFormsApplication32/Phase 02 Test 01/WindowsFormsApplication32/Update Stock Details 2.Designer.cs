namespace WindowsFormsApplication32
{
    partial class frmusd2
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
            this.lblic = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblsq = new System.Windows.Forms.Label();
            this.txtic = new System.Windows.Forms.TextBox();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtaq = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndis = new System.Windows.Forms.Button();
            this.lblcq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcq = new System.Windows.Forms.TextBox();
            this.txttq = new System.Windows.Forms.TextBox();
            this.lbltot = new System.Windows.Forms.Label();
            this.btnlcq = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(41, 41);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "ItemCode";
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(209, 41);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblsq
            // 
            this.lblsq.AutoSize = true;
            this.lblsq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsq.Location = new System.Drawing.Point(304, 41);
            this.lblsq.Name = "lblsq";
            this.lblsq.Size = new System.Drawing.Size(132, 18);
            this.lblsq.TabIndex = 2;
            this.lblsq.Text = "AddingQuantity";
            // 
            // txtic
            // 
            this.txtic.Location = new System.Drawing.Point(26, 81);
            this.txtic.Name = "txtic";
            this.txtic.Size = new System.Drawing.Size(100, 20);
            this.txtic.TabIndex = 3;
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(174, 81);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(100, 20);
            this.txtit.TabIndex = 4;
            // 
            // txtaq
            // 
            this.txtaq.Location = new System.Drawing.Point(324, 81);
            this.txtaq.Name = "txtaq";
            this.txtaq.Size = new System.Drawing.Size(100, 20);
            this.txtaq.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.BurlyWood;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(466, 403);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 35);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btndis
            // 
            this.btndis.BackColor = System.Drawing.Color.BurlyWood;
            this.btndis.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.Location = new System.Drawing.Point(610, 402);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(121, 35);
            this.btndis.TabIndex = 8;
            this.btndis.Text = "DisplayStock";
            this.btndis.UseVisualStyleBackColor = false;
            // 
            // lblcq
            // 
            this.lblcq.AutoSize = true;
            this.lblcq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcq.Location = new System.Drawing.Point(463, 41);
            this.lblcq.Name = "lblcq";
            this.lblcq.Size = new System.Drawing.Size(138, 18);
            this.lblcq.TabIndex = 9;
            this.lblcq.Text = "CurrentQuantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 10;
            // 
            // txtcq
            // 
            this.txtcq.Location = new System.Drawing.Point(473, 81);
            this.txtcq.Name = "txtcq";
            this.txtcq.Size = new System.Drawing.Size(107, 20);
            this.txtcq.TabIndex = 11;
            // 
            // txttq
            // 
            this.txttq.Location = new System.Drawing.Point(624, 81);
            this.txttq.Name = "txttq";
            this.txttq.Size = new System.Drawing.Size(107, 20);
            this.txttq.TabIndex = 12;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.Location = new System.Drawing.Point(621, 41);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(116, 18);
            this.lbltot.TabIndex = 13;
            this.lbltot.Text = "TotalQuantity";
            // 
            // btnlcq
            // 
            this.btnlcq.BackColor = System.Drawing.Color.BurlyWood;
            this.btnlcq.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlcq.Location = new System.Drawing.Point(234, 404);
            this.btnlcq.Name = "btnlcq";
            this.btnlcq.Size = new System.Drawing.Size(202, 33);
            this.btnlcq.TabIndex = 14;
            this.btnlcq.Text = "LoadCurrentQuantity";
            this.btnlcq.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 244);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmusd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(765, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlcq);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.txttq);
            this.Controls.Add(this.txtcq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcq);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaq);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.txtic);
            this.Controls.Add(this.lblsq);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Name = "frmusd2";
            this.Text = "Update_Stock_Details_2";
            this.Load += new System.EventHandler(this.Adding_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblsq;
        private System.Windows.Forms.TextBox txtic;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtaq;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Label lblcq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcq;
        private System.Windows.Forms.TextBox txttq;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Button btnlcq;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}