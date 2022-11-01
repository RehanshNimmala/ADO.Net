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
namespace Branson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                nameErrorProvider.SetError(nameTextBox, "Please enter the Name");
            }
            else
            {
                nameErrorProvider.SetError(nameTextBox, "");
            }
            string name = nameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            string ride = (string)rideComboBox.SelectedItem;

            string connection = $@"data source=Naveen; initial catalog =ADONET; 
          persist security info=true; integrated security=SSPI ";

            //Establish connection to DB
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connection);
                sqlConnection.Open();

                //create an oblect for the command

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $@"Insert into Branson(Name, Age, Ride)
                Values('{nameTextBox.Text}', {ageTextBox.Text},' {rideComboBox.SelectedItem}')";
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted");
                }
                else
                {
                    MessageBox.Show("Error observed, Please contact Admin");
                }

                sqlConnection.Close();
            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}
