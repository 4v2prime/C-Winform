namespace A1_ShopManagement
{
    partial class frmUnordCust
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
            this.grdUnOrdCust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnOrdCust)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUnOrdCust
            // 
            this.grdUnOrdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnOrdCust.Location = new System.Drawing.Point(12, 12);
            this.grdUnOrdCust.Name = "grdUnOrdCust";
            this.grdUnOrdCust.RowHeadersWidth = 51;
            this.grdUnOrdCust.RowTemplate.Height = 24;
            this.grdUnOrdCust.Size = new System.Drawing.Size(1069, 531);
            this.grdUnOrdCust.TabIndex = 1;
            // 
            // frmUnordCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 574);
            this.Controls.Add(this.grdUnOrdCust);
            this.Name = "frmUnordCust";
            this.Text = "Unorderd Customer";
            this.Load += new System.EventHandler(this.frmUnordCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnOrdCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUnOrdCust;
    }
}