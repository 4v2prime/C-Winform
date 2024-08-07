using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace MyProjectWatchlist1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=WatchList;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home objHome = new Home();
            objHome.MdiParent = this;
            objHome.Show();

        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmanime1 objAni = new frmanime1();
            objAni.MdiParent = this;
            objAni.Show();

        }

        private void hollwoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hollywood objholly = new Hollywood();
            objholly.MdiParent = this;
            objholly.Show();    

        }

        private void bollywoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Indian objind = new Indian();
            objind.MdiParent = this;
            objind.Show();

        }

        private void isekaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Anime objAni = new Anime();
            objAni.MdiParent = this;
            objAni.Show();
        }

        private void cKDramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ckDrama objck = new ckDrama();
            objck.MdiParent = this;
            objck.Show();
        }
    }
}
