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

namespace HotelInformation
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }
        string hotelConnection = $"data source=Naveen;Initial catalog=ADONET;Persist security info=True;integrated security=SSPI";

        private void insertButton_Click(object sender, EventArgs e)
        {
            //Declaring the variables

            string customerName;
            if (customerNameTextBox.TextLength > 0)
            {
                customerName = customerNameTextBox.Text;

                string from = fromTextBox.Text;
                int duration = int.Parse(durationTextBox.Text);
                //int billAmount = int.Parse(billTextBox.Text);


                //calculating the bill
                double amount = duration * 1000;
                amountLabel.Text = amount.ToString();

                //Establishing the connection string

                try
                {


                    //Create an object for the SQL connection class

                    SqlConnection connection = new SqlConnection(hotelConnection);
                    connection.Open();
                    //Create an object for the command(New Query as in sql)

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"Insert into Hotel_Information
                                        Values('{customerNameTextBox.Text}','{fromTextBox.Text}',{durationTextBox.Text},{amount})";
                    int rowsEffected = command.ExecuteNonQuery();
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Data inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted");
                    }
                    connection.Close();
                }

                catch (Exception)
                {

                    MessageBox.Show("Please contact Admin");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Name");
            }
            GettingDataFromDB();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Exit button

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {


                //Create an object for the SQL connection class

                SqlConnection connection = new SqlConnection(hotelConnection);
                connection.Open();
                //Create an object for the command(New Query as in sql)

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $@"update Hotel_Information
                                        set Customer_Name='{customerNameTextBox.Text}',
From_Address='{fromTextBox.Text}' where
Duration={durationTextBox.Text}";
//Bill_Amount={amountLabel.Text})";
                int rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }
                connection.Close();
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

                SqlConnection conn = new SqlConnection(hotelConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Delete from Hotel_Information where Customer_Name='{customerNameTextBox.Text}'";
                int rowsChanged = cmd.ExecuteNonQuery();
                if (rowsChanged > 0)
                {
                    MessageBox.Show("Data deleted");
                }
                else
                {
                    MessageBox.Show("Data not deleted");
                }
                cmd.Connection.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("please contact Admin");
            }

        }
        public void GettingDataFromDB()
        {
            SqlConnection sqlConnection = new SqlConnection(hotelConnection);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $@"Select Customer_Name,From_Address,Duration, Bill_Amount from Hotel_Information";
            var results = sqlCommand.ExecuteReader();

            List<GridView> list = new List<GridView>();
            while (results.Read())
            {
                GridView gridView = new GridView();
                gridView.CustomerName = results["Customer_Name"].ToString();
                gridView.FromCity = results["From_Address"].ToString();
                gridView.Duration = Convert.ToInt16(results["Duration"]);
                gridView.AmountDue = Convert.ToInt16(results["Bill_Amount"]);
                list.Add(gridView);
            }
            hotelGridView.DataSource = list;
        }
    }

    internal class GridView
    {
        public string CustomerName { get; set; }
        public string FromCity { get; set; }
        public int Duration { get; set; }
        public int AmountDue { get; set; }
    }

   
    
    
}
