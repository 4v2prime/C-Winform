using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace ShopManagementA1
{
    public class clsShopManage
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=ShopManagement;Integrated Security=True");
        public string UserType { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserGender { get; set; }
        public string UserContry { get; set; }
        public string UserState { get; set; }
        public string UserCity { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
        public int ProductName { get; set; }
        public string ProductName1 { get; set; }
        public string ProductSize { get; set; }
        public int ProductMRP { get; set; }
        public int ProductPrice { get; set; }
        public int UserId { get; set; }
        public int SizeId { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public clsShopManage(string type, string name, string mail, string gender, string contry, string state, string city, string pass)
        {
            UserType = type;
            UserName = name;
            UserEmail = mail;
            UserGender = gender;
            UserContry = contry;
            UserState = state;
            UserCity = city;
            UserPassword = pass;
        }
        public clsShopManage (string type){ UserType = type; }
        public clsShopManage() { }  
        public clsShopManage(int id,int product,string size,int mrp,int price) 
        {
            ProductTypeId = id;ProductName = product;ProductSize = size;ProductMRP = mrp;ProductPrice = price;
        }
        public clsShopManage(int type) { ProductTypeId= type; }
        public clsShopManage(int id,string name ){ ProductTypeId = id;ProductName1 = name;}
        public clsShopManage(string type,string mail,string pass) { UserType = type;UserEmail = mail;UserPassword = pass; }
        public clsShopManage(int tid,int pid) { ProductTypeId = tid;ProductId = pid; }
        public clsShopManage(int id, int sid, string sts) {UserId= id;Status = sts;SizeId = sid; }
        public void RSaveData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RSaveData");
            cmd.Parameters.AddWithValue("@RType", UserType);
            cmd.Parameters.AddWithValue("@RName", UserName);
            cmd.Parameters.AddWithValue("@REmail", UserEmail);
            cmd.Parameters.AddWithValue("@RGender", UserGender);
            cmd.Parameters.AddWithValue("@RContry", UserContry);
            cmd.Parameters.AddWithValue("@RState", UserState);
            cmd.Parameters.AddWithValue("@RCity", UserCity);
            cmd.Parameters.AddWithValue("@RPassword", UserPassword);
            cmd.ExecuteNonQuery();
            con.Close();    
        }
        public DataTable Alldata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Alldata");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt=new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable AllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AllProduct");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable OderedProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OderProduct");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void TypeSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TypeSave");
            cmd.Parameters.AddWithValue("@RType", UserType);
            cmd.ExecuteNonQuery ();con.Close();
        }
        public void PrdSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PrdSave");
            cmd.Parameters.AddWithValue("@PTypeId",ProductTypeId);
            cmd.Parameters.AddWithValue("@PPName", ProductName1);
            cmd.ExecuteNonQuery ();con.Close();
        }
        public DataTable FetchPtype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPType");
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            adp.Fill(dt2);
            return dt2;
            con.Close();
        }
        public DataTable FetchPrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchP1");
            cmd.Parameters.AddWithValue("@PTypeId",ProductTypeId);
            SqlDataAdapter adpt4= new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();adpt4.Fill(dt3);con.Close(); return dt3;
        }
        public SqlDataReader PTotal()
        {//fetching the total for txttotal form order form by the datagridviews event input cellclick 
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PTotal");
            cmd.Parameters.AddWithValue("@PSizeId", ProductTypeId);
            SqlDataReader dr = cmd.ExecuteReader();
            ;return dr;con.Close();
        }
        public DataTable FetchProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchProduct");
            cmd.Parameters.AddWithValue("@PTypeId", ProductTypeId);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();adp.Fill(dt);return dt; con.Close();
        }
        public DataTable FetchSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchSize");
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();adp.Fill(dt);return dt; con.Close();
        }
        ///heeeeeeee
        public DataTable FetchSizeGRD() 
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SizeGRD");
            cmd.Parameters.AddWithValue("@PTypeId",ProductTypeId); cmd.Parameters.AddWithValue("@PId",ProductId);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand= cmd;
            DataTable dt = new DataTable();adp.Fill(dt);return dt; con.Close();
        }
        public void ProductSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ProductSave");
            cmd.Parameters.AddWithValue("@PTypeId", ProductTypeId);
            cmd.Parameters.AddWithValue("@PPName", ProductName);
            cmd.Parameters.AddWithValue("@PPSize", ProductSize);
            cmd.Parameters.AddWithValue("@PPmrp", ProductMRP);
            cmd.Parameters.AddWithValue("@PPprice", ProductPrice);
            cmd.ExecuteNonQuery();con.Close();
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UserLogin");
            cmd.Parameters.AddWithValue("@RType", UserType); cmd.Parameters.AddWithValue("@REmail", UserEmail); cmd.Parameters.AddWithValue("@RPassword", UserPassword);
            SqlDataReader dr=cmd.ExecuteReader();
            return dr;
        }
       public void OrderConfirm()
        {
            // fro inserting data of order confirmed on order page 
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","OrderConfirm");
            DateTime currentDateTime = DateTime.Now;
            cmd.Parameters.AddWithValue("@RId",UserId); cmd.Parameters.AddWithValue("@PSizeId", SizeId); cmd.Parameters.AddWithValue("@OStatus",Status); cmd.Parameters.AddWithValue("@ODate", currentDateTime);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }
}
