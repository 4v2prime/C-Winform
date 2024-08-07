using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopManagementA1
{
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=ShopManagement;Integrated Security=True");
        public string CId { get; set; }
        public string CEmail { get; set; }
        public string CName { get; set; }
        public string currentDateTime { get; set; }
        public Order()
        {
            InitializeComponent();
            DateTime currentDateTime = DateTime.Now;
        }
        public Order(string cid,string CName,string CEmail)
            
        {
            InitializeComponent();
            CId = cid;
            lblUName.Text = CName;
            lblUEmail.Text = CEmail;
           
        }
        
        private void grpbxOrderInfo_Enter(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            
            //fetch name and mail of customer
            clsShopManage objFthType = new clsShopManage();
            DataTable dt = new DataTable();
            dt= objFthType.FetchPtype();
            cmbbxType.DisplayMember = "TypeName"; cmbbxType.ValueMember = "TypeId"; cmbbxType.DataSource = dt;
            //try by geting sqlreder here
           
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Tid = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManage objs1 = new clsShopManage(Tid);
            DataTable dt = new DataTable();
            dt = objs1.FetchPrd();
            cmbbxProduct.DisplayMember = "PproductName"; cmbbxProduct.ValueMember = "ProductNameId"; cmbbxProduct.DataSource = dt;
        }

        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // grid view show give type id and product id to grdview make method and call here
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int Pid=Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            clsShopManage objgrd= new clsShopManage(TypeId,Pid);
            DataTable dt = objgrd.FetchSizeGRD();
            grdSize.DataSource= dt;grdSize.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbliprice.Text=string.Empty;cmbbxProduct.Text = string.Empty;cmbbxType.Text = string.Empty;grdSize.DataSource = null;grdSize.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login objLog = new Login();
            objLog.Show();
        }

        public void grdSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CName = grdSize.Rows[e.RowIndex].Cells["ProductSize"].Value.ToString();
            //clsShopManage j1=new clsShopManage(CName);
            int sizeId = Convert.ToInt32(grdSize.Rows[e.RowIndex].Cells["SizeId"].Value);
            clsShopManage objTotal = new clsShopManage(sizeId,CName);
            SqlDataReader dr;
            dr = objTotal.PTotal();
            while(dr.Read()) { lbliprice.Text = dr["ProductPrice"].ToString(); }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add to cart

        }

        private void lstvwOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        { //i.SubItems.Add(cmbbxType.Text;
            lstvwCart.View = View.Details;
           // lstvwCart.Columns.Add("TypeId", 0);
            lstvwCart.Columns.Add("Type", 1);
            lstvwCart.Columns.Add("Product", 2);
            lstvwCart.Columns.Add("SizeId", 0);
            lstvwCart.Columns.Add("Size", 3);
            lstvwCart.Columns.Add("Price", 4);

            ListViewItem i = new ListViewItem(cmbbxType.Text);
            i.SubItems.Add(cmbbxProduct.Text);
            i.SubItems.Add(grdSize.Rows[grdSize.CurrentRow.Index].Cells["SizeId"].Value.ToString());
            i.SubItems.Add(grdSize.Rows[grdSize.CurrentRow.Index].Cells["ProductSize"].Value.ToString());
            i.SubItems.Add(lbliprice.Text);
            lstvwCart.Items.Add(i);
           // lstvwCart.Columns["SizeId"].Width = 0;
        }

        private void lblnamecart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvwCart.SelectedItems.Count > 0) { lstvwCart.Items.RemoveAt(0); }
            else { MessageBox.Show("Please select item to delete..!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //total botton on the cart page
            int columnIndexToSum = 3;
            int total = 0;
            foreach (ListViewItem item in lstvwCart.Items ) 
            {
                int value;
                if (int.TryParse(item.SubItems[columnIndexToSum].Text, out value)) { total += value; }
            }
            lbltotal.Text = total.ToString();
        }

        private void grdSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //order confirmed data saving unfinished
                      
            MessageBox.Show("Order Confirmed..!");

        }

        private void lstvwCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpbxCart_Enter(object sender, EventArgs e)
        {

        }
    }
}
