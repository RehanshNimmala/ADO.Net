using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismPractice
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void shapeButton_Click(object sender, EventArgs e)
        {
            ClassShape shape = new ClassShape(20, 30);
            resultTextBox.Text = shape.Draw();

        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            ClassCircle circle= new ClassCircle(20, 30);
            resultTextBox.Text= circle.Draw();
            resultTextBox.Text += $"Circle Class Draw method is inherited from ShapeClass.{Environment.NewLine}";
            resultTextBox.Text += circle.FillColor("Red");

        }//circle

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            ClassRectangle rectangle= new ClassRectangle(20, 30);
            ClassRectangle square = new ClassRectangle(20);
            resultTextBox.Text= rectangle.Draw();
            resultTextBox.Text += Environment.NewLine;
            resultTextBox.Text += square.Draw();
        }

        private void upcastingButton_Click(object sender, EventArgs e)
        {
            ClassShape circleShape= new ClassShape(20, 30);
            string message = circleShape.Draw();
            resultTextBox.Text= message;
        }//upcast by instantiation

        private void upcastingByAssignmentButton_Click(object sender, EventArgs e)
        {
            ClassShape shape= new ClassShape(20, 30);
            ClassRectangle rectangle= new ClassRectangle(20, 30);
            ClassCircle circle = new ClassCircle(20, 30);
            string message = "";
            message+=$"Drawing Shape:{shape.Draw()}";
            message+=$"Drawing rectangle:{rectangle.Draw()}";
            shape = rectangle;
            resultTextBox.Text = message;
        }

        private void notDowncastingButton_Click(object sender, EventArgs e)
        {
            string message = $"try this code:{Environment.NewLine}" +
                $"ClassCircle downshape=(ClassCircle)new ClassShape(35,37);{Environment.NewLine}" +
                $"string message=downShape.FillColor(\"Blue\");{Environment.NewLine}" +
                $@"That will be ok & IDE will not throw an error.But it will be caught as an error in run time(Invalid cast Error)
                DownCasting is not type-safe!{Environment.NewLine}+{Environment.NewLine}" +
                $"Any other form of instance Downcasting such as this one below will also throw runtime error:{Environment.NewLine}" +
                $"Rectangle=(ClassRectangle)shape;{Environment.NewLine}" +
                $" message+= rectangle.Draw();{Environment.NewLine}" +
                $@"//Instantiating two objects:
                {Environment.NewLine}ClassShape=new ClassShape(66,67);
                 {Environment.NewLine}ClassRectangle rectangle=new ClassRectangle(44,45);" +
                 $@"{Environment.NewLine}Moral :Do NOT do Down Casting.
                    It will throw errors in runtime even if IDE does not scream about it
                    But C# supports DownCasting!! See other code";
            resultTextBox.Text = message;
        }

        private void okDowncastingButton_Click(object sender, EventArgs e)
        {
            ClassShape shapeR = new ClassRectangle(34, 45);
            ClassRectangle rectangle = new ClassRectangle(11, 22);
            if (shapeR is ClassRectangle)
            {
                resultTextBox.Text = $@"{shapeR.Draw()}+{Environment.NewLine + Environment.NewLine}.
                DownCasting works if shapeR isalso of the type ClassRectangle!{Environment.NewLine}+
                That worked because: You initialized the shape object type, with the rectangle ctor which makes
                the shape object a Rectangle!
                {Environment.NewLine} ClassShape shapeR=new ClassRectangle(34,35);";
            }
        }
    }
}
