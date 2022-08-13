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

namespace InsertUpdateDeletePractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rollNumber;
        string studentName;
        int age;
        string course;
        SqlConnection connection;
        SqlCommand command;
        //SqlDataReader  datareader;
        string databaseConnection = $@"Data source=Naveen;initial catalog=ADONET; persist security info=True;Integrated security=True";

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                rollNumber = int.Parse(txtRollNumber.Text);
                studentName = txtStudentName.Text;
                age = int.Parse(txtAge.Text);
                course = txtCourse.Text;

                connection = new SqlConnection(databaseConnection);
                connection.Open();
                command = new SqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $@"Insert into STUDENT
                                    (Roll_Number,
                                    Student_Name,
                                    Age,
                                    Course)
                                    values
                                    ({rollNumber},
                                    '{studentName}',
                                    {age},
                                    '{course}')";
                int rowsEffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data saved Successfully");

                }
                else
                {
                    MessageBox.Show("Problem with Data Saving");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Please contact administrator");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtCourse.Clear();
            txtRollNumber.Clear();
            txtStudentName.Clear();
            txtRollNumber.Focus();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                connection = new SqlConnection(databaseConnection);
                connection.Open();
                command = new SqlCommand();
                // command = new SqlCommand("delete from student where Roll_Number = " + txtRollNumber.Text + " ", connection);
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"Delete from student where Roll_Number={txtRollNumber.Text}";

                int rowsEffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");

                }
                else
                {
                    MessageBox.Show("Problem with Data Deleting");
                }
            }


            catch (Exception Error)
            {
                MessageBox.Show("Please contact administrator");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(databaseConnection);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = $@"Select * from STUDENT where Roll_Number={txtRollNumber.Text}";
            // command = new SqlCommand("select* from student where Roll_Number = " + txtRollNumber.Text + " ", connection);
            SqlDataReader dreader = command.ExecuteReader();
            try
            {
                if (dreader.Read())
                {
                    txtStudentName.Text = dreader[1].ToString();
                    txtAge.Text = dreader[2].ToString();
                    txtCourse.Text = dreader[3].ToString();
                }
                else
                {
                    MessageBox.Show(" No Record");
                }
                dreader.Close();
            }
            catch (Exception Error)
            {

                MessageBox.Show(" No Record");

            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(databaseConnection);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = $@"update student set
                                    Student_Name='{txtStudentName.Text}',
                                    Age={txtAge.Text},
                                    Course='{txtCourse.Text}'
                                    where
                                    Roll_Number={txtRollNumber.Text}";

            int rowsEffected = command.ExecuteNonQuery();
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Data not saved, Please try again");
            }
            connection.Close();


        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(databaseConnection);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = @"SELECT Roll_Number,
                                            Student_Name,
                                            Age,
                                            Course
                                            FROM 
                                            STUDENT";

            var results = command.ExecuteReader();

            List<DataGridView> studentList = new List<DataGridView>();
            while (results.Read())
            {
                DataGridView student = new DataGridView();

                student.RollNumber = Convert.ToInt32(results["Roll_Number"]);
                student.StudentName = results["Student_Name"].ToString();
                student.Age = Convert.ToInt32(results["Age"]);
                student.Course = results["Course"].ToString();

                studentList.Add(student);

            }
            searchGridView.DataSource = studentList;


        }

    }  

}

    

        
            
              

                
           