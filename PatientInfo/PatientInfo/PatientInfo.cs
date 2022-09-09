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
namespace PatientInfo
{
    //Created by Nimmala
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }
        string sqlConnection = $@"Data source=Naveen;initial Catalog=ADONET;
                                        persist security info=true;integrated security=SSPI";
       
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Dclaring the variables
                string patientName = nameTextBox.Text;
                int age = int.Parse(ageTextBox.Text);
                int phoneNumber = int.Parse(phoneNumberTextBox.Text);
                int billAmount = int.Parse(billAmountTextBox.Text);

                // creating Connection to the data base

                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();

                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Insert into Patient_Information values
                                 ('{nameTextBox.Text}',{ageTextBox.Text},{phoneNumberTextBox.Text},{billAmountTextBox.Text})";
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data is inserted");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
                sql.Close();
                BindGridView();

            }
            catch (Exception )
            {

                MessageBox.Show("Please contact Admin");
            }


        }// End of submit button

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();

                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Delete from Patient_Information where Patient_Name='{nameTextBox.Text}'";
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data is Deleted");
                }
                else
                {
                    MessageBox.Show("Data not Deleted");
                }
                sql.Close();
            }
            catch (Exception )
            {

                MessageBox.Show("Please contact the admin");
            }

        }

      
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();

                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Update Patient_Information set 
                                Age={ageTextBox.Text},
                                Phone_Number={phoneNumberTextBox.Text},
                                Bill_Amount={billAmountTextBox.Text} Where Patient_Name='{nameTextBox.Text}'";
                int rowsChanged = cmd.ExecuteNonQuery();
                if (rowsChanged > 0)
                {
                    MessageBox.Show("Data is Updated");
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }
                sql.Close();
            }
            catch (Exception)
            {


                MessageBox.Show("Please contact the admin");
            }

        }

        public void BindGridView()
        {
            SqlConnection sql = new SqlConnection(sqlConnection);
            sql.Open();

            SqlCommand cmd = new SqlCommand(sqlConnection);
            cmd.Connection = sql;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $@"Select Patient_Name,Age,Phone_Number,Bill_Amount from Patient_Information";
            var results=cmd.ExecuteReader();
            List<DataView> list = new List<DataView>();
            while(results.Read())
            {
                DataView dv = new DataView();
                dv.Name = results["Patient_Name"].ToString();
                dv.Age = Convert.ToInt16(results["Age"]);
                dv.PhoneNumber = Convert.ToInt16(results["Phone_Number"]);
                dv.BillAmount = Convert.ToInt16(results["Bill_Amount"]);
                list.Add(dv);


            }
            dataGridView.DataSource=list;
        }

       
    }// End of class
}//End of Namespace
