using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HollywoodDataApp
{
     class HollywoodDataClass
    {
        //Connection object
        private SqlConnection HWConnection;
        //Connection string

        string HWConnString = ConfigurationManager.ConnectionStrings["HollywoodDataApp.properties.Settings.HWConnString"].ConnectionString;

        private SqlConnection GetConnection()
        {
            //Instantiate if null, and return connection
            if( HWConnection == null ) HWConnection = new SqlConnection( HWConnString );
            return HWConnection;
        }//GetConnection

        private void OpenConnection()
        {
            if(HWConnection.State== ConnectionState.Closed) HWConnection.Open();
        }//Open Connection

        private void CloseConnection()
        {
            HWConnection.Close();
        }//Close Connection
    }
}
