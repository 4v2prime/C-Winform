using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lblGstErpPlacement;
using static Siticone.UI.Native.WinApi;


namespace GstErpPlacement
{
    public partial class frmAssignExam : Form
    {
        public int Upid { get; set; }
        public int ReExamAssignId { get; set; }
        public bool Edit { get; set; }
        public string Exam { get; set; }//used for the case statement below 
        public string TechnologyName { get; set; }
        public string StudentName { get; set; }
        public string ExamName { get; set; }
        public string StaffName { get; set; }
        public string AssignExamDate { get; set; }
        public string ExamTime { get; set; }
        public string Duration { get; set; }
        public string LabName { get; set; }
        public int TotslMarks { get; set; }
        public string Status { get; set; }
        public string BranchNameAssign { get; set; }
        public string BranchCodeAssign { get; set; }
        public string LogedStaffCodeAssign { get; set; }
        public string Experience { get; set; }

        //fetching the assigned tests duration from gsttbladdtest
        // public DateTime AssignDuration { get; set; }
        public frmAssignExam()
        {
            InitializeComponent();
        }
        public frmAssignExam(frmAssignExam objedit)
        {
            //checking if i haev selected to edit
            Edit = false;
            Edit = objedit.Edit;
            Exam = "Assign";
            Exam = objedit.Exam;//used for the case statement  below
            ReExamAssignId = objedit.ReExamAssignId;
            Upid = objedit.Upid;
            TechnologyName = objedit.TechnologyName;
            StudentName = objedit.StudentName;
            ExamName = objedit.ExamName;
            StaffName = objedit.StaffName;
            AssignExamDate = objedit.AssignExamDate;
            ExamTime = objedit.ExamTime;
            Duration = "00:00:00";
            Duration = objedit.Duration;
            LabName = objedit.LabName;
            TotslMarks = objedit.TotslMarks;
            Status = objedit.Status;
            BranchCodeAssign = objedit.BranchCodeAssign;
            BranchNameAssign = objedit.BranchNameAssign;
            Experience=objedit.Experience;
        }
        //creating the methode for the systemdate
        public DateTime SystemDate()
        {
            DateTime sysDate = DateTime.Now;
            return sysDate;
        }
        public void FetchAssignData()
        {
            //setting the date og dattimepicker to now
            dtpExamDate.Text = SystemDate().ToString();
            ///fetching the technology ie prefferd skill 
            ListTechnology();
            cmbbxTechnology.Text = TechnologyName;
            //fetching the exam here for combobox
            clsExam objExam = new clsExam();
            DataTable dt4 = new DataTable();
            dt4 = objExam.FetchAllExam();
            cmbbxExamName.DisplayMember = "TestName";
            cmbbxExamName.ValueMember = "TestId";
            cmbbxExamName.DataSource = dt4;
            cmbbxExamName.Text = ExamName;
            txtDuration.Text = Duration;
            txtBranch.Text = BranchNameAssign;
            txtBranch.Enabled = false;
            ///fetching the lab 
            //labs based on the center
            clsExam objLab = new clsExam();
            objLab.CenterCode = BranchCodeAssign;  
            DataTable dt5 = new DataTable();
            dt5 = objLab.FetchLab();
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.ValueMember = "LabCode";
            cmbbxLabName.DataSource = dt5;
            
        }
        /// <summary>
        /// in this form load there four operations operates, 1. assign the exam normally after clicking on the assign exam on the all exam page grid view
        /// 2.edit assign exam-this is been done through the edit assign exam from the assign exam page gridview 
        /// 3.pending exam-pending exam also gets updated from here 
        /// 4. re-exam : this is also happen here
        /// </summary>
        private void frmAssignExam_Load(object sender, EventArgs e)
        {

            FetchAssignData();
            

            if (Exam == "ReExam")
            {
                FetchAssignData();
                cmbbxStudentName.Text = StudentName;
                cmbbxStudentName.Enabled = false;
                cmbbxExamName.Text = ExamName;
                cmbbxExamName.Enabled = false;
            }
            else if (Edit == true)
            {
                this.Text = "Edit Exams";
                lblTitel.Text = "Edit  Exam";
                if (Exam == "Pending")
                {
                    lblTitel.Text = "Edit Pending Exam";

                }
                lblStatus.Visible = true;
                cmbbxStatus.Visible = true;
                btnSave.Text = "UPDATE";
                btnSave.FillColor = Color.CornflowerBlue; btnSave.FillColor2 = Color.Blue;
                btnSave.FillColor = Color.ForestGreen;
                btnSave.FillColor2 = Color.ForestGreen;
                btnSave.FillColor = Color.Blue;
                btnSave.FillColor2 = Color.CornflowerBlue;
                btnSave.HoveredState.FillColor = Color.CornflowerBlue;
                btnSave.HoveredState.FillColor2 = Color.Blue;
                cmbbxTechnology.Text = TechnologyName;
                cmbbxTechnology.Enabled = false;
                cmbbxExperience.Text = Experience;
                //fetching the students from the GSTtblStudent
                clsExam objStud = new clsExam();
                DataTable dt1 = new DataTable();
                dt1 = objStud.ListExternalStudent();
                cmbbxStudentName.DisplayMember = "FullName";
                cmbbxStudentName.ValueMember = "Studcode";
                cmbbxStudentName.DataSource = dt1;
                cmbbxStudentName.Text = StudentName;
                cmbbxStudentName.Enabled = false;
                //fetching the status of assigned exam those are
                clsExam objStaff = new clsExam();
                DataTable dt2 = new DataTable();
                dt2 = objStaff.FetchStaff();
                cmbbxStaffName.ValueMember = "StaffCode";
                cmbbxStaffName.DisplayMember = "StaffName";
                cmbbxStaffName.DataSource = dt2;
                cmbbxStaffName.Text = StaffName;
                cmbbxExamName.Text = ExamName;
                cmbbxExamName.Enabled = false;
                //labs based on the center
                clsExam objLab = new clsExam();
                objLab.CenterCode = BranchCodeAssign;    /*fetch the center based on the lab name*/
                DataTable dt5 = new DataTable();
                dt5 = objLab.FetchLab();
                cmbbxLabName.DisplayMember = "LabName";
                cmbbxLabName.ValueMember = "LabCode";
                cmbbxLabName.DataSource = dt5;
                cmbbxLabName.Text = LabName;
                //dtpExamDate.Enabled = false;
                dtpExamTme.Text = ExamTime;
                txtDuration.Text = Duration;
                txtDuration.Enabled = false;
                // cmbbxCenter.Enabled = false;

            }
        }


        private void cmbbxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                //fetching the exam here for combobox
                clsExam objExam = new clsExam();
                DataTable dt4 = new DataTable();
                dt4 = objExam.FetchAllExam();
                cmbbxExamName.DisplayMember = "TestName";
                cmbbxExamName.ValueMember = "TestId";
                cmbbxExamName.DataSource = dt4;
                cmbbxExamName.Text = ExamName;
            }
        }

        private void cmbbxCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                if (cmbbxTechnology.Text == "")
                {

                    MessageBox.Show("Please select the Technology..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (cmbbxStudentName.Text == "")
                {
                    MessageBox.Show("Please select the Student..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbbxExamName.Text == "")
                {
                    MessageBox.Show("Please select the Exam..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbbxStaffName.Text == "")
                {
                    MessageBox.Show("Please select the Supervisor Staff..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtpExamTme.Text == "00:00:00")
                {
                    MessageBox.Show("Please select the Exam Time..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbbxLabName.Text == "")
                {
                    MessageBox.Show("Please select the Exam Lab..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    //checking if exam allready exists
                    clsExam objCheck = new clsExam();
                    objCheck.AStudCode = cmbbxStudentName.SelectedValue.ToString();
                    SqlDataReader dr = objCheck.CheckAssignExam();
                    if (dr.Read()) { }
                    if (dr.HasRows == true)
                    {
                        DialogResult= MessageBox.Show("Exam Has been Assigned to this Student Allready..!\n Sure you want to assign this too..!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (DialogResult == DialogResult.Yes)
                        {
                            //saving the arranged exam here
                            clsExam objSaveAssignExam = new clsExam();
                            objSaveAssignExam.AExamId = cmbbxExamName.SelectedValue.ToString();
                            objSaveAssignExam.AStudCode = cmbbxStudentName.SelectedValue.ToString();
                            objSaveAssignExam.ReExamId = ReExamAssignId;
                            objSaveAssignExam.AExamDate = Convert.ToDateTime(dtpExamDate.Value);
                            objSaveAssignExam.AExamTime = dtpExamTme.Value;
                            objSaveAssignExam.SupervisorCode = cmbbxStaffName.SelectedValue.ToString();
                            objSaveAssignExam.ALabCode = cmbbxLabName.SelectedValue.ToString();
                            objSaveAssignExam.LoginStaffCode = LogedStaffCodeAssign;
                            objSaveAssignExam.clsBranchName = BranchNameAssign;
                            objSaveAssignExam.clsBranchCode = BranchCodeAssign;
                            //objSaveAssignExam.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                            objSaveAssignExam.SaveAssignExm();
                          DialogResult=  MessageBox.Show("Exam Assigned Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK) { this.Close(); }
                        }
                    }
                    else
                    {
                        
                            //saving the arranged exam here
                            clsExam objSaveAssignExam = new clsExam();
                            objSaveAssignExam.AExamId = cmbbxExamName.SelectedValue.ToString();
                            objSaveAssignExam.AStudCode = cmbbxStudentName.SelectedValue.ToString();
                            objSaveAssignExam.ReExamId = ReExamAssignId;
                            objSaveAssignExam.AExamDate = Convert.ToDateTime(dtpExamDate.Value);
                            objSaveAssignExam.AExamTime = dtpExamTme.Value;
                            objSaveAssignExam.SupervisorCode = cmbbxStaffName.SelectedValue.ToString();
                            objSaveAssignExam.ALabCode = cmbbxLabName.SelectedValue.ToString();
                            objSaveAssignExam.LoginStaffCode = LogedStaffCodeAssign;
                            objSaveAssignExam.clsBranchName = BranchNameAssign;
                            objSaveAssignExam.clsBranchCode = BranchCodeAssign;
                            //objSaveAssignExam.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                            objSaveAssignExam.SaveAssignExm();
                            DialogResult= MessageBox.Show("Exam Assigned Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK) { this.Close(); }
                    }
                }
            }
            else if (Edit == true)
            {
                switch (Exam)
                {

                    case "Assigned":
                        //updating the status of the assigned test
                        clsExam objEditAE = new clsExam();
                        //objEditAE.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                        objEditAE.UpdateId = Upid;
                        objEditAE.AExamDate = dtpExamDate.Value;
                        objEditAE.AExamTime = dtpExamTme.Value;
                        objEditAE.SupervisorCode = cmbbxStaffName.SelectedValue.ToString();
                        objEditAE.ALabCode = cmbbxLabName.SelectedValue.ToString();
                        objEditAE.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                        objEditAE.EditAssignedExam();
                        MessageBox.Show("Assigned Exam Updated Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "Pending":
                        lblTitel.Text = "Edit Pending Exam";
                        //updating the status of the assigned test
                        clsExam objEditPE = new clsExam();
                        objEditPE.AExamDate = dtpExamDate.Value;
                        objEditPE.AExamTime = dtpExamTme.Value;
                        objEditPE.ALabCode = cmbbxLabName.SelectedValue.ToString();
                        objEditPE.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                        objEditPE.UpdateId = Upid;
                        objEditPE.clsBranchName = BranchNameAssign;
                        objEditPE.clsBranchCode = BranchCodeAssign;
                        objEditPE.AExmStatus = int.Parse(cmbbxStatus.SelectedValue.ToString());
                        objEditPE.EditPendingExam();
                        MessageBox.Show("Pending Exam Updated Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    default: break;
                }
            }
        }
        //making a methode for clearing the all comboboxes
        public void ClearAll()
        {
            //making them editable
            cmbbxStaffName.Enabled = true;
            cmbbxLabName.Enabled = true;
            cmbbxStatus.Enabled = true;
            cmbbxTechnology.Enabled = true;
            dtpExamDate.Enabled = true;
            txtDuration.Enabled = true;
            dtpExamTme.Enabled = true;
            txtBranch.Enabled = true;
            cmbbxStudentName.Enabled = true;
            cmbbxExamName.Enabled = true;
            //making then empty
            cmbbxStaffName.Text = string.Empty;
            cmbbxLabName.Text = string.Empty;
            cmbbxStatus.Text = string.Empty;
            cmbbxTechnology.Text = string.Empty;
            dtpExamDate.Text = string.Empty;
            txtDuration.Text = string.Empty;
            dtpExamTme.Text = string.Empty;
            txtBranch.Text = string.Empty;
            cmbbxStudentName.Text = string.Empty;
            cmbbxExamName.Text = string.Empty;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clearing the all selections
            DialogResult = MessageBox.Show("Sure want to clear the selection..!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                //nothing
            }

        }



        private void cmbbxStudentName_Leave(object sender, EventArgs e)
        {
            //validation for the student combobox
            if (cmbbxStudentName.Text == "")
            {
                MessageBox.Show("Please select the Student..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbbxExamName_Leave(object sender, EventArgs e)
        {
            //validation for the Exam Name combobox
            if (cmbbxExamName.Text == "")
            {
                MessageBox.Show("Please select the Exam..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbbxStaffName_Leave(object sender, EventArgs e)
        {
            //validation for the supervisor taff combobox
            if (cmbbxStaffName.Text == "")
            {
                MessageBox.Show("Please select the Supervisor Staff..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpExamTme_Leave(object sender, EventArgs e)
        {
            //validating the exam time
            if (dtpExamTme.Text == "00:00:00")
            {
                MessageBox.Show("Please select the Exam Time..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpExamDuration_Leave(object sender, EventArgs e)
        {
            //validating the exam duration

        }

        private void cmbbxLabName_Leave(object sender, EventArgs e)
        {
            //validation for the cmbbxLabName
            if (cmbbxLabName.Text == "")
            {
                MessageBox.Show("Please select the Exam Lab..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// fetching the students who matched the above technology and experience || qualification
        /// </summary>
        public void ListExternalStudents()
        {
            if (Edit == false)
            {
                //fetching the students from the GSTtblStudent
                clsExam objStud = new clsExam();
                objStud.ATechnology = cmbbxTechnology.SelectedValue.ToString();
                DataTable dt = new DataTable();
                dt = objStud.ListExternalStudent();
                cmbbxStudentName.DataSource = dt;
                cmbbxStudentName.DisplayMember = "FullName";
                cmbbxStudentName.ValueMember = "StudCode";
                cmbbxStudentName.BindingContext = BindingContext;
            }
        }
        private void cmbbxStudentName_Click(object sender, EventArgs e)
        {
            // ListExternalStudents();
        }

        private void cmbbxStaffName_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                //fetching the status of assigned exam those are
                clsExam objStaff = new clsExam();
                DataTable dt2 = new DataTable();
                dt2 = objStaff.FetchStaff();
                cmbbxStaffName.ValueMember = "StaffCode";
                cmbbxStaffName.DisplayMember = "StaffName";
                cmbbxStaffName.DataSource = dt2;
                cmbbxStaffName.Text = string.Empty;
            }
        }
        private void cmbbxStatus_Click(object sender, EventArgs e)
        {
            //fetching the status for the edditing the pending exam and assigned exam

            clsExam objCenter = new clsExam();
            DataTable dt = new DataTable();
            dt = objCenter.FetchStatus();
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dt;

        }

        private void dtpExamDate_Leave(object sender, EventArgs e)
        {
            //if selected the late date show error
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            if (dtpExamDate.Value < dt)
            {
                MessageBox.Show("Please select the valid date..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbbxTechnology_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///summery
            ///fetch the seleected technology related experience exam like   
            cmbbxExperience.Items.Clear();
            cmbbxExperience.Items.Add("Fresher");
            cmbbxExperience.Items.Add("1 - 3 Years");
            cmbbxExperience.Items.Add("3 & Above");
            if (cmbbxExperience.Text == "Fresher")
            {
                lblQualification.Visible = true;
                cmbbxQualification.Visible = true;
            }
            else
            {
                lblQualification.Visible = false;
                cmbbxQualification.Visible = false;
            }
        }

        private void cmbbxExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///summery
            ///based on the experience fetch the qualification or the exams directly
            ///summmery
            ///have to fetch qualification based on the test
            if (cmbbxExperience.Text == "Fresher")
            {
                lblQualification.Visible = true;
                cmbbxQualification.Visible = true;
                lblSpecialization.Visible = true;
                cmbbxSpecialization.Visible = true;
                cmbbxQualification.Items.Clear();
                cmbbxQualification.Items.Add("SSC");
                cmbbxQualification.Items.Add("HSC");
                cmbbxQualification.Items.Add("UG");
                cmbbxQualification.Items.Add("PG");
            }
            else if (cmbbxExperience.Text == "1 - 3 Years")
            {
                lblQualification.Visible = false;
                cmbbxQualification.Visible = false;
                lblSpecialization.Visible = false;
                cmbbxSpecialization.Visible = false;
                cmbbxStudentName.DataSource = null;
                cmbbxStudentName.Items.Clear();
                clsExam objList = new clsExam();
                DataTable dt = new DataTable();
                objList.ATechnology = cmbbxTechnology.SelectedValue.ToString();
                dt = objList.ListExternalStudent1to3();
                cmbbxStudentName.DataSource = null;
                cmbbxStudentName.Items.Clear();
                cmbbxStudentName.DataSource = dt;
                cmbbxStudentName.DisplayMember = "FullName";
                cmbbxStudentName.ValueMember = "CandidateCode";

            }
            else if (cmbbxExperience.Text == "3 & Above")
            {
                lblQualification.Visible = false;
                cmbbxQualification.Visible = false;
                lblSpecialization.Visible = false;
                cmbbxSpecialization.Visible = false;
                cmbbxStudentName.DataSource = null;
                cmbbxStudentName.Items.Clear();
                clsExam objList = new clsExam();
                objList.ATechnology = cmbbxTechnology.SelectedValue.ToString();
                DataTable dt1 = new DataTable();
                dt1 = objList.ListExternalStudent3moreExp();
                cmbbxStudentName.DisplayMember = "FullName";
                cmbbxStudentName.ValueMember = "StudCode";
                cmbbxStudentName.DataSource = dt1;
            }
            else
            {
                lblQualification.Visible = false;
                cmbbxQualification.Visible = false;
                lblSpecialization.Visible = false;
                cmbbxSpecialization.Visible = false;
            }

        }

        private void cmbbxQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///summery
            ///based on the experience if it is fresher this combobox will appear
            if (cmbbxQualification.Text == "UG")
            {
                cmbbxSpecialization.Visible = true;
                lblSpecialization.Visible = true;
                ///this methode call the graduations 
                clsExam objFetch = new clsExam();
                DataTable dt = new DataTable();
                dt = objFetch.ListGraduation();
                cmbbxSpecialization.Items.Clear();
                cmbbxSpecialization.DataSource = null;
                cmbbxSpecialization.DataSource = dt;
                cmbbxSpecialization.DisplayMember = "GraduationName";
                cmbbxSpecialization.ValueMember = "GraduationId";
            }
            else if (cmbbxQualification.Text == "PG")
            {
                cmbbxSpecialization.Visible = true;
                lblSpecialization.Visible = true;
                ///this methode call the post  graduations 
                clsExam objFetch = new clsExam();
                DataTable dt = new DataTable();
                dt = objFetch.ListGraduation();
                cmbbxSpecialization.DataSource = null;
                cmbbxSpecialization.Items.Clear();
                cmbbxSpecialization.DataSource = dt;
                cmbbxSpecialization.DisplayMember = "PostGraduationName";
                cmbbxSpecialization.ValueMember = "PostGraduationId";
            }
        }
        /// <summary>
        /// fetching the technology for the combobox
        /// </summary>
        public void ListTechnology()
        {
            //fetching the tblCourse here for saving the add exam ,,
            clsExam objFchCourse = new clsExam();
            DataTable data = new DataTable();
            data = objFchCourse.ListTechnology();
            cmbbxTechnology.DataSource = data;
            cmbbxTechnology.DisplayMember = "SkillName";
            cmbbxTechnology.ValueMember = "SkillId";

        }

        private void cmbbxTechnology_Click(object sender, EventArgs e)
        {

            ListTechnology();
        }

        private void cmbbxTechnology_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ///summery
            ///have to fetch the experinece if saved in the add exam
            cmbbxExperience.Items.Clear();
            cmbbxExperience.Items.Add("Fresher");
            cmbbxExperience.Items.Add("1 - 3 Years");
            cmbbxExperience.Items.Add("3 & Above");

        }

        private void cmbbxLabName_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                //labs based on the center
                clsExam objLab = new clsExam();
                objLab.clsBranchCode = BranchCodeAssign;
                DataTable dt5 = new DataTable();
                dt5 = objLab.FetchLab();
                cmbbxLabName.DisplayMember = "LabName";
                cmbbxLabName.ValueMember = "LabCode";
                cmbbxLabName.DataSource = dt5;
            }
        }
    }
}