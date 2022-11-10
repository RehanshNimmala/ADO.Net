using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwndDbConnection
{
    public partial class northwndDBForm : Form
    {
        public northwndDBForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void individualCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate the class
            Individual_Customers individual_Customers = new Individual_Customers();
            individual_Customers.MdiParent = this;
            individual_Customers.Show();

        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instantiate the class
            AllCustomers all_Customers = new AllCustomers();    
            all_Customers.MdiParent = this;
            all_Customers.Show();
        }
    }
}
