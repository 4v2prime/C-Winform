using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Otp
{
    public partial class frmForgotPassword : Form
    {
        private Form loginForm;
        private string otpCode;
        private int timeLeft;
        public frmForgotPassword(frmLogin objLogin,string email)
        {
            InitializeComponent();
            this.loginForm = objLogin;
           txtEmail.Text = email;
            otpTimer.Interval = 1000;
            otpTimer.Tick += OtpTimer_Tick;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string recipientEmail = txtEmail.Text;

            if (IsValidEmail(recipientEmail))
            {
                otpCode = GenerateOtp();
                bool result = SendEmail(recipientEmail, otpCode);

                if (result)
                {
                    lblStatus.Text = "OTP sent successfully!";
                    btnVerify.Enabled = true;
                    StartOtpTimer();
                }
                else
                {
                    lblStatus.Text = "Failed to send OTP.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid email address.";
            }

        }
        /// <summary>
        /// mthode for generating otp 
        /// </summary>
        /// <returns></returns>
        private string GenerateOtp()
        {
            // Generate a 6-digit OTP
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        /// <summary>
        /// method for sending the email to mail
        /// </summary>
        /// <param name="toEmail"></param>
        /// <param name="otp"></param>
        /// <returns></returns>
        private bool SendEmail(string toEmail, string otp)
        {
            try
            {
                // Sender's email credentials
                string fromEmail = "7arc.prime@gmail.com";
                string password = "tnjq qbyy yxqq mjww";

                // Email message setup
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromEmail);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = "Otp for the Prime Solutions";
                message.Body = OTPMSG() +"\r\n"+ $"Your OTP is: {otp}";

                // SMTP client configuration
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, password);
                smtp.EnableSsl = true;

                // Send email
                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}");
                txtOTP.Text = ex.ToString();
                return false;
            }
        }
        /// <summary>
        /// method for validating the email id
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// this method is for the making the message 
        /// </summary>
        /// <returns></returns>
        public string OTPMSG()
        {
            string message = "Hello sir/ma'am," + "\r\n"
               + "Your One-Time Password has been shared here," + "\r\n"
               + "Please verify the OTP on our website to set a new password." + Environment.NewLine
               + "Thanks for being here!";

            return message;
        }
        /// <summary>
        /// this event is used to verify the otp and go back to mail form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOTP.Text == otpCode)
                {
                    MessageBox.Show("Verified successfully..!", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    frmLogin objlog = new frmLogin();
                    objlog.mail = txtEmail.Text;
                    this.Close();
                    loginForm.Show();
                }
                else
                {

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error"+ex);
            }

        }
        /// <summary>
        /// this methode is for starting the timer
        /// </summary>
        private void StartOtpTimer()
        {
            timeLeft = 180;
            otpTimer.Start(); 
        }
        /// <summary>
        /// this methode is for the timer to tick and make logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtpTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; 
                lblStatus.Text = $"Please wait {timeLeft / 60:D2}:{timeLeft % 60:D2} minutes before resending OTP.";
                btnSendMail.Enabled = false;
            }
            else
            {
                otpTimer.Stop(); 
                lblStatus.Text = "You can now resend the OTP.";
                btnSendMail.Enabled = true;
            }
        }

        private void txtOTP_Enter(object sender, EventArgs e)
        {
            txtOTP.Text = null;
        }
    }
}
