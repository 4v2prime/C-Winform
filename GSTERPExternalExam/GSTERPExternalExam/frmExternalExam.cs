//using MsBox.Avalonia.Dto;
using BespokeFusion;
using Pretty;
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
    public partial class frmExternalExam : Form
    {
        public frmExternalExam()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            //creating the instace to open addExam form here
            frmAddExam addexam= new frmAddExam();
            addexam.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Checked);
            //MaterialMessageBox.ShowError("Your cool message here", "");
            //MessageBoxCustomParams customParams = new MessageBoxCustomParams();
            //customParams.ContentMessage = "Ajay is Something..!";
            //customParams.InputParams = new InputParams();

            // Custom message box function call
            //ShowCustomMessageBox("This is a custom message!", "Custom Message", MessageBoxIcon.Information);

        }
        private void ShowCustomMessageBox(string message, string title, MessageBoxIcon icon)
        {
            using (CustomMessageBoxForm customMessageBox = new CustomMessageBoxForm(message, title, icon))
            {
                customMessageBox.ShowDialog();
            }
        }
        public partial class CustomMessageBoxForm : Form
        {
            public CustomMessageBoxForm(string message, string title, MessageBoxIcon icon)
            {
                //InitializeComponent();
                //lblMessage.Text = message;
                //this.Text = title;

                //// Set the icon based on MessageBoxIcon
                //switch (icon)
                //{
                //    case MessageBoxIcon.Information:
                //        pictureBoxIcon.Image = SystemIcons.Information.ToBitmap();
                //        break;
                //    case MessageBoxIcon.Warning:
                //        pictureBoxIcon.Image = SystemIcons.Warning.ToBitmap();
                //        break;
                //    case MessageBoxIcon.Error:
                //        pictureBoxIcon.Image = SystemIcons.Error.ToBitmap();
                //        break;
                //    default:
                //        break;
                //}
            }

            private void btnOK_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }

        private void frmExternalExam_Load(object sender, EventArgs e)
        {
           

        }
    }
}

