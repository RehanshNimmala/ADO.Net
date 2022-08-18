using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RidesInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ridesConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                    persist security info=True;integrated security=SSPI";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaring the variables

            string pickUp=txtPickUp.Text;
            string rideDate = DateTime.Now.ToShortDateString();
            string drop=txtDrop.Text;   
            int distance=int.Parse(txtDistance.Text);
            int amount= int.Parse(txtAmount.Text);

            //Establishing the connection string

            try
            {
                

                //Create an object for the SQL connection class

                SqlConnection connection = new SqlConnection(ridesConnection);
                connection.Open();
                //Create an object for the command(New Query as in sql)

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $@"Insert into RIDES_LIST(Date,Pickup,Dropping,Distance,Amount) 
                                        Values('{rideDate}','{pickUp}','{drop}',{distance},{amount})";
                int rowsEffected= command.ExecuteNonQuery();
                if(rowsEffected>0)
                {
                    MessageBox.Show("Data inserted");
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtDistance.Clear();
            txtDrop.Clear();
            txtPickUp.Clear();
            txtDate.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring the variables
                string pickUp = txtPickUp.Text;
                //string rideDate = DateTime.Now.ToShortDateString();
                //string drop = txtDrop.Text;
                //int distance = int.Parse(txtDistance.Text);
                //int amount = int.Parse(txtAmount.Text);

                //Establishing the connecton string

                //string ridesConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                   // Persist security info=True; integrated security=SSPI";

               // string rideConnection = $@"data source=Naveen;Initial catalog=ADONET;
               // persist security info = True; integrated security = SSPI";

                SqlConnection connection = new SqlConnection(ridesConnection);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $@"Delete from RIDES_LIST where Pickup='{pickUp}'";
                int rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data deleted");
                }
                else
                {
                    MessageBox.Show("Data not deleted");
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please contact Administrator");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ridesConnection);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $@"Update RIDES_LIST set
                            Dropping='{txtDrop.Text}',
                            Distance={txtDistance.Text},
                            Amount={txtAmount.Text} where Pickup='{txtPickUp.Text}'";

                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data updated");
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }
                cmd.Connection.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Please contact Administrator");
            }
        }
    }
}
