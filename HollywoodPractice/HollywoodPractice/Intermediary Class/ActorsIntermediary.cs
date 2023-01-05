using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollywoodPractice
{
     class ActorsIntermediary
    {
        public string LastError { get; set; }

        public DataTable GetAllActors()
        {
            DataAccess dataAccess = new DataAccess();
            try
            {
                string sqlString = "Select * from Actors";
                DataSet actorsDataSet = dataAccess.GetDataSet(sqlString);
                return actorsDataSet.Tables[0];
            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return null; ;
            }

        }//GetAllActors
    }
}
