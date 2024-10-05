namespace WinForm_Otp
{
    partial class frmForgotPassword
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.otpTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(391, 193);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 34);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "ex. exaple@email.com";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Magenta;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(283, 282);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(190, 52);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Send OTP";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter OTP :";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(391, 396);
            this.txtOTP.MaxLength = 64;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(372, 34);
            this.txtOTP.TabIndex = 2;
            this.txtOTP.Text = "Enter OTP ";
            this.txtOTP.Enter += new System.EventHandler(this.txtOTP_Enter);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Magenta;
            this.btnVerify.Enabled = false;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(283, 485);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(190, 52);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify OTP";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(395, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 6;
            // 
            // otpTimer
            // 
            this.otpTimer.Interval = 180;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(866, 656);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer otpTimer;
    }
}