using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1frm
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text;
            string UserState =cmbbxState.SelectedItem.ToString();
            string UserCity =cmbbxCity.SelectedItem.ToString();
            MessageBox.Show(UserName + " Wel-come to RAHITECH..!" + " Your State is " + UserState+ " Your City is " + UserCity);
        }

        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                     
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxCity.Items.Clear();
            if (cmbbxState.SelectedItem.ToString()== "Maharashtra")
            {
                cmbbxCity.Items.Add("Pune");
                cmbbxCity.Items.Add("Mumbai");
                cmbbxCity.Items.Add("Nasik");
            }
            else if (cmbbxState.SelectedItem.ToString() == "Gujrat")
            {
                cmbbxCity.Items.Add("Surat");
                cmbbxCity.Items.Add("Badodara");
                cmbbxCity.Items.Add("Amdabad");
            }
           else if (cmbbxState.SelectedItem.ToString() == "Karnataka")
            {
                cmbbxCity.Items.Add("Vijapur");
                cmbbxCity.Items.Add("Gulbarg");
                cmbbxCity.Items.Add("Banglore");
            }
        }

        private void lblRahitech_Click(object sender, EventArgs e)
        {

        }
    }
}
