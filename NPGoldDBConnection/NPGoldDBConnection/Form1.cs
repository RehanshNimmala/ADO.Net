using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPGoldDBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {

                // if(tryparse(firstNameTextBox.Text,out))
                if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0)
                {
                    string firstName = firstNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    if (salaryTextBox.Text.Length > 0)
                    {
                        int salary = int.Parse(salaryTextBox.Text);


                        //Instantiate the Intermediary class
                        IntermediaryClass intermediaryClass = new IntermediaryClass();
                        intermediaryClass.InsertRep(firstName, lastName, salary);
                        displayLabel.Text = "One Record is Inserted";
                    }
                    else
                    {
                        displayLabel.Text = "Please enter a valid amount";
                    }
                }
                else
                {
                    displayLabel.Text = "Please enter the values";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
