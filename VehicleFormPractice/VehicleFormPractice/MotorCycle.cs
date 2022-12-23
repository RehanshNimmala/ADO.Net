using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFormPractice
{
     class MotorCycle:Vehicle
    {
        /*Motorcycle is also a vehicle just like the vehicle class and derives all the methods and properties from the parent class.
         * However motor cycle is different because, it has only two wheels.*/
        private const int No_Of_Wheels = 2;
        private const string MC_Color = "Black";

        public MotorCycle(double maxSpeed): base(No_Of_Wheels,maxSpeed,MC_Color)
        {
            //NO code statements as class will take care
        }//ctor
    }//motorcycle class
}//namespace
