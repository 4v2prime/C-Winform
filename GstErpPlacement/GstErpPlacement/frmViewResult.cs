using lblGstErpPlacement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GstErpPlacement
{
    public partial class frmViewResult : Form
    {
        public int FetchId { get; set; }
        public string ResultStatus {  get; set; }
        public frmViewResult()
        {
            InitializeComponent();
        }
        public frmViewResult(frmViewResult objfetch)
        {
            FetchId = objfetch.FetchId;
            ResultStatus = objfetch.ResultStatus;
        }
        private void frmViewResult_Load(object sender, EventArgs e)
        {
            clsExam objfetch = new clsExam();
            objfetch.UpdateId = FetchId;
            SqlDataReader dr;
            dr = objfetch.FetchResult();
            if (dr.Read())
            {
                lblMyExamStatus.Text= dr["ResultStatus"].ToString();
                ResultStatus= dr["ResultStatus"].ToString();
                lblMyExamName.Text = dr["TestName"].ToString();
                lblMyExamDate.Text= DateTime.Parse(dr["AssignDate"].ToString()).ToShortDateString();
                lblMyStudName.Text= dr["FullName"].ToString();
                lblMyTotalMarks.Text= dr["TotalMarks"].ToString();
                lblMyObtainedMarks.Text= dr["ObtainedMarks"].ToString();
            }
            else
            {
                MessageBox.Show("Please add result first..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (ResultStatus == "Fail")
            {
                btnReExam.Visible = true;
            }
        }

        private void btnReExam_Click(object sender, EventArgs e)
        {
            ///summery
            ///after clicking on the reexam button the old assign id will go to the new assignexamid ad retestassign id in gsttblassigntest
            /// adding to the reexam code save assign exam 
            frmAssignExam objReexam = new frmAssignExam();
            objReexam.Exam = "ReExam";
            objReexam.ReExamAssignId = FetchId;
            objReexam.StudentName = lblMyStudName.Text;
            objReexam.ExamName = lblMyExamName.Text;
            DialogResult = MessageBox.Show("Are you Sure !. Want to Re-Assign..? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
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
