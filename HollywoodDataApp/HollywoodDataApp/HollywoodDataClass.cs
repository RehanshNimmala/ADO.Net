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
        private SqlDataReader GetReader(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null,
            SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null )
        {
            //Instantiate the command object
            SqlCommand hwSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            hwSqlCommand.CommandType = cmdType;// set the cmd type as incoming cmdType:How the sqlcomand text is to be interpreted.
            //set the parameters (parameters are the incoming values)
            if(param1 != null)hwSqlCommand.Parameters.Add(param1);
            if(param2 != null)hwSqlCommand.Parameters.Add(param2);
            if(param3 != null)hwSqlCommand.Parameters.Add(param3);
            if(param4 != null)hwSqlCommand.Parameters.Add(param4);
            if(param5 != null)hwSqlCommand.Parameters.Add(param5);
            if(param6 != null)hwSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return hwSqlCommand.ExecuteReader();// returns one row at a time
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                hwSqlCommand.Dispose();
            }
        }//GetReader()
    }
}
