namespace MyProjectRoomManagement
{
    partial class Save
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
            this.cmbbxItems = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbbxPerson = new System.Windows.Forms.ComboBox();
            this.lblhead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbxItems
            // 
            this.cmbbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxItems.FormattingEnabled = true;
            this.cmbbxItems.Items.AddRange(new object[] {
            "Room Rent",
            "Electricity Bill",
            "Grocery",
            "Mandai",
            "Others"});
            this.cmbbxItems.Location = new System.Drawing.Point(356, 187);
            this.cmbbxItems.Name = "cmbbxItems";
            this.cmbbxItems.Size = new System.Drawing.Size(164, 30);
            this.cmbbxItems.TabIndex = 29;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(356, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 38);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cost :";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(141, 199);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 24);
            this.lblItem.TabIndex = 21;
            this.lblItem.Text = "Items :";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(141, 147);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(80, 24);
            this.lblPerson.TabIndex = 20;
            this.lblPerson.Text = "Person :";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(356, 252);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 28);
            this.txtCost.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(193, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbbxPerson
            // 
            this.cmbbxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPerson.FormattingEnabled = true;
            this.cmbbxPerson.Location = new System.Drawing.Point(356, 143);
            this.cmbbxPerson.Name = "cmbbxPerson";
            this.cmbbxPerson.Size = new System.Drawing.Size(164, 30);
            this.cmbbxPerson.TabIndex = 17;
            this.cmbbxPerson.SelectedIndexChanged += new System.EventHandler(this.cmbbxPerson_SelectedIndexChanged);
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(227, 29);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(182, 24);
            this.lblhead.TabIndex = 16;
            this.lblhead.Text = "Room Management ";
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 456);
            this.Controls.Add(this.cmbbxItems);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbbxPerson);
            this.Controls.Add(this.lblhead);
            this.Name = "Save";
            this.Text = "Save";
            this.Load += new System.EventHandler(this.Save_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbxItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbbxPerson;
        private System.Windows.Forms.Label lblhead;
    }
}