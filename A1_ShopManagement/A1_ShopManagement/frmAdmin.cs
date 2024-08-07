using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_ShopManagement
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            IsMdiContainer=true;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            clsShopManage objallp = new clsShopManage();

        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAll_Products obj1= new frmAll_Products();   
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void orderdProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder_Product obj1= new frmOrder_Product();
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objLog = new frmLogin();
            objLog.MdiParent = this;
            objLog.Show();
            this.Close();
        }

        private void unorderedProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmunOrdPrd objun=new frmunOrdPrd();
            objun.MdiParent = this;
            objun.Show();
        }

        private void unorderdCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnordCust objuncus=new frmUnordCust();
            objuncus.MdiParent = this;
            objuncus.Show();
        }
    }
}
