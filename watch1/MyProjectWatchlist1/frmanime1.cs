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
    public partial class frmanime1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=WatchList;Integrated Security=True");
        public frmanime1()
        {
            InitializeComponent();
        }

        private void frmanime1_Load(object sender, EventArgs e)
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adpt = new SqlDataAdapter("select *from tblAniAnimation", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            grdAniView.DataSource = dt;
            grdAniView.Show();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblAniAnimation values ('" + txtName.Text + "','" + cmbbxGenre.SelectedItem + "','" + txtIMDB.Text + "','" + txtLink.Text + "')", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Saved Successfully..!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tblAniAnimation set  AniName='"+txtName.Text+"',AniGenre='"+cmbbxGenre.SelectedItem+"',AniIMDB='"+txtIMDB.Text+"',AniLink='"+txtLink.Text+"' where AniId='"+txtId.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Successfully..!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tblAniAnimation where AniId='"+txtId.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Deleted...!");
        }
    }
}
