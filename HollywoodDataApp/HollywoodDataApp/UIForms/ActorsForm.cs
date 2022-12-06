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
    public partial class ActorsForm : Form
    {
        //from instance
        private static ActorsForm actorsForm;
        private ActorsForm()
        {
            InitializeComponent();
        }//ctor
        public static ActorsForm ActorsFormInstance()
        {
            if (actorsForm == null)
                actorsForm = new ActorsForm();
            return actorsForm;
        }//ActorsFormInstance()

        private void ActorsForm_Load(object sender, EventArgs e)
        {
            //Instantiate the class
            ActorsIntermediary actorsIntermediary = new ActorsIntermediary();

            try
            {
                actorsDataGridView.DataSource = actorsIntermediary.GetAllActors();//Assign data to grid view

                //formatting
                actorsDataGridView.ReadOnly = true;
            }
            catch (Exception)
            {

                throw;
            }
        }//Form_load

        private void ActorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          actorsForm=null;
        }
    }//class
}//Namespace
