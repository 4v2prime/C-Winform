namespace MyProjectWatchlist1
{
    partial class Anime
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbbxGenre = new System.Windows.Forms.ComboBox();
            this.tblGenre = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.grdAniShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAniShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(361, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // cmbbxGenre
            // 
            this.cmbbxGenre.FormattingEnabled = true;
            this.cmbbxGenre.Items.AddRange(new object[] {
            "Isekai",
            "Slice of Life",
            "Action",
            "Animation"});
            this.cmbbxGenre.Location = new System.Drawing.Point(361, 165);
            this.cmbbxGenre.Name = "cmbbxGenre";
            this.cmbbxGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGenre.TabIndex = 2;
            // 
            // tblGenre
            // 
            this.tblGenre.AutoSize = true;
            this.tblGenre.Location = new System.Drawing.Point(168, 173);
            this.tblGenre.Name = "tblGenre";
            this.tblGenre.Size = new System.Drawing.Size(44, 16);
            this.tblGenre.TabIndex = 3;
            this.tblGenre.Text = "Genre";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(168, 222);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(40, 16);
            this.lblIMDB.TabIndex = 4;
            this.lblIMDB.Text = "IMDB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Link";
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(361, 216);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(100, 22);
            this.txtIMDB.TabIndex = 6;
            this.txtIMDB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(361, 267);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 22);
            this.txtLink.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(272, 346);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grdAniShow
            // 
            this.grdAniShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAniShow.Location = new System.Drawing.Point(12, 410);
            this.grdAniShow.Name = "grdAniShow";
            this.grdAniShow.RowHeadersWidth = 51;
            this.grdAniShow.RowTemplate.Height = 24;
            this.grdAniShow.Size = new System.Drawing.Size(573, 291);
            this.grdAniShow.TabIndex = 10;
            // 
            // Anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 740);
            this.Controls.Add(this.grdAniShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.tblGenre);
            this.Controls.Add(this.cmbbxGenre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Anime";
            this.Text = "Anime";
            this.Load += new System.EventHandler(this.Anime_Load);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.cmbbxGenre, 0);
            this.Controls.SetChildIndex(this.tblGenre, 0);
            this.Controls.SetChildIndex(this.lblIMDB, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtIMDB, 0);
            this.Controls.SetChildIndex(this.txtLink, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnShow, 0);
            this.Controls.SetChildIndex(this.grdAniShow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdAniShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbbxGenre;
        private System.Windows.Forms.Label tblGenre;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView grdAniShow;
    }
}