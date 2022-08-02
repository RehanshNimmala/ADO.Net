using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace adoNetPractise2
{
    public class EmployeeDetailsGridView
    {
        public List<Employee> BindGridView()
        {
            string databaseConnection = $@"data source=Naveen;initial catalog=ADONET;
                                persist security info=True;integrated security=SSPI;";
            SqlConnection employeeConnection = new SqlConnection(databaseConnection);
            employeeConnection.Open();
            SqlCommand employeeCommand = new SqlCommand();
            employeeCommand.CommandType = System.Data.CommandType.Text;
            employeeCommand.Connection = employeeConnection;
            employeeCommand.CommandText = @"SELECT
                                            Emp_Id,
                                            Emp_Name ,
                                            Department ,
                                            ContactDetails 
                                            FROM EMPLOYEE";
            var results = employeeCommand.ExecuteReader();
            List<Employee> employeeDetails = new List<Employee>();
            while (results.Read())
            {
                Employee employeeView = new Employee();

                employeeView.EmployeeID = Convert.ToInt32(results["Emp_Id"]);
                employeeView.EmployeeName = results["Emp_Name"].ToString();
                employeeView.Department = results["Department"].ToString();
                employeeView.ContactDetails = results["ContactDetails"].ToString();

                employeeDetails.Add(employeeView);
            }
            return employeeDetails;
            //employeeGridView.DataSource = employeeDetails;

        }
    }
}