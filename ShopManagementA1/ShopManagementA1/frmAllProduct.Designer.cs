namespace ShopManagementA1
{
    partial class frmAllProduct
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
            this.grdAppProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAppProduct
            // 
            this.grdAppProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppProduct.Location = new System.Drawing.Point(24, 26);
            this.grdAppProduct.Name = "grdAppProduct";
            this.grdAppProduct.RowHeadersWidth = 51;
            this.grdAppProduct.RowTemplate.Height = 24;
            this.grdAppProduct.Size = new System.Drawing.Size(959, 495);
            this.grdAppProduct.TabIndex = 0;
            // 
            // frmAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 646);
            this.Controls.Add(this.grdAppProduct);
            this.Name = "frmAllProduct";
            this.Text = "frmAllProduct";
            this.Load += new System.EventHandler(this.frmAllProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAppProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAppProduct;
    }
}