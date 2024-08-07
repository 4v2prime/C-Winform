using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_ShopManagement
{
    public partial class frmOrder_Product : Form
    {
        public frmOrder_Product()
        {
            InitializeComponent();

        }

        private void frmOrder_Product_Load(object sender, EventArgs e)
        {
            clsShopManage objs1= new clsShopManage();
            DataTable dt=new DataTable();
            dt = objs1.FetchOrdAdm();
            grdOrderProduct.DataSource= dt;
            grdOrderProduct.Show();
           
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtsbyn.Text = string.Empty;txtsbyp.Text = string.Empty;
            clsShopManage objs2 = new clsShopManage();
            DataTable dt1 = new DataTable();
            dt1 = objs2.FetchOrdAdm();
            grdOrderProduct.DataSource = dt1;
            grdOrderProduct.Show();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
        //cell click event here
        public int OId { get; set; }
       
        private void txtsbyn_TextChanged(object sender, EventArgs e)
        {
            // search by name from 
            // (grdOrderProduct.DataSource as DataTable).DefaultView.RowFilter = string.Format("UName like'{0}'", txtsbyn.Text);
            (grdOrderProduct.DataSource as DataTable).DefaultView.RowFilter = string.Format("UName LIKE '{0}%'", txtsbyn.Text);
        }

        private void txtsbyp_TextChanged(object sender, EventArgs e)
        {
            //search by product 
            (grdOrderProduct.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName like'{0}%'",txtsbyp.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //deleting the checked rows from the datagridview
            List<Tuple<int, int>> DelRow = new List<Tuple<int, int>>();

            foreach (DataGridViewRow row in grdOrderProduct.Rows)
            {
                //checking if the checkbox of that row is checked
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                //condition to check its not null
                if(checkBoxCell != null&& Convert.ToBoolean(checkBoxCell.Value))
                {
                    int rowIndex = row.Index;
                    int id = Convert.ToInt32(row.Cells["OId"].Value);
                    DelRow.Add(Tuple.Create(rowIndex, id));
                }
            }
           // MessageBox.Show("Removed successfully..!");
            // Remove the selected rows from the DataGridView
            for (int i = DelRow.Count - 1; i >= 0; i--)
            {
                int rowIndex = DelRow[i].Item1;
                int id = DelRow[i].Item2;
                grdOrderProduct.Rows.RemoveAt(rowIndex);
                //create the class instance here to change the order status 
                clsShopManage objup = new clsShopManage(id);
                objup.UpOrd();
            }
        }
        //cell content click event here
        private void grdOrderProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdOrderProduct.Columns["Offer"].Index && e.RowIndex >= 0 && grdOrderProduct.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                int OId = Convert.ToInt32(grdOrderProduct.Rows[e.RowIndex].Cells["OId"].Value.ToString());
                string product = grdOrderProduct.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                int price = Convert.ToInt32(grdOrderProduct.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString());
                frmOffer objoffer = new frmOffer(OId, product, price);
                objoffer.Show();
            }
        }
    }
}
