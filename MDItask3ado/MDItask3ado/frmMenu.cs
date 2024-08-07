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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder objOrder = new frmOrder(cmbbxType.Text,cmbbxMenu.Text,lblPricemenu.Text);
            objOrder.Show();

        }
        //Maharashtraian  Gujrati  South Indian

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxMenu.Items.Clear();
            if (cmbbxType.SelectedItem.ToString() == "Maharashtraian") { cmbbxMenu.Items.Add("Wada Pav"); cmbbxMenu.Items.Add("Puran Poli"); cmbbxMenu.Items.Add("Bhaji"); }
            else if (cmbbxType.SelectedItem.ToString() == "Gujrati") { cmbbxMenu.Items.Add("Dokhla"); cmbbxMenu.Items.Add("Fafda"); cmbbxMenu.Items.Add("Thepla"); }
            else if (cmbbxType.SelectedItem.ToString() == "South Indian") { cmbbxMenu.Items.Add("Idli"); cmbbxMenu.Items.Add("Dosa"); cmbbxMenu.Items.Add("Utappa"); }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblPricemenu_Click(object sender, EventArgs e)
        {

            
        }

        private void cmbbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbbxMenu.SelectedItem)
            {
                case "Wada Pav":
                    int cost = 15;
                    lblPricemenu.Text = cost.ToString();
                    break;
                case "Puran Poli":
                    int cost1 = 30;
                    lblPricemenu.Text = cost1.ToString();
                    break;
                case "Bhagi":
                    int cost2 = 20;
                    lblPricemenu.Text = cost2.ToString();
                    break;
                case "Dokhla":
                    int cost3 = 10;
                    lblPricemenu.Text = cost3.ToString();
                    break;
                case "Fafda":
                    int cost4 = 25;
                    lblPricemenu.Text = cost4.ToString();
                    break;
                case "Thepla":
                    int cost5 = 40;
                    lblPricemenu.Text = cost5.ToString();
                    break;
                case "Idli":
                    int cost6 = 30;
                    lblPricemenu.Text = cost6.ToString();
                    break;
                case "Dosa":
                    int cost7 = 25;
                    lblPricemenu.Text = cost7.ToString();
                    break;
                case "Utappa":
                    int cost8 = 50;
                    lblPricemenu.Text = cost8.ToString();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
