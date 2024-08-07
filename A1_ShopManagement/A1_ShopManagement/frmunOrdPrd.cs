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
    public partial class frmunOrdPrd : Form
    {
        public frmunOrdPrd()
        {
            InitializeComponent();
        }

        private void frmunOrdPrd_Load(object sender, EventArgs e)
        {
            // unorder product feching here 
            clsShopManage objun=new clsShopManage();    
            DataTable dt = new DataTable();
            dt = objun.UnOrdPrd();
            grdunOrdPrd.DataSource= dt;
            grdunOrdPrd.Show();
        }
    }
}
