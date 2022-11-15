using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsAndDataBinding
{
    public partial class BindingControlsForm : Form
    {
        public BindingControlsForm()
        {
            InitializeComponent();
        }

        private void BindingControlsForm_Load(object sender, EventArgs e)
        {
            DALClassLibrary.ConnectToNW connectClass = new DALClassLibrary.ConnectToNW();//Instantiated

            DataTable customersDataTable =  connectClass.GetCustomersData();
            BindingSource customersBindingSource= new BindingSource();
            customersBindingSource.DataSource = customersDataTable;
            customersBindingSource.Sort = "CompanyName";// if wants to sort the data

            //Bind the data to labels:
            contactLabel.DataBindings.Add("Text", customersBindingSource, "ContactName", false, DataSourceUpdateMode.Never);
            titleLabel.DataBindings.Add("Text", customersBindingSource, "ContactTitle", false, DataSourceUpdateMode.Never);
            cityLabel.DataBindings.Add("Text", customersBindingSource, "City", false, DataSourceUpdateMode.Never);

            //reset the combobox
            companyComboBox.Items.Clear();
            companyComboBox.DataSource = customersBindingSource;
            companyComboBox.ValueMember = "CustomerID";
            companyComboBox.DisplayMember = "CompanyName";
            companyComboBox.DataBindings.Add("Text", customersBindingSource, "CompanyName", false, DataSourceUpdateMode.Never);


        }//form load event

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string custID=companyComboBox.SelectedValue.ToString();
            DALClassLibrary.ConnectToNW connectClass = new DALClassLibrary.ConnectToNW();

            ordersDataGridView.DataSource = connectClass.getOrdersData(custID);
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
        }// end orderdetails

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this gets id of data when the company name change in the combobox
            ordersDataGridView.DataSource = null;
        }
    }//end form
}//Namespace

