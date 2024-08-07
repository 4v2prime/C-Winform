using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementA1
{
    public partial class Type : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=ShopManagement;Integrated Security=True");
        public Type()
        {
            InitializeComponent();
        }

        private void Type_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            clsShopManage objTypesave = new clsShopManage(txtType.Text);
            objTypesave.TypeSave();
            Product objP = new Product(); objP.Show();
            MessageBox.Show("Type saved Successfully..!");

        }
    }
}
