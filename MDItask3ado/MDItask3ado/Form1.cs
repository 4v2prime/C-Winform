using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDItask3ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome objHome = new frmHome();
            objHome.Show();
            objHome.MdiParent = this;

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu objMenu = new frmMenu();
            objMenu.Show();
            objMenu.MdiParent = this;

        }
    }
}
