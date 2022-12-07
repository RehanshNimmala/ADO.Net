using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal
{
    class ActorsIntermediary
    {
        public DataTable GetAllActors()
        {
            DataAccessClass dataAccess = new DataAccessClass();
            try
            {
                string sqlQuery = "select * from Actors";
                DataSet ds = new DataSet();
                ds = dataAccess.GetDataSet(sqlQuery);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
