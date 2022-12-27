using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class ClassCircle:ClassShape
    {
        public ClassCircle(int x,int y):base(x,y)
        {

        }//ctor
        public string FillColor(string color)
        {
            return $@"Fill Circle with color{color}{Environment.NewLine}Output from CircleClass";

        }//FillColor
    }//end class
}//end namespace
