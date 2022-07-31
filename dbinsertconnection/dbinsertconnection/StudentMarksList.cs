using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace dbinsertconnection
{
    public partial class StudentMarksSheet : Form
    {
        public StudentMarksSheet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtStudentName.Text;
                int teluguMarks = int.Parse(txtTeluguMarks.Text);
                int englishMarks = int.Parse(txtEnglishMarks.Text);
                int total = 0;
                int id = GetRandomId();
                // calculation

                total = teluguMarks + englishMarks;

                // Set connection string
                string databaseConnection = $@"data source=Naveen;initial catalog=ADONET;
                persist security info=True;Integrated Security=SSPI";

                //Create an object for sql connection class

                SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                sqlConnection.Open();

                //Write sql command
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = $@"INSERT INTO MyPractise
                                        (Id,StudentName,
                                        Telugu,
                                        English,
                                        Total)
                                        VALUES
                                        ({id},
                                        '{studentName}',
                                        {teluguMarks},
                                        {englishMarks},
                                        {total})";
                //Execute the Query

                int rowsEffected = sqlCommand.ExecuteNonQuery();

                // Close the connection

                sqlConnection.Close();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data saved Successfully");

                }
                else
                {
                    MessageBox.Show("Problem with Data Saving");
                }

                BindStudentGridView();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Some thing went wrrong,Please contact the Administrator"+exception.Message);
            }

                
        }
        private int GetRandomId()
        {
            Random random = new Random();
            return random.Next(2,1000);
        }

        private void BindStudentGridView()
        {
            string databaseConnection = $@"data source=Naveen;initial catalog=ADONET;persist security info=True; Integrated Security=SSPI";

            SqlConnection studentDatabaseConnection = new SqlConnection(databaseConnection);
            studentDatabaseConnection.Open();
            SqlCommand selectsqlCommand = new SqlCommand();
            selectsqlCommand.Connection = studentDatabaseConnection;
            selectsqlCommand.CommandType = System.Data.CommandType.Text;
            selectsqlCommand.CommandText = @"SELECT Id,
                                            StudentName,
                                            Telugu,
                                            English,
                                            Total
                                            FROM 
                                            MyPractise";

            var results = selectsqlCommand.ExecuteReader();

            List<StudentMarks> studentList = new List<StudentMarks>();
            while (results.Read())
            {
                StudentMarks student = new StudentMarks();

                student.Id = Convert.ToInt32(results["Id"]);
                student.StudentName = results["StudentName"].ToString();
                student.Telugu = Convert.ToInt32(results["Telugu"]);
                student.English = Convert.ToInt32(results["English"]);
                student.Total = Convert.ToInt32(results["Total"]);

                studentList.Add(student);

            }
            studentGridView.DataSource = studentList;
        }

        
        private void validatingStudentName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtStudentName.Text.Length > 0)
            {
                erpStudentName.SetError(txtStudentName, "");
            }
            else
            {
                erpStudentName.SetError(txtStudentName, "Please enter the Student Name");
                txtStudentName.Focus();
                txtStudentName.SelectAll();
                return;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = "";
            txtTeluguMarks.Text = "";
            txtEnglishMarks.Text = "";
            studentGridView.DataSource = null;
            studentGridView.Rows.Clear();
        }
    }
}
