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

namespace MyProjectWatchlist1
{
    public partial class ckDrama : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=WatchList;Integrated Security=True");
        public ckDrama()
        {
            InitializeComponent();
        }

        private void ckDrama_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adp=new SqlDataAdapter("select *from tblKCdrama", conn);
            DataTable dt = new DataTable(); 
            adp.Fill(dt);
            grdAniView.DataSource = dt;
            grdAniView.Show();
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblKCdrama values ('"+txtName.Text+"','"+txtEpisodes.Text+"','"+txtIMDB.Text+"','"+txtLink.Text+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved Successfully...!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tblKCdrama set DramaNames='"+txtName.Text+"',DramaEpisodes='"+txtEpisodes.Text+"',DramaIMDB='"+txtIMDB.Text+"',DramaLink='"+txtLink.Text+"' where DramaId='"+txtId.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Successfully...!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete tblKCdrama where DramaId='"+txtId.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Successfully...!");
        }
    }
}
