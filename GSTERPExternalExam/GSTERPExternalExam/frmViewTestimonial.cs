using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTERPExternalExam
{
    public partial class frmViewTestimonial : Form
    {
        public frmViewTestimonial()
        {
            InitializeComponent();
        }

        private void AudioPlayer_Enter(object sender, EventArgs e)
        {
            ///play audio on click
            string f = "";
            AudioPlayer.URL = f;
        }

        private void videoPlayer_Enter(object sender, EventArgs e)
        {
            string f = "";
            videoPlayer.URL= f;
        }
    }
}
