namespace GSTERPExternalExam
{
    partial class frmExternalExam
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAssignedExam = new System.Windows.Forms.Button();
            this.btnPendingExam = new System.Windows.Forms.Button();
            this.btnConductedExam = new System.Windows.Forms.Button();
            this.btnAllExam = new System.Windows.Forms.Button();
            this.btnAssignExam = new System.Windows.Forms.Button();
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.tblpnlExam = new System.Windows.Forms.TableLayoutPanel();
            this.grdExam = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tblpnlMain.SuspendLayout();
            this.tblpnlExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExam)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1408, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "External";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssignedExam
            // 
            this.btnAssignedExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignedExam.Location = new System.Drawing.Point(3, 3);
            this.btnAssignedExam.Name = "btnAssignedExam";
            this.btnAssignedExam.Size = new System.Drawing.Size(195, 50);
            this.btnAssignedExam.TabIndex = 0;
            this.btnAssignedExam.Text = "Assigned Exam";
            this.btnAssignedExam.UseVisualStyleBackColor = true;
            // 
            // btnPendingExam
            // 
            this.btnPendingExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingExam.Location = new System.Drawing.Point(204, 3);
            this.btnPendingExam.Name = "btnPendingExam";
            this.btnPendingExam.Size = new System.Drawing.Size(195, 50);
            this.btnPendingExam.TabIndex = 0;
            this.btnPendingExam.Text = "Pending Exam";
            this.btnPendingExam.UseVisualStyleBackColor = true;
            // 
            // btnConductedExam
            // 
            this.btnConductedExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductedExam.Location = new System.Drawing.Point(405, 3);
            this.btnConductedExam.Name = "btnConductedExam";
            this.btnConductedExam.Size = new System.Drawing.Size(195, 50);
            this.btnConductedExam.TabIndex = 0;
            this.btnConductedExam.Text = "Conducted Exam";
            this.btnConductedExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConductedExam.UseVisualStyleBackColor = true;
            // 
            // btnAllExam
            // 
            this.btnAllExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllExam.Location = new System.Drawing.Point(606, 3);
            this.btnAllExam.Name = "btnAllExam";
            this.btnAllExam.Size = new System.Drawing.Size(195, 50);
            this.btnAllExam.TabIndex = 0;
            this.btnAllExam.Text = "All Exam";
            this.btnAllExam.UseVisualStyleBackColor = true;
            this.btnAllExam.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAssignExam
            // 
            this.btnAssignExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignExam.Location = new System.Drawing.Point(807, 3);
            this.btnAssignExam.Name = "btnAssignExam";
            this.btnAssignExam.Size = new System.Drawing.Size(198, 50);
            this.btnAssignExam.TabIndex = 0;
            this.btnAssignExam.Text = "Assign Exam";
            this.btnAssignExam.UseVisualStyleBackColor = true;
            this.btnAssignExam.Visible = false;
            this.btnAssignExam.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 5;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.60976F));
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.39024F));
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tblpnlMain.Controls.Add(this.btnRefresh, 2, 0);
            this.tblpnlMain.Controls.Add(this.btnAddExam, 1, 0);
            this.tblpnlMain.Location = new System.Drawing.Point(199, 32);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 1;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlMain.Size = new System.Drawing.Size(702, 66);
            this.tblpnlMain.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::GSTERPExternalExam.Properties.Resources.rotate;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(408, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 60);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackgroundImage = global::GSTERPExternalExam.Properties.Resources.add;
            this.btnAddExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddExam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddExam.Location = new System.Drawing.Point(228, 3);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(96, 60);
            this.btnAddExam.TabIndex = 0;
            this.btnAddExam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddExam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // tblpnlExam
            // 
            this.tblpnlExam.ColumnCount = 5;
            this.tblpnlExam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlExam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlExam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlExam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlExam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlExam.Controls.Add(this.btnAssignedExam, 0, 0);
            this.tblpnlExam.Controls.Add(this.btnPendingExam, 1, 0);
            this.tblpnlExam.Controls.Add(this.btnConductedExam, 2, 0);
            this.tblpnlExam.Controls.Add(this.btnAssignExam, 4, 0);
            this.tblpnlExam.Controls.Add(this.btnAllExam, 3, 0);
            this.tblpnlExam.Location = new System.Drawing.Point(199, 118);
            this.tblpnlExam.Name = "tblpnlExam";
            this.tblpnlExam.RowCount = 1;
            this.tblpnlExam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlExam.Size = new System.Drawing.Size(1008, 61);
            this.tblpnlExam.TabIndex = 2;
            // 
            // grdExam
            // 
            this.grdExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Edit});
            this.grdExam.Location = new System.Drawing.Point(202, 226);
            this.grdExam.Name = "grdExam";
            this.grdExam.RowHeadersWidth = 51;
            this.grdExam.RowTemplate.Height = 24;
            this.grdExam.Size = new System.Drawing.Size(1005, 344);
            this.grdExam.TabIndex = 3;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 80;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Action";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.Width = 60;
            // 
            // frmExternalExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 681);
            this.Controls.Add(this.grdExam);
            this.Controls.Add(this.tblpnlExam);
            this.Controls.Add(this.tblpnlMain);
            this.Controls.Add(this.button1);
            this.Name = "frmExternalExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExternalExam";
            this.Load += new System.EventHandler(this.frmExternalExam_Load);
            this.tblpnlMain.ResumeLayout(false);
            this.tblpnlExam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAssignedExam;
        private System.Windows.Forms.Button btnPendingExam;
        private System.Windows.Forms.Button btnConductedExam;
        private System.Windows.Forms.Button btnAllExam;
        private System.Windows.Forms.Button btnAssignExam;
        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.TableLayoutPanel tblpnlExam;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView grdExam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}

