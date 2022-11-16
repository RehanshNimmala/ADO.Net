using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek14
{
    internal class SalesSpyFoundException : Exception
    {
        public SalesSpyFoundException(string spyName) : base($"Sales Spy Found:SpyName:{spyName}")
        {
        } //overloaded ctor


        public SalesSpyFoundException(string SpyName, Exception innerException) : base($"Sales Spy Found:Spy Name{spyName}", innerException)

        { 
        }//overloaded ctor

    }//class
}//Namespace
