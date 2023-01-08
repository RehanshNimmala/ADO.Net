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
    public partial class AddMoviesForm : Form
    {
        private static AddMoviesForm instance;
        private AddMoviesForm()
        {
            InitializeComponent();
        }
        public static AddMoviesForm AddMoviesFormInstance()
        {
            if (instance==null)
                instance = new AddMoviesForm();
            return instance;
        }

        private void AddMoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance=null;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            //Instantiate the intermediary class
            MoviesIntermediary moviesIntermediary= new MoviesIntermediary();

            //declare the variables

            int movieId;
            int runtime;

            if(!int.TryParse(movieIDTextBox.Text, out movieId))
            {
                MessageBox.Show("Please enter values for MovieID");
                return;
            }

            if(movieTitleTextBox.Text==""||(!int.TryParse(runtimeTextBox.Text, out runtime)))
            {
                MessageBox.Show("Please enter values for Movie title and running time");
                return;
            }
            try
            {
                if (moviesIntermediary.AddMovie(movieId, movieTitleTextBox.Text, runtime, addMovieDateTimePicker.Value) != -1)
                {
                    MessageBox.Show("1 record inserted");
                    movieIDTextBox.Clear();
                    movieTitleTextBox.Clear();
                    movieIDTextBox.Focus();
                    runtimeTextBox.Clear();
                    addMovieDateTimePicker.Text = "";
                }
                else
                {
                    MessageBox.Show("INsertion failed");
                }
            }

            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
