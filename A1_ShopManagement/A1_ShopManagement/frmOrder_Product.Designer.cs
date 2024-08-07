namespace A1_ShopManagement
{
    partial class frmOrder_Product
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
            this.grdOrderProduct = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Offer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtsbyn = new System.Windows.Forms.TextBox();
            this.txtsbyp = new System.Windows.Forms.TextBox();
            this.lblsearchproduct = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderProduct
            // 
            this.grdOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Offer});
            this.grdOrderProduct.Location = new System.Drawing.Point(38, 251);
            this.grdOrderProduct.Name = "grdOrderProduct";
            this.grdOrderProduct.RowHeadersWidth = 51;
            this.grdOrderProduct.RowTemplate.Height = 24;
            this.grdOrderProduct.Size = new System.Drawing.Size(1357, 543);
            this.grdOrderProduct.TabIndex = 0;
            this.grdOrderProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderProduct_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 60;
            // 
            // Offer
            // 
            this.Offer.HeaderText = "Offer";
            this.Offer.MinimumWidth = 6;
            this.Offer.Name = "Offer";
            this.Offer.Text = "Offer";
            this.Offer.UseColumnTextForButtonValue = true;
            this.Offer.Width = 50;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(517, 25);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(251, 24);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Order Product Information";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(444, 91);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(177, 24);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "Search by Name :";
            // 
            // txtsbyn
            // 
            this.txtsbyn.Location = new System.Drawing.Point(659, 93);
            this.txtsbyn.Name = "txtsbyn";
            this.txtsbyn.Size = new System.Drawing.Size(165, 22);
            this.txtsbyn.TabIndex = 3;
            this.txtsbyn.TextChanged += new System.EventHandler(this.txtsbyn_TextChanged);
            // 
            // txtsbyp
            // 
            this.txtsbyp.Location = new System.Drawing.Point(659, 141);
            this.txtsbyp.Name = "txtsbyp";
            this.txtsbyp.Size = new System.Drawing.Size(165, 22);
            this.txtsbyp.TabIndex = 6;
            this.txtsbyp.TextChanged += new System.EventHandler(this.txtsbyp_TextChanged);
            // 
            // lblsearchproduct
            // 
            this.lblsearchproduct.AutoSize = true;
            this.lblsearchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchproduct.Location = new System.Drawing.Point(444, 139);
            this.lblsearchproduct.Name = "lblsearchproduct";
            this.lblsearchproduct.Size = new System.Drawing.Size(194, 24);
            this.lblsearchproduct.TabIndex = 5;
            this.lblsearchproduct.Text = "Search by Product :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(508, 192);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 39);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(711, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOrder_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 826);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtsbyp);
            this.Controls.Add(this.lblsearchproduct);
            this.Controls.Add(this.txtsbyn);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.grdOrderProduct);
            this.Name = "frmOrder_Product";
            this.Text = "Order Product details";
            this.Load += new System.EventHandler(this.frmOrder_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderProduct;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtsbyn;
        private System.Windows.Forms.TextBox txtsbyp;
        private System.Windows.Forms.Label lblsearchproduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Offer;
        private System.Windows.Forms.Button btnDelete;
    }
}