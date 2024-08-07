namespace MyProjectWatchlist1
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtonid = new System.Windows.Forms.TextBox();
            this.grdongoingt = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddon = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbbxGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdongoingt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(674, 21);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(354, 21);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(102, 16);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "Ongoing Things";
            // 
            // txtonid
            // 
            this.txtonid.Location = new System.Drawing.Point(135, 63);
            this.txtonid.Name = "txtonid";
            this.txtonid.Size = new System.Drawing.Size(52, 22);
            this.txtonid.TabIndex = 4;
            this.txtonid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grdongoingt
            // 
            this.grdongoingt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdongoingt.Location = new System.Drawing.Point(44, 220);
            this.grdongoingt.Name = "grdongoingt";
            this.grdongoingt.RowHeadersWidth = 51;
            this.grdongoingt.RowTemplate.Height = 24;
            this.grdongoingt.Size = new System.Drawing.Size(718, 198);
            this.grdongoingt.TabIndex = 5;
            this.grdongoingt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddon
            // 
            this.lblAddon.AutoSize = true;
            this.lblAddon.Location = new System.Drawing.Point(20, 69);
            this.lblAddon.Name = "lblAddon";
            this.lblAddon.Size = new System.Drawing.Size(75, 16);
            this.lblAddon.TabIndex = 7;
            this.lblAddon.Text = "Add to List :";
            // 
            // lblGenre
            // 
            this.lblGenre.AllowDrop = true;
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 28);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(91, 16);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Select Genre :";
            // 
            // cmbbxGenre
            // 
            this.cmbbxGenre.FormattingEnabled = true;
            this.cmbbxGenre.Items.AddRange(new object[] {
            "Anime",
            "KCdrama",
            "Indian",
            "Hollywood"});
            this.cmbbxGenre.Location = new System.Drawing.Point(135, 25);
            this.cmbbxGenre.Name = "cmbbxGenre";
            this.cmbbxGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGenre.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAddon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdongoingt);
            this.Controls.Add(this.txtonid);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnShow);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdongoingt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtonid;
        private System.Windows.Forms.DataGridView grdongoingt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddon;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbbxGenre;
    }
}