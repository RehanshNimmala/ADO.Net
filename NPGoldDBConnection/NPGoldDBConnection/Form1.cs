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
                    int salary = int.Parse(salaryTextBox.Text);

                    if (salaryTextBox.Text.Length > 0)
                    {


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

        private void firstNameValidating(object sender, CancelEventArgs e)
        {
            // verifying the correct input
            if(firstNameTextBox.Text.Length>0)
            {
                firstNameErrorProvider.SetError(firstNameTextBox, "");
            }
            else
            {
                firstNameErrorProvider.SetError(firstNameTextBox, "Please enter valid Name");
                firstNameTextBox.Focus();
                firstNameTextBox.SelectAll();

            }//
        }//FirstName Validating

        private void lastNameValidating(object sender, CancelEventArgs e)
        {
            if(lastNameTextBox.Text.Length>0)
            {
                lastNameErrorProvider.SetError(lastNameTextBox, "");
            }
            else
            {
                lastNameErrorProvider.SetError(lastNameTextBox, "Please enter the Last Name");
                lastNameTextBox.Focus();
                lastNameTextBox.SelectAll();
            }
        }//LastName validating

        private void salaryValidating(object sender, CancelEventArgs e)
        {
           // int salary=int.Parse(salaryTextBox.Text);
            if(salaryTextBox.Text.Length>0)
            {
                salaryErrorProvider.SetError(salaryTextBox, "");

            }
            else
            {
                salaryErrorProvider.SetError(salaryTextBox, "Please enter a valid salary amount");
                salaryTextBox.Focus();
                salaryTextBox.SelectAll();
            }
        }//Salary Validating
    }
}
