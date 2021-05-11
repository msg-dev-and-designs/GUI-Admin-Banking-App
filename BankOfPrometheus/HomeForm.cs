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
using System.Configuration;


namespace BankOfPrometheus
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TransferForm().ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepositForm().ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WithdrawForm().ShowDialog();
        }

        private void openNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewAccountForm().ShowDialog();
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageAccountForm().ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear the session storage variable
            SessionStorage.currentLoggedInUser = "";

            //open the login form and close this form
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateNewUserForm().ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            try
            {
                //Just styling a bit
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10.75F);
                dataGridView1.RowsDefaultCellStyle.Font = new Font("Arial", 9.75F);

                string currentUser = SessionStorage.currentLoggedInUser;
                
                //getting values from Users table to check their roles
                List<string> output = DatabaseHelper.selectData($"Select * from Users where userName = '{currentUser}'");
                string currentUserRole = output[0].Split('|')[2];

                if (currentUserRole == "Manager")
                {
                    //Manager can't create or manage users
                    userToolStripMenuItem.Visible = false;
                }
                else if (currentUserRole == "Employee")
                {
                    //Employee can't create or manage users and can't manage account
                    userToolStripMenuItem.Visible = false;
                    manageAccountToolStripMenuItem.Visible = false;
                }
                //Else Admin will have all the access

                LoadRecrodsInTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void LoadRecrodsInTable()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                //list of headings or column that we'll display in our dataGridView seperated by comma
                string headingsString = "AccountNumber,FirstName,LastName,Address,PhoneNumber,Balance,AccountType,DateOpened";
                string[] headings = headingsString.Split(',');


                foreach (string columnName in headings)
                {
                    //update the dataGirdView and add columns
                    dataGridView1.Columns.Add(columnName, columnName);
                }

                //Get the list of all the active accounts
                List<string> myOutput = DatabaseHelper.selectData("SELECT * FROM Accounts WHERE Status='Active'");

                //iterate through each row
                foreach (string currentRow in myOutput)
                {
                    //rowData will have each cell value
                    string[] rowData = currentRow.Split('|');

                    //Just making our balance column looks pertier. Rather than 100.01 it will be $100.01
                    rowData[5] = "$" + Math.Round(Double.Parse(rowData[5]), 2).ToString();

                    //Adding rows to our dataGridView
                    dataGridView1.Rows.Add(new string[] { rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5], rowData[7],rowData[8].Split()[0] });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUserForm().ShowDialog();
        }

        private void searchAccount(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                string queryString = txtSearch.Text;

                //Get the list of active accounts with accountNumber similar to queryString(text in our search box)
                List<string> myOutput = DatabaseHelper.selectData($"SELECT * FROM Accounts WHERE Status='Active' AND AccountNumber LIKE '%{queryString}%'");

                //iterate through each row
                foreach (string currentRow in myOutput)
                {
                    //rowData will have each cell value
                    string[] rowData = currentRow.Split('|');

                    //Just making our balance column looks pertier. Rather than 100.01 it will be $100.01
                    rowData[5] = "$" + Math.Round(Double.Parse(rowData[5]), 2).ToString();

                    //Adding rows to our dataGridView
                    dataGridView1.Rows.Add(new string[] { rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5], rowData[7], rowData[8].Split()[0] });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the row index
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //call transaction form and pass the accountNumber or Value inside cell[0] to it
            new TransactionsForm(row.Cells[0].Value.ToString()).ShowDialog();
        }

        private void updateInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                Account account = new Account();
                
                //Updating interest
                if (account.InterestRateAdded())
                {
                    MessageBox.Show("Interest Updated");
                    //Updating records in table
                    LoadRecrodsInTable();
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
    }

 
   
}
