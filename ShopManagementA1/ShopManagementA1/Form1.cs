using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.MdiParent = this;
            objLogin.Show();

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser objRegister = new RegisterUser();
            objRegister.MdiParent= this;
            objRegister.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSize objProduct = new frmSize();objProduct.MdiParent= this;objProduct.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type objType = new Type();objType.MdiParent= this;objType.Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product objPrd=new Product();objPrd.MdiParent= this; objPrd.Show();  
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize objSize=new frmSize();objSize.MdiParent= this;objSize.Show();
        }
    }
}
