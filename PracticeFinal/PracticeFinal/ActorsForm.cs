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
    public partial class ActorsForm : Form
    {
        private static ActorsForm actorsFormInstance;//form instance
        private ActorsForm()
        {
            InitializeComponent();
        }
        internal static ActorsForm actorsForm()
        {
            if (actorsFormInstance == null)
                actorsFormInstance = new ActorsForm();
            return actorsFormInstance;
        }

        private void ActorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         actorsFormInstance=null;
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {
            //Instantiate the class
            ActorsIntermediary actorsIntermediary = new ActorsIntermediary();
            try
            {
                dataGridViewActors.DataSource = actorsIntermediary.GetAllActors();
                dataGridViewActors.ReadOnly = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
