using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiDemoado1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome objHome = new frmHome();
            objHome.Show();
           objHome.MdiParent = this;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminBilling objAdminBilling= new frmAdminBilling();
            objAdminBilling.Show();
           objAdminBilling.MdiParent=this;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustBilling objcbilling = new frmCustBilling();
            objcbilling.Show();
           objcbilling.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
           objLogin.MdiParent = this;
        }
    }
}
