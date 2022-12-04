using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectionPractice2
{
    public partial class RNRDataBase : Form
    {
        public RNRDataBase()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RNRDataBase_Load(object sender, EventArgs e)
        {
            //Declare the connection string
            //Dataset to hold the data
            //create SQL statement
            //Create connection string and send connection query as argument
            //Open the connection
            //Get sql adapter
            //use adapter fill method to fill the data
            //close the connection

            try
            {
                string rnrConnection = ConfigurationManager.ConnectionStrings["DBConnectionPractice2.properties.settings.DBConnection"].ConnectionString;
                DataSet rnrDataset = new DataSet();
                string sqlString = $@"select ISBN, Title, Author from books";
                SqlConnection sqlConnection = new SqlConnection(rnrConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, rnrConnection);
                sqlDataAdapter.Fill(rnrDataset);
                sqlConnection.Close();
                dataGridView.DataSource = rnrDataset.Tables[0];
                dataGridView.AutoResizeColumns();
                dataGridView.ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
