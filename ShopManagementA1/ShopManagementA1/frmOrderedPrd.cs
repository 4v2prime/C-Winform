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
    public partial class frmOrderedPrd : Form
    {
        public frmOrderedPrd()
        {
            InitializeComponent();
        }

        private void frmOrderedPrd_Load(object sender, EventArgs e)
        {
            clsShopManage objop= new clsShopManage();
            DataTable dt = new DataTable();
            dt = objop.OderedProduct();
            grdorderproducts.DataSource = dt;
            grdorderproducts.Show();
        }
    }
}
