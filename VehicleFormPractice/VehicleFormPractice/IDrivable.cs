using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFormPractice
{
    //11111111111
    interface  IDrivable
    {
        //This interface has one property and one method that returns a string and accepta two arguments

        double MaximumSpeed { get; set; }

        string Drive(double distance, double speedLimit);
    }//interface
}//namespace
