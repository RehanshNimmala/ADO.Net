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
        // variable to hold data
        private static Individual_Customers individualCustomers;

        private Individual_Customers()
        {
            InitializeComponent();
        }//ctor

        public static Individual_Customers GetForm()
        {
            //Instantiate if  the instance is null
            if (individualCustomers == null)
                individualCustomers = new Individual_Customers();
            //returns instance
            return individualCustomers;
        }//GetForm



        private void Individual_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Set instance to null
            individualCustomers=null;
        }//form closing

        private void Individual_Customers_Load(object sender, EventArgs e)
        {
            //Instantiate the Intermediary class
            IntermediaryClass nWIntermediaryClass= new IntermediaryClass();
            //Get data and store in table
            DataTable nWDataTable= nWIntermediaryClass.FetchData();
            //Declare binding source for controls
            BindingSource nWBindingSource = new BindingSource();
            //Assign data received to binding source
            nWBindingSource.DataSource = nWDataTable;

            //Add bindings to labels

            companyLabel.DataBindings.Add("text", nWBindingSource, "CompanyName", false, DataSourceUpdateMode.Never);
            contactLabel.DataBindings.Add("text", nWBindingSource, "ContactName", false, DataSourceUpdateMode.Never);

            cityLabel.DataBindings.Add("text", nWBindingSource, "City", false, DataSourceUpdateMode.Never);

            countryLabel.DataBindings.Add("text", nWBindingSource, "Country", false, DataSourceUpdateMode.Never);

            //databindings for Combobox
            idComboBox.DataSource = nWBindingSource;
            idComboBox.DisplayMember = "CustomerID";
            idComboBox.ValueMember = "CustomerID";
            idComboBox.DataBindings.Add("text", nWBindingSource, "CustomerID", false, DataSourceUpdateMode.Never);

        }//form load event
    }//class
}//Namespace
