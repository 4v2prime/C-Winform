using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace A1_ShopManagement
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        //getingt the user values from the login page
        public int UId {  get; set; }
        // making property for mrpfor order purpose
        public int PrdMRP { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public frmOrder(int id,string name,string mail) 
        { 
            InitializeComponent();
            PrdMRP = 0;
            UId = id;
            UserName = name;
            UserEmail = mail;
            lblUName.Text = name;
            lblUEmail.Text = mail;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            //fething type for comboox 
            clsShopManage objFthType = new clsShopManage();
            DataTable dt = new DataTable();
            dt = objFthType.FetchPType();
            cmbbxType.DisplayMember = "ProductType";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
            //creating the column for the listview so it can show the structure
            lstvwCart.Columns.Add("Type",60);
            lstvwCart.Columns.Add("Product", 80);
            lstvwCart.Columns.Add("SizeId", 40);
            lstvwCart.Columns.Add("Size", 50);
            lstvwCart.Columns.Add("Price", 60);
        }
        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fething the prodcucts based on the types 
            int Tid = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManage objs1 = new clsShopManage(Tid);
            DataTable dt = new DataTable();
            dt = objs1.FetchPrd();
            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember = "ProductNameId";
            cmbbxProduct.DataSource = dt;
        }
        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fetching size tbl values size id and size name for gridview 
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int Pid = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            clsShopManage objgrd = new clsShopManage(TypeId, Pid);
            DataTable dt = objgrd.FetchSizeGRD();
            grdSize.DataSource = dt; grdSize.Show();
        } 
        private void grdSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // calculate the total based on which size user chooses
            string CName = grdSize.Rows[e.RowIndex].Cells["ProductSize"].Value.ToString();
            int sizeId = Convert.ToInt32(grdSize.Rows[e.RowIndex].Cells["SizeId"].Value);
            clsShopManage objTotal = new clsShopManage(sizeId);
            SqlDataReader dr;
            dr = objTotal.PTotal();
            while (dr.Read())
            { 
                lbliprice.Text = dr["ProductPrice"].ToString();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //logout button code incomplete
            frmLogin objLog = new frmLogin();
            objLog.Show();
            this.Close();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // code for clear button 
            lbliprice.Text = string.Empty;
            cmbbxProduct.Text = string.Empty;
            cmbbxType.Text = string.Empty;
            grdSize.DataSource = null; grdSize.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adding item to listview here
            ListViewItem item = new ListViewItem(cmbbxType.Text);
            item.SubItems.Add(cmbbxProduct.Text);
            item.SubItems.Add(grdSize.Rows[grdSize.CurrentRow.Index].Cells["SizeId"].Value.ToString());
            item.SubItems.Add(grdSize.Rows[grdSize.CurrentRow.Index].Cells["ProductSize"].Value.ToString());
            item.SubItems.Add(lbliprice.Text);
            lstvwCart.Items.Add(item);
            lstvwCart.Columns[2].Width = 0;
            //
            // all the total of buyed products from order page
            int columnIndexToSum = 4;
            int total = 0;
            foreach (ListViewItem item1 in lstvwCart.Items)
            {
                int value;
                if (int.TryParse(item.SubItems[columnIndexToSum].Text, out value)) 
                {
                    total += value;
                }
            }
            lbltotal.Text = total.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //code for removing cart items error here
            if (lstvwCart.SelectedItems.Count > 0) 
            {
                lstvwCart.Items.Remove(lstvwCart.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select item to delete..!");
            }
            // all the total of buyed products from order page
            int columnIndexToSum = 4;
            int total = 0;
            foreach (ListViewItem item1 in lstvwCart.Items)
            {
                int value;
                if (int.TryParse(item1.SubItems[columnIndexToSum].Text, out value)) 
                {
                    total += value;
                }
            }
            lbltotal.Text = total.ToString();
        }
        //order confirmed button
        private void button1_Click(object sender, EventArgs e)
        {
            //saving the data from the listview to tblOrder for
            if (lstvwCart.Items.Count != 0) 
            {
                foreach (ListViewItem item in lstvwCart.Items)
                {
                    string columnValue = item.SubItems[2].Text;
                    //double i = 0;
                    if (int.TryParse(columnValue, out int sid))
                    {

                    }
                    clsShopManage objOrder = new clsShopManage(UId, sid, "Confirmed");
                    objOrder.OrderSave();

                }
                MessageBox.Show("Order Confirmed..!");
            }
            else
            {
                MessageBox.Show("Please select at least one product.");
            }
           

        }
       
        private void lstvwCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grpbxCart_Enter(object sender, EventArgs e)
        {

        }
    }
}
