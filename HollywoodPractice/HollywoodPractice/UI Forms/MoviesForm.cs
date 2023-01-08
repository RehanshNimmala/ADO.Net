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
    public partial class MoviesForm : Form
    {
        MoviesIntermediary moviesIntermediary= new MoviesIntermediary();
        private static MoviesForm instance;
        private MoviesForm()
        {
            InitializeComponent();
        }
        public static MoviesForm MoviesFormInstance()
        {
            if(instance == null)
                instance = new MoviesForm();
            return instance;
        }

        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countOfMoviesButton_Click(object sender, EventArgs e)
        {
            int moviesCount = moviesIntermediary.GetCount();
            countLabel.Text = $"Movies Count:{moviesCount}";

        }

        private void showActorsButton_Click(object sender, EventArgs e)
        {
            // Check if something in the combo box is selected
            if(moviesComboBox.SelectedIndex!=-1)
            {
                int movieID= moviesComboBox.SelectedIndex;
                DataTable actorsTable = new DataTable();
                actorsTable=moviesIntermediary.GetActors(movieID);
                moviesGridView.DataSource=actorsTable;
                moviesGridView.ReadOnly = true;

            }
            else
            {
                countLabel.Text = "Please select a movie from the DropDown";
            }
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = moviesIntermediary.GetMovies();
            //data binding using the data source
            //clear any previous items in the combobox
            moviesComboBox.Items.Clear();

            moviesComboBox.DataSource=bindingSource;
            //set display member and value member
            moviesComboBox.DisplayMember = "MovieTitle";
            moviesComboBox.ValueMember = "MovieID";
            //data binding

            moviesComboBox.DataBindings.Add("text", bindingSource, "MovieTitle", false, DataSourceUpdateMode.Never);
        }
    }
}
