using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HollywoodPractice
{
    public partial class HollywoodApplication : Form
    {
        public HollywoodApplication()
        {
            InitializeComponent();
        }

        private void getBestPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bestPicturesForm BestPicturesForm = bestPicturesForm.BestPicturesInstance();
            BestPicturesForm.MdiParent = this;
            BestPicturesForm.Show();
        }
    }
}
