using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOfPrometheus
{
    public partial class ManageAccountForm : Form
    {
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        //OnChange of the account number text box, we search the DB until only one account is returned with account number given.
        //Then fill the other text boxes with data from that account. 
        private void searchAccount(object sender, KeyEventArgs e)
        {
            //Grabs the Accounts associated with account number given.
            List<string> restults = DatabaseHelper.selectData($"SELECT AccountNumber, FirstName, LastName, PhoneNumber, Address, AccountType FROM Accounts WHERE AccountNumber = {txtAccountNumber.Text} AND Status = 'Active'");

            //When only one account is returned from the DB, format the data and fill out the fields in the form. 
            if (restults.Count == 1)
            {
                string[] formattedData = null;
                foreach (string data in restults)
                {
                    formattedData = data.Split('|');
                }

                fillData(formattedData[1], formattedData[2], formattedData[3], formattedData[4], formattedData[5]);

            }
            else
            {
                clearData();
            }

        }


        //fillData takes in the data from a certain account and fills the forms fields with that data.
        private void fillData(string firstName, string lastName, string phoneNumber, string address, string accountType)
        {
            txtAccountType.Text = accountType;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtPhoneNumber.Text = phoneNumber;
            txtAddress.Text = address;
        }

        //clearData is used to clear all the fields if more than one account is returns or zero account are returned
        private void clearData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        private void AdminManageAccount_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAccountNumber;

        }

        //When the update button is clicked the field data is passed to EditAccountDetails which updates the Account information in the DB. 
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

            try
            {
                Account.EditAccountDetails(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtAddress.Text, txtAccountNumber.Text);
                MessageBox.Show("Account has been updated.", "Success", MessageBoxButtons.OK);
                Close();
                //This finds the home form and reloads the records by calling the LoadRecrodsInTable.
                Home home = Application.OpenForms.OfType<Home>().First();
                home.LoadRecrodsInTable();
            }
            catch
            {
                MessageBox.Show("An error has occured. Please double check all fields and try again.", "Error", MessageBoxButtons.OK);
            }

        }


        //When the deactivate button is clicked the status of the associated account will be updates to Inactive. 
        private void btnDeactivate_Click(object sender, EventArgs e)
        {

            try
            {
                Account.DeactivateAccount(txtAccountNumber.Text);
                MessageBox.Show("Account has been deactivated.", "Error", MessageBoxButtons.OK);
                Close();
                Home adminHome = Application.OpenForms.OfType<Home>().First();
                adminHome.LoadRecrodsInTable();

            }
            catch
            {
                MessageBox.Show("An error has occured. Please double check your account number.", "Error", MessageBoxButtons.OK);
            }



        }
    }
}
