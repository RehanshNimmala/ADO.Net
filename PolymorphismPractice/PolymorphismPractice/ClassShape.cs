using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    public class ClassShape:IPolyShapes
    {
        protected int xPosition;
        protected int yPosition;
        public ClassShape(int x, int y)
        {
            xPosition = x;
            yPosition = y;
        }//ctor
        public string Draw()
        {
            return $"Drawing shape at X position:{xPosition},Y:{yPosition}.{Environment.NewLine} output from shape class.";
        }//end Draw()
    }//class
}//namespace
