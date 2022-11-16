using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek14
{
    internal class UnexpectedException:Exception
    {
        public UnexpectedException(string message) : base(message)
        {

        }//overloaded ctor
        public UnexpectedException(string message, Exception innerException) : base(message, innerException)
        {

        }// overloadedctor

    }//class
}//NAmespace
