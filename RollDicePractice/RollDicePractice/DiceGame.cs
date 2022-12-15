using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDicePractice
{
    public partial class DiceGame : Form
    {
        public DiceGame()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //instantiate the class
            DiceRoll diceRoll = new DiceRoll();

            //declare the variables
            int myDie1;
            int myDie2;
            int sum;

            sum=diceRoll.Roll(out myDie1,out myDie2);

            dice1Label.Text = myDie1.ToString();
            dice2Label.Text = myDie2.ToString();
            sumOfDice.Text = sum.ToString();
        }//roll button
    }//class
}//Namespace
