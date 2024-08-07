using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoLsitview1
{
    public partial class Form1 : Form
    {
        SqlConnection conn=new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True"); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtname.Text);
            item.SubItems.Add(txtint.Text);
            lstvw1.Items.Add(item);
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (lstvw1.SelectedItems.Count>0)
            {
                lstvw1.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            //this space is total calculation
            int columnIndexToSum = 1;
            int sum = 0;

            // Iterate through each item in the ListView
            foreach (ListViewItem item in lstvw1.Items)
            {
                // Assuming the numeric values are in int format and in the specified column index
                int value;
                if (int.TryParse(item.SubItems[columnIndexToSum].Text, out value))
                {
                    // Sum the values
                    sum += value;
                }
            }
            txttotal.Text = sum.ToString(); 
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtint.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adpt=new SqlDataAdapter("select *from tblUser", conn);
            DataTable dt= new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();   
            conn.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ont this event i wamt to pass the id value to lsitview with other
            if (e.RowIndex>=0&&e.ColumnIndex>=0) 
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string variableToStoreValue = cellValue.ToString();
            }
        }
    }
}
