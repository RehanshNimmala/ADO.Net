using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollywoodPractice
{
     class DataAccess
    {
        //Connection object
        private SqlConnection HWConnection;
        //Connection string

        string HWConnString = ConfigurationManager.ConnectionStrings["HollywoodPractice.properties.Settings.HWConnString"].ConnectionString;

        private SqlConnection GetConnection()
        {
            //Instantiate if null, and return connection
            if (HWConnection == null) HWConnection = new SqlConnection(HWConnString);
            return HWConnection;
        }//GetConnection
        private void OpenConnection()
        {
            if (HWConnection.State == ConnectionState.Closed) HWConnection.Open();
        }//Open Connection

        private void CloseConnection()
        {
            HWConnection.Close();
        }//Close Connection
        private SqlDataReader GetReader(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null,
           SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            //Instantiate the command object
            SqlCommand hwSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            hwSqlCommand.CommandType = cmdType;// set the cmd type as incoming cmdType:How the sqlcomand text is to be interpreted.
            //set the parameters (parameters are the incoming values)
            if (param1 != null) hwSqlCommand.Parameters.Add(param1);
            if (param2 != null) hwSqlCommand.Parameters.Add(param2);
            if (param3 != null) hwSqlCommand.Parameters.Add(param3);
            if (param4 != null) hwSqlCommand.Parameters.Add(param4);
            if (param5 != null) hwSqlCommand.Parameters.Add(param5);
            if (param6 != null) hwSqlCommand.Parameters.Add(param6);

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
        public DataTable GetTable(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null,
            SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            // load a table ftom the database using either query or text or a stored procedure
            DataTable table = new DataTable();
            SqlDataReader reader = null;

            try
            {
                //Instantiate reader using GetReader method
                reader = GetReader(procNameOrQuery, cmdType, param1, param2, param3, param4, param5, param6);
                //load the table with data.Even with the disconnected layer, you are just filling up
                //the data table with the data, one row at a time using the tables load method

                table.Load(reader);
                //close the reader
                reader.Close();
                //return the data table with the data
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }//GetTable()
        public int ExecNonQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null,
            SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            //instantiate the command object
            SqlCommand hwSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            hwSqlCommand.CommandType = cmdType;
            if (param1 != null) hwSqlCommand.Parameters.Add(param1);
            if (param2 != null) hwSqlCommand.Parameters.Add(param2);
            if (param3 != null) hwSqlCommand.Parameters.Add(param3);
            if (param4 != null) hwSqlCommand.Parameters.Add(param4);
            if (param5 != null) hwSqlCommand.Parameters.Add(param5);
            if (param6 != null) hwSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return hwSqlCommand.ExecuteNonQuery();// if successful executeNonQuery returns an integer

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();
                hwSqlCommand.Dispose();
            }
        }//ExecuteNonQuery()
        public object ExecScalarQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null,
            SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            // instantiate the command object
            SqlCommand hwSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            hwSqlCommand.CommandType = cmdType;
            //set the parameters
            if (param1 != null) hwSqlCommand.Parameters.Add(param1);
            if (param2 != null) hwSqlCommand.Parameters.Add(param2);
            if (param3 != null) hwSqlCommand.Parameters.Add(param3);
            if (param4 != null) hwSqlCommand.Parameters.Add(param4);
            if (param5 != null) hwSqlCommand.Parameters.Add(param5);
            if (param6 != null) hwSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return hwSqlCommand.ExecuteScalar();//if successful ExecNonQuery returns an integer

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();//close the connection
                hwSqlCommand.Dispose();
            }

        }//ExecScalarQuery
        public DataSet GetDataSet(string sqlString)
        {
            try
            {
                DataSet hwDataSet = new DataSet();
                SqlDataAdapter hwAdapter = new SqlDataAdapter(sqlString, this.GetConnection());
                this.OpenConnection();
                hwAdapter.Fill(hwDataSet);
                return hwDataSet;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }//GetDataSet()

    }
}
