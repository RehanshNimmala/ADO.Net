using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPGoldDBConnection
{
     class DataAccessClass
    {
        public string LastError { get; set; }

        //Create the connection object
        private SqlConnection npConnection;

        //Create the sqlString
        string npConnectionString = ConfigurationManager.ConnectionStrings["NPGoldDBConnection.Properties.Settings.NPGoldConnection"].ConnectionString;
        public SqlConnection GetConnection()
        {
            if (npConnection == null) npConnection = new SqlConnection(npConnectionString);
            return npConnection;
        }// Establishing the connection.
        public void OpenConnection()
        {
            if (npConnection.State == ConnectionState.Closed)
            {
                npConnection.Open();
            }
        }//OPen the connection only if it is closed
        public void CloseConnection()
        {
            npConnection.Close();
        }//Closes the connection

        //Creating the method
        public int ExecNonQuery(string text, CommandType commandType, SqlParameter para1 = null,
            SqlParameter para2 = null, SqlParameter para3 = null)
        {
            SqlCommand cmd = new SqlCommand(text, this.GetConnection());
            cmd.CommandType = commandType;
            if (para1 != null) cmd.Parameters.Add(para1);
            if (para2 != null) cmd.Parameters.Add(para2);
            if (para3 != null) cmd.Parameters.Add(para3);

            try
            {
                this.OpenConnection();
                return cmd.ExecuteNonQuery();
            }//try
            catch (Exception ex)
            {

                LastError = ex.Message;
                return -1;
            }//catch
            finally
            {
                this.CloseConnection();
                cmd.Dispose();
            }//finally
        }//ExecNonQuery method()
    }//Class
}

