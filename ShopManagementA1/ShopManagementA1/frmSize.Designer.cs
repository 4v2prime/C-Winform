namespace ShopManagementA1
{
    partial class frmSize
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
            this.lblType = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lclProduct = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tblTitel = new System.Windows.Forms.Label();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(63, 76);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(241, 265);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 28);
            this.txtPrice.TabIndex = 1;
            // 
            // cmbbxType
            // 
            this.cmbbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(241, 68);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(196, 30);
            this.cmbbxType.TabIndex = 2;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(108, 341);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 39);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lclProduct
            // 
            this.lclProduct.AutoSize = true;
            this.lclProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclProduct.Location = new System.Drawing.Point(63, 124);
            this.lclProduct.Name = "lclProduct";
            this.lclProduct.Size = new System.Drawing.Size(85, 24);
            this.lclProduct.TabIndex = 4;
            this.lclProduct.Text = "Product :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(63, 175);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 24);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size :";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(63, 221);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(61, 24);
            this.lblMRP.TabIndex = 6;
            this.lblMRP.Text = "MRP :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(64, 269);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 24);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price :";
            // 
            // txtMRP
            // 
            this.txtMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(241, 215);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(196, 28);
            this.txtMRP.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(250, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblTitel
            // 
            this.tblTitel.AutoSize = true;
            this.tblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTitel.Location = new System.Drawing.Point(148, 18);
            this.tblTitel.Name = "tblTitel";
            this.tblTitel.Size = new System.Drawing.Size(183, 24);
            this.tblTitel.TabIndex = 12;
            this.tblTitel.Text = "Product Registration ";
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(241, 118);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(196, 30);
            this.cmbbxProduct.TabIndex = 13;
            this.cmbbxProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxProduct_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(241, 171);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(196, 28);
            this.txtSize.TabIndex = 14;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 482);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbbxProduct);
            this.Controls.Add(this.tblTitel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lclProduct);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblType);
            this.Name = "frmSize";
            this.Text = "Size";
            this.Load += new System.EventHandler(this.Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lclProduct;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label tblTitel;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.TextBox txtSize;
    }
}