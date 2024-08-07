namespace demoLsitview1
{
    partial class Form1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.Label();
            this.lblint = new System.Windows.Forms.Label();
            this.txtint = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.lstvw1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnclear = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(220, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 0;
            // 
            // tblname
            // 
            this.tblname.AutoSize = true;
            this.tblname.Location = new System.Drawing.Point(62, 38);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(41, 16);
            this.tblname.TabIndex = 1;
            this.tblname.Text = "name";
            // 
            // lblint
            // 
            this.lblint.AutoSize = true;
            this.lblint.Location = new System.Drawing.Point(62, 86);
            this.lblint.Name = "lblint";
            this.lblint.Size = new System.Drawing.Size(20, 16);
            this.lblint.TabIndex = 3;
            this.lblint.Text = "int";
            // 
            // txtint
            // 
            this.txtint.Location = new System.Drawing.Point(220, 81);
            this.txtint.Name = "txtint";
            this.txtint.Size = new System.Drawing.Size(100, 22);
            this.txtint.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(65, 132);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(65, 171);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(211, 171);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 23);
            this.btntotal.TabIndex = 6;
            this.btntotal.Text = "total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // lstvw1
            // 
            this.lstvw1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvw1.FullRowSelect = true;
            this.lstvw1.HideSelection = false;
            this.lstvw1.Location = new System.Drawing.Point(675, 38);
            this.lstvw1.Name = "lstvw1";
            this.lstvw1.Size = new System.Drawing.Size(421, 320);
            this.lstvw1.TabIndex = 7;
            this.lstvw1.UseCompatibleStateImageBehavior = false;
            this.lstvw1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "int1";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(211, 132);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(329, 172);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 768);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lstvw1);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblint);
            this.Controls.Add(this.txtint);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label tblname;
        private System.Windows.Forms.Label lblint;
        private System.Windows.Forms.TextBox txtint;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.ListView lstvw1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

