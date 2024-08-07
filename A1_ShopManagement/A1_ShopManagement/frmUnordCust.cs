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
    public partial class frmUnordCust : Form
    {
        public frmUnordCust()
        {
            InitializeComponent();
        }

        private void frmUnordCust_Load(object sender, EventArgs e)
        {
            // unorder customer details fetching here
            clsShopManage objun=new clsShopManage();
            DataTable dt = new DataTable();
            dt = objun.UnOrdCust();
            grdUnOrdCust.DataSource = dt;
            grdUnOrdCust.Show();
        }
    }
}
