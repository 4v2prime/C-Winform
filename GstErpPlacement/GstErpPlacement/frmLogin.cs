using lblGstErpPlacement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Siticone.UI.HtmlRenderer.Adapters.RGraphicsPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GstErpPlacement
{
    public partial class frmLogin : Form
    {
        private object errorProvider1;
        public string StaffName { get; set; }
        public string StaffCode { get; set; }
        public string EmailID { get; set; }
        public string StaffPosition { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //frmForgotPassword frmForgotPassword = new frmForgotPassword();
            //frmForgotPassword.Show();
            //this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsLogin obj=new clsLogin();
            DataTable dt = new DataTable();
            dt = obj.StaffPositionFunc();

            foreach (DataRow dr in dt.Rows)
            {
                cmbbxType.Items.Add(dr["StaffPosition"].ToString());
                cmbbxType.Text = "Placement Co-ordinator";
                cmbbxType.Visible = false;

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = "";
            string Password = "";
            bool validUser = false;
           
            clsLogin obj = new clsLogin();
           
            obj.OfficialEmailId = txtUserName.Text;
            obj.Password = txtPassword.Text;
            clsLogin objLogin = new clsLogin(obj);
            DataTable dt = objLogin.LoginValidation();

            //Show Count of matcing values and StaffCode
            foreach (DataRow dr in dt.Rows)
            {
                StaffName = (dr["StaffName"].ToString());
                StaffCode = dr["StaffCode"].ToString();
                EmailID = dr["OfficialEmailId"].ToString();
                BranchName = dr["BranchName"].ToString();
                BranchCode = dr["BranchCode"].ToString();
            }
            //After Succesful login we gonna see LockProfile on Dashboard.
            if(cmbbxType.SelectedItem.ToString() == "Placement Co-ordinator")
            {
                if (EmailID == txtUserName.Text)
                {
                    DialogResult= MessageBox.Show("LogIn Succesfull..!","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                    if (DialogResult==DialogResult.OK) 
                    {
                        clsExam sendStaffcode = new clsExam();
                        sendStaffcode.LoginStaffCode = StaffCode;
                        sendStaffcode.clsBranchName = BranchName;
                        sendStaffcode.clsBranchCode = BranchCode;

                        //Lock Profile
                        frmExam obutton = new frmExam();
                        obutton.LogedStaffCodeExam = StaffCode;
                        obutton.ExamBranchName= BranchName;
                        obutton.ExamBranchCode= BranchCode;
                        obutton.Show();
                        
                    }
                    else { }
                    
                }
                else
                {
                    MessageBox.Show("Invalid User: LogIn failed");
                }
            }
           
            //Error Provider
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Enter UserName");
                errorProvider2.SetError(txtUserName, "Please Enter the UserName");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Password");
                errorProvider2.SetError(txtPassword, "Please Enter the Passwword");
                return;
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            bool hasCapitalLetter = password.Any(char.IsUpper);
            bool hasSpecialCharacter = !string.IsNullOrWhiteSpace(password) && password.Any(ch => !char.IsLetterOrDigit(ch));
            bool hasNumber = password.Any(char.IsDigit);
            bool isLengthValid = password.Length >= 6 && password.Length <= 14;
            
            //Validating condition for Password
            if (hasCapitalLetter && hasSpecialCharacter && hasNumber && isLengthValid)
            {
                btnLogin.Enabled = true;
                lblValidationMessage.Visible = true;
                lblValidationMessage.Text = "Password is valid";
            }
            else
            {
                btnLogin.Enabled = false;
                lblValidationMessage.Visible = true;
                lblValidationMessage.Text = "Password should contain at least one capital letter, one number, one special character, and be 8 to 14 characters long.";
            }
        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string email = txtUserName.Text.Trim();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValidEmail = Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

        //UserName is valid
            if (isValidEmail)
            {
                btnLogin.Enabled = true;
                lblEmailvalidation.Visible = false;
            }
        //UserName is Invalid
            else
            {
                btnLogin.Enabled = false;
                lblEmailvalidation.Visible = true;
                lblEmailvalidation.Text = "Please enter a valid email address";
            }
        }

        //Enter Event for UserName
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text =="UserName")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor= Color.Black;
            }
        }

        //Leave Event for UserName
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text =="")
            {
                txtUserName.Text = "UserName";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        //Enter Event for Password
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        //Leave Event for Password
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        //CheckChanged Event For CheckBox
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if(Check.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;   
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;  
            }
        }
        //Validating Event For UserName(Errorrovider)
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text != "")
            {
                string email = txtUserName.Text;
                if (!email.Contains("@") || !email.Contains("."))
                {
                    //MessageBox.Show("Email Address is not in correct format");
                    errorProvider2.SetError(txtUserName, "Email Address is not in correct Format");
                    return;
                }
                errorProvider2.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Up Email ");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
