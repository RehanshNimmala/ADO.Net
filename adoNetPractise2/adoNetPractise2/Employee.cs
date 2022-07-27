using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adoNetPractise2
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //get the variables
                string employeeName = txtEmployeeName.Text;
                string department = txtDepartment.Text;
                int contactNumber = int.Parse(txtContactNumber.Text);
                int employeeId = GetRandomId();

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
                                            ({employeeId},
                                            '{employeeName}',
                                            '{department}',
                                            {contactNumber})";
                int numberOfRowsEffected = employeeCommand.ExecuteNonQuery();
                employeeConnection.Close();
                if (numberOfRowsEffected > 0)
                {
                    MessageBox.Show("data saved successfully");
                }
                else
                {
                    MessageBox.Show("ERROR!Data not saved. ");

                }
            }
            catch (Exception Error)
            {

                MessageBox.Show("Something went wrong, Please contact administrator " + Error.Message);
            }

        }
        private int GetRandomId()
        {
            Random random = new Random();
            return random.Next(2, 1000);
        }



    }
}

