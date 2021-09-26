namespace WindowsFormsApplication32
{
    partial class frmdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdit));
            this.lblic = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.btnsrc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.txtit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.Color.Transparent;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(116, 84);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(89, 18);
            this.lblic.TabIndex = 0;
            this.lblic.Text = "Item Code";
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.BackColor = System.Drawing.Color.Transparent;
            this.Item.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.Location = new System.Drawing.Point(116, 136);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(43, 18);
            this.Item.TabIndex = 1;
            this.Item.Text = "Item";
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.Control;
            this.btndel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(284, 273);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(129, 36);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(232, 82);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(152, 20);
            this.mskic.TabIndex = 0;
            this.mskic.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskic_MaskInputRejected);
            this.mskic.TextChanged += new System.EventHandler(this.mskic_TextChanged);
            // 
            // btnsrc
            // 
            this.btnsrc.BackColor = System.Drawing.SystemColors.Control;
            this.btnsrc.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc.Location = new System.Drawing.Point(72, 273);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(129, 36);
            this.btnsrc.TabIndex = 7;
            this.btnsrc.Text = "Load";
            this.btnsrc.UseVisualStyleBackColor = false;
            this.btnsrc.Click += new System.EventHandler(this.btnsrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price(Rs.)";
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(232, 186);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(152, 20);
            this.txtpr.TabIndex = 9;
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(232, 137);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(152, 20);
            this.txtit.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Delete Items";
            // 
            // frmdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsrc);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.lblic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdit";
            this.Text = "Delete Items";
            this.Load += new System.EventHandler(this.frmdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.Button btnsrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.Label label2;
    }
}