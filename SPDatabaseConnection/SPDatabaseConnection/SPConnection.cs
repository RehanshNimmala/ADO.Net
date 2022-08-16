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
                {
                    MessageBox.Show("Data saved Successfully");
                }
                else
                {
                    MessageBox.Show("Data not saved Successfully");
                }
                BindSPGridView();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Something went wrong, Please ask adminstrator" + exception.Message);

            }

        }
        private void BindSPGridView()
        {
            // creating data base connection
            string databaseConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                         persist security info=True; Integrated security=SSPI;";
            SqlConnection mySPTableConnection = new SqlConnection(databaseConnection);
            mySPTableConnection.Open();

            //command creation

            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = mySPTableConnection;
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            selectCommand.CommandText = "spselectbinding";
            var results = selectCommand.ExecuteReader();

            List<SpSelectConnection> List = new List<SpSelectConnection>();
            while (results.Read())
            {
                SpSelectConnection student = new SpSelectConnection();
                student.Id=Convert.ToInt32(results["ID"]);
                student.FirstName = results["FirstName"].ToString();
                student.LastName = results["LastName"].ToString();
                student.Country = results["Country"].ToString();
                student.ContactNumber = results["ContactNumber"].ToString();
                List.Add(student);

            }
            spGridView.DataSource = List;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtContactNumber.Text = "";
            txtCountry.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStudentId.Clear();
            spGridView.DataSource = null;
            spGridView.Rows.Clear();
        }
    }
}