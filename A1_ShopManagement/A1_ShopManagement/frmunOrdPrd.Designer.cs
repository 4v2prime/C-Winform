namespace A1_ShopManagement
{
    partial class frmunOrdPrd
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
            this.grdunOrdPrd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdunOrdPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // grdunOrdPrd
            // 
            this.grdunOrdPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdunOrdPrd.Location = new System.Drawing.Point(12, 12);
            this.grdunOrdPrd.Name = "grdunOrdPrd";
            this.grdunOrdPrd.RowHeadersWidth = 51;
            this.grdunOrdPrd.RowTemplate.Height = 24;
            this.grdunOrdPrd.Size = new System.Drawing.Size(957, 493);
            this.grdunOrdPrd.TabIndex = 0;
            // 
            // frmunOrdPrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 513);
            this.Controls.Add(this.grdunOrdPrd);
            this.Name = "frmunOrdPrd";
            this.Text = "Unorderd Products";
            this.Load += new System.EventHandler(this.frmunOrdPrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdunOrdPrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdunOrdPrd;
    }
}