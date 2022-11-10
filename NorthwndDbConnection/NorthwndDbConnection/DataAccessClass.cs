using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndDbConnection
{
    class DataAccessClass
    {


        /* Declare sqlConnection object and connection string as private level variables inside the class.
         * 
         * Step 2: create methods for:
         * 1.Intntiating the connection
         * 2.Opening the connection
         * 3.Closing the connection
         * 
         * Step 3: Create  any methods for data access:
         * Methods for getting data from the database
         * Methods for inserting/ updating/deleting dara to the database
         * Methods for any other data manipulation purpose*/

        //Variable for connection
        private SqlConnection NwConnection;

        //error property to hold the error if any returned by the DB
        public string ErrorReturned { get; set; }

        //Connection string: This will need to be created inside the form that has the project
        private string nwConnectionString = ConfigurationManager.ConnectionStrings["NorthwndDBConnection.Properties.Settings.northwndDb"].ConnectionString;


        //Step 2: Connection, Open and close methods
        private SqlConnection GetConnection()
        {
            //This method will instantiate and return connection
            //Instantiate conn if not created yet
            if (NwConnection == null)
                NwConnection = new SqlConnection(nwConnectionString);
            //return NwConnection
            return NwConnection;
        }//GetConnection
        private void OpenConnection()
        {
            //Open if closed
            if (NwConnection.State == System.Data.ConnectionState.Closed)
                NwConnection.Open();
        }//open Connection
        private void CloseConnection()
        {

            NwConnection.Close();
        }//CloseConnection

        //Step 3: Create methods for data

        public DataSet GetNwData(string sqlString)
        {
           
                DataSet nWDataSet = new DataSet();
            try 
            { 
                SqlDataAdapter nWDataAdapter = new SqlDataAdapter(sqlString, this.GetConnection());
                nWDataAdapter.Fill(nWDataSet);
                return nWDataSet;
            }
            catch (Exception ex)
            {

               this.ErrorReturned = ex.Message;
                return null;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
