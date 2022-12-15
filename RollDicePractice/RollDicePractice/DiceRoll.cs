using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDicePractice
{
    public class DiceRoll
    {
        //Create a method which generates two random numbers for the incoming parameters and return the total
        public int Roll(out int die1, out int die2)
        {
            Random random = new Random();
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);
            return die1+ die2;
        }//Roll
    }//class
}//namespace
