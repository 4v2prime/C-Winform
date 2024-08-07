using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstapppl1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text;
            string UserCity = cmbbxCity.SelectedItem.ToString();
            MessageBox.Show(UserName+" Welcome to Rahitech...! "+"Your City is"+UserCity );
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cmbbxCity.Items.Add("Nasik");
            cmbbxCity.Items.Add(" Lonavala");
        }
    }
}
