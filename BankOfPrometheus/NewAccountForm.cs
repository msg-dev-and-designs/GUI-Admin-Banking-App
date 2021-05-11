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
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }


        //When the btnOpen button is clicked a new account will be created based on the informtion passed in by the user.
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                account.CreateAccount(txtFirstName.Text, txtLastName.Text, txtAddress.Text, long.Parse(txtPhoneNumber.Text), cmbAccountType.Text);

                //Create a query to pass to the DateHelper class, so the Account can be added to the DB
                string query = $"INSERT INTO Accounts VALUES ({account.AccountNumber},'{account.FirstName}','{account.LastName}', '{account.Address}', {account.PhoneNumber}, {account.Balance}, '{account.Status}', '{account.AcccountType}', GETDATE())";
                DatabaseHelper.insertUpdateDeleteData(query);
                MessageBox.Show("Account has been created.", "Success", MessageBoxButtons.OK);
                Close();

                //Finds the current AdminHome form that is open and calls the LoadRecrodsInTable() method to update the table.
                Home adminHome = Application.OpenForms.OfType<Home>().First();
                adminHome.LoadRecrodsInTable();

            }
            catch
            {
                MessageBox.Show("An error has occured. Please double check all fields and try again.", "Error", MessageBoxButtons.OK);
            }
        }

  

        private void AdminOpenNewAccount_Load(object sender, EventArgs e)
        {
            cmbAccountType.Text = "Chequing";
        }
    }
}
