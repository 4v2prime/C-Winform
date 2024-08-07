using System.Data.SqlClient;
using System.Data;
using lblGstErpPlacement;


namespace GstErpPlacement
{
    public class clsLogin
    {
        SqlConnection con = new SqlConnection("Data Source=PriMe;Initial Catalog=GSTEducationERP;Integrated Security=True");


        public string OfficialEmailId { get; set; }
        public string Password { get; set; }

        public string StaffEmail{ get; set;}

            public clsLogin()
            {
            
            }
            //Copy Constructor
            public clsLogin(clsLogin loginobj)
            {
                OfficialEmailId = loginobj.OfficialEmailId;
                Password = loginobj.Password;
                StaffEmail = loginobj.StaffEmail;
            }
        
            //Login Validation
            public DataTable LoginValidation()
            {
                int count;
                con.Open();
                SqlCommand cmd = new SqlCommand("GSTPlacement", con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", "LoginValidation");
                cmd.Parameters.AddWithValue("@OfficialEmailId", OfficialEmailId);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                return dt;
            }
        //StaffPosition Function
        public DataTable StaffPositionFunc()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Position");
            
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        //Reset Password
        public void ResetPassword()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GSTPlacement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", "ResetPassword");
                cmd.Parameters.AddWithValue("@OfficialEmailId", OfficialEmailId);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        
            //Forgot Password
            public SqlDataReader ForgotPassword()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GSTPlacement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", "ForgotPassword");
                cmd.Parameters.AddWithValue("@OfficialEmailId", StaffEmail);//usernamemail
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                return dr;
                con.Close();
            }
            //Lock Profile
            public DataTable LockProfileNameFunc()
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GSTPlacement", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", "LockProfileNameFunc");
                    cmd.Parameters.AddWithValue("@OfficialEmailId", OfficialEmailId);
                    SqlDataAdapter adpt = new SqlDataAdapter();
                    adpt.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);


                    con.Close();
                    return dt;
            }
            public SqlDataReader LockProfilePasswword()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GSTPlacement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", "LockProfilePasswword");
                cmd.Parameters.AddWithValue("@OfficialEmailId", OfficialEmailId);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                return dr;
                con.Close();
            }

    }
}
