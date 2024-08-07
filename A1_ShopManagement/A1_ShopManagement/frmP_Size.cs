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
    public partial class frmP_Size : Form
    {
        public frmP_Size()
        {
            InitializeComponent();
        }

        private void frmP_Size_Load(object sender, EventArgs e)
        {
            //fetch type for sise page 
            clsShopManage objFetchptype = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objFetchptype.FetchPType();
            cmbbxType.DisplayMember = "ProductType";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // depending on type the product should apear here
            int type = Convert.ToInt32(cmbbxType.SelectedValue);
            clsShopManage objfp = new clsShopManage(type);
            DataTable dt3 = new DataTable();
            dt3 = objfp.FetchPrd();
            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember = "ProductNameId";
            cmbbxProduct.DataSource = dt3;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // saving the data of product on size page to tblSize through method PrdSave
            int Tid = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int Pid = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            clsShopManage objpsave = new clsShopManage(Tid, Pid, txtSize.Text, Convert.ToInt32(txtMRP.Text), Convert.ToInt32(txtPrice.Text));
            objpsave.SizeSave();
            MessageBox.Show("Product Registerd Successfully..!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            cmbbxProduct.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtMRP.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }
    }
}
