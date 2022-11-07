using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleDBConnectionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Declaration of connection string
            string rnrConnection = ConfigurationManager.ConnectionStrings["ConsoleDBConnectionPractice.Properties.Settings.ConsoleDBPractice"].ConnectionString;

            //Declare the SQL string
            string sqlString = "Select ISBN, Title from books";

            //Step 3: Instantiating SqlConnection instance with connection string as argument
            SqlConnection sqlConnection = new SqlConnection(rnrConnection);
            try
            {
                SqlCommand rnrCommand = new SqlCommand(sqlString, sqlConnection);
                sqlConnection.Open();
                SqlDataReader rnrBooksReader = rnrCommand.ExecuteReader();
                Console.WriteLine($"{rnrBooksReader.GetName(0),-20},{rnrBooksReader.GetName(1),-20}");
                while (rnrBooksReader.Read())
                {
                    Console.WriteLine($"{rnrBooksReader[0],-50},{rnrBooksReader[1]}");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                sqlConnection.Close();
            }




        }
    }
}
