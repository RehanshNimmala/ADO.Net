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
    }
}
