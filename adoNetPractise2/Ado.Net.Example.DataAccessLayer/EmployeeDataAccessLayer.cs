using System.Data.SqlClient;

namespace adoNetPractise2
{
    public class EmployeeDataAccessLayer
    {
        public int SaveEmployeeDetails(EmployeeCreation employeeCreation)
                    {

            //Establish connection string
            string dbConncection = $@"data source=Naveen;Initial catalog=ADONET; 
                persist security info=True; Integrated security =SSPI";

            //create object for sqlConnection
            SqlConnection employeeConnection = new SqlConnection(dbConncection);
            employeeConnection.Open();

            //create command 
            SqlCommand employeeCommand = new SqlCommand();
            employeeCommand.Connection = employeeConnection;
            employeeCommand.CommandType = System.Data.CommandType.Text;
            employeeCommand.CommandText = $@"INSERT INTO Employee
                                            (Emp_ID,
                                            Emp_Name,
                                            Department,
                                            ContactDetails)
                                            Values
                                            ({employeeCreation.EmployeeID},
                                            '{employeeCreation.EmployeeName}',
                                            '{employeeCreation.Department}',
                                            {employeeCreation.ContactDetails})";

            int numberOfRowsEffected = employeeCommand.ExecuteNonQuery();

            employeeConnection.Close();

            return numberOfRowsEffected;
        }
    }
}
