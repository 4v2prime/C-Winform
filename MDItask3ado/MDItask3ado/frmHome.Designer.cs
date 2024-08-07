namespace MDItask3ado
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pbhome = new System.Windows.Forms.PictureBox();
            this.lblHotel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).BeginInit();
            this.SuspendLayout();
            // 
            // pbhome
            // 
            this.pbhome.Image = ((System.Drawing.Image)(resources.GetObject("pbhome.Image")));
            this.pbhome.Location = new System.Drawing.Point(257, 129);
            this.pbhome.Name = "pbhome";
            this.pbhome.Size = new System.Drawing.Size(234, 232);
            this.pbhome.TabIndex = 0;
            this.pbhome.TabStop = false;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(285, 60);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(155, 25);
            this.lblHotel.TabIndex = 1;
            this.lblHotel.Text = "Despande Veg";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.pbhome);
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbhome;
        private System.Windows.Forms.Label lblHotel;
    }
}