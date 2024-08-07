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
using System.Xml.Linq;

namespace ShopManagementA1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsShopManage objLogin= new clsShopManage(cmbbxType.SelectedItem.ToString(),txtEmail.Text,txtPassword.Text);
            SqlDataReader dr = objLogin.Login();
            
            if (dr.Read()) 
            {
                string userId = dr["UserId"].ToString();
                string name = dr["Name"].ToString();
                Order objOder = new Order(userId,name,txtEmail.Text);
                MessageBox.Show("Login Successfully..!");
                if (cmbbxType.Text == "Customer")
                {
                    objOder.Show();
                }
                else if (cmbbxType.Text == "Admin") { frmAdminLogin objal =new frmAdminLogin();objal.Show(); }
            }
           
            else { MessageBox.Show("Login Failed...!"); }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text=string.Empty;txtEmail.Text=string.Empty;txtPassword.Text=string.Empty;
        }
    }
}
