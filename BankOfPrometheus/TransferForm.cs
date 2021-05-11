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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void AdminTransfer_Load(object sender, EventArgs e)
        {
            //Everything in here works as autocomplete for comboBox

            try
            {
                List<string> cmbListOfAccountNumbers = new List<string>();
                //getting the list of Chequing Accounts with active status
                List<string> output = DatabaseHelper.selectData($"Select * from Accounts where Status = 'Active' AND AccountType='Chequing'");

                foreach (string currentRow in output)
                {
                    string[] rowData = currentRow.Split('|');
                    //Adding account number to the list
                    cmbListOfAccountNumbers.Add(rowData[0]);
                }


                cmbFromAccount.Items.Clear();
                cmbToAccount.Items.Clear();

                //adding values to both the comboBoxes From Account and To Account
                cmbFromAccount.Items.AddRange(cmbListOfAccountNumbers.ToArray());
                cmbToAccount.Items.AddRange(cmbListOfAccountNumbers.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchFromAccount(object sender, KeyEventArgs e)
        {
            try
            {
                string accountNumber = cmbFromAccount.Text;

                List<string> cmbListOfAccounts = new List<string>();

                //Get the list of account Numbers related to text inside comboBox
                List<string> output = DatabaseHelper.selectData($"Select * from Accounts Where Status = 'Active' AND AccountNumber LIKE '%{accountNumber}%' AND AccountType='Chequing'");

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

                cmbFromAccount.Items.Clear();

                //everytime we type something in comboBox cursor move to index 0, so this is the fix for that
                cmbFromAccount.Select(cmbFromAccount.Text.Length, 0);

                cmbFromAccount.Items.AddRange(cmbListOfAccounts.ToArray());
            }
            catch (Exception ex)
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
                List<string> output = DatabaseHelper.selectData($"Select * from Accounts Where Status = 'Active' AND AccountNumber LIKE '%{accountNumber}%' AND AccountType='Chequing'");

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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Double amount = double.Parse(txtAmount.Text);
                long fromAccountNumer = long.Parse(cmbFromAccount.Text);
                long toAccountNumber = long.Parse(cmbToAccount.Text);
                
                //from and to account for transfer cannot be same
                if(fromAccountNumer == toAccountNumber)
                {
                    throw new Exception("Invalid Transfer");
                }

                //Amount cannot be zero or negative
                if (amount <= 0)
                {
                    throw new Exception("Amount cannot be less than or equal to 0");
                }

                //Get the balance of FROM_ACCOUNT
                List<string> outputFrom = DatabaseHelper.selectData($"Select Balance from Accounts where accountNumber = {fromAccountNumer}");
                double balanceFrom = double.Parse(outputFrom[0].Split('|')[0]);

                //If there is not a sufficient balance then throw an error
                if (balanceFrom < amount)
                {
                    throw new Exception("Insufficient Balance");
                }

                //withdraw money from FROM_ACCOUNT 
                //Add values inside Transaction table and update the balance
                int rowsAffectedBalanceFrom = DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts Set Balance = {balanceFrom - amount} where AccountNumber = {fromAccountNumer}");
                int rowsAffectedTrnsFrom = DatabaseHelper.insertUpdateDeleteData($"INSERT INTO Transactions (Type,Amount,Date,AccountNumber,TransactionDetails) Values('Dr','{amount}',GETDATE(),'{fromAccountNumer}','Money Transfer to {toAccountNumber}')");

                //Get the balance of TO_ACCOUNT
                List<string> outputTo = DatabaseHelper.selectData($"Select Balance from Accounts where accountNumber = {toAccountNumber}");
                double balanceTo = double.Parse(outputTo[0].Split('|')[0]);

                //deposit money to TO_ACCOUNT 
                //Add values inside Transaction table and update the balance
                int rowsAffectedTrnsTo = DatabaseHelper.insertUpdateDeleteData($"INSERT INTO Transactions (Type,Amount,Date,AccountNumber,TransactionDetails) Values('Cr','{amount}',GETDATE(),'{toAccountNumber}','Money Transfer from {fromAccountNumer}')");
                int rowsAffectedBalanceTo = DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts Set Balance = {amount + balanceTo} where AccountNumber = {toAccountNumber}");


                if (rowsAffectedBalanceFrom > 0 && rowsAffectedTrnsFrom > 0 && rowsAffectedBalanceTo > 0 && rowsAffectedTrnsTo > 0)
                {
                    MessageBox.Show("Transfer Successful");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
