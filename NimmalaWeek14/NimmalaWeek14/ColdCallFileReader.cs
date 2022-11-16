using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek14
{
    internal class ColdCallFileReader
    {

        //variables
        private FileStream fileStream;
        private StreamReader streamReader;
        private unit numberOfPeopleToCall;
        private bool isDisposed = false;
        private bool isOPen=false;

        public void Open(string fileName)
        {
            //method access to file and opens it
            //expcets an integer in the first line of the file
            //keeps it open for the processNextPerson method to read the contents 
            if(isDisposed)
            {
                throw new ObjectDisposedException("people to call");

            }//if

            //open the file
            fileStream = new FileStream(fileName, FileMode.Open);
            streamReader = new StreamReader(fileStream);
            try
            {
                string firstLine=streamReader.ReadLine();//read the first line
                numberOfPeopleToCall = unit.Parse(firstLine);

                isOPen=true;
            }
            catch(FormatException ex)
            {
                throw new ColdCallFileFormatException($"Firdt LIne is not an Integer", ex());
            }//trycatch

        }//open

        public void ProcessNextPerson()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("people to call");

            }//if
            if(!isOPen)
            {
                throw new UnexpectedException("Attempt to access a ColdCallFile that is not open");

            }//if
            try
            {
                string name=streamReader.ReadLine();
                if(name==null)
                {
                    throw new ColdCallFileFormatException("Not enough number of names to call");

                }//if
                if (name[0]=='T'|| name=="Navin")
                {
                    throw new SalesSpyFoundException($"we found a spy and the name is {name}");

                }//if
                //write the name of the person to call
                Console.WriteLine(name);
            }//try
            catch
            {
                throw;
            }

        }//processNextPerson();

        public unit NumberOfPeopleToCall
        {
            get
            {
                if(isDisposed)
                {
                    throw new ObjectDisposedException("people to call");
                    if(!isOPen)
                    {
                        throw new UnexpectedException("Attempt to accessa coldcall file is not open");
                    }
                }
            }
        }
    }
}
