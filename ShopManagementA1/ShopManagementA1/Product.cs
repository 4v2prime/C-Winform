using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementA1
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        public string PType { get; set; }
        public Product(string type) {PType=type; }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManage objPsave =new clsShopManage(TypeId,txtProduct.Text);
            objPsave.PrdSave();
            frmSize frmSize = new frmSize();
            frmSize.Show();
            MessageBox.Show("Product saved Successfully..!");
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // i need to fetch the tblPType so i can save it's type id to the product table 
            clsShopManage objFetchptype = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objFetchptype.FetchPtype();
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.DataSource = dt;
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            txtProduct.Text= string.Empty;
        }
    }
}
