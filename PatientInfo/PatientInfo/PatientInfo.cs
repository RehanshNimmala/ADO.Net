using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PatientInfo
{
    //Created by Nimmala
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Dclaring the variables
                string patientName = nameTextBox.Text;
                int age = int.Parse(ageTextBox.Text);
                int phoneNumber = int.Parse(phoneNumberTextBox.Text);
                int billAmount = int.Parse(billAmountTextBox.Text);

                // creating Connection to the data base

                string sqlConnection = $@"Data source=Naveen;initial Catalog=ADONET;
                                        persist security info=true;integrated security=SSPI";
                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();
                SqlCommand cmd = new SqlCommand(sqlConnection);
                cmd.Connection = sql;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"Insert into Patient_Information values
                                 ('{nameTextBox.Text}',{ageTextBox.Text},{phoneNumberTextBox.Text},{billAmountTextBox.Text})";
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBox.Show("Data is inserted");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
                sql.Close();

            }
            catch (Exception )
            {

                MessageBox.Show("Please contact Admin");
            }


        }// End of submit button
    }// End of class
}//End of Namespace
