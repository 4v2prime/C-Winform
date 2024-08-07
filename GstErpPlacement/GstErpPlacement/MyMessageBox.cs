using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GstErpPlacement
{
    public partial class MyMessageBox : Form
    {
        public string Message {  get; set; }
        public string IconType { get; set; }

        public MyMessageBox()
        {
            InitializeComponent();
        }
        public MyMessageBox(MyMessageBox obj)
        {
            Message = obj.Message;
            IconType = obj.IconType;
            
            lblMessage.Text =Message;
        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            IconType = "Success";
            lblMessage.Text = "So what..!";
            //MessageIconType();

        }
        public void MessageIconType()
        {
            if (IconType == "Error")
            {
                string imagePath = "W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\warning.png";
                if (System.IO.File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    ImageButton.Image = image;
                    ImageButton.Size = new Size(8,8);
                }
            }
            else if (IconType == "Success")
            {
                //ImageButton.Load("W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\success.png");
                string imagePath1 = "W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\success.png";
                if (System.IO.File.Exists(imagePath1))
                {
                    Image image = Image.FromFile(imagePath1);
                    ImageButton.Image = image;
                    ImageButton.Size = new Size(8,8);
                    //ImageButton.Size = image.Size;
                }
            }
            else if (IconType == "Warning")
            {
                //MessageBoxIcon.Load("W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\warningorg.png");
                string imagePath2 = "W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\warningorg.png";
                if (System.IO.File.Exists(imagePath2))
                {
                    Image image = Image.FromFile(imagePath2);
                    ImageButton.Image = image;
                    ImageButton.Size = new Size(32, 32);
                }
            }
            else if (IconType == "Information")
            { 
                //MessageBoxIcon.Load("W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\information.png");
                string imagePath3 = "W:\\DotNet\\Software\\GstErpPlacement\\GstErpPlacement\\Resources\\information.png";
                if (System.IO.File.Exists(imagePath3))
                {
                    Image image = Image.FromFile(imagePath3);
                    ImageButton.Image = image;
                    ImageButton.Size = new Size(32, 32);
                }
            }
              
            }
        }
    }

