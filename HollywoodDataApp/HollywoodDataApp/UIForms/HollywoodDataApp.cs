﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HollywoodDataApp
{
    public partial class HollywoodDataApp : Form
    {
        public HollywoodDataApp()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Exit

       
        private void addNewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovieForm addMoviesForm = AddMovieForm.AddMovieInstance();
            addMoviesForm.MdiParent = this;
            addMoviesForm.Show();   
        }

        private void getBestPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestPicturesForm bestPicturesForm =  BestPicturesForm.BestPicturesInstance();
            bestPicturesForm.MdiParent = this;
            bestPicturesForm.Show();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorsForm actorsForm =  ActorsForm.ActorsFormInstance();
            actorsForm.MdiParent = this;
            actorsForm.Show();
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm =  MoviesForm.MoviesFormInstance();
            moviesForm.MdiParent = this;
            moviesForm.Show();

        }
    }
}
