using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoGetSet1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 Frm2 = new Form2(txtName.Text,txtContent.Text);
              
            Frm2.Show();
            

        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
