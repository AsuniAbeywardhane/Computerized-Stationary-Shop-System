namespace WindowsFormsApplication32
{
    partial class frmast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmast));
            this.lblic = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblcq = new System.Windows.Forms.Label();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lstast = new System.Windows.Forms.ListBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.Color.Transparent;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(83, 54);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(89, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "Item Code";
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.BackColor = System.Drawing.Color.Transparent;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(347, 54);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblcq
            // 
            this.lblcq.AutoSize = true;
            this.lblcq.BackColor = System.Drawing.Color.Transparent;
            this.lblcq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcq.Location = new System.Drawing.Point(588, 54);
            this.lblcq.Name = "lblcq";
            this.lblcq.Size = new System.Drawing.Size(80, 18);
            this.lblcq.TabIndex = 2;
            this.lblcq.Text = " Quantity";
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(50, 92);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(164, 20);
            this.mskic.TabIndex = 0;
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(298, 92);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(164, 20);
            this.txtit.TabIndex = 4;
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(541, 92);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(161, 20);
            this.txtq.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(226, 403);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 40);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lstast
            // 
            this.lstast.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstast.FormattingEnabled = true;
            this.lstast.ItemHeight = 19;
            this.lstast.Location = new System.Drawing.Point(50, 159);
            this.lstast.Name = "lstast";
            this.lstast.Size = new System.Drawing.Size(651, 194);
            this.lstast.TabIndex = 7;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.Silver;
            this.btnclr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(428, 403);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(129, 40);
            this.btnclr.TabIndex = 8;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Stock";
            // 
            // frmast
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lstast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.lblcq);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmast";
            this.Text = "Add_Stock";
            this.Load += new System.EventHandler(this.frmast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblcq;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox lstast;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label label1;
    }
}