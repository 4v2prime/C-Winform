namespace ShopManagementA1
{
    partial class frmOrderedPrd
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdorderproducts = new System.Windows.Forms.DataGridView();
            this.txtsbyn = new System.Windows.Forms.TextBox();
            this.txtsbyp = new System.Windows.Forms.TextBox();
            this.lblsbyn = new System.Windows.Forms.Label();
            this.lblsbtp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdorderproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(334, 48);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(251, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Order Product Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(410, 716);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grdorderproducts
            // 
            this.grdorderproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdorderproducts.Location = new System.Drawing.Point(45, 139);
            this.grdorderproducts.Name = "grdorderproducts";
            this.grdorderproducts.RowHeadersWidth = 51;
            this.grdorderproducts.RowTemplate.Height = 24;
            this.grdorderproducts.Size = new System.Drawing.Size(890, 408);
            this.grdorderproducts.TabIndex = 2;
            // 
            // txtsbyn
            // 
            this.txtsbyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsbyn.Location = new System.Drawing.Point(494, 591);
            this.txtsbyn.Name = "txtsbyn";
            this.txtsbyn.Size = new System.Drawing.Size(224, 28);
            this.txtsbyn.TabIndex = 3;
            this.txtsbyn.Text = "a";
            // 
            // txtsbyp
            // 
            this.txtsbyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsbyp.Location = new System.Drawing.Point(494, 651);
            this.txtsbyp.Name = "txtsbyp";
            this.txtsbyp.Size = new System.Drawing.Size(224, 28);
            this.txtsbyp.TabIndex = 4;
            // 
            // lblsbyn
            // 
            this.lblsbyn.AutoSize = true;
            this.lblsbyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbyn.Location = new System.Drawing.Point(258, 591);
            this.lblsbyn.Name = "lblsbyn";
            this.lblsbyn.Size = new System.Drawing.Size(178, 24);
            this.lblsbyn.TabIndex = 5;
            this.lblsbyn.Text = "Search By Name :";
            // 
            // lblsbtp
            // 
            this.lblsbtp.AutoSize = true;
            this.lblsbtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbtp.Location = new System.Drawing.Point(258, 651);
            this.lblsbtp.Name = "lblsbtp";
            this.lblsbtp.Size = new System.Drawing.Size(195, 24);
            this.lblsbtp.TabIndex = 6;
            this.lblsbtp.Text = "Search By Product :";
            // 
            // frmOrderedPrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 803);
            this.Controls.Add(this.lblsbtp);
            this.Controls.Add(this.lblsbyn);
            this.Controls.Add(this.txtsbyp);
            this.Controls.Add(this.txtsbyn);
            this.Controls.Add(this.grdorderproducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmOrderedPrd";
            this.Text = "frmOrderedPrd";
            this.Load += new System.EventHandler(this.frmOrderedPrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdorderproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdorderproducts;
        private System.Windows.Forms.TextBox txtsbyn;
        private System.Windows.Forms.TextBox txtsbyp;
        private System.Windows.Forms.Label lblsbyn;
        private System.Windows.Forms.Label lblsbtp;
    }
}