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
    public partial class RegisterUser : Form
    {
        string gen;
        public RegisterUser()
        {
            InitializeComponent();
        }

        

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMale.Checked==true) { gen = "Male"; }
        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnFemale.Checked == true) { gen = "Female"; }
        }

        private void rdbtnOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOther.Checked == true) { gen = "Other"; }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
          
            string gen = rdbtnMale.Text;
            clsShopManage objSave = new clsShopManage(cmbbxType.SelectedItem.ToString(), txtName.Text, txtEmail.Text,gen,cmbbxContry.SelectedItem.ToString() ,cmbbxState.SelectedItem.ToString(), cmbbxCity.SelectedItem.ToString(), txtPassword.Text);
            objSave.RSaveData();
            MessageBox.Show("User Registerd Successfully...!");

        }

        private void cmbbxContry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbbxContry.Items.Clear();India Japan America Russia Germany

            cmbbxState.Items.Clear();
            if (cmbbxContry.Text == "India") {cmbbxState.Items.Add("Maharashtra");cmbbxState.Items.Add("Gujrat");cmbbxState.Items.Add("Haryana"); cmbbxState.Items.Add("Uttar Pradesh"); cmbbxState.Items.Add("Tamil Nadu"); }
            if (cmbbxContry.Text == "Japan") {cmbbxState.Items.Add("Tokyo");cmbbxState.Items.Add("Osaka");cmbbxState.Items.Add("Hokkaido"); cmbbxState.Items.Add("Aichi"); cmbbxState.Items.Add("Fukuoka"); }
            if (cmbbxContry.Text == "America"){ cmbbxState.Items.Add("Texas");cmbbxState.Items.Add("Hawaii");cmbbxState.Items.Add("Washington"); }
            if (cmbbxContry.Text == "Russia"){ cmbbxState.Items.Add("Moscow");cmbbxState.Items.Add("Saint Petersburg");cmbbxState.Items.Add("Kazan");}
            if (cmbbxContry.Text == "Germany"){ cmbbxState.Items.Add("Berlin");cmbbxState.Items.Add("Hamburg");cmbbxState.Items.Add("Saxony");}
        }
            private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmbbxCity.Items.Clear();//  indian states

            if (cmbbxState.Text == "Maharashtra"){ cmbbxCity.Items.Add("Mumbai");cmbbxCity.Items.Add("Pune");cmbbxCity.Items.Add("Satara"); cmbbxCity.Items.Add("Beed"); cmbbxCity.Items.Add("Kolhapur"); }
            if (cmbbxState.Text == "Gujrat"){ cmbbxCity.Items.Add("Amdabad");cmbbxCity.Items.Add("Surat");cmbbxCity.Items.Add("Vadodara"); cmbbxCity.Items.Add("Rajkot"); cmbbxCity.Items.Add("Gandhinagar"); }
            if (cmbbxState.Text == "Haryana"){ cmbbxCity.Items.Add("Chandigarh");cmbbxCity.Items.Add("Faridabad");cmbbxCity.Items.Add("Gurugram"); cmbbxCity.Items.Add("Rohtak"); cmbbxCity.Items.Add("Hisar"); }
            if (cmbbxState.Text == "Uttar Pradesh") { cmbbxCity.Items.Add("Lucknow"); cmbbxCity.Items.Add("Kanpur"); cmbbxCity.Items.Add("Agra"); cmbbxCity.Items.Add("Varanasi"); cmbbxCity.Items.Add("Allahabad"); }
            if (cmbbxState.Text == "Tamil Nadu") { cmbbxCity.Items.Add("Chennai"); cmbbxCity.Items.Add("Coimbatore"); cmbbxCity.Items.Add("Madurai"); cmbbxCity.Items.Add("Tiruchirappalli"); cmbbxCity.Items.Add("Salem"); }
            // japans states
            if (cmbbxState.Text == "Tokyo") {cmbbxCity.Items.Add("Tokyo"); cmbbxCity.Items.Add("Yokohama"); cmbbxCity.Items.Add("Chiba"); cmbbxCity.Items.Add("Saitama"); cmbbxCity.Items.Add("Kawasaki"); }  
            if(cmbbxState.Text == "Osaka") { cmbbxCity.Items.Add("Osaka"); cmbbxCity.Items.Add("Kyoto"); cmbbxCity.Items.Add("Sakai"); cmbbxCity.Items.Add("Higashi-Osaka"); cmbbxCity.Items.Add("Suita"); }
            if (cmbbxState.Text == "Hokkaido") { cmbbxCity.Items.Add("Sapporo"); cmbbxCity.Items.Add("Asahikawa"); cmbbxCity.Items.Add("Hakodate"); cmbbxCity.Items.Add("Kushiro"); cmbbxCity.Items.Add("Obihiro"); }
            if (cmbbxState.Text == "Aichi") { cmbbxCity.Items.Add("Nagoya"); cmbbxCity.Items.Add("Toyota"); cmbbxCity.Items.Add("Okazaki"); cmbbxCity.Items.Add("Ichinomiya"); cmbbxCity.Items.Add("Toyohashi"); }
            if (cmbbxState.Text == "Fukuoka") { cmbbxCity.Items.Add("Fukuoka"); cmbbxCity.Items.Add("Kitakyushu"); cmbbxCity.Items.Add("Kurume"); cmbbxCity.Items.Add("Omuta"); cmbbxCity.Items.Add("Kasuga"); }
            // american state
            if (cmbbxState.Text == "Texas") { cmbbxCity.Items.Add("Austin"); cmbbxCity.Items.Add("Dallas"); cmbbxCity.Items.Add("Houston"); }
            if (cmbbxState.Text == "Hawaii") { cmbbxCity.Items.Add("Honolulu"); cmbbxCity.Items.Add("Lahaina"); cmbbxCity.Items.Add("Hilo"); }
            if (cmbbxState.Text == "Washington") { cmbbxCity.Items.Add("Seattle"); cmbbxCity.Items.Add("Olympia"); cmbbxCity.Items.Add("Tacoma"); }
            //russian states
            if (cmbbxState.Text == "Moscow") { cmbbxCity.Items.Add("Bulatnikovskoe"); cmbbxCity.Items.Add("Krasnogorsk"); cmbbxCity.Items.Add("Khorlovo"); }
            if (cmbbxState.Text == "Saint Petersburg") { cmbbxCity.Items.Add("Kolpino"); cmbbxCity.Items.Add("Krasnoye"); cmbbxCity.Items.Add("Selo"); }
            if (cmbbxState.Text == "Kazan") { cmbbxCity.Items.Add("Aviastroitelny"); cmbbxCity.Items.Add("Vakhitovsky"); cmbbxCity.Items.Add("Kirovsky"); }
            //Gemrnamy states
            if (cmbbxState.Text == "Berlin") { cmbbxCity.Items.Add("Bernau"); cmbbxCity.Items.Add("Strausberg"); cmbbxCity.Items.Add("Ludwigsfelde"); }
            if (cmbbxState.Text == "Hamburg") { cmbbxCity.Items.Add("Georg"); cmbbxCity.Items.Add("Veddel"); cmbbxCity.Items.Add("Waltershof"); }
            if (cmbbxState.Text == "Saxony") { cmbbxCity.Items.Add("Leipzig"); cmbbxCity.Items.Add("Dresden"); cmbbxCity.Items.Add("Chemnitz"); }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbtnMale.Checked=false;
            rdbtnFemale.Checked=false;
            rdbtnOther.Checked=false;
            cmbbxType.Text= string.Empty;
            cmbbxContry.Text= string.Empty;
            cmbbxState.Text= string.Empty;
            cmbbxCity.Text= string.Empty;
            txtName.Text= string.Empty;
            txtEmail.Text= string.Empty;
            txtPassword.Text= string.Empty;
        }
    }
}
