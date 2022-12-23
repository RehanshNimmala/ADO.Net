using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFormPractice
{
     class Truck:Vehicle
    {
        private const int  No_Of_Wheels= 18;
        private const int Max_Speed = 70;
        private const string Truck_Color = "Red";
        private int axleWeight;

        /*//Regular way of defing the ctor
        public Truck(int weightPerAxle):base(No_Of_Wheels,Max_Speed,Color)
        {
            axleWeight = weightPerAxle;
        }*/
        public Truck(int weightPerAxle) : base(No_Of_Wheels, Max_Speed, Truck_Color) => axleWeight = weightPerAxle;

        public int AxleWeight
        { get => axleWeight; 
            set => axleWeight = value;
        }
    }//end class
}//namespace
