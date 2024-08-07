using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProjectWatchlist1
{
    public partial class Home : Form
    {
        SqlConnection conn =new SqlConnection("Data Source=PRIME;Initial Catalog=WatchList;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adpt=new SqlDataAdapter("select *from tblOngoingth", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            grdongoingt.DataSource = dt;
            grdongoingt.Show();
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(cmbbxGenre.SelectedItem)
            {//Anime KCdrama Indian Hollywood
                case "Anime":
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblOngoingth\r\nSELECT * FROM tblAniAnimation\r\nWHERE AniId='"+txtonid.Text+"' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    break;
                case "KCdrama":
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO tblOngoingth\r\nSELECT * FROM tblKCdrama\r\nWHERE DramaId='" + txtonid.Text + "' ", conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    break;
                case "Indian":
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO tblOngoingth\r\nSELECT * FROM tblIndian\r\nWHERE BollyId='" + txtonid.Text + "' ", conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    break;
                case "Hollywood":
                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tblOngoingth\r\nSELECT * FROM tblHollywood\r\nWHERE Hollyid='" + txtonid.Text + "' ", conn);
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                    break;
                default:
                    break;
            }



        }
    }
}
