namespace MyProjectRoomManagement
{
    partial class Home
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
            this.grdViewhome = new System.Windows.Forms.DataGridView();
            this.lblPerson = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbbxid = new System.Windows.Forms.ComboBox();
            this.txtperson = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewhome)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewhome
            // 
            this.grdViewhome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewhome.Location = new System.Drawing.Point(12, 120);
            this.grdViewhome.Name = "grdViewhome";
            this.grdViewhome.RowHeadersWidth = 51;
            this.grdViewhome.RowTemplate.Height = 24;
            this.grdViewhome.Size = new System.Drawing.Size(597, 220);
            this.grdViewhome.TabIndex = 25;
            this.grdViewhome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView1_CellContentClick);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(120, 31);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(157, 24);
            this.lblPerson.TabIndex = 27;
            this.lblPerson.Text = "Select Person Id :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(462, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 30);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbbxid
            // 
            this.cmbbxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxid.FormattingEnabled = true;
            this.cmbbxid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbbxid.Location = new System.Drawing.Point(279, 28);
            this.cmbbxid.Name = "cmbbxid";
            this.cmbbxid.Size = new System.Drawing.Size(153, 30);
            this.cmbbxid.TabIndex = 31;
            this.cmbbxid.SelectedIndexChanged += new System.EventHandler(this.cmbbxid_SelectedIndexChanged);
            // 
            // txtperson
            // 
            this.txtperson.AutoSize = true;
            this.txtperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperson.Location = new System.Drawing.Point(308, 74);
            this.txtperson.Name = "txtperson";
            this.txtperson.Size = new System.Drawing.Size(71, 24);
            this.txtperson.TabIndex = 32;
            this.txtperson.Text = "Name :";
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(142, 374);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(87, 30);
            this.btnTotal.TabIndex = 33;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(275, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 24);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 438);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtperson);
            this.Controls.Add(this.cmbbxid);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.grdViewhome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewhome;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbbxid;
        private System.Windows.Forms.Label txtperson;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}