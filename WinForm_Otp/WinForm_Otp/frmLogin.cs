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
    public partial class frmLogin : Form
    {
        public string mail;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (mail!=null)
            {
                txtEmail.Text= mail;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Failed..!","Invalid Password",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void lnklblForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword obj = new frmForgotPassword(this,txtEmail.Text);
            this.Hide();
            obj.Show();
        }
    }
}
