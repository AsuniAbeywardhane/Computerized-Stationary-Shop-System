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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusd2));
            this.btncal = new System.Windows.Forms.Button();
            this.mskic = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtavq = new System.Windows.Forms.TextBox();
            this.txtaq = new System.Windows.Forms.TextBox();
            this.txtstq = new System.Windows.Forms.TextBox();
            this.txtit = new System.Windows.Forms.TextBox();
            this.lblavq = new System.Windows.Forms.Label();
            this.lblaq = new System.Windows.Forms.Label();
            this.lblstq = new System.Windows.Forms.Label();
            this.lblit = new System.Windows.Forms.Label();
            this.lblic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Silver;
            this.btncal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(357, 318);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(139, 42);
            this.btncal.TabIndex = 26;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // mskic
            // 
            this.mskic.Location = new System.Drawing.Point(217, 99);
            this.mskic.Mask = "AAA####";
            this.mskic.Name = "mskic";
            this.mskic.Size = new System.Drawing.Size(101, 20);
            this.mskic.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Silver;
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(230, 412);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 44);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtavq
            // 
            this.txtavq.Location = new System.Drawing.Point(217, 340);
            this.txtavq.Name = "txtavq";
            this.txtavq.Size = new System.Drawing.Size(102, 20);
            this.txtavq.TabIndex = 23;
            // 
            // txtaq
            // 
            this.txtaq.Location = new System.Drawing.Point(217, 276);
            this.txtaq.Name = "txtaq";
            this.txtaq.Size = new System.Drawing.Size(102, 20);
            this.txtaq.TabIndex = 22;
            this.txtaq.TextChanged += new System.EventHandler(this.txtaq_TextChanged);
            // 
            // txtstq
            // 
            this.txtstq.Location = new System.Drawing.Point(217, 214);
            this.txtstq.Name = "txtstq";
            this.txtstq.Size = new System.Drawing.Size(102, 20);
            this.txtstq.TabIndex = 21;
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(217, 155);
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(102, 20);
            this.txtit.TabIndex = 20;
            // 
            // lblavq
            // 
            this.lblavq.AutoSize = true;
            this.lblavq.BackColor = System.Drawing.Color.Transparent;
            this.lblavq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavq.Location = new System.Drawing.Point(55, 343);
            this.lblavq.Name = "lblavq";
            this.lblavq.Size = new System.Drawing.Size(149, 18);
            this.lblavq.TabIndex = 19;
            this.lblavq.Text = "AvailableQuantity";
            // 
            // lblaq
            // 
            this.lblaq.AutoSize = true;
            this.lblaq.BackColor = System.Drawing.Color.Transparent;
            this.lblaq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaq.Location = new System.Drawing.Point(55, 279);
            this.lblaq.Name = "lblaq";
            this.lblaq.Size = new System.Drawing.Size(132, 18);
            this.lblaq.TabIndex = 18;
            this.lblaq.Text = "AddingQuantity";
            // 
            // lblstq
            // 
            this.lblstq.AutoSize = true;
            this.lblstq.BackColor = System.Drawing.Color.Transparent;
            this.lblstq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstq.Location = new System.Drawing.Point(55, 217);
            this.lblstq.Name = "lblstq";
            this.lblstq.Size = new System.Drawing.Size(130, 18);
            this.lblstq.TabIndex = 17;
            this.lblstq.Text = "StoredQuantity";
            // 
            // lblit
            // 
            this.lblit.AutoSize = true;
            this.lblit.BackColor = System.Drawing.Color.Transparent;
            this.lblit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblit.Location = new System.Drawing.Point(55, 158);
            this.lblit.Name = "lblit";
            this.lblit.Size = new System.Drawing.Size(43, 18);
            this.lblit.TabIndex = 16;
            this.lblit.Text = "Item";
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.Color.Transparent;
            this.lblic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblic.Location = new System.Drawing.Point(53, 107);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(85, 18);
            this.lblic.TabIndex = 15;
            this.lblic.Text = "ItemCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "   Update Stock Details\r\n(Interaction with supplier)";
            // 
            // frmusd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.blue_abstract_background_310971;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.mskic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtavq);
            this.Controls.Add(this.txtaq);
            this.Controls.Add(this.txtstq);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.lblavq);
            this.Controls.Add(this.lblaq);
            this.Controls.Add(this.lblstq);
            this.Controls.Add(this.lblit);
            this.Controls.Add(this.lblic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmusd2";
            this.Text = "Update_Stock_Details_Interaction_with_supplier_";
            this.Load += new System.EventHandler(this.Update_Stock_Details_Interaction_with_supplier__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.MaskedTextBox mskic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtavq;
        private System.Windows.Forms.TextBox txtaq;
        private System.Windows.Forms.TextBox txtstq;
        private System.Windows.Forms.TextBox txtit;
        private System.Windows.Forms.Label lblavq;
        private System.Windows.Forms.Label lblaq;
        private System.Windows.Forms.Label lblstq;
        private System.Windows.Forms.Label lblit;
        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label label1;
    }
}