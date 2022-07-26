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

namespace SPDatabaseConnection
{
    public partial class SPConnection : Form
    {
        public SPConnection()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtStudentId.Text);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string country = txtCountry.Text;
                int contactNumber = int.Parse(txtContactNumber.Text);

                //Establishing the connection string

                string spdatabaseConnection = $@"data source=Naveen;Initial catalog=ADONET;persist security info=True;Integrated security=SSPI;";

                //Creating an object for Sqlconnection class

                SqlConnection sqlConnection = new SqlConnection(spdatabaseConnection);
                sqlConnection.Open();

                // write the command

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "BindWithStoredProcedure";
                sqlCommand.Parameters.AddWithValue("@Id", studentId);
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                sqlCommand.Parameters.AddWithValue("@Country", country);
                sqlCommand.Parameters.AddWithValue("@ContactNumber", contactNumber);

                sqlCommand.Connection = sqlConnection;  
                int numberOfRowsEffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (numberOfRowsEffected > 0)
                    MessageBox.Show("Data saved Successfully");
                else
                    MessageBox.Show("Data not saved Successfully");
            }
            catch ( Exception exception)
            {

                MessageBox.Show("Something went wrong, Please ask adminstrator"+exception.Message);

            }









        }
    }
}