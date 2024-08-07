namespace A1_ShopManagement
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderdProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderedProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderdCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.orderdProductsToolStripMenuItem,
            this.unorderedProductsToolStripMenuItem,
            this.unorderdCustomerToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1759, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // orderdProductsToolStripMenuItem
            // 
            this.orderdProductsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.orderdProductsToolStripMenuItem.Name = "orderdProductsToolStripMenuItem";
            this.orderdProductsToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.orderdProductsToolStripMenuItem.Text = "Orderd Products";
            this.orderdProductsToolStripMenuItem.Click += new System.EventHandler(this.orderdProductsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // unorderedProductsToolStripMenuItem
            // 
            this.unorderedProductsToolStripMenuItem.Name = "unorderedProductsToolStripMenuItem";
            this.unorderedProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.unorderedProductsToolStripMenuItem.Text = "Unordered Products";
            this.unorderedProductsToolStripMenuItem.Click += new System.EventHandler(this.unorderedProductsToolStripMenuItem_Click);
            // 
            // unorderdCustomerToolStripMenuItem
            // 
            this.unorderdCustomerToolStripMenuItem.Name = "unorderdCustomerToolStripMenuItem";
            this.unorderdCustomerToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.unorderdCustomerToolStripMenuItem.Text = "Unorderd Customer";
            this.unorderdCustomerToolStripMenuItem.Click += new System.EventHandler(this.unorderdCustomerToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 824);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderdProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderedProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderdCustomerToolStripMenuItem;
    }
}