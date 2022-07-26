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
                command.Connection = sqlConnection;
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

                MessageBox.Show("Please contact Admin");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = $@"Data source=Naveen;Initial catalog=ADONET; persist security info=True;Integrated security=SSPI";
                SqlConnection sqlConnection = new SqlConnection(connection);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Delete from Branson where Name='{nameTextBox.Text}'";
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted");
                }
                else
                {
                    MessageBox.Show("Data not deleted, Please cotact Admin");
                }
                sqlConnection.Close();
            }
            catch (Exception )
            {

                MessageBox.Show("Please contact Admin");
            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Establish the connection string
            string sqlConnection = $@"Data source=Naveen;initial catalog=ADONET;persist security info=true;integrated security=SSPI";
                SqlConnection updateConnection = new SqlConnection(sqlConnection);
                updateConnection.Open();
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = updateConnection;
                updateCommand.CommandType = CommandType.Text;
                updateCommand.CommandText = $@"update Branson set Age={ageTextBox.Text}, Ride='{rideComboBox.SelectedItem}' where Name='{nameTextBox.Text}'";
                int dataChanged = updateCommand.ExecuteNonQuery();
                if (dataChanged > 0)
                {
                    MessageBox.Show("Data is updated");
                }
                else
                {
                    MessageBox.Show("Data not Updated.PLease check with Admin");
                }
                updateConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
            {
                nameErrorProvider.SetError(nameTextBox, "");
            }
            else
            {
                nameErrorProvider.SetError(nameTextBox, "Please enter a Name");
                nameTextBox.Focus();
                nameTextBox.SelectAll();
            }
        }
    }
}
