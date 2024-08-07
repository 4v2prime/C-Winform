namespace ShopManagementA1
{
    partial class Order
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpbxOrderInfo = new System.Windows.Forms.GroupBox();
            this.lbliprice = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.grdSize = new System.Windows.Forms.DataGridView();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpbxCart = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblUEmail = new System.Windows.Forms.Label();
            this.lstvwCart = new System.Windows.Forms.ListView();
            this.lblUName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSize)).BeginInit();
            this.grpbxCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(63, 503);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 24);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(613, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Order Form";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpbxOrderInfo
            // 
            this.grpbxOrderInfo.Controls.Add(this.lbliprice);
            this.grpbxOrderInfo.Controls.Add(this.lblRs);
            this.grpbxOrderInfo.Controls.Add(this.cmbbxProduct);
            this.grpbxOrderInfo.Controls.Add(this.lblProduct);
            this.grpbxOrderInfo.Controls.Add(this.grdSize);
            this.grpbxOrderInfo.Controls.Add(this.cmbbxType);
            this.grpbxOrderInfo.Controls.Add(this.lblPrice);
            this.grpbxOrderInfo.Controls.Add(this.lblType);
            this.grpbxOrderInfo.Controls.Add(this.btnClear);
            this.grpbxOrderInfo.Controls.Add(this.btnLogOut);
            this.grpbxOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOrderInfo.Location = new System.Drawing.Point(33, 26);
            this.grpbxOrderInfo.Name = "grpbxOrderInfo";
            this.grpbxOrderInfo.Size = new System.Drawing.Size(499, 753);
            this.grpbxOrderInfo.TabIndex = 8;
            this.grpbxOrderInfo.TabStop = false;
            this.grpbxOrderInfo.Text = "Order Information :";
            this.grpbxOrderInfo.Enter += new System.EventHandler(this.grpbxOrderInfo_Enter);
            // 
            // lbliprice
            // 
            this.lbliprice.AutoSize = true;
            this.lbliprice.Location = new System.Drawing.Point(156, 503);
            this.lbliprice.Name = "lbliprice";
            this.lbliprice.Size = new System.Drawing.Size(30, 24);
            this.lbliprice.TabIndex = 36;
            this.lbliprice.Text = "00";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(216, 503);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(35, 24);
            this.lblRs.TabIndex = 15;
            this.lblRs.Text = "RS";
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(205, 117);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(215, 30);
            this.cmbbxProduct.TabIndex = 13;
            this.cmbbxProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(42, 117);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(85, 24);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Product :";
            // 
            // grdSize
            // 
            this.grdSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSize.Location = new System.Drawing.Point(74, 187);
            this.grdSize.Name = "grdSize";
            this.grdSize.RowHeadersWidth = 51;
            this.grdSize.Size = new System.Drawing.Size(346, 275);
            this.grdSize.TabIndex = 8;
            this.grdSize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSize_CellClick);
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(205, 49);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(215, 30);
            this.cmbbxType.TabIndex = 7;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(284, 588);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(65, 588);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 43);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(577, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add to Cart ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(586, 343);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 70);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpbxCart
            // 
            this.grpbxCart.Controls.Add(this.lbltotal);
            this.grpbxCart.Controls.Add(this.lblUEmail);
            this.grpbxCart.Controls.Add(this.lstvwCart);
            this.grpbxCart.Controls.Add(this.lblUName);
            this.grpbxCart.Controls.Add(this.button2);
            this.grpbxCart.Controls.Add(this.button1);
            this.grpbxCart.Controls.Add(this.label1);
            this.grpbxCart.Controls.Add(this.label3);
            this.grpbxCart.Controls.Add(this.lblName);
            this.grpbxCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxCart.Location = new System.Drawing.Point(768, 26);
            this.grpbxCart.Name = "grpbxCart";
            this.grpbxCart.Size = new System.Drawing.Size(527, 753);
            this.grpbxCart.TabIndex = 21;
            this.grpbxCart.TabStop = false;
            this.grpbxCart.Text = "Cart";
            this.grpbxCart.Enter += new System.EventHandler(this.grpbxCart_Enter);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(245, 576);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(30, 24);
            this.lbltotal.TabIndex = 35;
            this.lbltotal.Text = "00";
            // 
            // lblUEmail
            // 
            this.lblUEmail.AutoSize = true;
            this.lblUEmail.Location = new System.Drawing.Point(225, 123);
            this.lblUEmail.Name = "lblUEmail";
            this.lblUEmail.Size = new System.Drawing.Size(44, 24);
            this.lblUEmail.TabIndex = 34;
            this.lblUEmail.Text = "mail";
            // 
            // lstvwCart
            // 
            this.lstvwCart.GridLines = true;
            this.lstvwCart.HideSelection = false;
            this.lstvwCart.Location = new System.Drawing.Point(58, 187);
            this.lstvwCart.Name = "lstvwCart";
            this.lstvwCart.Size = new System.Drawing.Size(463, 275);
            this.lstvwCart.TabIndex = 32;
            this.lstvwCart.UseCompatibleStateImageBehavior = false;
            this.lstvwCart.View = System.Windows.Forms.View.Details;
            this.lstvwCart.SelectedIndexChanged += new System.EventHandler(this.lstvwCart_SelectedIndexChanged);
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(223, 55);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(66, 24);
            this.lblUName.TabIndex = 33;
            this.lblUName.Text = "Name ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Total";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Order Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "RS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "E-Mail :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(146, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name :";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 814);
            this.Controls.Add(this.grpbxCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpbxOrderInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.grpbxOrderInfo.ResumeLayout(false);
            this.grpbxOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSize)).EndInit();
            this.grpbxCart.ResumeLayout(false);
            this.grpbxCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpbxOrderInfo;
        private System.Windows.Forms.DataGridView grdSize;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpbxCart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lstvwCart;
        private System.Windows.Forms.Label lblUEmail;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbliprice;
    }
}