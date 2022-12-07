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
    public partial class GetBestPictures : Form
    {
        private static GetBestPictures instance;
        private GetBestPictures()
        {
            InitializeComponent();
        }
        public static GetBestPictures GetBestPicturesInstance()
        {
            if(instance == null) instance = new GetBestPictures();
            return instance;
        }

        private void GetBestPictures_Load(object sender, EventArgs e)
        {
            //instantiate the class
            MoviesIntermediaryClass moviesIntermediaryClass = new MoviesIntermediaryClass();
            //DataTable dataTable = new DataTable();
            //dataTable = moviesIntermediaryClass.GetBestMovies();
            dataGridViewGetBestPictures.DataSource = moviesIntermediaryClass.GetBestpictures();
           dataGridViewGetBestPictures.ReadOnly = true;


        }

        private void GetBestPictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
