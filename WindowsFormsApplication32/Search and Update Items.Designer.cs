namespace WindowsFormsApplication32
{
    partial class frmsrit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsrit));
            this.lblic = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblpr = new System.Windows.Forms.Label();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lstsi = new System.Windows.Forms.ListBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.Color.Transparent;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(54, 93);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "ItemCode";
            this.lblic.Click += new System.EventHandler(this.lblic_Click);
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.BackColor = System.Drawing.Color.Transparent;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(242, 93);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblpr
            // 
            this.lblpr.AutoSize = true;
            this.lblpr.BackColor = System.Drawing.Color.Transparent;
            this.lblpr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpr.Location = new System.Drawing.Point(388, 93);
            this.lblpr.Name = "lblpr";
            this.lblpr.Size = new System.Drawing.Size(88, 18);
            this.lblpr.TabIndex = 2;
            this.lblpr.Text = "Price(Rs.)";
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(205, 126);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(105, 20);
            this.txtit.TabIndex = 4;
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(376, 126);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(100, 20);
            this.txtpr.TabIndex = 5;
            // 
            // mskic
            // 
            this.mskic.BeepOnError = true;
            this.mskic.Location = new System.Drawing.Point(39, 126);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(100, 20);
            this.mskic.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(32, 367);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 35);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(205, 367);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 35);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lstsi
            // 
            this.lstsi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsi.FormattingEnabled = true;
            this.lstsi.ItemHeight = 19;
            this.lstsi.Location = new System.Drawing.Point(32, 187);
            this.lstsi.Name = "lstsi";
            this.lstsi.Size = new System.Drawing.Size(482, 156);
            this.lstsi.TabIndex = 10;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnclr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(580, 254);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(150, 89);
            this.btnclr.TabIndex = 11;
            this.btnclr.Text = "Clear searched details";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btncl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.Location = new System.Drawing.Point(580, 367);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(150, 89);
            this.btncl.TabIndex = 12;
            this.btncl.Text = "Clear List";
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search and Update Items";
            // 
            // frmsrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lstsi);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblpr);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsrit";
            this.Text = "Search and Update Items";
            this.Load += new System.EventHandler(this.frmsrit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblpr;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ListBox lstsi;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Label label1;
    }
}