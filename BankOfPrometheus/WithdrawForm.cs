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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
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

        private void AdminWithdraw_Load(object sender, EventArgs e)
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

                //adding values to both the comboBoxes From Account and To Account
                cmbFromAccount.Select(cmbFromAccount.Text.Length, 0);

                cmbFromAccount.Items.AddRange(cmbListOfAccountNumbers.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                Double amount = double.Parse(txtAmount.Text);
                long accountNumer = long.Parse(cmbFromAccount.Text);

                //Amount cannot be zero or negative
                if (amount <= 0)
                {
                    throw new Exception("Amount cannot be less than or equal to 0");
                }

                //Get the balance of FROM_ACCOUNT
                List<string> output = DatabaseHelper.selectData($"Select Balance from Accounts where accountNumber = {accountNumer}");
                double balance = double.Parse(output[0].Split('|')[0]);

                //If there is not a sufficient balance then throw an error
                if (balance < amount)
                {
                    throw new Exception("Insufficient Balance");
                }

                //withdraw money from FROM_ACCOUNT 
                //Add values inside Transaction table and update the balance
                int rowsAffectedBalance = DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts Set Balance = {balance - amount} where AccountNumber = {accountNumer}");
                int rowsAffectedTrns = DatabaseHelper.insertUpdateDeleteData($"INSERT INTO Transactions (Type,Amount,Date,AccountNumber,TransactionDetails) Values('Dr','{amount}',GETDATE(),'{accountNumer}','Cash Withdrawn')");

                if (rowsAffectedBalance > 0 && rowsAffectedTrns > 0)
                {
                    MessageBox.Show("Withdrawl Successful");
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
