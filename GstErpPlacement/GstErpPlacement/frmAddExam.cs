using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using lblGstErpPlacement;
using static Siticone.UI.Native.WinApi;

//`namespace GstErpPlacement.Properties { }
namespace GstErpPlacement
{
    public partial class frmAddExam : Form
    {
        public bool Edit { get; set; }
        public int TestId { get; set; }
        public string TechnologyName { get; set; }
        public string ExamName { get; set; }
        //public string ExamId { get; set; }/*this is for auto increment exam code selectedPath*/
        public string TotalMarks { get; set; }
        public string Duration { get; set; }
        public float PassingMarks { get; set; }
        public float NooOfQuestions { get; set; }
        public string FilePath { get; set; }
        public string LognedStaffCodeAdd { get; set; }
        public string CenterCodeAdd { get; set; }
        public string CenterNameAdd { get; set; }
        public string ExperienceOfExam { get; set; }
        public string QualificationOfExam { get; set; }
        //public string Status { get; set; }
        public frmAddExam()
        {
            InitializeComponent();
        }
        public frmAddExam(frmAddExam objEdit)
        {
            Edit = false;
            Edit = objEdit.Edit;
            TestId = objEdit.TestId;
            TechnologyName = objEdit.TechnologyName;
            ExamName = objEdit.ExamName;
            TotalMarks = objEdit.TotalMarks;
            Duration = objEdit.Duration;
            PassingMarks = objEdit.PassingMarks;
            NooOfQuestions = objEdit.NooOfQuestions;
            FilePath = objEdit.FilePath;
            LognedStaffCodeAdd = objEdit.LognedStaffCodeAdd;
            CenterCodeAdd = objEdit.CenterCodeAdd;
            CenterNameAdd = objEdit.CenterNameAdd;
            //Status = objEdit.Status;
        }
        /// <summary>
        /// fetching the technology for the combobox technology 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ListTechnology()
        {
            //fetching the tblCourse here for saving the add exam ,
            clsExam objFchCourse = new clsExam();
            DataTable data = new DataTable();
            data = objFchCourse.ListTechnology();
            cmbbxTechnology.ValueMember = "SkillId";
            cmbbxTechnology.DisplayMember = "SkillName";
            cmbbxTechnology.DataSource = data;
        }
        private void frmAddExam_Load(object sender, EventArgs e)
        {
            //border colour of tbl layout pannel making it black
            //tbllytAddExam.CellBorder.colour = Color.Black;;
            switch (Edit)
            {
                case false:
                    DateTime SysDate = DateTime.Now;
                    SysDate.ToShortDateString();
                    dtpDuration.Text ="00:00:00";  
                    break;
                case true:
                    //this.Text = "Edit Exam";
                    lblTitel.Text = "Edit Exam";
                    btnSave.Text = "UPDATE";
                    btnSave.FillColor = Color.Blue;
                    btnSave.FillColor2 = Color.CornflowerBlue;
                    btnSave.HoveredState.FillColor = Color.CornflowerBlue;
                    btnSave.HoveredState.FillColor2 = Color.Blue;
                    ///fetching the technologies for the cmbbxtechnologuy
                    ListTechnology();
                    cmbbxTechnology.Text = TechnologyName;
                    cmbbxTechnology.Enabled = false;
                    cmbbxExperience.Text = ExperienceOfExam;
                    cmbbxExperience.Enabled = false;
                    if (ExperienceOfExam== "Fresher") 
                    {
                        ///then make the remaing two cpmboxox active
                        ///then put their values form the database
                        ///and lock them
                        
                    }
                    else if (ExperienceOfExam == "1 - 3 Years")
                    {
                        ///just show
                        
                    }
                    else if (ExperienceOfExam == "3 & Above")
                    {
                        ///just show
                    }
                    txtExamName.Text = ExamName;
                    txtExamName.Enabled = false;
                    dtpDuration.Text = Duration;
                    txtTotalMarks.Text = TotalMarks;
                    //txtTotalMarks.Enabled=false;
                    txtPassingMarks.Text = PassingMarks.ToString();
                    //txtPassingMarks.Enabled=false;
                    txtTotalNoOfQuestions.Text = NooOfQuestions.ToString();
                    //txtTotalNoOfQuestions.Enabled= false;
                    lnklblDocument.Text = Path.GetFileName(FilePath);/*getting the file path*/
                    break;
                default: break;
            }
        }
        //validations
        private void txtExamName_Leave_1(object sender, EventArgs e)
        {

            //validating the exam name textbox
            if (string.IsNullOrEmpty(txtExamName.Text))
            {
                txtExamName.Focus();
                MessageBox.Show("Plese enter the name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void txtTotalMarks_Leave(object sender, EventArgs e)
        {

            //if txtbx is empty
            if (string.IsNullOrEmpty(txtTotalMarks.Text))
            {
                txtTotalMarks.Focus();
                MessageBox.Show("Please enter the totsl marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

            }
        }

        private void txtPassingMarks_Leave(object sender, EventArgs e)
        {
            //validating the passign marks
            if (string.IsNullOrEmpty(txtPassingMarks.Text))
            {
                txtPassingMarks.Focus();
                MessageBox.Show("Please enter the passing marks..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

            }
        }

        private void txtTotalNoOfQuestions_Leave(object sender, EventArgs e)
        {
            //validating the total number of questions
            if (string.IsNullOrEmpty(txtTotalNoOfQuestions.Text))
            {
                txtTotalNoOfQuestions.Focus();
                MessageBox.Show("Please enter the passing marks..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
        private void txtTotalMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validating the textbox of total marks
            char ch = (char)e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPassingMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validating the passing marks textbox
            char ch = (char)e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTotalNoOfQuestions_KeyPress(object sender, KeyPressEventArgs e)
        {

            //validating the total no of question textbox to take only numeric value
            char ch = (char)e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtExamName.Text))
            {
                txtExamName.Focus();
                MessageBox.Show("Plese enter the name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (string.IsNullOrEmpty(txtTotalMarks.Text))
            {
                txtTotalMarks.Focus();
                MessageBox.Show("Please enter the totsl marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPassingMarks.Text))
            {
                txtPassingMarks.Focus();
                MessageBox.Show("Please enter the passing marks..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtTotalNoOfQuestions.Text))
            {
                txtTotalNoOfQuestions.Focus();
                MessageBox.Show("Please enter the total questions..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            switch (Edit)
            {
                case false:
                    //code for the saving the new exam here
                    btnSave.FillColor = Color.ForestGreen;
                    btnSave.FillColor2 = Color.ForestGreen;
                    //validation if exam naem is allready been taken
                    clsExam objCHeck = new clsExam();
                    objCHeck.AExmName = txtExamName.Text;
                    SqlDataReader dr = objCHeck.CheckAllExam();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Exam Name allreday exists..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // code for saving add exam to database  here 
                        clsExam objSaveAddExm = new clsExam();
                        objSaveAddExm.ATechnology = cmbbxTechnology.SelectedValue.ToString();
                        objSaveAddExm.AExmName = txtExamName.Text;
                        objSaveAddExm.Experience = cmbbxExperience.Text;
                    //    objSaveAddExm.QualificationId = int.Parse(cmbbxSpecialization.SelectedValue.ToString());
                        objSaveAddExm.AExmDuration = dtpDuration.Text;
                        objSaveAddExm.AExmTotmarks = Convert.ToInt32(txtTotalMarks.Text);
                        objSaveAddExm.AExmPassingMarks = Convert.ToInt32(txtPassingMarks.Text);
                        objSaveAddExm.AExmttlQuestions = Convert.ToInt32(txtTotalNoOfQuestions.Text);
                        objSaveAddExm.UploadFile = FilePath;
                        objSaveAddExm.LoginStaffCode = LognedStaffCodeAdd;
                        //objSaveAddExm.AExmStatus = Convert.ToInt32(cmbbxStatus.SelectedValue);
                        objSaveAddExm.SaveNewExam();

                        MessageBox.Show("New Exam Added Successfully..! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case true:
                    //code for the editing the exam here
                    //editing the add exam here
                    clsExam objedit = new clsExam();
                    objedit.UpdateId = TestId;
                    objedit.AExmDuration = (dtpDuration.Text);
                    objedit.AExmTotmarks = Convert.ToInt32(txtTotalMarks.Text);
                    objedit.AExmPassingMarks = Convert.ToInt32(txtPassingMarks.Text);
                    objedit.AExmttlQuestions = Convert.ToInt32(txtTotalNoOfQuestions.Text);
                    objedit.UploadFile = FilePath;
                    objedit.LoginStaffCode = LognedStaffCodeAdd;
                    objedit.EditAddExam();

                    DialogResult = MessageBox.Show("Exam Edited Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                    {

                    }
                    break;
                default: break;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //uploading the file here 
            if (Edit == false)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select a Question Paper";
                openFileDialog.Filter = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                }
                lnklblDocument.Text = Path.GetFileName(FilePath);
            }
            else if (Edit == true)
            {
                // uploaded file edit here
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select a Question Paper";
                openFileDialog.Filter = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                }
                lnklblDocument.Text = Path.GetFileName(FilePath);
            }
        }



        private void lnklblDocument_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //opening the saved document
            if (FilePath == "NULL")
            {
                MessageBox.Show("Please upload file first..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(FilePath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Edit == true || Edit == false)
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
        }

        private void cmbbxTechnology_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///summery
            ///have to fetch the experinece if saved in the add exam
            ///  
            cmbbxExperience.Items.Clear();
            cmbbxExperience.Items.Add("Fresher");
            cmbbxExperience.Items.Add("1 - 3 Years");
            cmbbxExperience.Items.Add("3 & Above");
        }

        private void cmbbxExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            else
            {
                lblQualification.Visible = false;
                cmbbxQualification.Visible = false;
                lblSpecialization.Visible = false;
                cmbbxSpecialization.Visible=false;
            }
        }
        /// <summary>
        /// fetching the technology for the combobox on this event so the values don't appear directly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbbxTechnology_Click(object sender, EventArgs e)
        {
            ListTechnology();
        }
        /// <summary>
        /// in the qualification i saved vaguely like ssc hsc ug and pg 
        /// now when i select the option ug the below cmbbxSpecilization shloud appear with the ug courses
        /// when i select the option pg the below cmbbxSpecilization shloud appear with the pg courses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbbxQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxQualification.Text == "UG")
            {
                cmbbxSpecialization.Visible = true;
                lblSpecialization.Visible=true;
                ///this methode call the graduations 
                clsExam objFetch= new clsExam();
                DataTable dt = new DataTable();
                dt = objFetch.ListGraduation();
                cmbbxSpecialization.DataSource = null;
                cmbbxSpecialization.Items.Clear();
                cmbbxSpecialization.DataSource = dt;
                cmbbxSpecialization.DisplayMember= "GraduationName";  
                cmbbxSpecialization.ValueMember= "GraduationId";
            }
            else if (cmbbxQualification.Text == "PG")
            {
                cmbbxSpecialization.Visible = true;
                lblSpecialization.Visible = true;
                ///this methode call the post  graduations 
                clsExam objFetch = new clsExam();
                DataTable dt1 = new DataTable();
                dt1 = objFetch.ListGraduation();
                cmbbxSpecialization.Items.Clear();
                cmbbxSpecialization.DataSource = null;
                cmbbxSpecialization.DataSource = dt1;
                cmbbxSpecialization.DisplayMember = "PostGraduationName";
                cmbbxSpecialization.ValueMember = "PostGraduationId";
            }
        }
    }
}