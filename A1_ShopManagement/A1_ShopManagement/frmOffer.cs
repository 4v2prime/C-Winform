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
    public partial class frmOffer : Form
    {
        public frmOffer()
        {
            InitializeComponent();
        }
        // getting the value of product and price 
        public int Price { get; set; }
        public int OrderId { get; set; }
        public string Product { get; set; }
        private void frmOffer_Load(object sender, EventArgs e)
        {
            lblPrice.Text = Convert.ToString(Price);
            lblProduct.Text = Product;
            

        }

        private void grpbxOffer_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalNewPrc_Click(object sender, EventArgs e)
        {
           
            
        }
        // constructor for gaetting the values from the admproduct form
        public frmOffer(int oid, string prd, int prc)
        {
            InitializeComponent();
            OrderId = oid;
            Price = prc;
            Product = prd;
        }
        //update price code here
        private void btnupdate_Click(object sender, EventArgs e)
        {

            int dsco=Convert.ToInt32(txtDiscount.Text);
            if (!(txtDiscount.Text==""))
            {
                clsShopManage objdis = new clsShopManage(OrderId, dsco);
                objdis.SaveDiscount();
                MessageBox.Show("Updated Successfully..!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid discount value. Please enter a valid integer.");
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            // calculation for new price
            int d = Convert.ToInt32(txtDiscount.Text);
            int NewPrice;
            int dis;
            dis = (Price * d) / 100;
            NewPrice = Price - dis;
            txtnewPrc.Text = NewPrice.ToString();
        }
    }
    
}
