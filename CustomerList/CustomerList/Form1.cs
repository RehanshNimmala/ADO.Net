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

namespace CustomerList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaring the variables
                int customerId = int.Parse(txtCustomerId.Text);
                int phoneNumber = int.Parse(txtPhoneNumber.Text);
                string customerName = txtCustomerName.Text;

                //Establishing the connection string

                string customerConnection = $@"data source=Naveen;
                            initial catalog=ADONET;persist security info=True;integrated security=SSPI";

                SqlConnection sqlConnection = new SqlConnection(customerConnection);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Insert into Customer_List(Customer_ID,Customer_Name,Phone_Number)
                                                            Values({customerId},'{customerName}',{phoneNumber})";
                int rowsEfffected = cmd.ExecuteNonQuery();
                if (rowsEfffected > 0)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
                sqlConnection.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Please check with Admin");

            }



        }
    }
}
