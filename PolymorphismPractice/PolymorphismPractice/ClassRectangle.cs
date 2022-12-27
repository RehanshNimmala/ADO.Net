using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
     class ClassRectangle: ClassShape
    {
        public ClassRectangle(int length, int width): base(length, width)
        {

        }
        public ClassRectangle(int length):base(length, length)
        {

        }
        public new string Draw()
        {
            if (base.xPosition == base.yPosition)
                return $@"Drawing a square:Length{xPosition}.{Environment.NewLine}
                    Square is a rectangle with equal sides.Output from Rectangle Class.
                    {Environment.NewLine} Draw() method of rectangle class hides the base class method.
             {Environment.NewLine}The Rectangle Class ctor has overloaded constructors:one for square and other for Rectangle";
            else
                return $@"Drawing rectangle:X{xPosition},Y:{yPosition}.
                {Environment.NewLine}Output from Rectangle class.
                {Environment.NewLine}Draw() method of rectangle class hides the base class method";
        }
    }
}
