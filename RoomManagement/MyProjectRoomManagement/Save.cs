using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyProjectRoomManagement
{
    public partial class Save : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=RoomManagement;Integrated Security=True");
        public Save()
        {
            InitializeComponent();
        }
        public Save(int id) { }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void Save_Load(object sender, EventArgs e)
        {
            clsRoomMange objfetch = new clsRoomMange();
            DataTable dt = new DataTable();
            dt = objfetch.NameFetches();
            cmbbxPerson.DisplayMember="Name";
            cmbbxPerson.ValueMember = "ID";
            cmbbxPerson.DataSource = dt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // DateTime date=new DateTime();
            int typeId = Convert.ToInt32(cmbbxPerson.SelectedValue.ToString());
            clsRoomMange objSave = new clsRoomMange(typeId,cmbbxItems.SelectedItem.ToString(),Convert.ToInt32(txtCost.Text));
            objSave.SaveData();
            MessageBox.Show("Saved Successfully...!");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
       
        private void cmbbxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxPerson.SelectedItem = string.Empty;
            cmbbxItems.SelectedItem = string.Empty;
            txtCost.Text= string.Empty;
        }
    }
}
