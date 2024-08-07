using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A1_ShopManagement
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=ShopManagement;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objLog=new frmLogin();
            objLog.MdiParent = this;    
            objLog.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser_Register objUserReg = new frmUser_Register();
            objUserReg.MdiParent = this;
            objUserReg.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP_Type objType=new frmP_Type();
            objType.MdiParent = this;
            objType.Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmP_Product objProduct = new frmP_Product();
            objProduct.MdiParent = this;
            objProduct.Show();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP_Size objSize=new frmP_Size();
            objSize.MdiParent = this;
            objSize.Show();
        }
    }
}
