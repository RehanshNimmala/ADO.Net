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
    public partial class Individual_Customers : Form
    {
        //Instance variable
        private static Individual_Customers individualCustomers;

        private Individual_Customers()
        {
            InitializeComponent();
        }//ctor

        public static Individual_Customers GetForm()
        {
            //Instantiate if null
            if(individualCustomers == null)
                individualCustomers = new Individual_Customers();
            //returns instance
            return individualCustomers;
        }//GetForm

        private void Individual_Customers_Load(object sender, EventArgs e)
        {
            //Instantiate intermediary class
            IntermediaryClass nWIntermediaryClass=new IntermediaryClass();
            // get data adn store in table
            DataTable nWDataTable=nWIntermediaryClass.FetchData();
            //Assign the table to grid data source
            individualDataGridView.DataSource= nWDataTable;

            //Formatting
            individualDataGridView.AllowUserToAddRows = false;
            individualDataGridView.AllowUserToDeleteRows = false;
            individualDataGridView.AutoResizeColumns();
            individualDataGridView.AutoResizeRows();
            individualDataGridView.ReadOnly= true;


        }

        private void Individual_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Set instance to null
            individualCustomers=null;
        }//form closing
    }
}
