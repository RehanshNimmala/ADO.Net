using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek14
{
    internal class ColdCallFileFormatException:Exception
    {
        public ColdCallFileFormatException(string message) : base(message)
        {

        }//ctor
        public ColdCallFileFormatException(string message, Exception innerException) : base(message, innerException)
        {

        }//overloaded ctor

    }//class
}//namespace
