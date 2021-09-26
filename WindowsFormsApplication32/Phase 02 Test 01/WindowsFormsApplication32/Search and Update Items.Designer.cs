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
            this.lblic = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblpr = new System.Windows.Forms.Label();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(47, 62);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "ItemCode";
            this.lblic.Click += new System.EventHandler(this.lblic_Click);
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(219, 62);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblpr
            // 
            this.lblpr.AutoSize = true;
            this.lblpr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpr.Location = new System.Drawing.Point(348, 62);
            this.lblpr.Name = "lblpr";
            this.lblpr.Size = new System.Drawing.Size(88, 18);
            this.lblpr.TabIndex = 2;
            this.lblpr.Text = "Price(Rs.)";
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(193, 117);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(105, 20);
            this.txtit.TabIndex = 4;
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(336, 117);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(100, 20);
            this.txtpr.TabIndex = 5;
            // 
            // mskic
            // 
            this.mskic.BeepOnError = true;
            this.mskic.Location = new System.Drawing.Point(32, 117);
            this.mskic.Mask = "A####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(100, 20);
            this.mskic.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.BurlyWood;
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(50, 306);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 35);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.BurlyWood;
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(208, 306);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 35);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // frmsrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(538, 403);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblpr);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Name = "frmsrit";
            this.Text = "Search Items";
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
    }
}