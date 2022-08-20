using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaring the variables

            try
            {
                int employeeId = int.Parse(txtEmployeeId.Text);
                string employeeName = txtEmployeeName.Text;
                string department = txtDepartment.Text;

                //Establishing the connection string

                string databaseConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                        persist security info=True;integrated security=SSPI";
                SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $@"Insert into Employee_LIst(Emp_ID,Emp_Name,Department)
                                values({employeeId},'{employeeName}','{department}')";
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data Inserted");

                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
                cmd.Connection.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Please contact Administrator");
            }
            
        }
    }
}
