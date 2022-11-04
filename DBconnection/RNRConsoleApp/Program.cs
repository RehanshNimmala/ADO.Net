using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace RNRConsoleApp
{
    class RnrConsole
    {
        //Created by Nimmala
        static void Main(string[] args)
        {


            /* Open the connection
             * Using the reader.read() method, read one row at a time.
             * This is usually done in a loop because you will have to handle each row read from the databaseright away.
             * This is the connected layer to DB connection.*/

            //Step 1: Declare the connection string
            string rnrConnString = ConfigurationManager.ConnectionStrings["RNRConsoleApp.properties.Settings.rnrConsole"].ConnectionString;

            //Step 2: Declare SqlQuery string
            string sqlString = "Select ISBN, Title, Author, Publisher from books";

            //Step 3: Instantiate SqlConnection instance with connection string as argument.
            SqlConnection rnrConnection = new SqlConnection(rnrConnString);
            try
            {

                //Step 4: Instantiate SqlCommand object with sqlQuery and sqlConnection as arguments.
                SqlCommand rnrCommand = new SqlCommand(sqlString, rnrConnection);

                //Step 5: Open Connection
                rnrConnection.Open();

                //Instantiate reader, and all execute reader method.
                //Note:To create a sqlDataReader, you must call the ExecuteReader method of the Sqlcommand object,
                //instead of directly using a constructor.

                SqlDataReader rnrBooksReader = rnrCommand.ExecuteReader();
                //SqlDataReader provides a way of reading a forward-only stream of rows from a sql server database. This class cannot be inherited.

                //Your sql reader is ready to read rows.read one row at a time from the table,
                //and make sure you display the data before you proceed to read the next row.

                Console.ForegroundColor = ConsoleColor.Green;
                //displaying the names of the columns
                //rnrBooksReader.GetName gets the name of the specified column.
                Console.WriteLine($"{rnrBooksReader.GetName(0),-20} {rnrBooksReader.GetName(1),-50}" +
                    $"{rnrBooksReader.GetName(2),-30}{rnrBooksReader.GetName(3),-40}");
                while (rnrBooksReader.Read())
                {
                    Console.WriteLine($"{rnrBooksReader[0],-20} {rnrBooksReader[1],-50}{rnrBooksReader[2],-30}{rnrBooksReader[3],-40}");

                    //Your sqlReader is ready to read rows. 
                    //Read one row at a time.
                    //This is usually done in loop because yow will have to handle each row read from the DB
                    //This is the connectred layer DB connectivity
                }//while

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }
            finally
            {
                rnrConnection.Close();
            }
        }
    }
}
