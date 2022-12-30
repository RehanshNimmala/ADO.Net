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
    public partial class ActorsForm : Form
    {
        private static ActorsForm actorsForm;
        private ActorsForm()
        {
            InitializeComponent();
        }//ctor

        public static ActorsForm ActorsFormInstance()
        {
            if(actorsForm == null)
                actorsForm = new ActorsForm();
            return actorsForm;
        }

        private void ActorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            actorsForm=null;
        }
    }
}
