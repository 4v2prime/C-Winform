using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSTERPExternalExam
{
    
    internal class clsExternalExam
    {
        SqlConnection con = new SqlConnection("Data Source=PriMe;Initial Catalog=GSTEducationERP;Integrated Security=True;");
        //all the methodes will be done here
        //starting with the AddExam
        //fetching the course tbl for thwe course combobox on addexam page
        public DataTable FetchCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCourse");
            SqlDataAdapter adtp = new SqlDataAdapter();
            adtp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adtp.Fill(dt);
            con.Close();
            return dt;
            
        }
        //fetching the status for multiple purpose for now
        public DataTable FetchStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();  
            adpt.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2); con.Close();
            return dt2;
           
        }
        //defining the property for add exam methode
        public string ExamName { get; set; }
        public int TopicId { get; set; }
        public string CourseCode { get; set; }
    }
}
