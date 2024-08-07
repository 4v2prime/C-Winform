namespace MyProjectWatchlist1
{
    partial class frmanime1
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
            this.lblName = new System.Windows.Forms.Label();
            this.cmbbxGenre = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdAniView = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEpisodes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAniView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(201, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // cmbbxGenre
            // 
            this.cmbbxGenre.FormattingEnabled = true;
            this.cmbbxGenre.Items.AddRange(new object[] {
            "Isekai",
            "Slice of Life",
            "Action",
            "Animation"});
            this.cmbbxGenre.Location = new System.Drawing.Point(339, 137);
            this.cmbbxGenre.Name = "cmbbxGenre";
            this.cmbbxGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGenre.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(201, 145);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(201, 221);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(43, 16);
            this.lblIMDB.TabIndex = 5;
            this.lblIMDB.Text = "IMBD ";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(201, 269);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(31, 16);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Link";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(339, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(339, 221);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(100, 22);
            this.txtIMDB.TabIndex = 8;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(339, 269);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 22);
            this.txtLink.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 344);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdAniView
            // 
            this.grdAniView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAniView.Location = new System.Drawing.Point(63, 413);
            this.grdAniView.Name = "grdAniView";
            this.grdAniView.RowHeadersWidth = 51;
            this.grdAniView.RowTemplate.Height = 24;
            this.grdAniView.Size = new System.Drawing.Size(710, 258);
            this.grdAniView.TabIndex = 11;
            this.grdAniView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(339, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(206, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(470, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(201, 183);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(71, 16);
            this.lblEpisodes.TabIndex = 15;
            this.lblEpisodes.Text = "Episodes :";
            // 
            // frmanime1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdAniView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbbxGenre);
            this.Controls.Add(this.lblName);
            this.Name = "frmanime1";
            this.Text = "Anime";
            this.Load += new System.EventHandler(this.frmanime1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAniView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbbxGenre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdAniView;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEpisodes;
    }
}