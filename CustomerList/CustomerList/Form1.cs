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

        string customerConnection = $@"data source=Naveen;
                            initial catalog=ADONET;persist security info=True;integrated security=SSPI";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaring the variables
                int customerId = int.Parse(txtCustomerId.Text);
                int phoneNumber = int.Parse(txtPhoneNumber.Text);
                string customerName = txtCustomerName.Text;

                //Establishing the connection string

              

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
                ViewCustomerList();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Please check with Admin");

            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SqlConnection = new SqlConnection(customerConnection);
                SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = SqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = $@"Delete from Customer_List where Customer_Name='{txtCustomerName.Text}'";

                int rowsEfffected = sqlCommand.ExecuteNonQuery();
                if (rowsEfffected > 0)
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data not Deleted");
                }
                SqlConnection.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Please contact Admin");
            }



        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(customerConnection);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"update Customer_List set Customer_Name='{txtCustomerName.Text}',Phone_Number={txtPhoneNumber.Text}
                                    where (Customer_ID={txtCustomerId.Text})";
                int rowsChanged = cmd.ExecuteNonQuery();
                if (rowsChanged > 0)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Please contact Admin");
            }
        }
        public  void ViewCustomerList()
        {
            SqlConnection sqlConnection=new SqlConnection(customerConnection);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $@"Select Customer_ID, Customer_Name,Phone_Number from Customer_List";
            var results = sqlCommand.ExecuteReader();
            List<CustomerList> list = new List<CustomerList>();
            while(results.Read())
            {
                CustomerList customerList = new CustomerList();
                customerList.CustomerId = Convert.ToInt16(results["Customer_ID"]);
                customerList.CustomerName = results["Customer_Name"].ToString();
                customerList.PhoneNumber = Convert.ToInt16(results["Phone_Number"]);
                list.Add(customerList);

            }

            customerGridView.DataSource = list;
     
        }
        
    }
}
