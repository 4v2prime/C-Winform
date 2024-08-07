namespace GstErpPlacement
{
    partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOk = new Siticone.UI.WinForms.SiticoneButton();
            this.btnCancel = new Siticone.UI.WinForms.SiticoneButton();
            this.ImageButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(150, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(451, 97);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.CheckedState.Parent = this.btnOk;
            this.btnOk.CustomImages.Parent = this.btnOk;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoveredState.Parent = this.btnOk;
            this.btnOk.Location = new System.Drawing.Point(145, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.ShadowDecoration.Parent = this.btnOk;
            this.btnOk.Size = new System.Drawing.Size(140, 45);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ok";
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoveredState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(348, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            // 
            // ImageButton
            // 
            this.ImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageButton.BackgroundImage")));
            this.ImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton.Location = new System.Drawing.Point(12, 12);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(111, 97);
            this.ImageButton.TabIndex = 5;
            this.ImageButton.TabStop = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(710, 211);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MyMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private Siticone.UI.WinForms.SiticoneButton btnOk;
        private Siticone.UI.WinForms.SiticoneButton btnCancel;
        private System.Windows.Forms.PictureBox ImageButton;
    }
}