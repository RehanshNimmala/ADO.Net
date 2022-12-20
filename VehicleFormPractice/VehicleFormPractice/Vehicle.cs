using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFormPractice
{
    class Vehicle : IDrivable
    {
        public double MaximumSpeed
        {
            get { return MaximumSpeed; }
            set { MaximumSpeed = value; }
        }

        public string Drive(double distance, double speedLimit)
        {
            throw new NotImplementedException();
        }
    }
}
