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

        string databaseConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                        persist security info=True;integrated security=SSPI";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaring the variables

            try
            {
                int employeeId = int.Parse(txtEmployeeId.Text);
                string employeeName = txtEmployeeName.Text;
                string department = txtDepartment.Text;

                //Establishing the connection string

                
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
            BindEmployeeListView();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDepartment.Clear();
            txtEmployeeId.Clear();
            txtEmployeeName.Clear();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = $@"delete from Employee_List where Emp_ID='{txtEmployeeId.Text}'";
                int rowsEffected = sqlCommand.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data deleted");
                }
                else
                {
                    MessageBox.Show("data not deleted");
                }
                sqlCommand.Connection.Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Please contact Admin");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = $@"update Employee_List set Emp_Name='{txtEmployeeName.Text}',
                                    Department='{txtDepartment.Text}' where Emp_ID='{txtEmployeeId.Text}'";
                int rowsEffected = sqlCommand.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data updated");
                }
                else
                {
                    MessageBox.Show("Data not updated");
                }
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Please contact Admin");
            }
        }

        private void BindEmployeeListView()
        {
            SqlConnection sqlConnection=new SqlConnection(databaseConnection);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $@"select Emp_ID,Emp_Name,Department from Employee_List";
            var results = cmd.ExecuteReader();

            List<EmployeeDetails> list = new List<EmployeeDetails>();
            while (results.Read())
            {
                EmployeeDetails details = new EmployeeDetails();
                details.EmployeeID = Convert.ToInt32(results["Emp_ID"]);
                details.EmployeeName = results["Emp_Name"].ToString();
                details.Department = results["Department"].ToString();
                list.Add(details);
            }
            employeeGridView.DataSource = list;
        }
    }
}
