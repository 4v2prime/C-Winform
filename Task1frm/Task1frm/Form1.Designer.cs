namespace Task1frm
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
            this.lblRahitech = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRahitech
            // 
            this.lblRahitech.AutoSize = true;
            this.lblRahitech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRahitech.Location = new System.Drawing.Point(368, 30);
            this.lblRahitech.Name = "lblRahitech";
            this.lblRahitech.Size = new System.Drawing.Size(121, 25);
            this.lblRahitech.TabIndex = 0;
            this.lblRahitech.Text = "RAHITECH";
            this.lblRahitech.Click += new System.EventHandler(this.lblRahitech_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(281, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(281, 160);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 25);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(281, 219);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(483, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 4;
            // 
            // cmbbxState
            // 
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Items.AddRange(new object[] {
            "Maharashtra",
            "Gujrat",
            "Karnataka"});
            this.cmbbxState.Location = new System.Drawing.Point(483, 160);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(121, 24);
            this.cmbbxState.TabIndex = 5;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(483, 220);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(121, 24);
            this.cmbbxCity.TabIndex = 6;
            this.cmbbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbbxCity_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(384, 297);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 35);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRahitech);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRahitech;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.Button btnShow;
    }
}

