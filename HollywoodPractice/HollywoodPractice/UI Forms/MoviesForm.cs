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
    }
}
