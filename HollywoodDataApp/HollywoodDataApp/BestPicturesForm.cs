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
    public partial class BestPicturesForm : Form
    {
        private static BestPicturesForm instance;
        private BestPicturesForm()
        {
            InitializeComponent();
        }
        public static BestPicturesForm BestPicturesInstance()
        {
            if (instance == null)
                instance = new BestPicturesForm();
            return instance;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BestPicturesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void BestPicturesForm_Load(object sender, EventArgs e)
        {
            //Instantiate intermediary class
            MoviesIntermediary moviesIntermediary = new MoviesIntermediary();


            try
            {
                bestPicturesDataGridView.DataSource = moviesIntermediary.GetBestPictures();
                bestPicturesDataGridView.ReadOnly = true;
            }
            catch (Exception)
            {

                throw ;
            }
        }//load
    }//class
}//Namespace
