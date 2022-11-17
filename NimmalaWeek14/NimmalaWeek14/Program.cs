using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the name of the file containing the names of the people to be contacted");
            string fileName= Console.ReadLine();
            var peopleToCall=new ColdCallFileReader();//Instantiate the reader

            try
            {
                //open the file given by the user
                peopleToCall.Open(fileName);

                //iterate through and print the names
                for (int i = 0; i < peopleToCall.NumberOfPeopleToCall; i++)
                {
                    //print caller names using peopleToCall.next person method
                    peopleToCall.ProcessNextPerson();

                }//for
                Console.WriteLine("All Names processed successfully");
                Console.ReadKey();
            }
            catch (FileNotFoundException )
            {
                Console.WriteLine("The file does not exit");
                Console.ReadKey();              
            }
            catch(ColdCallFileFormatException ex)
            {
                Console.WriteLine($"The file:{fileName}appears to be corrupted.\r\n Details of the problem:{ex.Message}");
                if(ex.InnerException!=null)
                {
                    Console.WriteLine($"InnerException was:{ex.InnerException.Message}");
                }
                Console.ReadKey();
            }//catch
            catch(Exception ex)
            {
                Console.WriteLine($"error:{ex.Message}");
                Console.ReadKey();  

            }//catch
            finally
            {
                peopleToCall.DisposeFileStream();
            }
        }//main
    }//class
}//namespace
