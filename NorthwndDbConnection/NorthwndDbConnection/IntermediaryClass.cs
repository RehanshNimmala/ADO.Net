using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndDbConnection
{
    //Created by Nimmala
    //222222222222222222
     class IntermediaryClass
    {
        //DB Error property
        public string DBError { get; set; }

        public DataTable FetchData()
        {
            //Instantiate dataAccessClass
            DataAccessClass nWDataAccessClass = new DataAccessClass();

            //Create Sql string
            try
            {
                string sqlQuery = "Select CustomerID, CompanyName, ContactName, City, Country from Customers";

                //call method to get data
                DataSet dataSet = nWDataAccessClass.GetNwData(sqlQuery);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                //Set the error property
                this.DBError = nWDataAccessClass.ErrorReturned + ex.Message;
               // return null on error
               return null;
               
            }//try
        }//FetchData()
    }//class
}//Namespace
