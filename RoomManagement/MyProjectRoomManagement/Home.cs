using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyProjectRoomManagement
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=RoomManagement;Integrated Security=True");
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {


            //fetch data of selected cmmbxperson into datagridview person id will go out from textbox
            
            //for total expense of month 
           
           //also for total of selected pwerson use diffesnt cmd/fetch method in load 
            con.Open();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void grdView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(cmbbxid.SelectedItem.ToString());
            clsRoomMange objgrd = new clsRoomMange(typeid);
            DataTable dt1 = new DataTable();
            dt1 = objgrd.FetchpData();
            grdViewhome.DataSource = dt1;
            grdViewhome.Show();
            grdViewhome.Refresh();
         
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(cmbbxid.SelectedItem.ToString());
            clsRoomMange objTotal =new clsRoomMange(typeid);
            SqlDataReader dr = objTotal.TotalSum();
            while (dr.Read()) { lblTotal.Text = dr["TotalCost"].ToString(); }
            dr.Close();
        }

        private void cmbbxid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(cmbbxid.SelectedItem.ToString());
            clsRoomMange objgrd = new clsRoomMange(typeid);
            DataTable dt1 = new DataTable();
            dt1 = objgrd.FetchpData();
            grdViewhome.DataSource = dt1;
            grdViewhome.Show();
            grdViewhome.Refresh();
            //
            clsRoomMange objSname = new clsRoomMange(typeid);
            SqlDataReader dr = objSname.SNameFetch();
            while (dr.Read()) { txtperson.Text = dr["Name"].ToString(); }
            // calculatin total
            int typed = Convert.ToInt32(cmbbxid.SelectedItem.ToString());
            clsRoomMange objTotal = new clsRoomMange(typed);
            SqlDataReader dr1 = objTotal.TotalSum();
            while (dr1.Read()) { lblTotal.Text = dr["TotalCost"].ToString(); }
            dr.Close();
        }
    }
}
