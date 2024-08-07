using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace demoGetSet1
{
    public partial class Form2 : Form
    {
        
        public Form2(string name,string content)
        {
           InitializeComponent();
            this.Text = name;
            lblContent.Text = content;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            
        }

        private void lblContent1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblContent1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
