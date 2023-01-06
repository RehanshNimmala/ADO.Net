﻿using System;
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
    }
}
