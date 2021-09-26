namespace WindowsFormsApplication32
{
    partial class MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.tsddbit = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbstock = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactionWithSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactionWithCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbother = new System.Windows.Forms.ToolStripDropDownButton();
            this.calculaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsddbit
            // 
            this.tsddbit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchUpdateToolStripMenuItem});
            this.tsddbit.Image = ((System.Drawing.Image)(resources.GetObject("tsddbit.Image")));
            this.tsddbit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbit.Name = "tsddbit";
            this.tsddbit.Size = new System.Drawing.Size(49, 22);
            this.tsddbit.Text = "Items";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchUpdateToolStripMenuItem
            // 
            this.searchUpdateToolStripMenuItem.Name = "searchUpdateToolStripMenuItem";
            this.searchUpdateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.searchUpdateToolStripMenuItem.Text = "Search & Update";
            this.searchUpdateToolStripMenuItem.Click += new System.EventHandler(this.searchUpdateToolStripMenuItem_Click);
            // 
            // tsddbstock
            // 
            this.tsddbstock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbstock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.addToolStripMenuItem1});
            this.tsddbstock.Image = ((System.Drawing.Image)(resources.GetObject("tsddbstock.Image")));
            this.tsddbstock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbstock.Name = "tsddbstock";
            this.tsddbstock.Size = new System.Drawing.Size(49, 22);
            this.tsddbstock.Text = "Stock";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactionWithSupplierToolStripMenuItem,
            this.interactionWithCustomerToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // interactionWithSupplierToolStripMenuItem
            // 
            this.interactionWithSupplierToolStripMenuItem.Name = "interactionWithSupplierToolStripMenuItem";
            this.interactionWithSupplierToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.interactionWithSupplierToolStripMenuItem.Text = "Interaction with supplier";
            this.interactionWithSupplierToolStripMenuItem.Click += new System.EventHandler(this.interactionWithSupplierToolStripMenuItem_Click);
            // 
            // interactionWithCustomerToolStripMenuItem
            // 
            this.interactionWithCustomerToolStripMenuItem.Name = "interactionWithCustomerToolStripMenuItem";
            this.interactionWithCustomerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.interactionWithCustomerToolStripMenuItem.Text = "Interaction with customer";
            this.interactionWithCustomerToolStripMenuItem.Click += new System.EventHandler(this.interactionWithCustomerToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click_1);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click_1);
            // 
            // tsddbother
            // 
            this.tsddbother.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbother.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculaterToolStripMenuItem,
            this.billToolStripMenuItem});
            this.tsddbother.Image = ((System.Drawing.Image)(resources.GetObject("tsddbother.Image")));
            this.tsddbother.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbother.Name = "tsddbother";
            this.tsddbother.Size = new System.Drawing.Size(50, 22);
            this.tsddbother.Text = "Other";
            // 
            // calculaterToolStripMenuItem
            // 
            this.calculaterToolStripMenuItem.Name = "calculaterToolStripMenuItem";
            this.calculaterToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculaterToolStripMenuItem.Text = "Calculator";
            this.calculaterToolStripMenuItem.Click += new System.EventHandler(this.calculaterToolStripMenuItem_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.billToolStripMenuItem.Text = "Bill";
            this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbit,
            this.tsddbstock,
            this.toolStripDropDownButton1,
            this.tsddbother});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.searchToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(89, 22);
            this.toolStripDropDownButton1.Text = "Daily Income";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::WindowsFormsApplication32.Properties.Resources.sagara_Electronics;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 534);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton tsddbit;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsddbstock;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactionWithCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactionWithSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsddbother;
        private System.Windows.Forms.ToolStripMenuItem calculaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;

    }
}