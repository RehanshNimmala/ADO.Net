using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal
{
    class MoviesIntermediaryClass
    {
        

        public string LastError { get; set; }

        public DataTable GetBestpictures()
        {
            //Instantiate the dataclass
            try
            {
                DataAccessClass dataAccessClass = new DataAccessClass();
                DataTable dataTable = new DataTable();
                string sqlQuery = "select * from Actors";
                dataTable=dataAccessClass.GetTable(sqlQuery, CommandType.Text);
                return dataTable;

               //return dataAccessClass.GetTable("select * from Actors", CommandType.Text);

            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return null;
            }

        }
        public int AddMovie(int movieId, string movieTitle, int runningTime, System.DateTime releaseDate)
        {
            DataAccessClass dataAccessClass=new DataAccessClass();
            string sqlQuery = $@"insert into Movies values(@MovieId, @MovieTitle,@RunningTime, @ReleaseDate)";

            //definr the parameters and the data
            SqlParameter para1= new SqlParameter("@MovieId",SqlDbType.Int);
            SqlParameter para2= new SqlParameter("@MovieTitle", SqlDbType.Int);
            SqlParameter para3 = new SqlParameter("@RunningTime", SqlDbType.Text);
            SqlParameter para4 = new SqlParameter("@ReleaseDate", SqlDbType.DateTime);

            //supply the vaues to the parameters
            para1.Value = movieId;
            para2.Value = movieTitle;
            para3.Value= runningTime;
            para4.Value= releaseDate;

            try
            {
                return dataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, para1, para2, para3, para4);
            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return -1;
            }


        }
        
            

        
    }
}
