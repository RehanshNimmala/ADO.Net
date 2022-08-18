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

            MyClass myClass=new MyClass(nameEntered);
            Console.ReadKey();

        }
        public class MyClass
        {
            public MyClass(string name)
            {
                Console.WriteLine($"Hello {name}. Your first Console application is done");
            }
        }
    }
}
