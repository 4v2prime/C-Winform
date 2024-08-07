namespace GSTERPExternalExam
{
    partial class frmViewTestimonial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTestimonial));
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.AudioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPdf = new Siticone.UI.WinForms.SiticoneImageButton();
            this.btnClose = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblAudioPath = new System.Windows.Forms.Label();
            this.lblVideoPath = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDateOfJoining = new System.Windows.Forms.Label();
            this.lblSalaryOffer = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.siticoneAnimateWindow2 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPdfPath = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AudioPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // AudioPlayer
            // 
            this.AudioPlayer.Enabled = true;
            this.AudioPlayer.Location = new System.Drawing.Point(468, 766);
            this.AudioPlayer.Name = "AudioPlayer";
            this.AudioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AudioPlayer.OcxState")));
            this.AudioPlayer.Size = new System.Drawing.Size(244, 45);
            this.AudioPlayer.TabIndex = 32;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(164, 616);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(255, 195);
            this.videoPlayer.TabIndex = 31;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnPdf.CheckedState.Parent = this.btnPdf;
            this.btnPdf.HoveredState.Parent = this.btnPdf;
            this.btnPdf.Image = global::GSTERPExternalExam.Properties.Resources.pdf;
            this.btnPdf.ImageSize = new System.Drawing.Size(100, 100);
            this.btnPdf.Location = new System.Drawing.Point(775, 705);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.PressedState.Parent = this.btnPdf;
            this.btnPdf.Size = new System.Drawing.Size(104, 106);
            this.btnPdf.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 1;
            this.btnClose.BorderThickness = 1;
            this.btnClose.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClose.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.btnClose.CheckedState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(865, 889);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "CLOSE";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(212, 150);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(132, 28);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "Qualification :";
            // 
            // lblAudioPath
            // 
            this.lblAudioPath.AutoSize = true;
            this.lblAudioPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioPath.Location = new System.Drawing.Point(374, 526);
            this.lblAudioPath.Name = "lblAudioPath";
            this.lblAudioPath.Size = new System.Drawing.Size(107, 28);
            this.lblAudioPath.TabIndex = 27;
            this.lblAudioPath.Text = "audio path";
            // 
            // lblVideoPath
            // 
            this.lblVideoPath.AutoSize = true;
            this.lblVideoPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoPath.Location = new System.Drawing.Point(374, 486);
            this.lblVideoPath.Name = "lblVideoPath";
            this.lblVideoPath.Size = new System.Drawing.Size(61, 28);
            this.lblVideoPath.TabIndex = 26;
            this.lblVideoPath.Text = "video";
            // 
            // lblComments
            // 
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(374, 389);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(564, 97);
            this.lblComments.TabIndex = 25;
            this.lblComments.Text = "comments";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(374, 350);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 28);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "location";
            // 
            // lblDateOfJoining
            // 
            this.lblDateOfJoining.AutoSize = true;
            this.lblDateOfJoining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfJoining.Location = new System.Drawing.Point(374, 308);
            this.lblDateOfJoining.Name = "lblDateOfJoining";
            this.lblDateOfJoining.Size = new System.Drawing.Size(124, 28);
            this.lblDateOfJoining.TabIndex = 23;
            this.lblDateOfJoining.Text = "date of joing";
            // 
            // lblSalaryOffer
            // 
            this.lblSalaryOffer.AutoSize = true;
            this.lblSalaryOffer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryOffer.Location = new System.Drawing.Point(374, 271);
            this.lblSalaryOffer.Name = "lblSalaryOffer";
            this.lblSalaryOffer.Size = new System.Drawing.Size(108, 28);
            this.lblSalaryOffer.TabIndex = 22;
            this.lblSalaryOffer.Text = "salary offer";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(374, 232);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(126, 28);
            this.lblDesignation.TabIndex = 21;
            this.lblDesignation.Text = "Designation :";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(374, 191);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(148, 28);
            this.lblCompanyName.TabIndex = 20;
            this.lblCompanyName.Text = "CompanyName";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualification.Location = new System.Drawing.Point(374, 150);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(120, 28);
            this.lblQualification.TabIndex = 19;
            this.lblQualification.Text = "qualification";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(289, 565);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(49, 28);
            this.lbl12.TabIndex = 17;
            this.lbl12.Text = "Pdf :";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(264, 526);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(74, 28);
            this.lbl11.TabIndex = 16;
            this.lbl11.Text = "Audio :";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(266, 486);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(72, 28);
            this.lbl10.TabIndex = 15;
            this.lbl10.Text = "Video :";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(223, 389);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(115, 28);
            this.lbl9.TabIndex = 14;
            this.lbl9.Text = "Comments :";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(242, 350);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(96, 28);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Location :";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(182, 308);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(156, 28);
            this.lbl7.TabIndex = 12;
            this.lbl7.Text = "Date Of Joining :";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(216, 271);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(123, 28);
            this.lbl6.TabIndex = 11;
            this.lbl6.Text = "Salary Offer :";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(218, 232);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(126, 28);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Designation :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(182, 191);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(162, 28);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Company Name :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(277, 111);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 28);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Date :";
            // 
            // lblPdfPath
            // 
            this.lblPdfPath.AutoSize = true;
            this.lblPdfPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdfPath.Location = new System.Drawing.Point(374, 565);
            this.lblPdfPath.Name = "lblPdfPath";
            this.lblPdfPath.Size = new System.Drawing.Size(45, 28);
            this.lblPdfPath.TabIndex = 7;
            this.lblPdfPath.Text = "Pdf ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(374, 111);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateName.Location = new System.Drawing.Point(374, 74);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(179, 28);
            this.lblCandidateName.TabIndex = 5;
            this.lblCandidateName.Text = "Candidate Name ....";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(177, 74);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 28);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Candidate Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "View Testimonial ";
            // 
            // frmViewTestimonial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 1037);
            this.Controls.Add(this.AudioPlayer);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblAudioPath);
            this.Controls.Add(this.lblVideoPath);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDateOfJoining);
            this.Controls.Add(this.lblSalaryOffer);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPdfPath);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCandidateName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmViewTestimonial";
            this.Text = "frmViewTestimonial";
            ((System.ComponentModel.ISupportInitialize)(this.AudioPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private AxWMPLib.AxWindowsMediaPlayer AudioPlayer;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private Siticone.UI.WinForms.SiticoneImageButton btnPdf;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClose;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblAudioPath;
        private System.Windows.Forms.Label lblVideoPath;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDateOfJoining;
        private System.Windows.Forms.Label lblSalaryOffer;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblQualification;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow2;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPdfPath;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lbl1;
        private Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool siticoneCreditCardValidationTool1;
        private System.Windows.Forms.Label label1;
    }
}