using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");

            string nameEntered=Console.ReadLine();


            Console.WriteLine("Please enter your Name");

            string secondName=Console.ReadLine();

            MyClass myClass=new MyClass(nameEntered);
            MyName myName=new MyName(secondName);
            //Console.WriteLine();
            Console.ReadKey();

        }
        public class MyClass
        {
            public MyClass(string name)
            {
                Console.WriteLine($"Hello {name}. Your first Console application is done");
            }
          
        }
        public class MyName
        {
            public  MyName(string sName)
            {
                Console.WriteLine($"Your Second Name is {sName}");

            }
        }
    }
}
