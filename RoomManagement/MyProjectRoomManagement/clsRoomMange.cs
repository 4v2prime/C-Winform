using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Data.SqlTypes;

namespace MyProjectRoomManagement
{
    public class clsRoomMange
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=RoomManagement;Integrated Security=True");
       // public int BDate { get; set; }
        public int BName { get; set; }
        public string BItem { get; set; }
        public int BCost { get; set; }
        public clsRoomMange(int name,string item,int cost)
        {
           
            BName = name;
            BItem = item;
            BCost = cost;

        }
        public clsRoomMange(int name) { BName = name; }
        public clsRoomMange() { }

        public void SaveData() 
        {
            con.Open();
            DateTime currentDateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveData");
            cmd.Parameters.AddWithValue("@UDate", currentDateTime);
            cmd.Parameters.AddWithValue("@UPerson",BName);
            cmd.Parameters.AddWithValue("@UItem",BItem);
            cmd.Parameters.AddWithValue("@UCost",BCost);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteData() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","DeleteData");
            cmd.Parameters.AddWithValue("@UPerson",BName);
            cmd.ExecuteNonQuery ();
            con.Close();
        }
        public SqlDataReader TotalSum() 
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Total");
            cmd.Parameters.AddWithValue("@UPerson", BName);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
               
        }
        public DataTable NameFetches()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "NameFetches");
            SqlDataAdapter adpt=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        public DataTable FetchpData()
        {
         //sql la selected persons data will be show or fetched
            con.Open();
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPerson");
            cmd.Parameters.AddWithValue("@UPerson", BName);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            //con.Close();
                
        }
        public SqlDataReader SNameFetch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RoomManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SNameFetches");
            cmd.Parameters.AddWithValue("@UPerson", BName);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
