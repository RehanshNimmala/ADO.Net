using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace NorthwndDBConnection
{
    //Created by Nimmala
    //1111111111111111
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
        private void ColseConection()
        {

            NwConnection.Close();
        }//CloseConnection
    }
}
