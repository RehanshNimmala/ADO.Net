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
                string ridesConnection = $@"data source=Naveen;Initial catalog=ADONET;
                                    persist security info=True;integrated security=SSPI";

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
    }
}
