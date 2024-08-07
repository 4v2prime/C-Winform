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
    public partial class frmP_Type : Form
    {
        public frmP_Type()
        {
            InitializeComponent();
        }

        private void frmP_Type_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsShopManage objTypesave = new clsShopManage(txtType.Text);
            objTypesave.TypeSave();
            MessageBox.Show("Type saved Successfully..!");
        }
    }
}
