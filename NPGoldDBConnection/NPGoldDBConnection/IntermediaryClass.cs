using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPGoldDBConnection
{
    class IntermediaryClass
    {
        public string LastError { get; set; }
        public int InsertRep(string firstName, string lastName, int salary)
        {
            //Instantiate the dataaccessclass
            DataAccessClass nimmalaDataClass = new DataAccessClass();

            try
            {
                //create the SqlString
                string sqlQuery = "Insert into Representative values(@FirstName,@LastName, @Salary) ";

                SqlParameter para1 = new SqlParameter("@FirstName", SqlDbType.Text);
                SqlParameter para2 = new SqlParameter("@LastName", SqlDbType.Text);
                SqlParameter para3 = new SqlParameter("@Salary", SqlDbType.Int);

                para1.Value = firstName;
                para2.Value = lastName;
                para3.Value = salary;

                return nimmalaDataClass.ExecNonQuery(sqlQuery, CommandType.Text, para1, para2, para3);
            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return -1;
            }

        }
    }
}
