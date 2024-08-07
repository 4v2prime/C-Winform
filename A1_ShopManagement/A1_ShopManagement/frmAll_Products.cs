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
    public partial class frmAll_Products : Form
    {
        public frmAll_Products()
        {
            InitializeComponent();
        }
        //getting the product informating 
        private void frmAll_Products_Load(object sender, EventArgs e)
        {
            clsShopManage objad = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objad.AllPrd();
            grdAllproduct.DataSource = dt;
            grdAllproduct.Show();
        }

        private void txtsbyp_TextChanged(object sender, EventArgs e)
        {
            //search by product 
            (grdAllproduct.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName like'{0}%'", txtsbyp.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // refrech code
            clsShopManage objad = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objad.AllPrd();
            grdAllproduct.DataSource = dt;
            grdAllproduct.Show();
        }
    }
}
