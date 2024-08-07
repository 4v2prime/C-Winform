using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_ShopManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // password validation here need to be done
            int passlen = txtPassword.Text.Length;
            if (passlen < 6)
            {
                MessageBox.Show("Invalid Password...!");
            }
            else
            {
                clsShopManage objLogin = new clsShopManage(cmbbxType.SelectedItem.ToString(), txtEmail.Text, txtPassword.Text);
                SqlDataReader dr = objLogin.Login();

                if (dr.Read())
                {
                    //validation 
                    MessageBox.Show("Login Successfully..!");
                    //login as customer
                    if (cmbbxType.Text == "Customer")
                    {
                        int uid = (int)dr["UserId"];
                        string name = dr["UName"].ToString();
                        frmOrder objOder = new frmOrder(uid, name, txtEmail.Text);
                        objOder.Show();

                    }
                    //login as admin
                    else if (cmbbxType.Text == "Admin")
                    {
                        frmAdmin objal = new frmAdmin();
                        objal.Show();

                    }
                }

                else { MessageBox.Show("Login Failed...!"); }
            }
        }
        //btn clear code 
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty; 
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //email validation
            string mail = txtEmail.Text;
            if (mail.Contains("@") && mail.EndsWith(".com"))
            {
               
            }
            else
            {
                MessageBox.Show("Invalid Email...!");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
            //type validation
            if(cmbbxType.Text == string.Empty)
            {
                MessageBox.Show("Please Select Type..");
            }
        }
    }
}
