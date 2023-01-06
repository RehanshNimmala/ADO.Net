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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorsForm actorsForm = ActorsForm.ActorsFormInstance();
            actorsForm.MdiParent = this;
            actorsForm.Show();

        }

        private void addNewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoviesForm addMoviesForm = AddMoviesForm.AddMoviesFormInstance();
            addMoviesForm.MdiParent = this;
            addMoviesForm.Show();
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = MoviesForm.MoviesFormInstance();
            moviesForm.MdiParent = this;
            moviesForm.Show();
        }
    }
}
