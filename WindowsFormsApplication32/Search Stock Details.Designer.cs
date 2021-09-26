namespace WindowsFormsApplication32
{
    partial class frmssd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmssd));
            this.lblisc = new System.Windows.Forms.Label();
            this.lblis = new System.Windows.Forms.Label();
            this.lblcq = new System.Windows.Forms.Label();
            this.txtit = new System.Windows.Forms.TextBox();
            this.txtcq = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblisc
            // 
            this.lblisc.AutoSize = true;
            this.lblisc.BackColor = System.Drawing.Color.Transparent;
            this.lblisc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisc.Location = new System.Drawing.Point(61, 97);
            this.lblisc.Name = "lblisc";
            this.lblisc.Size = new System.Drawing.Size(89, 18);
            this.lblisc.TabIndex = 0;
            this.lblisc.Text = "Item Code";
            // 
            // lblis
            // 
            this.lblis.AutoSize = true;
            this.lblis.BackColor = System.Drawing.Color.Transparent;
            this.lblis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblis.Location = new System.Drawing.Point(61, 168);
            this.lblis.Name = "lblis";
            this.lblis.Size = new System.Drawing.Size(43, 18);
            this.lblis.TabIndex = 1;
            this.lblis.Text = "Item";
            // 
            // lblcq
            // 
            this.lblcq.AutoSize = true;
            this.lblcq.BackColor = System.Drawing.Color.Transparent;
            this.lblcq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcq.Location = new System.Drawing.Point(61, 242);
            this.lblcq.Name = "lblcq";
            this.lblcq.Size = new System.Drawing.Size(102, 18);
            this.lblcq.TabIndex = 3;
            this.lblcq.Text = "Current Qty";
            this.lblcq.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(194, 166);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(160, 20);
            this.txtit.TabIndex = 5;
            // 
            // txtcq
            // 
            this.txtcq.Location = new System.Drawing.Point(193, 243);
            this.txtcq.Name = "txtcq";
            this.txtcq.Size = new System.Drawing.Size(160, 20);
            this.txtcq.TabIndex = 6;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsearch.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(64, 328);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 40);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnclr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(251, 328);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(112, 40);
            this.btnclr.TabIndex = 8;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(193, 95);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(161, 20);
            this.mskic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Stock Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmssd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_3109711;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtcq);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblcq);
            this.Controls.Add(this.lblis);
            this.Controls.Add(this.lblisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmssd";
            this.Text = "Search Stock Details";
            this.Load += new System.EventHandler(this.frmssd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblisc;
        private System.Windows.Forms.Label lblis;
        private System.Windows.Forms.Label lblcq;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtcq;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.Label label1;
    }
}