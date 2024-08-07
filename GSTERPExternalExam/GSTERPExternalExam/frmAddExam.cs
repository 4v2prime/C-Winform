using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTERPExternalExam
{
    public partial class frmAddExam : Form
    {
        public frmAddExam()
        {
            InitializeComponent();
        }
        


        private void btnSave_Click(object sender, EventArgs e)
        {
            //saving the added eaxm details to the database
            
        }

        private void frmAddExam_Load(object sender, EventArgs e)
        {
            //fetching the tblCourse for the combox course
            clsExternalExam fetchc=new clsExternalExam();
            DataTable dt = new DataTable();
            dt = fetchc.FetchCourse();
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.ValueMember = "Coursecode";
            cmbbxCourse.DataSource = dt;
            //fetching the tblstatus for the status combobox
            DataTable dt2=new DataTable();
            dt2= fetchc.FetchStatus();
            cmbbxStatus.DisplayMember= "Status";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dt2;
        }
    }
}
