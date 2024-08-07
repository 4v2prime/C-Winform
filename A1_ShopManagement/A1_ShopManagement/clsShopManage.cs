using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A1_ShopManagement
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
        //UserRegistration code starts here
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
        //login code starts here
        public clsShopManage(string type, string mail, string pass)
        { 
            UserType = type;
            UserEmail = mail;
            UserPassword = pass;
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UserLogin");
            cmd.Parameters.AddWithValue("@RType", UserType);
            cmd.Parameters.AddWithValue("@REmail", UserEmail);
            cmd.Parameters.AddWithValue("@RPassword", UserPassword);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        //type save code
        public clsShopManage(string type) 
        { 
            UserType = type;
        }
        public void TypeSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TypeSave");
            cmd.Parameters.AddWithValue("@RType", UserType);
            cmd.ExecuteNonQuery(); con.Close();
        }
        //fetching saved types for the combox on product page
        public clsShopManage() { }
        public DataTable FetchPType()
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
        // product save code
        public int PrdTId { get;set; }
        public string PrdName { get; set; }
        public clsShopManage(int id,string Name) {PrdTId= id; PrdName = Name;}
        public void PrdSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PrdSave");
            cmd.Parameters.AddWithValue("@PTypeId", PrdTId);
            cmd.Parameters.AddWithValue("@PPName", PrdName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //produxt fetch for given type id 
       // public int PrdTId {  get; set; }
        public clsShopManage (int Ptid) { PrdTId= Ptid;}
        public DataTable FetchPrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPrd");
            cmd.Parameters.AddWithValue("@PTypeId", PrdTId);
            SqlDataAdapter adpt4 = new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            adpt4.Fill(dt3);
            return dt3;
            con.Close();
        }
        // size save
        public int PrdId {get; set; }
        public string PrdSize {get; set;}
        public int PrdMRP {get; set; }
        public int PrdPrice {get; set; }
        public clsShopManage(int id, int product, string size, int mrp, int price)
        {
            PrdTId = id;
            PrdId= product;
            PrdSize= size;
            PrdMRP= mrp;
            PrdPrice= price;
        }
        public void SizeSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SizeSave");
            cmd.Parameters.AddWithValue("@PTypeId", PrdTId);
            cmd.Parameters.AddWithValue("@PPName", PrdId);
            cmd.Parameters.AddWithValue("@PPSize", PrdSize);
            cmd.Parameters.AddWithValue("@PPmrp", PrdMRP);
            cmd.Parameters.AddWithValue("@PPprice", PrdPrice);
            cmd.ExecuteNonQuery(); con.Close();
        }
        // fething size tblsize values for datagridview reusingt this in next discount save methode
        public clsShopManage(int tid,int pid) 
        { 
            PrdTId = tid;
            PrdId = pid; 
        }
        public DataTable FetchSizeGRD()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SizeGRD");
            cmd.Parameters.AddWithValue("@PTypeId", PrdTId);
            cmd.Parameters.AddWithValue("@PId", PrdId);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            con.Close();
        }
        //product total for the paeg order selected by sizeid
        // reusignt ht allready defined constructor Ptid from FetchPrd()
        public SqlDataReader PTotal()
        {//fetching the total for txttotal form order form by the datagridviews event input cellclick 
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PTotal");
            cmd.Parameters.AddWithValue("@PSizeId", PrdTId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        //order confirmed data saving to tblorder
        public int PrdSId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }  
       // public double Discont { get; set; }
        public clsShopManage(int tid,int sid,string pname)
        { 
            UserId = tid;
            Status = pname;
            PrdSId = sid;
          //  Discont = dis;
        }
        public void OrderSave()
        {
            con.Open();
            DateTime currentDateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderConfirm");
            cmd.Parameters.AddWithValue("@RId", UserId);
            cmd.Parameters.AddWithValue("@PSizeId", PrdSId);
            cmd.Parameters.AddWithValue("@OStatus", Status); 
            cmd.Parameters.AddWithValue("@ODate", currentDateTime);
            //cmd.Parameters.AddWithValue("@Dis", );
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //fetching all product data fron tblsize
        public DataTable AllPrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","AllPrd");
            SqlDataAdapter adapter =new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();
        }
        //fetching the order details on admin page
        public DataTable FetchOrdAdm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AdmOrd");
            SqlDataAdapter adpt= new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        // saving dicount in % to tblorder
        public void SaveDiscount()
        {//reusing the above properties prdtid and prdid from FetchSizeGRD()
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SDiscount");
            cmd.Parameters.AddWithValue("@Dis", PrdId);
            cmd.Parameters.AddWithValue("@OrderId", PrdTId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //unordered product fetching for admin page 
        public DataTable UnOrdPrd() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnordPrd");
            SqlDataAdapter adpt=new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        // customer list who does not order any product 
        public DataTable UnOrdCust()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnOrdCust");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //changingt the status of order here && reusing the fetchprd methodes class and property..
        public void UpOrd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateOrd");
            cmd.Parameters.AddWithValue("@OrderId", PrdTId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
