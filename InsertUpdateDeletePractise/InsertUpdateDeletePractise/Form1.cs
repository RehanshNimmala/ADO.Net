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
    }
}
        
            
              

                
              

    //command = new SqlCommand("Insert into STUDENT values(rollNumber, 'studentName', age, 'course')",connection);
            
               