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
    }
}
