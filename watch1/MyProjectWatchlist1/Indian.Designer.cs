namespace MyProjectWatchlist1
{
    partial class Indian
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
            this.grdAniViewInd = new System.Windows.Forms.DataGridView();
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
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbbxGenreind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAniViewInd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(395, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 37;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(257, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 36;
            this.lblId.Text = "ID :";
            // 
            // grdAniViewInd
            // 
            this.grdAniViewInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAniViewInd.Location = new System.Drawing.Point(45, 363);
            this.grdAniViewInd.Name = "grdAniViewInd";
            this.grdAniViewInd.RowHeadersWidth = 51;
            this.grdAniViewInd.RowTemplate.Height = 24;
            this.grdAniViewInd.Size = new System.Drawing.Size(710, 258);
            this.grdAniViewInd.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(395, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(395, 258);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 22);
            this.txtLink.TabIndex = 33;
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(395, 219);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(100, 22);
            this.txtIMDB.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(395, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 31;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(257, 258);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(31, 16);
            this.lblLink.TabIndex = 30;
            this.lblLink.Text = "Link";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(257, 219);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(43, 16);
            this.lblIMDB.TabIndex = 29;
            this.lblIMDB.Text = "IMBD ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(257, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // txtEpisodes
            // 
            this.txtEpisodes.Location = new System.Drawing.Point(395, 179);
            this.txtEpisodes.Name = "txtEpisodes";
            this.txtEpisodes.Size = new System.Drawing.Size(100, 22);
            this.txtEpisodes.TabIndex = 39;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(250, 185);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(71, 16);
            this.lblEpisodes.TabIndex = 38;
            this.lblEpisodes.Text = "Episodes :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(257, 146);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 41;
            this.lblGenre.Text = "Genre";
            // 
            // cmbbxGenreind
            // 
            this.cmbbxGenreind.FormattingEnabled = true;
            this.cmbbxGenreind.Items.AddRange(new object[] {
            "Movie",
            "Series",
            "Drama"});
            this.cmbbxGenreind.Location = new System.Drawing.Point(395, 138);
            this.cmbbxGenreind.Name = "cmbbxGenreind";
            this.cmbbxGenreind.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGenreind.TabIndex = 40;
            // 
            // Indian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbbxGenreind);
            this.Controls.Add(this.txtEpisodes);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdAniViewInd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Name = "Indian";
            this.Text = "Indian";
            this.Load += new System.EventHandler(this.Indian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAniViewInd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView grdAniViewInd;
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
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbbxGenreind;
    }
}