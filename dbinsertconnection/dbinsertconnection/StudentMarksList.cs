using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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
    }
}
