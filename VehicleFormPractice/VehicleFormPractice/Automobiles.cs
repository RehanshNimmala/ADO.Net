using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleFormPractice
{
    public partial class Automobiles : Form
    {
        private string lineBreaker = Environment.NewLine + Environment.NewLine;
        public Automobiles()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//exit

        private void sedanButton_Click(object sender, EventArgs e)
        {
            //Instantiating vehicle class:
            Vehicle sedan = new Vehicle(4, 70, "Grey");
            string message = ObjDetails(sedan);
            //call about property for sedan for more details:
            message += $"{sedan.About}{lineBreaker}";
            message += $@"The parameters passed to the constructorwere: 4wheels,70MPH Maximum speed, and Gray color.
                        Now call the Drive Method and supply 350 miles for distance driven,
                        and speed you drove as :140 MPH{lineBreaker} Output from {sedan.GetType().Name}class:{sedan.ToString()}
                        {lineBreaker}{sedan.Drive(350, 140)}.Observe that the speed calculated is still 70MPH 
                        because a car not allowed to travel over the speed limit.";
            resultTextBox.Text = message;
            //note that the drive method is overloaded which takes either 2 or 1 argument
        }

        private void raceCarButton_Click(object sender, EventArgs e)
        {
            //Instantiating the race car class(derived class)
            IDrivable raceCar = new RaceCar(400, "Red", RaceCar.RaceCarType.Formula);
            //Used the interface as a type to instantiate the derived class
            //See that you are using the enum from the race car class while supplying argument for car type

            string message = ObjDetails(raceCar);
            message += $@"see that when you use the Drive method, you will notice that speed limit is not applicable
                        for the racer car because of the overeide method in the class:{lineBreaker}{raceCar.Drive(1200, 70)}";
            resultTextBox.Text = message;
        }
        private string ObjDetails(IDrivable objectName)
        {
            /*This method receives an incoming parameter of type IDrivable(or any derivative of IDrivable) and returns the 
             * information about the object.*/
            return $"Name of the object or class is :{objectName.GetType().Name}{lineBreaker}" +
                $"This class is derived from{objectName.GetType().BaseType}{lineBreaker}" +
                $"The Name of assembly is {objectName.GetType().Assembly.GetName()}{lineBreaker}" +
                $"More details about this class :{objectName.ToString()}{lineBreaker}";
        }

        private void motorcycleButton_Click(object sender, EventArgs e)
        {
            /*You are using a var(varient) keyword here instead of specific object type.
             * var assumes the type of the object assigned to it.in this case, Motorcycle.
             * */
            var motorCycle = new MotorCycle(70);
            //see you only supplied one argument for the constructor

            string message = ObjDetails(motorCycle);
            message += $"More details:{motorCycle.About}";
            message += $@"Output comes from MotorCycle class{lineBreaker}Overloaded method with 
                            one parametersupplied(distance):{motorCycle.Drive(700)}.
                    You were driving within the speed limit of {motorCycle.MaximumSpeed}MPH.{lineBreaker}
                Now call the overloaded method with two parameters(distance and speed Driven as 140)
                    {motorCycle.Drive(750, 140)}.The speed limit was{motorCycle.MaximumSpeed}.
                    You dont get to drive over the speed limiteven if you have a motorcycle.{lineBreaker}
            Now call the Drive method with a driving speed as 50 MPH:{motorCycle.Drive(350.50)}: Observe that the lower speed 
                    of 50 MPH used for calculations.";
            resultTextBox.Text = message;

        }

        private void truckButton_Click(object sender, EventArgs e)
        {
            //Instantiate the truck class
            Truck truck = new Truck(20000);
            //calling the classes and properties in truck class and displaying the details by calling the ObjDetailsmethod:
            string message = ObjDetails(truck);
            message += $"{Environment.NewLine}Axle Weight:{truck.AxleWeight}pounds.";
            resultTextBox.Text = message;
        }
    }//end form
}//namespace
