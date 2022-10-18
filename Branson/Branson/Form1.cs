﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                nameErrorProvider.SetError(nameTextBox, "Please enter the Name");
            }
            else
            {
                nameErrorProvider.SetError(nameTextBox, "");
            }
        }
    }
}
