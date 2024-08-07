using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementA1
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling frmallproduct from here
            frmAllProduct objFp= new frmAllProduct();
            objFp.MdiParent = this;
            objFp.Show();
        }

        private void orderdProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // calling frmOderProducts here 
            frmOrderedPrd objFp= new frmOrderedPrd();   
            objFp.MdiParent = this;
            objFp.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout calling login form 
            Login objLogin=new Login();
            objLogin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
