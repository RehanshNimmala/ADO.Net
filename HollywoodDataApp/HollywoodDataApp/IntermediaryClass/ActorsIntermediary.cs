using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollywoodDataApp
{
     class ActorsIntermediary
    {
        //property for errors
        public string LastError { get; set; }   

        public DataTable GetAllActors()
        {
            HollywoodDataClass hwActors= new HollywoodDataClass();

            try
            {
                string sqlString = "Select * from Actors";
                DataSet actorsDataSet = hwActors.GetDataSet(sqlString);
                return actorsDataSet.Tables[0];
            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return null; ;
            }

        }//GetAllActors
    }//class
}//Namespace
