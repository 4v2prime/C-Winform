namespace MyProjectWatchlist1
{
    partial class Hollywood
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grdAniViewHolly = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEpisodes = new System.Windows.Forms.TextBox();
            this.lblEpisodes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAniViewHolly)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(395, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 37;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(252, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 36;
            this.lblId.Text = "ID :";
            // 
            // grdAniViewHolly
            // 
            this.grdAniViewHolly.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdAniViewHolly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAniViewHolly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grdAniViewHolly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAniViewHolly.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdAniViewHolly.Location = new System.Drawing.Point(42, 334);
            this.grdAniViewHolly.Name = "grdAniViewHolly";
            this.grdAniViewHolly.RowHeadersWidth = 51;
            this.grdAniViewHolly.RowTemplate.Height = 24;
            this.grdAniViewHolly.Size = new System.Drawing.Size(710, 258);
            this.grdAniViewHolly.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(365, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(395, 217);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 22);
            this.txtLink.TabIndex = 33;
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(395, 176);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(100, 22);
            this.txtIMDB.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(395, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 31;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(252, 220);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(31, 16);
            this.lblLink.TabIndex = 30;
            this.lblLink.Text = "Link";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(252, 182);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(43, 16);
            this.lblIMDB.TabIndex = 29;
            this.lblIMDB.Text = "IMBD ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(252, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(501, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtEpisodes
            // 
            this.txtEpisodes.Location = new System.Drawing.Point(395, 138);
            this.txtEpisodes.Name = "txtEpisodes";
            this.txtEpisodes.Size = new System.Drawing.Size(100, 22);
            this.txtEpisodes.TabIndex = 42;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(250, 144);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(71, 16);
            this.lblEpisodes.TabIndex = 41;
            this.lblEpisodes.Text = "Episodes :";
            // 
            // Hollywood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.txtEpisodes);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdAniViewHolly);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Name = "Hollywood";
            this.Text = "Hollywood";
            ((System.ComponentModel.ISupportInitialize)(this.grdAniViewHolly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView grdAniViewHolly;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEpisodes;
        private System.Windows.Forms.Label lblEpisodes;
    }
}