namespace A1_ShopManagement
{
    partial class frmOffer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpbxOffer = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblpercent = new System.Windows.Forms.Label();
            this.lblRS2 = new System.Windows.Forms.Label();
            this.txtnewPrc = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblrs = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblnprice = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.grpbxOffer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(353, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "OFFER FORM";
            // 
            // grpbxOffer
            // 
            this.grpbxOffer.Controls.Add(this.btnupdate);
            this.grpbxOffer.Controls.Add(this.lblProduct);
            this.grpbxOffer.Controls.Add(this.lblpercent);
            this.grpbxOffer.Controls.Add(this.lblRS2);
            this.grpbxOffer.Controls.Add(this.txtnewPrc);
            this.grpbxOffer.Controls.Add(this.txtDiscount);
            this.grpbxOffer.Controls.Add(this.lblrs);
            this.grpbxOffer.Controls.Add(this.lblPrice);
            this.grpbxOffer.Controls.Add(this.lblnprice);
            this.grpbxOffer.Controls.Add(this.lblDis);
            this.grpbxOffer.Controls.Add(this.lbltext);
            this.grpbxOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOffer.Location = new System.Drawing.Point(97, 110);
            this.grpbxOffer.Name = "grpbxOffer";
            this.grpbxOffer.Size = new System.Drawing.Size(695, 363);
            this.grpbxOffer.TabIndex = 3;
            this.grpbxOffer.TabStop = false;
            this.grpbxOffer.Text = "Offer Information";
            this.grpbxOffer.Enter += new System.EventHandler(this.grpbxOffer_Enter);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(244, 274);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(176, 35);
            this.btnupdate.TabIndex = 27;
            this.btnupdate.Text = "Update Price";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(240, 66);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(38, 22);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "****";
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercent.Location = new System.Drawing.Point(589, 140);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(26, 22);
            this.lblpercent.TabIndex = 24;
            this.lblpercent.Text = "%";
            // 
            // lblRS2
            // 
            this.lblRS2.AutoSize = true;
            this.lblRS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS2.Location = new System.Drawing.Point(580, 204);
            this.lblRS2.Name = "lblRS2";
            this.lblRS2.Size = new System.Drawing.Size(35, 22);
            this.lblRS2.TabIndex = 23;
            this.lblRS2.Text = "RS";
            // 
            // txtnewPrc
            // 
            this.txtnewPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewPrc.Location = new System.Drawing.Point(399, 198);
            this.txtnewPrc.Name = "txtnewPrc";
            this.txtnewPrc.Size = new System.Drawing.Size(165, 28);
            this.txtnewPrc.TabIndex = 21;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(399, 134);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(165, 28);
            this.txtDiscount.TabIndex = 20;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblrs
            // 
            this.lblrs.AutoSize = true;
            this.lblrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrs.Location = new System.Drawing.Point(512, 66);
            this.lblrs.Name = "lblrs";
            this.lblrs.Size = new System.Drawing.Size(35, 22);
            this.lblrs.TabIndex = 19;
            this.lblrs.Text = "RS";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(397, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "00.00";
            // 
            // lblnprice
            // 
            this.lblnprice.AutoSize = true;
            this.lblnprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnprice.Location = new System.Drawing.Point(72, 198);
            this.lblnprice.Name = "lblnprice";
            this.lblnprice.Size = new System.Drawing.Size(102, 22);
            this.lblnprice.TabIndex = 17;
            this.lblnprice.Text = "New Price :";
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(72, 134);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(176, 22);
            this.lblDis.TabIndex = 16;
            this.lblDis.Text = "Discount in Percent :";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(72, 66);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(152, 22);
            this.lbltext.TabIndex = 15;
            this.lbltext.Text = "Original Price Of :";
            // 
            // frmOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 613);
            this.Controls.Add(this.grpbxOffer);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmOffer";
            this.Text = "Offer";
            this.Load += new System.EventHandler(this.frmOffer_Load);
            this.grpbxOffer.ResumeLayout(false);
            this.grpbxOffer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpbxOffer;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.Label lblRS2;
        private System.Windows.Forms.TextBox txtnewPrc;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblrs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblnprice;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnupdate;
    }
}