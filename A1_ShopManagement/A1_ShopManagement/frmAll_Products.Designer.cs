namespace A1_ShopManagement
{
    partial class frmAll_Products
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
            this.grdAllproduct = new System.Windows.Forms.DataGridView();
            this.txtsbyp = new System.Windows.Forms.TextBox();
            this.lblsearchproduct = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAllproduct
            // 
            this.grdAllproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllproduct.Location = new System.Drawing.Point(71, 174);
            this.grdAllproduct.Name = "grdAllproduct";
            this.grdAllproduct.RowHeadersWidth = 51;
            this.grdAllproduct.RowTemplate.Height = 24;
            this.grdAllproduct.Size = new System.Drawing.Size(906, 433);
            this.grdAllproduct.TabIndex = 0;
            // 
            // txtsbyp
            // 
            this.txtsbyp.Location = new System.Drawing.Point(530, 55);
            this.txtsbyp.Name = "txtsbyp";
            this.txtsbyp.Size = new System.Drawing.Size(165, 22);
            this.txtsbyp.TabIndex = 8;
            this.txtsbyp.TextChanged += new System.EventHandler(this.txtsbyp_TextChanged);
            // 
            // lblsearchproduct
            // 
            this.lblsearchproduct.AutoSize = true;
            this.lblsearchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchproduct.Location = new System.Drawing.Point(315, 53);
            this.lblsearchproduct.Name = "lblsearchproduct";
            this.lblsearchproduct.Size = new System.Drawing.Size(194, 24);
            this.lblsearchproduct.TabIndex = 7;
            this.lblsearchproduct.Text = "Search by Product :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(435, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 39);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAll_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 657);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtsbyp);
            this.Controls.Add(this.lblsearchproduct);
            this.Controls.Add(this.grdAllproduct);
            this.Name = "frmAll_Products";
            this.Text = "All Products";
            this.Load += new System.EventHandler(this.frmAll_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAllproduct;
        private System.Windows.Forms.TextBox txtsbyp;
        private System.Windows.Forms.Label lblsearchproduct;
        private System.Windows.Forms.Button btnRefresh;
    }
}