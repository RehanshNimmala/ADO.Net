using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorsForm actorsForm = ActorsForm.actorsForm();
            actorsForm.MdiParent = this;
            actorsForm.Show();
        }

        private void getBestPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBestPictures getBestPictures= GetBestPictures.GetBestPicturesInstance();
            getBestPictures.MdiParent = this;
            getBestPictures.Show();
        }
    }
}
