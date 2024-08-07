namespace MyProjectWatchlist1
{
    partial class ckDrama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grdAniView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEpisodes = new System.Windows.Forms.TextBox();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAniView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(404, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 26;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(259, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID :";
            // 
            // grdAniView
            // 
            this.grdAniView.BackgroundColor = System.Drawing.Color.Cyan;
            this.grdAniView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAniView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grdAniView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdAniView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAniView.GridColor = System.Drawing.Color.Chartreuse;
            this.grdAniView.Location = new System.Drawing.Point(45, 343);
            this.grdAniView.Name = "grdAniView";
            this.grdAniView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grdAniView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAniView.RowTemplate.Height = 24;
            this.grdAniView.Size = new System.Drawing.Size(710, 258);
            this.grdAniView.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(364, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(404, 227);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 22);
            this.txtLink.TabIndex = 22;
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(404, 182);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(100, 22);
            this.txtIMDB.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(404, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 20;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(260, 230);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(31, 16);
            this.lblLink.TabIndex = 19;
            this.lblLink.Text = "Link";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(260, 188);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(43, 16);
            this.lblIMDB.TabIndex = 18;
            this.lblIMDB.Text = "IMBD ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(259, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtEpisodes
            // 
            this.txtEpisodes.Location = new System.Drawing.Point(404, 145);
            this.txtEpisodes.Name = "txtEpisodes";
            this.txtEpisodes.Size = new System.Drawing.Size(100, 22);
            this.txtEpisodes.TabIndex = 28;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(259, 151);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(71, 16);
            this.lblEpisodes.TabIndex = 27;
            this.lblEpisodes.Text = "Episodes :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckDrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEpisodes);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdAniView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Name = "ckDrama";
            this.Text = "ckDrama";
            this.Load += new System.EventHandler(this.ckDrama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAniView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView grdAniView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEpisodes;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.Button btnDelete;
    }
}