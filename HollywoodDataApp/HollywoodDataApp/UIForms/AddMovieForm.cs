using System;
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
    public partial class AddMovieForm : Form
    {
        //form instance
        private static AddMovieForm instance;      
        private AddMovieForm()
        {
            InitializeComponent();
        }//ctor
        public static AddMovieForm AddMovieInstance()
        {
            if (instance == null)
                instance = new AddMovieForm();
            return instance;
        }//AddMovieInstance()

        private void insertMovieButton_Click(object sender, EventArgs e)
        {
            //Declaring the variables
            int movieId;
            int runningTime;
            MoviesIntermediary moviesIntermediary= new MoviesIntermediary();
            if(!int.TryParse(movieIDTextBox.Text,out movieId))
            {
                MessageBox.Show("Please enter values for MovieId");
                return;
            }
            if(movieTitleTextBox.Text==""||(!int.TryParse(runningTimeTextBox.Text, out runningTime)))
            {
                MessageBox.Show("Please enter values for movie Title an running Time");
                return ;
            }
            try
            {
                if ((moviesIntermediary.AddMovie(movieId, movieTitleTextBox.Text, runningTime, addMovieDateTimePicker.Value)) != -1)
                {
                    MessageBox.Show("1 Recod inserted");
                    movieIDTextBox.Clear();
                    movieIDTextBox.Focus();
                    movieTitleTextBox.Clear();
                    runningTimeTextBox.Clear();
                    addMovieDateTimePicker.Text = "";
                }
                else
                {
                    MessageBox.Show("Insert failed");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }//Insert movies
    }//Form class
}//namespace
