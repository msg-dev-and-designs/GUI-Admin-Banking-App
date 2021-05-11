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
    public partial class TransactionsForm : Form
    {
        string accountNumber;
        public TransactionsForm(string _accountNumber)
        {
            InitializeComponent();
            accountNumber = _accountNumber;
        }

        //Here we are loading all the transactions into the form
        private void AdminTransactions_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTransactionType.SelectedIndex = 0;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10.75F);
                dataGridView1.RowsDefaultCellStyle.Font = new Font("Arial", 9.75F);
                LoadRecrodsInTable("All");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This allows to grab transactions based on the transaction type and the transaction id
        //Transaction id is an optional parameter. 
        public void LoadRecrodsInTable(string transactionType,string transactionId = "")
        {
            try
            {
                //We are clearing the rows and columns
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                //Setting the column headers
                string headingsString = "TxnID,Type,Amount,Date,AccountNumber,Details";
                string[] headings = headingsString.Split(',');
                foreach (string columnName in headings)
                {
                    dataGridView1.Columns.Add(columnName, columnName);
                }

                //Gets transactions and updates the rows the table. 
                foreach (string currentRow in Transaction.GetTransactions(transactionType, transactionId, accountNumber))
                {
                    string[] rowData = currentRow.Split('|');
                    rowData[2] = "$" + Math.Round(Double.Parse(rowData[2]), 2).ToString();
                    dataGridView1.Rows.Add(new string[] { rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5] });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecrodsInTable(cmbTransactionType.Text,txtTransId.Text);
        }

        private void txtTransId_TextChanged(object sender, EventArgs e)
        {
            LoadRecrodsInTable(cmbTransactionType.Text, txtTransId.Text);
        }
    }
}
