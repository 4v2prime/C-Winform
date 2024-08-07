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
using lblGstErpPlacement;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using Syncfusion.WinForms.DataGridConverter;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GstErpPlacement
{
    public partial class frmExam : Form
    {

        SqlConnection con=new SqlConnection("Data Source=PriMe;Initial Catalog=GSTEducationERP;Integrated Security=True;");
        
        public string action { get; set; }
        public string CandidateType { get; set; }
        public string LogedStaffCodeExam { get; set; }
        public string ExamBranchName { get; set; }
        public string ExamBranchCode { get; set; }
        public bool IspanelVisible { get; set; }
        public frmExam()
        {
            InitializeComponent();
            
        }
        public frmExam(frmExam objExam)
        {
            action = objExam.action;
            LogedStaffCodeExam = objExam.LogedStaffCodeExam;
            CandidateType = "External";
            ExamBranchName = objExam.ExamBranchName;
            CandidateType = objExam.CandidateType;
            ExamBranchCode = objExam.ExamBranchCode;
            IspanelVisible = false;
        }
        //setting the colours of the buttons to default 255, 77, 165
        public void Visuals()
        {
            //btnExternal.FillColor = Color.FromArgb(94, 148, 255); btnExternal.FillColor2 = Color.FromArgb(255, 77, 165);
            btnAssignedExam.FillColor = Color.FromArgb(94, 148, 255); btnAssignedExam.FillColor2 = Color.FromArgb(255, 77, 165);
            btnAssignedExam.HoveredState.FillColor= Color.Blue; btnAssignedExam.HoveredState.FillColor = Color.Blue;
            btnPendingExam.FillColor = Color.FromArgb(94, 148, 255); btnPendingExam.FillColor2 = Color.FromArgb(255, 77, 165);
            btnPendingExam.HoveredState.FillColor = Color.Blue; btnPendingExam.HoveredState.FillColor = Color.Blue;
            btnConductedExam.FillColor = Color.FromArgb(94, 148, 255); btnConductedExam.FillColor2 = Color.FromArgb(255, 77, 165);
            btnConductedExam.HoveredState.FillColor = Color.Blue; btnConductedExam.HoveredState.FillColor = Color.Blue;
            btnAllExam.FillColor = Color.FromArgb(94, 148, 255); btnAllExam.FillColor2 = Color.FromArgb(255, 77, 165);
            btnAllExam.HoveredState.FillColor = Color.Blue; btnAllExam.HoveredState.FillColor = Color.Blue;
        }
        private void frmExternalExam_Load(object sender, EventArgs e)
        {
            ///default call to the assigned exam
            
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            //making the instance of add exam form for adding the new exams from the base form 
            Visuals();
            frmAddExam objAdd=new frmAddExam();
            objAdd.LognedStaffCodeAdd = LogedStaffCodeExam;
            
            objAdd.Show();
        }

        private void btnExternal_Click(object sender, EventArgs e)
        {
            CandidateType = "External";
            //string exam="External"
            Visuals();
            btnExternal.FillColor = Color.Blue;
            btnExternal.FillColor2 = Color.Blue;
            btnExternal.HoveredState.FillColor = Color.Blue; btnExternal.HoveredState.FillColor2 = Color.Blue;
            pnlExternalExam.Visible = true;
            grdvExam.Visible = true;
            btnAssignedExam.Visible = true;
            btnConductedExam.Visible = true;
            btnPendingExam.Visible = true;
            btnAllExam.Visible = true;
            btnAssignedExam.FillColor=Color.Blue;
            btnAssignedExam.FillColor2=Color.Blue;
            action = "Assigned";
            AssignedExam();

        }

        private void btnExternal_Leave(object sender, EventArgs e)
        {
            Visuals();
        }

        
        //making the methodes for fetching the differnt datafridview for the diffrerent buttons
        public void AssignedExam()
        {
            //clearing the datagridview for not meddling the next time
            grdvExam.DataSource = null;
            grdvExam.Columns.Clear();
            DataGridViewCheckBoxColumn chkbxclm = new DataGridViewCheckBoxColumn();
            chkbxclm.Name = "Checkbox";
            chkbxclm.HeaderText = "";
            chkbxclm.ReadOnly = false;
            chkbxclm.Width = 50;
            grdvExam.Columns.Add(chkbxclm);
            clsExam objAsgnedExam = new clsExam();
            DataTable dt = new DataTable();
            dt = objAsgnedExam.AssignedExam();
            grdvExam.DataSource = dt;
            //adding the action column to gridview 
            DataGridViewLinkColumn lnklbl1 = new DataGridViewLinkColumn();
            lnklbl1.Name = "Action";
            lnklbl1.Text = "Edit";
            lnklbl1.HeaderText = "Action";
            lnklbl1.ReadOnly = false;
            lnklbl1.UseColumnTextForLinkValue = true;
            lnklbl1.Width = 50;
            grdvExam.Columns.Add(lnklbl1);
            grdvExam.Columns[0].Width = 30;//checkbox widht
            grdvExam.Columns[1].HeaderText = "Sr. No."; grdvExam.Columns[1].Width = 30;
            grdvExam.Columns[6].HeaderText = "Technology Name";
            grdvExam.Columns[7].HeaderText = "Candidate Name";grdvExam.Columns[7].Width = 200;
            grdvExam.Columns[8].HeaderText = "Exam Name"; grdvExam.Columns[7].Width = 80;
            grdvExam.Columns[9].HeaderText = "Supervisor Name";grdvExam.Columns[9].Width = 100;
            grdvExam.Columns[11].HeaderText = "Exam Time";
            grdvExam.Columns[12].HeaderText = "Exam Date";
            grdvExam.Columns[14].HeaderText = "Total Marks";
            grdvExam.Columns[2].Visible = false;//assign test id
            grdvExam.Columns[3].Visible = false;//status
            grdvExam.Columns[4].Visible = false;//experinec
            grdvExam.Columns[5].Visible = false;//testid
            grdvExam.Columns[10].Visible = false;//lab name
            grdvExam.Columns[13].Visible = false;//duration
            grdvExam.Columns[15].Visible = false;//supervisor code
            grdvExam.Columns[16].Visible = false;// labcode
            //grdvExam.Columns[15].Visible = false;

        }
        private void btnAssignedExam_Click(object sender, EventArgs e)
        {
            Visuals();
            btnAssignedExam.FillColor = Color.Blue; btnAssignedExam.FillColor2 = Color.Blue;
            //btnAssignedExam.HoveredState.FillColor=Color.Blue; btnAssignedExam.HoveredState.FillColor2 = Color.Blue;
            action = "Assigned";
            AssignedExam();
        }
        public void PendingExam()
        {
            grdvExam.DataSource = null;
            grdvExam.Columns.Clear();
            DataGridViewCheckBoxColumn chkbxclm = new DataGridViewCheckBoxColumn();
            chkbxclm.Name = "Checkbox";
            chkbxclm.HeaderText = "";
            chkbxclm.ReadOnly = false;
            chkbxclm.Width = 50;
            grdvExam.Columns.Add(chkbxclm);
            //fetching the asiigned exam from the tblAssign
            clsExam objAsgnedExam = new clsExam();
            DataTable dt = new DataTable();
            dt = objAsgnedExam.PendingExam();
            grdvExam.DataSource = dt;
            //adding the action column to gridview 
            DataGridViewLinkColumn lnklbl1 = new DataGridViewLinkColumn();
            lnklbl1.Text = "Edit";
            lnklbl1.HeaderText = "Action";
            lnklbl1.ReadOnly = false;
            lnklbl1.UseColumnTextForLinkValue = true;
            lnklbl1.Width = 50;
            grdvExam.Columns.Add(lnklbl1);
            grdvExam.Columns[0].Width = 35;
            grdvExam.Columns[1].HeaderText = "Sr.No."; grdvExam.Columns[1].Width = 35;
            grdvExam.Columns[6].HeaderText = "Technology Name";
            grdvExam.Columns[7].HeaderText = "Candidate Name";grdvExam.Columns[7].Width = 180;
            grdvExam.Columns[8].HeaderText = "Exam Name"; grdvExam.Columns[8].Width = 90;
            grdvExam.Columns[9].HeaderText = "Supervisor Name"; grdvExam.Columns[9].Width = 130;
            grdvExam.Columns[10].HeaderText = "Lab Name";
            grdvExam.Columns[11].HeaderText = "Exam Time";
            grdvExam.Columns[12].HeaderText = "Exam Date";
            grdvExam.Columns[14].HeaderText = "Total Marks";
            grdvExam.Columns[2].Visible = false;//assign test id
            grdvExam.Columns[3].Visible = false;//ststud
            grdvExam.Columns[4].Visible = false;//experience><
            grdvExam.Columns[5].Visible = false;//testid
            grdvExam.Columns[15].Visible = false;//supervisor code cross><
            grdvExam.Columns[16].Visible = false;//labcode cross><
        }
        private void btnPendingExam_Click(object sender, EventArgs e)
        {
            Visuals();
            btnPendingExam.FillColor = Color.Blue;btnPendingExam.FillColor2 = Color.Blue;
            action = "Pending";
            PendingExam();

        }
        public void ConductedExam()
        {
            //fetching the conducted exams here form the database
            grdvExam.DataSource = null;
            grdvExam.Columns.Clear();
            DataGridViewCheckBoxColumn chkbxclm = new DataGridViewCheckBoxColumn();
            chkbxclm.Name = "Checkbox";
            chkbxclm.HeaderText = "";
            chkbxclm.ReadOnly = false;
            chkbxclm.Width = 10;
            grdvExam.Columns.Add(chkbxclm);
            //fetching the asiigned exam from the tblAssign
            clsExam objAsgnedExam = new clsExam();
            DataTable dt = new DataTable();
            dt = objAsgnedExam.ConductedExam();
            grdvExam.DataSource = dt;
            //adding the action column to gridview for view result 
            DataGridViewLinkColumn lnklbl1 = new DataGridViewLinkColumn();
            lnklbl1.Text = "View";
            lnklbl1.HeaderText = "Action";
            lnklbl1.ReadOnly = false;
            lnklbl1.UseColumnTextForLinkValue = true;
            lnklbl1.Width = 50;
            grdvExam.Columns.Add(lnklbl1);
            //adding the linllabel column for the add reuslt
            DataGridViewLinkColumn lnklbl2 = new DataGridViewLinkColumn();
            lnklbl2.Text = "Add Result";
            lnklbl2.HeaderText = "Action";
            lnklbl2.ReadOnly = false;
            lnklbl2.UseColumnTextForLinkValue = true;
            lnklbl2.Width = 50;
            grdvExam.Columns.Add(lnklbl2);
            grdvExam.Columns[0].Width = 35;
            grdvExam.Columns[1].HeaderText = "Sr.No."; grdvExam.Columns[1].Width = 35;
            grdvExam.Columns[6].HeaderText = "Technology Name"; grdvExam.Columns[6].Width = 80;
            grdvExam.Columns[7].HeaderText = "Candidate Name"; grdvExam.Columns[7].Width = 180;
            grdvExam.Columns[8].HeaderText = "Exam Name"; grdvExam.Columns[8].Width = 90;
            grdvExam.Columns[9].HeaderText = "Supervisor Name"; grdvExam.Columns[9].Width = 100;
            grdvExam.Columns[10].HeaderText = "Lab Name";
            grdvExam.Columns[11].HeaderText = "Exam Time";
            grdvExam.Columns[12].HeaderText = "Exam Date";
            grdvExam.Columns[14].HeaderText = "Total Marks";
            grdvExam.Columns[2].Visible = false;//assign testid
            grdvExam.Columns[3].Visible = false;//status
            grdvExam.Columns[4].Visible = false;//experience
            grdvExam.Columns[5].Visible = false;//testid><
            grdvExam.Columns[15].Visible = false;//superviosr code><
            grdvExam.Columns[16].Visible = false;//labcode><
        }
        private void btnConductedExam_Click(object sender, EventArgs e)
        {
            Visuals();
            btnConductedExam.FillColor = Color.Blue; btnConductedExam.FillColor2 = Color.Blue;
            action = "Conducted";
            ConductedExam();
        }
        public void AllExam()
        {
            //clearing the datagridview for not meddling the next time
            grdvExam.DataSource = null;
            grdvExam.Columns.Clear();
            DataGridViewCheckBoxColumn chkbxclm = new DataGridViewCheckBoxColumn();
            chkbxclm.Name = "Checkbox";
            chkbxclm.HeaderText = "";
            chkbxclm.ReadOnly = false;
            chkbxclm.Width = 50;
            grdvExam.Columns.Add(chkbxclm);

            //fetching the all exam here on button click here
            clsExam objFchAllExam = new clsExam();
            DataTable dataTable = new DataTable();
            dataTable = objFchAllExam.FetchExam();
            grdvExam.DataSource = dataTable;
            //adding the action column to gridview 
            DataGridViewLinkColumn lnklbl1 = new DataGridViewLinkColumn();
            lnklbl1.Text = "Edit";
            lnklbl1.HeaderText = "Action";
            lnklbl1.ReadOnly = false;
            lnklbl1.UseColumnTextForLinkValue = true;
            lnklbl1.Width = 50;
            grdvExam.Columns.Add(lnklbl1);
            DataGridViewLinkColumn lnklbl2 = new DataGridViewLinkColumn();
            lnklbl2.Text = "Assign Exam";
            lnklbl2.HeaderText = "";
            lnklbl2.ReadOnly = false;
            lnklbl2.UseColumnTextForLinkValue = true;
            lnklbl2.Width = 50;
            grdvExam.Columns.Add(lnklbl2);
            grdvExam.Columns[1].HeaderText = "Sr.No."; grdvExam.Columns[1].Width = 50;
            grdvExam.Columns[5].HeaderText = "Technology Name";
            grdvExam.Columns[6].HeaderText = "Exam Name";grdvExam.Columns[6].Width = 100;
            grdvExam.Columns[7].HeaderText = "Register Date";
            grdvExam.Columns[8].HeaderText = "Total Marks";
            grdvExam.Columns[2].Visible = false;
            grdvExam.Columns[3].Visible = false;
            grdvExam.Columns[4].Visible = false;
            grdvExam.Columns[10].Visible = false;
            grdvExam.Columns[11].Visible = false;
            grdvExam.Columns[12].Visible = false;
            
        }
        private void btnAllExam_Click(object sender, EventArgs e)
        {
            Visuals();
            btnAllExam.FillColor = Color.Blue; btnAllExam.FillColor2 = Color.Blue;
            action = "AllExam";
            AllExam();
        }
        // refreshing the datagirdview for refresh  button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Assigned":
                    //fetching the datagridview of assigned exam
                    AssignedExam(); pnlFilter.Visible = false; cmbbxFilterCourse.Text = string.Empty;
                    cmbbxFilterExam.Text = string.Empty;
                    break;
                case "Pending":
                    //fetching the datagridview of  pending exam
                    pnlFilter.Visible=false; cmbbxFilterCourse.Text = string.Empty;
                    cmbbxFilterExam.Text = string.Empty;
                    PendingExam();
                    break;
                case "Conducted":
                    //fetching the conducted exams here form the database
                    ConductedExam(); pnlFilter.Visible = false; cmbbxFilterCourse.Text = string.Empty;
                    cmbbxFilterExam.Text = string.Empty;
                    break;
                case "AllExam":
                    //fetching the datagridview or refreshing the datagridview of all exam
                    AllExam(); pnlFilter.Visible = false; cmbbxFilterCourse.Text = string.Empty;
                    cmbbxFilterExam.Text = string.Empty;
                    break;
                default:
                    pnlFilter.Visible = false;
                    cmbbxFilterCourse.Text=string.Empty;
                    cmbbxFilterExam.Text=string.Empty;
                    break;
            }
        }

        private void grdvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(action)
            {
                case "Assigned":
                    //edit form for differnt pages 1. assigned exam page
                    if (e.RowIndex >= 0 && e.ColumnIndex == 17)
                    {
                        frmAssignExam objEdit = new frmAssignExam();
                        objEdit.Edit = true;
                        objEdit.Exam = action;
                        objEdit.Upid = int.Parse(grdvExam.Rows[e.RowIndex].Cells["AssignTestId"].Value.ToString());
                        objEdit.TechnologyName = grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                        objEdit.Experience= grdvExam.Rows[e.RowIndex].Cells["Experience"].Value.ToString();
                        objEdit.StudentName= grdvExam.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                        objEdit.ExamName= grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                        objEdit.StaffName= grdvExam.Rows[e.RowIndex].Cells["StaffName"].Value.ToString();
                        objEdit.AssignExamDate= (grdvExam.Rows[e.RowIndex].Cells["TestDate"].Value.ToString());
                        objEdit.ExamTime = (grdvExam.Rows[e.RowIndex].Cells["TestTime"].Value.ToString());
                        objEdit.Duration = (grdvExam.Rows[e.RowIndex].Cells["Duration"].Value.ToString());
                        objEdit.LabName= grdvExam.Rows[e.RowIndex].Cells["LabName"].Value.ToString();
                        objEdit.Status= grdvExam.Columns[1].ToString();
                        objEdit.ShowDialog();
                    }
                    break;
                case "Pending":
                    //edit form for the pending exam
                    if (e.RowIndex >= 0 && e.ColumnIndex == 17)
                    {
                        frmAssignExam objEdit = new frmAssignExam();
                        objEdit.Edit = true;
                        objEdit.Exam = action;
                        objEdit.Upid = int.Parse(grdvExam.Rows[e.RowIndex].Cells["AssignTestId"].Value.ToString());
                        objEdit.TechnologyName = grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                        objEdit.StudentName = grdvExam.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                        objEdit.ExamName = grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                        objEdit.StaffName = grdvExam.Rows[e.RowIndex].Cells["StaffName"].Value.ToString();
                        objEdit.LabName = grdvExam.Rows[e.RowIndex].Cells["LabName"].Value.ToString();
                        objEdit.AssignExamDate = (grdvExam.Rows[e.RowIndex].Cells["TestDate"].Value.ToString());
                        objEdit.ExamTime = (grdvExam.Rows[e.RowIndex].Cells["TestTime"].Value.ToString());
                        objEdit.Duration = (grdvExam.Rows[e.RowIndex].Cells["Duration"].Value.ToString());
                        objEdit.TotslMarks= int.Parse(grdvExam.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString());
                        objEdit.Status = (grdvExam.Columns[0].ToString());
                        objEdit.ShowDialog();
                    }
                    break;
                case "Conducted":
                    //view result and add result for conducted for
                    if(e.RowIndex>=0 && (e.ColumnIndex >= 15 ))
                    {
                        DataGridViewCell cell= grdvExam.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string Linklabeltext=cell.Value.ToString();
                        switch(Linklabeltext)
                        {
                            case "View":
                                frmViewResult objView = new frmViewResult();
                                objView.FetchId= int.Parse(grdvExam.Rows[e.RowIndex].Cells["AssignTestId"].Value.ToString());
                                objView.ShowDialog();
                                break;
                            default:
                                //checking if the result allready exists
                                clsExam objcheck = new clsExam();
                                objcheck.UpdateId = int.Parse(grdvExam.Rows[e.RowIndex].Cells["AssignTestId"].Value.ToString());
                                SqlDataReader dr;
                                dr= objcheck.FetchResult();
                                if (dr.Read())
                                {
                                    int obtainedMarks =int.Parse(dr["ObtainedMarks"].ToString());
                                    string Result = dr["ResultStatus"].ToString();
                                   DialogResult= MessageBox.Show("Result Allready added..!\n Obtained Marks='"+obtainedMarks+"'\n Result='"+Result+"' \n Do you wish to update these marks ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (DialogResult ==DialogResult.Yes) 
                                    {
                                        frmAddResult objAdd = new frmAddResult();
                                        objAdd.Edit = true;
                                        objAdd.TestId = int.Parse(dr["ResultId"].ToString());
                                        objAdd.StudentCode = grdvExam.Rows[e.RowIndex].Cells["CandidateCode"].Value.ToString();
                                        objAdd.StudentName = grdvExam.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                                        objAdd.Course = grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                                        objAdd.ExamName = grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                                        objAdd.ExamDate = grdvExam.Rows[e.RowIndex].Cells["TestDate"].Value.ToString();
                                        objAdd.TotalMarks = int.Parse(grdvExam.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString());
                                        objAdd.PasssingMarks = int.Parse(grdvExam.Rows[e.RowIndex].Cells["PassingMarks"].Value.ToString());
                                        objAdd.ObtainedMarks = int.Parse(dr["ObtainedMarks"].ToString());
                                        objAdd.ResultStatus = dr["ResultStatus"].ToString();
                                        objAdd.ShowDialog();
                                    }
                                }
                                else
                                {
                                    frmAddResult objAdd = new frmAddResult();
                                    objAdd.TestId = int.Parse(grdvExam.Rows[e.RowIndex].Cells["AssignTestId"].Value.ToString());
                                    objAdd.StudentCode = grdvExam.Rows[e.RowIndex].Cells["CandidateCode"].Value.ToString();
                                    objAdd.StudentName = grdvExam.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                                    objAdd.Course = grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                                    objAdd.ExamName = grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                                    objAdd.ExamDate = grdvExam.Rows[e.RowIndex].Cells["TestDate"].Value.ToString();
                                    objAdd.TotalMarks = int.Parse(grdvExam.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString());
                                    objAdd.ShowDialog();
                                }
                               break;
                        }
                    }
                    break;
                case "AllExam":
                    //condition for the opening the all exam edit form 
                    if (e.RowIndex>=0 && e.ColumnIndex == 13)
                    {
                        frmAddExam objEdit=new frmAddExam();
                        objEdit.Edit=true;
                        objEdit.TestId= int.Parse(grdvExam.Rows[e.RowIndex].Cells["TestId"].Value.ToString());
                        objEdit.TechnologyName= grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                        objEdit.ExperienceOfExam= grdvExam.Rows[e.RowIndex].Cells["Experience"].Value.ToString();
                        objEdit.ExamName= grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                        objEdit.TotalMarks= (grdvExam.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString());
                        objEdit.Duration = (grdvExam.Rows[e.RowIndex].Cells["Duration"].Value.ToString());
                        objEdit.PassingMarks =Convert.ToInt32(grdvExam.Rows[e.RowIndex].Cells["PassingMarks"].Value.ToString());
                        objEdit.NooOfQuestions = Convert.ToInt32(grdvExam.Rows[e.RowIndex].Cells["TotalNoOfQuestion"].Value.ToString());
                        objEdit.FilePath = grdvExam.Rows[e.RowIndex].Cells["TestPaperFile"].Value.ToString();
                        objEdit.ShowDialog();
                    }
                    else if(e.RowIndex >= 0 && e.ColumnIndex == 14)
                    {
                        frmAssignExam objAssign = new frmAssignExam();
                        objAssign.TechnologyName = grdvExam.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                        objAssign.ExamName= grdvExam.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                        objAssign.Duration= grdvExam.Rows[e.RowIndex].Cells["Duration"].Value.ToString();
                        objAssign.LogedStaffCodeAssign = LogedStaffCodeExam;
                        objAssign.BranchCodeAssign = ExamBranchCode;
                        objAssign.BranchNameAssign = ExamBranchName;
                        objAssign.Show();
                    }
                    break;

                default:
                    break;

            }
            
        }
        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //search in the datagridview with the method for search for student name
            (grdvExam.DataSource as DataTable).DefaultView.RowFilter = string.Format("FUllName Like'%{0}%'", txtSearch.Text);
            //search in the datagridview with the method for search for student name
            //(grdvExam.DataSource as DataTable).DefaultView.RowFilter = string.Format("TestName Like'%{0}%'", txtSearch.Text);
        }

        private void btnAssignedExam_Leave(object sender, EventArgs e)
        {
            //default color set for the button
            
        }
        //deleting the selected rows from the datagridview
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdvExam.SelectedRows.Count>0)
            {
                for(int i = grdvExam.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = grdvExam.Rows[i];
                    DataGridViewCheckBoxCell chk = row.Cells["Checkbox"] as DataGridViewCheckBoxCell;
                    bool ischecked = Convert.ToBoolean(chk.Value);
                    if (ischecked)
                    {
                        grdvExam.Rows.RemoveAt(i);
                    }
                }
                MessageBox.Show("Deleted Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least one Checkbox..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        
        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //filter here
            IspanelVisible = !IspanelVisible;
            pnlFilter.Visible = IspanelVisible;
            pnlFilter.Visible = IspanelVisible;
            
            
        }

        private void grdvExam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //incrementing the Sr. No.
            grdvExam.Rows[e.RowIndex].Cells[1].Value =( e.RowIndex +1);
        }

        private void cmbbxFilterCourse_Click(object sender, EventArgs e)
        {
            //fetching the course for filter the datagridview for 4 thing assigned, pending, conduct3d and allTest
            clsExam objGet1 = new clsExam();
            DataTable dt = new DataTable();
            //dt = objGet1.FetchCourse();
            //cmbbxFilterCourse.ValueMember = "Name";
            cmbbxFilterCourse.DisplayMember = "CourseName";
            cmbbxFilterCourse.DataSource = dt;
            //switch (action)
            //{
            //    case "Assigned":
            //        clsPlacement objGet1 = new clsPlacement();
            //        DataTable dt = new DataTable();
            //        dt = objGet1.AssignedExam();
            //        //cmbbxFilterCourse.ValueMember = "Name";
            //        cmbbxFilterCourse.DisplayMember = "CourseName";
            //        cmbbxFilterCourse.DataSource = dt;

            //        break;
            //    case "Pending":
            //        clsPlacement objGet2 = new clsPlacement();
            //        DataTable dt2 = new DataTable();
            //        dt2 = objGet2.PendingExam();
            //        //cmbbxFilterCourse.ValueMember = "Name";
            //        cmbbxFilterCourse.DisplayMember = "CourseName";
            //        cmbbxFilterCourse.DataSource = dt2;
            //        break;
            //    case "Conducted":
            //        clsPlacement objGet3 = new clsPlacement();
            //        DataTable dt3 = new DataTable();
            //        dt3 = objGet3.ConductedExam();
            //        //cmbbxFilterCourse.ValueMember = "Name";
            //        cmbbxFilterCourse.DisplayMember = "CourseName";
            //        cmbbxFilterCourse.DataSource = dt3;
            //        break;
            //    case "AllExam":
            //        clsPlacement objGet4 = new clsPlacement();
            //        DataTable dt4 = new DataTable();
            //        dt4 = objGet4.FetchAllExam();
            //        //cmbbxFilterCourse.ValueMember = "Name";
            //        cmbbxFilterCourse.DisplayMember = "CourseName";
            //        cmbbxFilterCourse.DataSource = dt4;
            //        break;
            //    default: break;
            //}
        }

        private void cmbbxFilterExam_Click(object sender, EventArgs e)
        {
            //fetching the exam for filter the datagridview for 4 thing assigned, pending, conduct3d and allTest
            switch (action)
            {
                case "Assigned":
                    clsExam objGet1 = new clsExam();
                    DataTable dt = new DataTable();
                    dt = objGet1.AssignedExam();
                    //cmbbxFilterCourse.ValueMember = "Name";
                    cmbbxFilterExam.DisplayMember = "TestName";
                    cmbbxFilterExam.DataSource = dt;
                    break;
                case "Pending":
                    clsExam objGet2 = new clsExam();
                    DataTable dt2 = new DataTable();
                    dt2 = objGet2.PendingExam();
                    //cmbbxFilterCourse.ValueMember = "Name";
                    cmbbxFilterExam.DisplayMember = "TestName";
                    cmbbxFilterExam.DataSource = dt2;
                    break;
                case "Conducted":
                    clsExam objGet3 = new clsExam();
                    DataTable dt3 = new DataTable();
                    dt3 = objGet3.ConductedExam();
                    //cmbbxFilterCourse.ValueMember = "Name";
                    cmbbxFilterExam.DisplayMember = "TestName";
                    cmbbxFilterExam.DataSource = dt3;
                    break;
                case "AllExam":
                    clsExam objGet4 = new clsExam();
                    DataTable dt4 = new DataTable();
                    dt4 = objGet4.FetchAllExam();
                    //cmbbxFilterCourse.ValueMember = "Name";
                    cmbbxFilterExam.DisplayMember = "TestName";
                    cmbbxFilterExam.DataSource = dt4;
                    break;
                default: break;
            }
        }

        private void cmbbxFilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            (grdvExam.DataSource as DataTable).DefaultView.RowFilter = string.Format("CourseName Like'%{0}%'", cmbbxFilterCourse.Text);
        }

        private void cmbbxFilterExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            (grdvExam.DataSource as DataTable).DefaultView.RowFilter = string.Format("TestName Like'%{0}%'", cmbbxFilterExam.Text);
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            ///summery
            ///this code is for converting the selected rows 
            ///add the namespca of the microsoft exel form web add refrences

            // Check for checked checkbox rows
            var checkedRows = grdvExam.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToBoolean(row.Cells[0].Value) == true).ToList();

            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Please check rows to export.");
                return;
            }

            // Create Excel application object and workbook
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = null;

            try
            {
                // Create a new workbook
                excelWorkbook = excelApp.Workbooks.Add();

                // Create a new worksheet
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets.Add();

                // Get headers from the DataGridView
                string[] headers = new string[grdvExam.Columns.Count];
                for (int i = 0; i < headers.Length; i++)
                {
                    headers[i] = grdvExam.Columns[i].HeaderText;
                }

                // Write headers to the first row in Excel
                for (int i = 0; i < headers.Length; i++)
                {
                    excelWorksheet.Cells[1, i + 1] = headers[i];
                }

                // Iterate through checked checkbox rows and write data to Excel
                int rowNumber = 2; // Start writing data from the second row
                foreach (DataGridViewRow checkedRow in checkedRows)
                {
                    // Get cell values for the current row
                    object[] rowValues = new object[checkedRow.Cells.Count];
                    for (int i = 0; i < rowValues.Length; i++)
                    {
                        // Explicitly convert values to expected types
                        if (checkedRow.Cells[i].Value != null)
                        {
                            rowValues[i] = checkedRow.Cells[i].Value.ToString();
                        }
                    }

                    // Write cell values to the current row in Excel
                    for (int i = 0; i < rowValues.Length; i++)
                    {
                        excelWorksheet.Cells[rowNumber, i + 1] = rowValues[i];
                    }

                    rowNumber++;
                }

                // AutoFit columns
                excelWorksheet.Columns.AutoFit();

                // Make Excel visible
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
            finally
            {
                // Release COM objects
                if (excelWorkbook != null)
                {
                    Marshal.ReleaseComObject(excelWorkbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }

            }
        }
            private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ///summery
            ///this code is for exporting the selected rows to pdf

            
                if (grdvExam.SelectedRows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "ExamDetails.pdf";
                    bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to wride data in disk" + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(grdvExam.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            
                            foreach (DataGridViewColumn col in grdvExam.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }
                            for (int i = grdvExam.Rows.Count - 1; i >= 0; i--)
                            {
                                foreach (DataGridViewRow viewRow in grdvExam.SelectedRows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                Document document = new Document(PageSize.A4, 16f, 8f, 8f, 16f);
                                //Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting Data" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }
            


        }
    }
}
