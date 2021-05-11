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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void AdminDeposit_Load(object sender, EventArgs e)
        {
            //Everything in here works as autocomplete for comboBox

            try
            {
                List<string> cmbListOfAccountNumbers = new List<string>();
                //getting the list of Chequing Accounts with active status
                List<string> output = DatabaseHelper.selectData($"Select * from Accounts where Status = 'Active'");

                foreach (string currentRow in output)
                {
                    string[] rowData = currentRow.Split('|');
                    //Adding account number to the list
                    cmbListOfAccountNumbers.Add(rowData[0]);
                }

                cmbToAccount.Items.Clear();

                //adding values to the comboBox To Account
                cmbToAccount.Items.AddRange(cmbListOfAccountNumbers.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                Double amount = double.Parse(txtAmount.Text);
                long accountNumer = long.Parse(cmbToAccount.Text);

                //Amount cannot be zero or negative
                if (amount <= 0)
                {
                    throw new Exception("Amount cannot be less than or equal to 0");
                }

                //Get the balance of TO_ACCOUNT
                List<string> output = DatabaseHelper.selectData($"Select Balance from Accounts where accountNumber = {accountNumer}");
                double balance = double.Parse(output[0].Split('|')[0]);

                //deposit money to TO_ACCOUNT 
                //Add values inside Transaction table and update the balance
                int rowsAffectedTrns = DatabaseHelper.insertUpdateDeleteData($"INSERT INTO Transactions (Type,Amount,Date,AccountNumber,TransactionDetails) Values('Cr','{amount}',GETDATE(),'{accountNumer}','Cash Deposit')");
                int rowsAffectedBalance = DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts Set Balance = {amount+balance} where AccountNumber = {accountNumer}");

                if(rowsAffectedBalance > 0 && rowsAffectedTrns > 0)
                {
                    MessageBox.Show("Deposit Successful");
                    this.Close();

                    //If everything is good then update the records 
                    Home adminHome = Application.OpenForms.OfType<Home>().First();
                    adminHome.LoadRecrodsInTable();
                }
                else
                {
                    throw new Exception("Something went wrong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchToAccount(object sender, KeyEventArgs e)
        {
            try
            {
                string accountNumber = cmbToAccount.Text;

                List<string> cmbListOfAccounts = new List<string>();

                //Get the list of account Numbers related to text inside comboBox
                List<string> output = DatabaseHelper.selectData($"Select * from Accounts Where Status = 'Active' AND AccountNumber LIKE '%{accountNumber}%'");

                //Just checking if the length is 0 then show accordinly else show all the accountNumbers
                if (accountNumber.Length > 0)
                {
                    foreach (string currentRow in output)
                    {
                        string[] rowData = currentRow.Split('|');

                        //accountNumber is similar to accountNumber we typed in comboBox then display it
                        if (rowData[0].Contains(accountNumber))
                        {
                            cmbListOfAccounts.Add(rowData[0]);
                        }
                    }
                }
                else
                {
                    //Display all the account numbers
                    foreach (string currentRow in output)
                    {
                        string[] rowData = currentRow.Split('|');
                        cmbListOfAccounts.Add(rowData[0]);
                    }
                }

                cmbToAccount.Items.Clear();

                //everytime we type something in comboBox cursor move to index 0, so this is the fix for that
                cmbToAccount.Select(cmbToAccount.Text.Length, 0);

                cmbToAccount.Items.AddRange(cmbListOfAccounts.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
