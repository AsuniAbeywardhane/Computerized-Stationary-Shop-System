namespace WindowsFormsApplication32
{
    partial class frm1
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
            this.btnadd = new System.Windows.Forms.Button();
            this.lstai = new System.Windows.Forms.ListBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(45, 42);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "ItemCode";
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(257, 42);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 1;
            this.lblit.Text = "Item";
            // 
            // lblpr
            // 
            this.lblpr.AutoSize = true;
            this.lblpr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpr.Location = new System.Drawing.Point(434, 42);
            this.lblpr.Name = "lblpr";
            this.lblpr.Size = new System.Drawing.Size(92, 18);
            this.lblpr.TabIndex = 2;
            this.lblpr.Text = "Price (Rs.)";
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(212, 75);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(118, 20);
            this.txtit.TabIndex = 4;
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(408, 75);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(118, 20);
            this.txtpr.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(104, 361);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(167, 50);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lstai
            // 
            this.lstai.FormattingEnabled = true;
            this.lstai.Location = new System.Drawing.Point(30, 121);
            this.lstai.Name = "lstai";
            this.lstai.Size = new System.Drawing.Size(495, 186);
            this.lstai.TabIndex = 7;
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Silver;
            this.button_1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(356, 361);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(169, 49);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "Display";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(30, 75);
            this.mskic.Mask = "#####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(117, 20);
            this.mskic.TabIndex = 9;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(623, 458);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.lstai);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblpr);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Name = "frm1";
            this.Text = "AddingItems";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblpr;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox lstai;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.MaskedTextBox mskic;
    }
}

