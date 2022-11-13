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
    public partial class AllCustomers : Form
    {
        //Instance variable
        private static AllCustomers allCustomers;
        public AllCustomers()
        {
            InitializeComponent();
        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            //Instantiate intermediary class
            IntermediaryClass nWIntermediaryClass = new IntermediaryClass();
            // get data adn store in table
            DataTable nWDataTable = nWIntermediaryClass.FetchData();
            //Assign the table to grid data source
            allCustomersDataGridView.DataSource = nWDataTable;

            //Formatting
            allCustomersDataGridView.AllowUserToAddRows = false;
            allCustomersDataGridView.AllowUserToDeleteRows = false;
            allCustomersDataGridView.AutoResizeColumns();
            allCustomersDataGridView.AutoResizeRows();
            allCustomersDataGridView.ReadOnly = true;

        }
        public static AllCustomers GetForm()
        {
            //Instantiate if null
            if (allCustomers == null)
                allCustomers = new AllCustomers();
            //returns instance
            return allCustomers;
        }//GetForm

       

    

        private void AllCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Set instance to null
            allCustomers = null;
        }//form closing
    }
}
    

