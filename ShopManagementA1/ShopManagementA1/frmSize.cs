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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tid = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int Pid = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
           // int Sid = Convert.ToInt32(cmbbxSize.SelectedValue.ToString());
            clsShopManage objpsave= new clsShopManage(Tid,Pid,txtSize.Text,Convert.ToInt32(txtMRP.Text),Convert.ToInt32(txtPrice.Text));
            objpsave.ProductSave();
            MessageBox.Show("Product Registerd Successfully..!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            cmbbxProduct.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtMRP.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            clsShopManage objFetchptype = new clsShopManage();
            DataTable dt = new DataTable();
            dt=objFetchptype.FetchPtype();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
            
           
        }

        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////cmbbxSize starts here fetch tblSize
            //clsShopManage objFetchsize = new clsShopManage();
            //DataTable dt2 = new DataTable();
            //dt2 = objFetchsize.FetchSize();
            //cmbbxSize.DisplayMember = "SizeName";
            //cmbbxSize.ValueMember = "SizeId";
            //cmbbxSize.DataSource = dt2;
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
           // fetching the product tbl for combobox on size page 
           int type = Convert.ToInt32(cmbbxType.SelectedValue);
           clsShopManage objfp = new clsShopManage(type);
            DataTable dt3 = new DataTable();
            dt3 = objfp.FetchPrd();
            cmbbxProduct.DisplayMember = "PproductName";
            cmbbxProduct.ValueMember = "ProductNameId";
            cmbbxProduct.DataSource = dt3;
        }
    }
}
