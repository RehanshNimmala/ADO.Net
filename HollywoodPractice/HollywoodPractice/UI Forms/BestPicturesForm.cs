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
    public partial class bestPicturesForm : Form
    {
        private static bestPicturesForm instance;
        private bestPicturesForm()
        {
            InitializeComponent();
        }
        public static bestPicturesForm BestPicturesInstance()
        {
            if(instance == null)
            
                instance = new bestPicturesForm();
                return instance;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bestPicturesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void bestPicturesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bestPicturesForm_Load(object sender, EventArgs e)
        {
            //Insatntiate the class
            MoviesIntermediary moviesIntermediary = new MoviesIntermediary();

            try
            {
                bestPicturesDataGridView.DataSource = moviesIntermediary.GetBestPictures();
                bestPicturesDataGridView.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
