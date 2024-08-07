using lblGstErpPlacement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GstErpPlacement
{
    public partial class frmAddResult : Form
    {
        public bool Edit { get; set; }
        public int TestId { get; set; }
        public string StudentName { get; set; }
        public string StudentCode { get; set; }
        public string Course { get; set; }
        public string ExamName { get; set; }
        public string ExamDate { get; set; }
        public string ResultStatus { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public int PasssingMarks { get; set; }
        public int RUHere { get; set; }
        public string ExmResult { get; set; }
        public frmAddResult()
        {
            InitializeComponent();
            
        }
        public frmAddResult(frmAddResult objAdd)
        {
            Edit = false;
            Edit = objAdd.Edit;
            TestId=objAdd.TestId;
            StudentName=objAdd.StudentName;
            StudentCode=objAdd.StudentCode;
            Course=objAdd.Course;
            ExamName=objAdd.ExamName;
            ExamDate=objAdd.ExamDate;
            TotalMarks=objAdd.TotalMarks;
            PasssingMarks=objAdd.PasssingMarks;
        }
        private void frmAddResult_Load(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                btnAdd.Enabled = false;
                lblMyExamDate.Text = ExamDate;
                lblMyExamName.Text = ExamName;
                lblMyCourse.Text = Course;
                lblMyStudName.Text = StudentName;
                lblMyTotalMarks.Text = TotalMarks.ToString();
                txtObatineMarks.Text=ObtainedMarks.ToString();
                
            }
            else if(Edit==true)
            {
                this.Text = "Edit Result";
                lblTitelAddResult.Text = "Edit Result";
                btnAdd.Text = "Update";
                btnAdd.FillColor = Color.CornflowerBlue; btnAdd.FillColor2 = Color.Blue;
                btnAdd.Enabled = false;
                lblMyExamDate.Text = DateTime.Parse(ExamDate).ToShortDateString();
                lblMyExamName.Text = ExamName;
                lblMyCourse.Text = Course;
                lblMyStudName.Text = StudentName;
                lblMyTotalMarks.Text = TotalMarks.ToString();
                rdbbtnPresent.Checked=true;
                txtObatineMarks.Text = ObtainedMarks.ToString();
            }
        }

        private void rdbbtnPresent_CheckedChanged(object sender, EventArgs e)
        {
            //present code here status for the present is 30
            btnAdd.Enabled = true;
            if (rdbbtnPresent.Checked==true)
            {
                // RUHere = "Present";
                RUHere = 30;
            }
        }

        private void rdbbtnAbsent_CheckedChanged(object sender, EventArgs e)
        {
            //abcent here status for the abscent is 31

            btnAdd.Enabled=false;
            if (rdbbtnAbsent.Checked == true)
            {
                btnReExam.Visible = true;
                //RUHere = "Absent";
                RUHere = 31;
            }
        }
        public void ExamResult()
        {
            int marks = int.Parse(txtObatineMarks.Text);
            if (marks >= PasssingMarks)
            {
                ResultStatus="Pass";
            }
            else
            {
                ResultStatus= "Fail";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                btnAdd.FillColor = Color.ForestGreen;
                btnAdd.FillColor2 = Color.ForestGreen;
                //saving the result to the database
                clsExam objSave = new clsExam();
                objSave.UpdateId = TestId;
                objSave.AStudCode = StudentCode;
                objSave.ObtainedMarks = int.Parse(txtObatineMarks.Text);
                objSave.AttendanceId = RUHere;
                ExamResult();
                objSave.Result = ResultStatus;
                objSave.SaveResult();
                MessageBox.Show("Result Saved Successully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Edit == true)
            {
                btnAdd.FillColor = Color.Blue; btnAdd.FillColor2 = Color.Blue;
                //saving the result to the database
                clsExam objSave = new clsExam();
                objSave.UpdateId = TestId;
                objSave.ObtainedMarks = int.Parse(txtObatineMarks.Text);
                ExamResult();
                objSave.Result = ResultStatus;
                objSave.UpdateResult();
                MessageBox.Show("Result Updated Successully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtObatineMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation for only interger input
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to cancel..!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //nothing happens 
            }
        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            btnAdd.FillColor = Color.LawnGreen;
            btnAdd.FillColor2 = Color.ForestGreen;
        }

        private void txtObatineMarks_Leave(object sender, EventArgs e)
        {
            ExamResult();
            if (ResultStatus == "Fail")
            {
                btnReExam.Visible = true;
            }
            else { btnReExam.Visible = false; }
        }

        private void btnReExam_Click(object sender, EventArgs e)
        {
            ///summery
            ///after clicking on the reexam button the old assign id will go to the new assignexamid ad retestassign id in gsttblassigntest
            /// adding to the reexam code save assign exam 
            frmAssignExam objReexam= new frmAssignExam();
            objReexam.Exam = "ReExam";
            objReexam.ReExamAssignId = TestId;
            objReexam.StudentName = StudentName;
            objReexam.ExamName = ExamName;
            DialogResult = MessageBox.Show("Are you Sure !!! Want to Re-Assign..? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult== DialogResult.Yes) 
            {
                objReexam.ShowDialog();
            }
            else
            {
                //noting happens
            }
        }
    }
}
