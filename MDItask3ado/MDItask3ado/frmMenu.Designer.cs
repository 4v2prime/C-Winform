namespace MDItask3ado
{
    partial class frmMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPricemenu = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxMenu = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(216, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 25);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(216, 149);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(68, 25);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(216, 227);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price=";
            // 
            // lblPricemenu
            // 
            this.lblPricemenu.AutoSize = true;
            this.lblPricemenu.BackColor = System.Drawing.Color.Lime;
            this.lblPricemenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricemenu.Location = new System.Drawing.Point(474, 227);
            this.lblPricemenu.Name = "lblPricemenu";
            this.lblPricemenu.Size = new System.Drawing.Size(61, 25);
            this.lblPricemenu.TabIndex = 3;
            this.lblPricemenu.Text = "00.00";
            this.lblPricemenu.Click += new System.EventHandler(this.lblPricemenu_Click);
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Items.AddRange(new object[] {
            "Maharashtraian",
            "Gujrati",
            "South Indian"});
            this.cmbbxType.Location = new System.Drawing.Point(477, 73);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxType.TabIndex = 4;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxMenu
            // 
            this.cmbbxMenu.FormattingEnabled = true;
            this.cmbbxMenu.Location = new System.Drawing.Point(477, 149);
            this.cmbbxMenu.Name = "cmbbxMenu";
            this.cmbbxMenu.Size = new System.Drawing.Size(121, 24);
            this.cmbbxMenu.TabIndex = 5;
            this.cmbbxMenu.SelectedIndexChanged += new System.EventHandler(this.cmbbxMenu_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(341, 299);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(78, 35);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbbxMenu);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.lblPricemenu);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblType);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPricemenu;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxMenu;
        private System.Windows.Forms.Button btnOrder;
    }
}