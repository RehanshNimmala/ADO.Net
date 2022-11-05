using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DBConnectionPractice
{
    public partial class DBFormConnection : Form
    {
        public DBFormConnection()
        {
            InitializeComponent();
        }

        private void DBFormConnection_Load(object sender, EventArgs e)
        {
            try
            {
                // 1) Declare the connection string
                //2)Dataset to hold the data
                //3)Create the Sql statement
                //4)Create conncetion string and supply connection steing as argument
                //5)open the connection
                //6)Get Sql Adapter
                //7)Use the adapter fill method to fill the data in DB
                //8) close the connection

                string dbConnection = ConfigurationManager.ConnectionStrings
                        ["DBConnectionPractice.Properties.Settings.DBFormConnection"].ConnectionString;

                DataSet rnrDataset = new DataSet();

                string sqlString = $@"Select ISBN, Title,Author from books";
                SqlConnection sqlConnection = new SqlConnection(dbConnection);
                sqlConnection.Open();
                SqlDataAdapter myRnrAdapter = new SqlDataAdapter(sqlString, dbConnection);
                myRnrAdapter.Fill(rnrDataset);
                sqlConnection.Close();

                dataGridView1.DataSource = rnrDataset.Tables[0];
                dataGridView1.AutoResizeColumns();
                dataGridView1.ReadOnly = true;
            }
            catch (Exception  Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }
    }
}
