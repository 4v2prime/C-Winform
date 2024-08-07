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
    public partial class frmAllProduct : Form
    {
        public frmAllProduct()
        {
            InitializeComponent();
        }

        private void frmAllProduct_Load(object sender, EventArgs e)
        {
            //fetch all product data table here through class 
            clsShopManage objalldata= new clsShopManage();
            DataTable dt = new DataTable();
            dt=objalldata.AllProduct();
            grdAppProduct.DataSource = dt;
            grdAppProduct.Show();
            

        }
    }
}
