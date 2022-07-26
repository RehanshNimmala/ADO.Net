﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentInformation
{
    public partial class StudentForm : Form
    {
        public StudentForm()
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
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;

                int rollNumber = int.Parse(rollNumberTextBox.Text);
                int phoneNumber = int.Parse(phoneNumberTextBox.Text);

                // creating Connection to the data base

                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();

                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Insert into Student_Information values
                                 ({rollNumberTextBox.Text},'{firstNameTextBox.Text}','{lastNameTextBox.Text}',
                                    {phoneNumberTextBox.Text})";
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
             
            catch (Exception)
            {

                MessageBox.Show("Please contact Admin");
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
                cmd.CommandText = $@"Update Student_Information set 
                                
                                First_Name='{firstNameTextBox.Text}',
                                Last_Name='{lastNameTextBox.Text}',
                                Phone_Number={phoneNumberTextBox.Text}
                                 Where Roll_Number={rollNumberTextBox.Text}";
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

       
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();

                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"delete Student_Information 
                                 Where Roll_Number={rollNumberTextBox.Text}";
                int rowsChanged = cmd.ExecuteNonQuery();
                if (rowsChanged > 0)
                {
                    MessageBox.Show("Data is Deleted");
                }
                else
                {
                    MessageBox.Show("Data not Deleted");
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
            cmd.CommandText = $@"Select Roll_Number,First_Name,Last_Name,Phone_Number from Student_Information";
            var results = cmd.ExecuteReader();
            List<StudentDataView> list = new List<StudentDataView>();
            while (results.Read())
            {
                StudentDataView dv = new StudentDataView();
                dv.Roll_Number = Convert.ToInt16(results["Roll_Number"]);
                dv.First_Name = results["First_Name"].ToString();
                dv.Last_Name = results["Last_name"].ToString();
                dv.Phone_Number = Convert.ToInt16(results["Phone_Number"]);
                list.Add(dv);


            }
            studentGridView.DataSource = list;
        }
    }
}
