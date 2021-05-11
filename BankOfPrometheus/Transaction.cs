using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfPrometheus
{
    class Transaction
    {
        private string _type;
        private double _amount;
        private string _date;
        private long _accountNumber;
        private string _transactionDetails;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

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

        public string TransactionDetails
        {
            get
            {
                return _transactionDetails;
            }
            set
            {
                _transactionDetails = value;
            }
        }

        //This method grads all the transacions and send back the transactions based on the account number, type, and id.
        public static List<string> GetTransactions(string type, string id, string accountNumber)
        {
            
            if (id.Length > 0)
            {
                if (type == "All")
                {
                    return DatabaseHelper.selectData($"SELECT * FROM Transactions WHERE AccountNumber='{accountNumber}' AND TransactionId LIKE '%{id}%'");
                }
                else
                {
                    return DatabaseHelper.selectData($"SELECT * FROM Transactions WHERE AccountNumber='{accountNumber}' AND Type = '{type}' AND TransactionId LIKE '%{id}%'");
                }
            }
            else
            {
                if (type == "All")
                {
                    return  DatabaseHelper.selectData($"SELECT * FROM Transactions WHERE AccountNumber='{accountNumber}'");
                }
                else
                {
                    return  DatabaseHelper.selectData($"SELECT * FROM Transactions WHERE AccountNumber='{accountNumber}' AND Type = '{type}'");
                }
            }

        }
    }
}
