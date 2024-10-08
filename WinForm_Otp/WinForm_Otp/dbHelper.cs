using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinForm_Otp
{
    public class dbHelper
    {
        public string email { get; set; }
        public string passwors { get; set; }
        public dbHelper()
        {

        }
        public dbHelper(dbHelper obj)
        {
            email = obj.email;
            passwors = obj.passwors;
        }

        SqlConnection con = new SqlConnection("Data Source=PRIME\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUser WHERE Email = @Email AND Password = @Password", con);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", passwors);

            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            return reader;

        }
    }
}
