namespace A1_ShopManagement
{
    partial class frmP_Size
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.tblTitel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lclProduct = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(391, 197);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(196, 28);
            this.txtSize.TabIndex = 27;
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(391, 144);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(196, 30);
            this.cmbbxProduct.TabIndex = 26;
            // 
            // tblTitel
            // 
            this.tblTitel.AutoSize = true;
            this.tblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTitel.Location = new System.Drawing.Point(298, 44);
            this.tblTitel.Name = "tblTitel";
            this.tblTitel.Size = new System.Drawing.Size(183, 24);
            this.tblTitel.TabIndex = 25;
            this.tblTitel.Text = "Product Registration ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(400, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 39);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMRP
            // 
            this.txtMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(391, 241);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(196, 28);
            this.txtMRP.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(214, 295);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 24);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price :";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(213, 247);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(61, 24);
            this.lblMRP.TabIndex = 21;
            this.lblMRP.Text = "MRP :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(213, 201);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 24);
            this.lblSize.TabIndex = 20;
            this.lblSize.Text = "Size :";
            // 
            // lclProduct
            // 
            this.lclProduct.AutoSize = true;
            this.lclProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclProduct.Location = new System.Drawing.Point(213, 150);
            this.lclProduct.Name = "lclProduct";
            this.lclProduct.Size = new System.Drawing.Size(85, 24);
            this.lclProduct.TabIndex = 19;
            this.lclProduct.Text = "Product :";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(258, 367);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 39);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbbxType
            // 
            this.cmbbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(391, 94);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(196, 30);
            this.cmbbxType.TabIndex = 17;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(391, 291);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 28);
            this.txtPrice.TabIndex = 16;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(213, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type :";
            // 
            // frmP_Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
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
            this.Name = "frmP_Size";
            this.Text = "Size";
            this.Load += new System.EventHandler(this.frmP_Size_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.Label tblTitel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lclProduct;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblType;
    }
}