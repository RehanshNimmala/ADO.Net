using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollywoodDataApp
{
     class MoviesIntermediary
    {
        //property to hold last error
        public string LastError { get; set; }   

        public int GetCount()
        {
            string queryString = "select count(*) from Movies";

            try
            {
                //Instantiate the class
                HollywoodDataClass hollywoodData = new HollywoodDataClass();
                return Convert.ToInt32(hollywoodData.ExecScalarQuery(queryString, System.Data.CommandType.Text));
                //scalar method requires query string and command type, which is sent.
                //scalar query has several optional parameters that default to null

            }
            catch (Exception ex)
            {

               LastError=ex.Message;
                return -1;
            }
          
        }//GetCount()
        public DataTable GetBestPictures()
        {
            //Instantiate the class
            HollywoodDataClass hollywoodData=new HollywoodDataClass();
            try
            {

                // call GetTable method and supply stored peoc name and command type. other parameters default to null
                return hollywoodData.GetTable("spBestMovies", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                LastError= ex.Message;
                return null;
            }

        }//GetBestPictures()

        public DataTable GetActors(int movieID)
        {
            HollywoodDataClass hollywoodData=new HollywoodDataClass();
            SqlParameter param = new SqlParameter("@movieID", SqlDbType.Int);
            //need to supply the parameter as string and datatype of the parameter.
            param.Value = movieID;//supply the value for the parameter string.
            //create the sqlQuery with the parameter as criteria in the where clause.
            string sqlQuery = "select lastName, FirstName, DateOfBirth from Actors a " +
                "join roles r on a.ActorId=r.ActorId where movieId=@movieID";

            try
            {
                return hollywoodData.GetTable(sqlQuery, CommandType.Text, param);//there is one parameter, that is movieId supplied as argument.

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }//GetActors()
        public DataTable GetMovies()
        {
            HollywoodDataClass hollywoodData = new HollywoodDataClass();
            string sqlQuery = "Select MovieID, MovieTitle from Movies";

            try
            {
                return hollywoodData.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {

                LastError= ex.Message;
                return null;
            }
        }//GetMovies()
        public int AddMovie(int movieId, string movieTitle, int runningTime, System.DateTime releaseDate)
        {
            HollywoodDataClass hollywoodData = new HollywoodDataClass();
            // create the query string with placeholders for parameters:
            string sqlQuery = "Insert into Movies values(@MovieId, @MovieTitle, @RunningTime, @ReleaseDate)";

            //define the parameters and their data types
            SqlParameter param1 = new SqlParameter("@MoviesId", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@MoviesTitle", SqlDbType.Text);
            SqlParameter param3 = new SqlParameter("@RunningTime", SqlDbType.Int);
            SqlParameter param4 = new SqlParameter("ReleaseDate", SqlDbType.DateTime);

            //supply the values for the parameters
            param1.Value = movieId;
            param2.Value = movieTitle;
            param3.Value = runningTime;
            param4.Value = releaseDate;

            try
            {
                return hollywoodData.ExecNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4);
            }
            catch (Exception ex)
            {

                LastError = ex.Message;
                return -1;
            }
            
        }//AddMovie()
    }//class
}//namespace

