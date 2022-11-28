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
    public partial class MoviesForm : Form
    {
        private static MoviesForm mFInstance;
        //Intermediary class
        private MoviesIntermediary moviesIntermediary =new MoviesIntermediary();
        private MoviesForm()
        {
            InitializeComponent();
        }
        internal static MoviesForm MoviesFormInstance()
        {
            if(mFInstance == null)
                mFInstance = new MoviesForm();
            return mFInstance;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mFInstance=null;
        }

        private void countMoviesButton_Click(object sender, EventArgs e)
        {
            int moviesCount=moviesIntermediary.GetCount();
            countLabel.Text = $"Movies Count:{moviesCount}";
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            BindingSource moviesBindingSource = new BindingSource();
            moviesBindingSource.DataSource = moviesIntermediary.GetMovies();

            //data binding for combobox using the binding source.
            //clear any previous items in the Combobox.
            moviesComboBox.Items.Clear();
            //Assign datasource for combobox
            moviesComboBox.DataSource = moviesBindingSource;
            //set display member and value member
            moviesComboBox.DisplayMember = "MovieTitle";
            moviesComboBox.ValueMember = "MovieID";

            //data binding
            moviesComboBox.DataBindings.Add("text", moviesBindingSource, "MovieTitle", false, DataSourceUpdateMode.Never);
        }//load

        private void showActorsButton_Click(object sender, EventArgs e)
        {
            //check if something in the combobox is selected
            if(moviesComboBox.SelectedIndex!=-1)
            {
                int movieID=moviesComboBox.SelectedIndex;
                DataTable actorsTable= new DataTable();
                actorsTable = moviesIntermediary.GetActors(movieID);//supply the movieID as criteria
                actorsGridView.DataSource=actorsTable;
                actorsGridView.ReadOnly = true;
            }
            else
            {
                countLabel.Text = "Please select a movie from the DropDown";
            }
        }//Actors
    }//class
}//Namespace
