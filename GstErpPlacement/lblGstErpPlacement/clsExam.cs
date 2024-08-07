using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace lblGstErpPlacement
{
    /// <summary>
    /// this is my library class in which i will save my calling/fuction  mehtodes 
    /// </summary>
    public class clsExam
    {
        ///summery
        ///the sql connection is given below
        SqlConnection con = new SqlConnection("Data Source=PriMe;Initial Catalog=GSTEducationERP;Integrated Security=True");

        /// <summary>
        /// all the required properties are declared below for using in the copy constructor
        /// </summary>
        
        public clsExam()
        {

        }
        public string ATechnology { get; set; }
        public string AExmName { get; set; }
        public DateTime AExmRegisterDate { get; set; }
        public string AExmDuration { get; set; }
        public float AExmTotmarks { get; set; }
        public float AExmPassingMarks { get; set; }
        public int AExmttlQuestions { get; set; }
        public int UpdateId { get; set; }
        public string UploadFile { get; set; }
        public int AExmStatus { get; set; }
        public string CenterCode { get; set; }
        public string LoginStaffCode { get; set; }
        public string clsBranchName { get; set; }
        public string clsBranchCode { get; set; }
        public string AExamId { get; set; }
        public string AStudCode { get; set; }
        public int ReExamId { get; set; }
        public DateTime AExamDate { get; set; }
        public DateTime AExamTime { get; set; }
        public string ALabCode { get; set; }
        public string SupervisorCode { get; set; }
        public int ObtainedMarks { get; set; }
        public string Result { get; set; }
        public int AttendanceId { get; set; }
        public string Experience { get; set; }
        public int QualificationId { get; set; }

        public clsExam(clsExam Exm)
        {
            // Copying values from the existing object to the new object
            ATechnology = Exm.ATechnology;
            AExmName = Exm.AExmName;
            AExamId = Exm.AExamId;
            AExmRegisterDate = Exm.AExmRegisterDate;
            AExmDuration = Exm.AExmDuration;
            AExmTotmarks = Exm.AExmTotmarks;
            AExmPassingMarks = Exm.AExmPassingMarks;
            AExmttlQuestions = Exm.AExmttlQuestions;
            AExmStatus = Exm.AExmStatus;
            CenterCode = Exm.CenterCode;
            AExamDate = Exm.AExamDate;
            AExamTime = Exm.AExamTime;
            UpdateId = Exm.UpdateId;
            UploadFile = Exm.UploadFile;
            ObtainedMarks = Exm.ObtainedMarks;
            AttendanceId = Exm.AttendanceId;
            Result = Exm.Result;
            LoginStaffCode = Exm.LoginStaffCode;
            Experience=Exm.Experience;
            clsBranchCode = Exm.clsBranchCode;
        }
        ///summery
        ///fetching the GSTtblCourse for using them for combobox
        public DataTable ListTechnology()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListTechnologyAddExam");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();
        }
        /// summery
        /// fetching the status for multiple purpose use 25 instead of 19
        /// </summary>
        public DataTable FetchStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListStatusVP");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();
        }
        ///list the graduation for add exam
        public DataTable ListGraduation() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListGraduationExternal");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();
        }
        ///list the post graduation for add exam
        public DataTable ListPostGraduation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListGraduationExternal");
            cmd.Parameters.AddWithValue("@GraduationId",QualificationId);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///Defining the methode for saving the add exam to GSTtblAddTest
        ///
        public void SaveNewExam()
        {
            DateTime Now = DateTime.Now;
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddNewExamExtVp");
            cmd.Parameters.AddWithValue("@TestName", AExmName);
            cmd.Parameters.AddWithValue("@SkillId", ATechnology);
            cmd.Parameters.AddWithValue("@Experience", Experience);
            cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
            cmd.Parameters.AddWithValue("@RegisterDate", Now);
            cmd.Parameters.AddWithValue("@Duration", AExmDuration);
            cmd.Parameters.AddWithValue("@TotalMarks", AExmTotmarks);
            cmd.Parameters.AddWithValue("@PassingMarks", AExmPassingMarks);
            cmd.Parameters.AddWithValue("@TotalNoOfQuestion", AExmttlQuestions);
            cmd.Parameters.AddWithValue("@StaffCode", LoginStaffCode);
            cmd.Parameters.AddWithValue("@TestPaperFile", UploadFile);
            cmd.Parameters.AddWithValue("@StatusId", "44");
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///fething the all exam from the GSTtblAddTest whose status are created ie.44
        ///
        public DataTable FetchAllExam()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListAllExamExtVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///fetching the assigned exam for assign datagridview
        ///
        public DataTable AssignedExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DetailsAssignedExamExtVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///fetching the pending eaxm for main  desktop
        public DataTable PendingExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DetailsPendingExamExtVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///sumery
        ///conduceted exams here 
        public DataTable ConductedExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DetailsConductedExamExtVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        
        ///summery
        ///fetching the stident based on the their preferd technology, experience and qualification <summary>
        /// summery
        /// For freshers the preferd job skill and qualification
        /// </summary>
        /// <returns></returns>
        public DataTable ListExternalStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListExternalStudentsVP");
            cmd.Parameters.AddWithValue("@PrefferdjobSkill", ATechnology);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///for 1-3 year experinece and technology student
        public DataTable ListExternalStudent1to3()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListExternalStudents1to3Exp");
            cmd.Parameters.AddWithValue("@PrefferdjobSkill", ATechnology);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///for 1-3 year experinece and technology student
        public DataTable ListExternalStudent3moreExp()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListExternalStudents3andmoreExp");
            cmd.Parameters.AddWithValue("@PrefferdjobSkill", ATechnology);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        ///summery
        ///fetching the exam name and code for the assign exam
        public DataTable FetchExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DetailsAllExamExtVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///fetching the staff for the supervisor in assign exam
        public DataTable FetchStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListTrainerVP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///fetching the labs based on the user branch
        public DataTable FetchLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ListLabSN");
            cmd.Parameters.AddWithValue("@BatchCode", clsBranchCode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        ///summery
        ///saving the assign exam here 
        public void SaveAssignExm()
        {
            //saving the arranged system date
            DateTime Now = DateTime.Now;
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AssignExamVP");
            cmd.Parameters.AddWithValue("@TestId", AExamId);
            cmd.Parameters.AddWithValue("@StudentCodes", AStudCode);
            cmd.Parameters.AddWithValue("@RetestForAssignTestId", ReExamId);
            cmd.Parameters.AddWithValue("@AssignDate", Now);
            cmd.Parameters.AddWithValue("@TestDate", AExamDate);
            cmd.Parameters.AddWithValue("@TestTime", AExamTime);
            cmd.Parameters.AddWithValue("@TrainerCodeSupervisorCode", SupervisorCode);
            cmd.Parameters.AddWithValue("@LabCode", ALabCode);
            cmd.Parameters.AddWithValue("@ArrangedDateSystemDate", Now);
            cmd.Parameters.AddWithValue("@StaffCodeArrangedBy", LoginStaffCode);/*ther are three placement co-ordinator vishal patil-STF009,Tushar Kolate-STF010,Akash Sonawane-STF014*/
            cmd.Parameters.AddWithValue("@StatusId", "25");
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///updating the status of the assigned exam TestDate=@TestDate,TestTime=@TestTime,TrainerCodeSupervisorCode=@TrainerCodeSupervisorCode,LabCode=@LabCode,StatusId=@StatusId
        public void EditAssignedExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateAssignedExamExtVP");
            cmd.Parameters.AddWithValue("@TestDate", AExamDate);
            cmd.Parameters.AddWithValue("@TestTime", AExamTime);
            cmd.Parameters.AddWithValue("@TrainerCodeSupervisorCode", SupervisorCode);
            cmd.Parameters.AddWithValue("@LabCode", ALabCode);
            cmd.Parameters.AddWithValue("@StatusId", AExmStatus);
            cmd.Parameters.AddWithValue("@AssignTestId", UpdateId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///updating the status of the pending exam 
        public void EditPendingExam()
        {
            DateTime now = DateTime.Now;
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePendingExamExtVP");
            cmd.Parameters.AddWithValue("@StatusId", AExmStatus);
            cmd.Parameters.AddWithValue("@ArrangedDateSystemDate", now);
            cmd.Parameters.AddWithValue("@TestDate", AExamDate);
            cmd.Parameters.AddWithValue("@TestTime", AExamTime);
            cmd.Parameters.AddWithValue("@LabCode", ALabCode);
            cmd.Parameters.AddWithValue("@AssignTestId", UpdateId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///updating the status and file of the add exam from edit add form
        public void EditAddExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateExamVP");
            cmd.Parameters.AddWithValue("@Duration", AExmDuration);
            cmd.Parameters.AddWithValue("@TotalMarks", AExmTotmarks);
            cmd.Parameters.AddWithValue("@PassingMarks", AExmPassingMarks);
            cmd.Parameters.AddWithValue("@TestPaperFile", UploadFile);
            cmd.Parameters.AddWithValue("@TotalNoOfQuestion", AExmttlQuestions);
            cmd.Parameters.AddWithValue("@TestId", UpdateId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///adding or saving the result of the test here form the add result page
        public void SaveResult()
        {
            DateTime Now = DateTime.Now;
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddResultVP");
            cmd.Parameters.AddWithValue("@TestAssignedId", UpdateId);
            cmd.Parameters.AddWithValue("@StudentCodes", AStudCode);
            cmd.Parameters.AddWithValue("@ObtainedMarks", ObtainedMarks);
            cmd.Parameters.AddWithValue("@AttendanceStatusId", AttendanceId);
            cmd.Parameters.AddWithValue("@ResultStatus", Result);
            cmd.Parameters.AddWithValue("@TrainerCodeResultAddedBy", LoginStaffCode);
            cmd.Parameters.AddWithValue("@ResultAddedDate", Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///updating result here
        public void UpdateResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateResultExtVP");
            cmd.Parameters.AddWithValue("@ResultId", UpdateId);
            cmd.Parameters.AddWithValue("@ObtainedMarks", ObtainedMarks);
            cmd.Parameters.AddWithValue("@ResultStatus", Result);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///summery
        ///fetching the result to show on the view reult page
        public SqlDataReader FetchResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewResultExtVP");
            cmd.Parameters.AddWithValue("@AssignTestId", UpdateId);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            con.Close();
        }
        ///summery
        ///checking if the assigned exams student has allready been assigned for the exam
        public SqlDataReader CheckAssignExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckAssignExam");
            cmd.Parameters.AddWithValue("@StudentCodes", AStudCode);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            con.Close();
        }
        ///summery
        ///checking if the exams has allready been created
        public SqlDataReader CheckAllExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GSTPlacement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckAllExam");
            cmd.Parameters.AddWithValue("@TestName", AExmName);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            con.Close();
        }

    }
}
