using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfPrometheus
{
    
    //Account class is used to create, update, and deactivate account in the bank. 
    //The Account class also inherits the IChequing and ICreditCard Interfaces allowing us to deduct and add interest depending on the account type.
    class Account : IChequing
    {
        //Account fields.
        private long _accountNumber;
        private string _firstName;
        private string _lastName;
        private string _address;
        private long _phoneNumber;
        private double _balance;
        private string _status;
        private string _accountType;

        //Account properties.
        public long AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {


                _accountNumber = value;


            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                //Validation to make sure the phone is the appropriate length.
                if (value.ToString().Length == 10)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }


        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string AcccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        //CreateAccount allows the user to create a new account with supplied information
        //The account number, balance, and status will be set to a default initially.
        public void CreateAccount(string firstName, string lastName, string address, long phoneNumber, string accountType)
        {


            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Status = "Active";
            this.Balance = 0;
            this.AcccountType = accountType;

            //For the AccountNumber we have a defalut number which then gets increased based on the number of accounts in the DB, thus making the account number unique.
            this.AccountNumber = 5191241681 + DatabaseHelper.selectData("SELECT * FROM Accounts").Count();

        }

        //EditAccountDetails takes in the updated information from the used and updates the database accordingly.
        public static void EditAccountDetails(string fname, string lname, string phonenumber, string address, string accountNumber)
        {
            //If the phone is the equals ten and all the other fields have been filled send a query to update the DB.
            //Else throw an exception. 
            if (phonenumber.Length == 10 && !String.IsNullOrWhiteSpace(fname) && !String.IsNullOrWhiteSpace(lname) && !String.IsNullOrWhiteSpace(address) && !String.IsNullOrWhiteSpace(accountNumber))
            {
                DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts SET FirstName = '{fname}', LastName = '{lname}', PhoneNumber = {phonenumber}, Address = '{address}' WHERE AccountNumber = {accountNumber}");
            }
            else
            {
                throw new Exception();
            }
        }

        //DeactivateAccount takes an account number from the user and will then set the status of the account to Inactive.
        //The account will no longer be visiable in the program.
        public static void DeactivateAccount(string accountNumber)
        {
            DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts SET Status = 'Inactive' WHERE AccountNumber = {accountNumber}");
        }


        //InterestRateAdded takes in a account number and an interest rate and adds the interest amount to the current checking balance.
        public bool InterestRateAdded()
        {

            int countAccounts = 0;

            //Sends a query to the DB and gets all account that are active with a chequing type.
            List<string> output = DatabaseHelper.selectData("SELECT * FROM Accounts WHERE Status = 'Active' AND AccountType='Chequing'");

            //Loops through the results of the query and adds the interest rate to each balance.
            foreach (string currentRow in output)
            {
                string[] rowData = currentRow.Split('|');

                
                DateTime dateOpened = DateTime.Parse(rowData[8]);

                bool fiveYearsOrMore = false;
                DateTime currentDate = DateTime.Now;



                //365.25 because of leap year issue
                //365.25 is an average number of days
                //365+365+365+366 = 1461
                //1461/4 = 365.25
                if ((currentDate.Date - dateOpened.Date).TotalDays / 365.25 >= 5)
                {
                    fiveYearsOrMore = true;
                }

                float interestRate = 5.0f;

                if (fiveYearsOrMore)
                {
                    interestRate = 7.5f;
                }

                string accountNumber = rowData[0];
                double balance = Double.Parse(rowData[5]);

                double interestAmount = interestRate / 100 * balance;

                int rowsAffectedTrns = DatabaseHelper.insertUpdateDeleteData($"INSERT INTO Transactions (Type,Amount,Date,AccountNumber,TransactionDetails) Values('Cr','{interestAmount}',GETDATE(),'{accountNumber}','Interest @{interestRate}')");
                int rowsAffectedBalance = DatabaseHelper.insertUpdateDeleteData($"UPDATE Accounts Set Balance = {balance + interestAmount} where AccountNumber = {accountNumber}");


                if (rowsAffectedBalance > 0 && rowsAffectedTrns > 0)
                {
                    countAccounts++;
                }
                else
                {
                    throw new Exception("Something went wrong");
                }
            }

            if(countAccounts == output.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
