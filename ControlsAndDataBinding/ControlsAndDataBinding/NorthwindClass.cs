using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ControlsAndDataBinding
{
     class NorthwindClass
    {
        //Declare connection
        private SqlConnection NWConnection;
        //Declare the connection string
        private string NWConnString = ConfigurationManager.ConnectionStrings["ControlsAndDataBinding.Properties.Settings.NWConnString"].ConnectionString;
        //private string NWConnectionString = ConfigurationManager.ConnectionStrings["ControlsAndDataBinding.Properties.Settings.NWConnString"].
              //ConnectionString;
        //Set up connection
        public SqlConnection GetConnection()
        {
            if(NWConnection == null)
                NWConnection = new SqlConnection(NWConnString);
            return NWConnection;
        }//end GetConnection()

        //Open Connection
        public void OpenNWConnection()
        {
            if(NWConnection.State==ConnectionState.Closed)
                NWConnection.Open();
        }//end openConnection

        //CloseConnection
        public void CloseConnection()
        {
            NWConnection.Close();
        }//end closeConnection

        public DataTable JoinQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null,
            SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
            SqlDataAdapter NWDataAdapter = new SqlDataAdapter();
            //NWDataAdapter.TableMappings.Add("Table","custProducts");
            //assigns a name foe tables
            DataSet NWDataSet = new DataSet();

            // get the command ready:
            cmd.CommandType = cmdType;
            if(param1 != null) cmd.Parameters.Add(param1);
            if(param2 != null) cmd.Parameters.Add(param2);
            if(param3 != null) cmd.Parameters.Add(param3);
            if(param4 != null) cmd.Parameters.Add(param4);
            if(param5 != null) cmd.Parameters.Add(param5);

            //Assign the selectcommand property once you are ready to add cmd.
            NWDataAdapter.SelectCommand = cmd;
            /* if you were to use the reader you would do this:
             * DataTable NWDataTable= new DataTable();
             * SqlDataReader NWDataReader= cmd.ExecuteReader();
             * NWDataTable.Load(NWDataReader);
            */

            //fill the data
            try
            {
                this.OpenNWConnection();
                NWDataAdapter.Fill(NWDataSet);
                return NWDataSet.Tables[0];
            }
            finally
            {
                this.CloseConnection();
            }
        }//End Join Query

        public DataTable NWCustomersQuery(string procNameOrQuery)
        {
            DataTable NWDataTable = new DataTable();
            SqlCommand cmd= new SqlCommand(procNameOrQuery, this.GetConnection());
            try
            {
                this.OpenNWConnection();
                SqlDataReader NWDataReader = cmd.ExecuteReader();
                NWDataTable.Load(NWDataReader);
                return NWDataTable;
            }
            finally
            {
                this.CloseConnection();
            }
        }// end NWCustomersQuery


    }   //NorthwindClass
}//Namespace
