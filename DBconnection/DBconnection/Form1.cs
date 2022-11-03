using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBconnection
{
    //Created by Naveen
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Enclose the ebtire database connectivity inside a try catch block, so the app does not crash if any error occurs

                //Step 1: Declaring the connecton string

                string rnrConnectionString = ConfigurationManager.ConnectionStrings["DBConnection.properties.settings.rnrConnString"].ConnectionString;
                /*The configuration manager object will require Using System.Configuration
                 * The actual connection string is:"Data Source=(Local DB)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\AppData\RnrBooks.mdf;
                 * Integrated security=True; Connect Timeout=30;
                 * See that data source is sql server name(LocalDB)\MSSQLLocalDB)
                 * The Db file name is shown in pipes: Make sure you have the file path inside th pipes.That is the relative path.
                 * Integrated security for windows security.*/

                //Step 2: DataSet to hold data
                DataSet myRNRDataSet = new DataSet();
                //dataset instantiation will require Using System.Data statement.

                //Step 3: Create the Sql Statement
                string sqlString = "Select ISBN, Title, Author, Publisher from books";//where fiction=1;

                //Step 4: Create connection and supply connection string as argument
                SqlConnection myRNRConnection = new SqlConnection(rnrConnectionString);
                // need to include System.Data.SqlClient statement

                //Step 5: Opem the connection
                myRNRConnection.Open();

                //Step 6: Get SqlAdapter
                //supply sqlstring and sqlConnection as arguments
                SqlDataAdapter myRNRAdapter = new SqlDataAdapter(sqlString, myRNRConnection);

                //Step 7: Use Adapters fill method to fill the data in the dataset
                myRNRAdapter.Fill(myRNRDataSet);

                //Step 8: Close the connection
                //Data is filled, close the connection
                myRNRConnection.Close();

                //Step 9: 
                //Data is stored inside the data set as a connection of tables.
                // In our case, we know there is only one table, whose index will be '0'
                //Assign the data in our table to the dataGridView's data source

                dataGridView1.DataSource = myRNRDataSet.Tables[0];
                dataGridView1.AutoResizeColumns();
                dataGridView1.ReadOnly = true;// Prevents Edit by users
            }
            catch (Exception ex)          
            {

               MessageBox.Show(ex.Message);
            }//end catch
             
        }
    }
}
