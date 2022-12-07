using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PracticeFinal
{
     class DataAccessClass
    {
        //connnection object
        private SqlConnection practiseHWDB;

        //create connection string
        string connectionString = ConfigurationManager.ConnectionStrings["PracticeFinal.Properties.settings.PracticeHWDB"].ConnectionString;

        private SqlConnection GetConnection()
        {
            if(practiseHWDB == null) practiseHWDB = new SqlConnection(connectionString);
            return practiseHWDB;

        }//GetConnection
        private void OpenConnection()
        {
            if(practiseHWDB.State==ConnectionState.Closed) practiseHWDB.Open();
        }//open connection

        private void CloseConnection()
        {
            practiseHWDB.Close();
        }
        private SqlDataReader GetDataReader(string text, CommandType commandType, SqlParameter para1, SqlParameter para2 = null,
            SqlParameter para3 = null, SqlParameter para4 = null, SqlParameter para5 = null, SqlParameter para6 = null)
        {
            //instantiate the command object
            SqlCommand sqlCommand= new SqlCommand(text,this.GetConnection());
            sqlCommand.CommandType = commandType;
            if(para1!=null)sqlCommand.Parameters.Add(para1);
            if (para2 != null) sqlCommand.Parameters.Add(para2);
            if(para3 != null) sqlCommand.Parameters.Add(para3);
            if(para4 != null) sqlCommand.Parameters.Add(para4);
            if(para5 != null) sqlCommand.Parameters.Add(para5);
            if(para6 != null) sqlCommand.Parameters.Add(para6);

            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                practiseHWDB.Dispose();
            }

        }
        public DataTable GetTable(string text, CommandType commandType, SqlParameter para1=null,SqlParameter para2=null,
            SqlParameter para3 = null, SqlParameter para4 = null, SqlParameter para5 = null, SqlParameter para6 = null)
        {
          //load table from the database using sp method
          DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader = null;

            try
            {
                //Instantiate sqlDataReader using GetDataReader method
                sqlDataReader = GetDataReader(text, commandType, para1,para2,para3,para4,para5,para6);
                //loads the data even with the disconnected layer
                //loads one roow at a time using  Load() method.

                dataTable.Load(sqlDataReader);
                //close the sqlDataReader
                sqlDataReader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }//GetTable

        public int ExecNonQuery(string text, CommandType commandType, SqlParameter para1, SqlParameter para2, SqlParameter para3, SqlParameter para4)
        {
            SqlCommand cmd = new SqlCommand(text,this.GetConnection());
            cmd.CommandType = commandType;
            if(para1!=null)cmd.Parameters.Add(para1);
            try
            {
                this.OpenConnection();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();
                cmd.Dispose();
            }
        }//ExecNonQuery

        public DataSet GetDataSet(string text)
        {
            try
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(text, this.GetConnection());
                this.OpenConnection();
                sqlDataAdapter.Fill(dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }
       

    }
}
