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
    public partial class frmP_Product : Form
    {
        public frmP_Product()
        {
            InitializeComponent();
        }

        private void frmP_Product_Load(object sender, EventArgs e)
        {
            //need to fetch the types svaed in tbltype in database to combobox
            //using fetch methode for that
            clsShopManage objFetchptype = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objFetchptype.FetchPType();
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DisplayMember = "ProductType";
            cmbbxType.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManage objPsave = new clsShopManage(TypeId, txtProduct.Text);
            objPsave.PrdSave();
            MessageBox.Show("Product saved Successfully..!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;txtProduct.Text = string.Empty;
        }
    }
}
