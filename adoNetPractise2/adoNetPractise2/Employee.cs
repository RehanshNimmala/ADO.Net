using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace adoNetPractise2
{
    public partial class EmployeeDetails : Form
    {

        #region Constructor
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region button click event handlers
        private void btnSubmit_Click(object sender, EventArgs e)
        {

           
            try
            {
                //get the variables

                EmployeeCreation employeeCreation = new EmployeeCreation();

                employeeCreation.EmployeeName = txtEmployeeName.Text;
                employeeCreation.Department = txtDepartment.Text;
                employeeCreation.ContactDetails = ExtractValidIntegerFromText();
                employeeCreation.EmployeeID = GetRandomId();


                EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();

                int numberOfRowsEffected = employeeDataAccessLayer.
                    SaveEmployeeDetails(employeeCreation);

                if (numberOfRowsEffected > 0)
                {
                    MessageBox.Show("data saved successfully");
                }
                else
                {
                    MessageBox.Show("ERROR!Data not saved. ");

                }
                //BindGridView();
                EmployeeDetailsGridView employeeDetailsGridView = new EmployeeDetailsGridView();
                employeeGridView.DataSource = employeeDetailsGridView.BindGridView();






            }

            catch (Exception Error)
            {

                MessageBox.Show("Something went wrong, Please contact administrator " + Error.Message);
            }
             //ExtractValidIntegerFromText()
           


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
            txtDepartment.Text = "";
            txtContactNumber.Text = "";
            employeeGridView.DataSource = null;
            employeeGridView.Rows.Clear();

        }

        #endregion

        #region private local methods
        private int GetRandomId()
        {
            Random random = new Random();
            return random.Next(2, 1000);
        }
        //private void BindGridView()
        //{
        //    string databaseConnection = $@"data source=Naveen;initial catalog=ADONET;
        //                        persist security info=True;integrated security=SSPI;";
        //    SqlConnection employeeConnection = new SqlConnection(databaseConnection);
        //    employeeConnection.Open();
        //    SqlCommand employeeCommand = new SqlCommand();
        //    employeeCommand.CommandType = System.Data.CommandType.Text;
        //    employeeCommand.Connection = employeeConnection;
        //    employeeCommand.CommandText = @"SELECT
        //                                    Emp_Id,
        //                                    Emp_Name ,
        //                                    Department ,
        //                                    ContactDetails 
        //                                    FROM EMPLOYEE";
        //    var results = employeeCommand.ExecuteReader();
        //    List<Employee> employeeDetails = new List<Employee>();
        //    while (results.Read())
        //    {
        //        Employee employeeView = new Employee();
        //        employeeView.EmployeeID = Convert.ToInt32(results["Emp_Id"]);
        //        employeeView.EmployeeName = results["Emp_Name"].ToString();
        //        employeeView.Department = results["Department"].ToString();
        //        employeeView.ContactDetails = results["ContactDetails"].ToString();

        //        employeeDetails.Add(employeeView);
        //    }
        //    employeeGridView.DataSource = employeeDetails;


        //}

        //private void validatingContactNumber(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    //if(int.Parse.IsNullOrEmpty(txtContactNumber.Text))
        //    //{
        //    //    e.Cancel=true;
        //    //    txtContactNumber.Focus();
        //    //    erpContactNumber.SetError(txtContactNumber, "Please provide the contact Number");

        //    //}
        //    //else
        //    //{
        //    //    e.Cancel= false;
        //    //    erpContactNumber.SetError(txtContactNumber, null);
        //    //}
        //    if (txtContactNumber.Text.Length > 0)
        //    {
        //        erpContactNumber.SetError(txtContactNumber, "");
        //    }
        //    else
        //    {
        //        erpContactNumber.SetError(txtContactNumber, "Please enter Employee Name");
        //        txtContactNumber.Focus();
        //        txtContactNumber.SelectAll();
        //        return;
        //    }

        private int ExtractValidIntegerFromText()
        {

            bool isvalid = int.TryParse(txtContactNumber.Text, out int contactNumber);
            if(isvalid) return contactNumber;
            return (int)MessageBox.Show("Please enter contact Number");
                    
        }
        #endregion

        #region validation events handlers
      

        private void validatingEmployeeName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmployeeName.Text.Length > 0)
            {
                erpEmployeeName.SetError(txtEmployeeName, "");
            }
            else
            {
                erpEmployeeName.SetError(txtEmployeeName, "Please enter Employee Name");
                txtEmployeeName.Focus();
                txtEmployeeName.SelectAll();
                return;
            }
        }


        private void validatingDepartment(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                e.Cancel = true;
                txtDepartment.Focus();
                erpDepartment.SetError(txtDepartment, "Please enter Department Name");

            }
            else
            {
                e.Cancel = false;
                erpDepartment.SetError(txtDepartment, null);

            }

        }

        #endregion
    }
}

