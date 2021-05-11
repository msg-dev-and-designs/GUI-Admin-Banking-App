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
    public partial class CreateNewUserForm : Form
    {
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        //On load sets the selected index to 0.
        private void AdminCreateNewUser_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string role = cmbRole.Text;

                //This query will grab all the users UserNames from the DB
                string selectQuery = "SELECT UserName FROM Users";

                List<string> output = DatabaseHelper.selectData(selectQuery);

                //We will then loop through the results and if the username enter is already in the DB throw and error.
                foreach(string s in output)
                {
                    if(s == username)
                    {
                        txtUserName.Text = "";
                        throw new Exception("Username already exist");
                      
                    }
                }

                //We are creating a user here with the data provided and then intserted it into the DB 
                User user = new User(username, password, role);
                string query = $"INSERT INTO Users VALUES ('{user.Username}','{user.Password}', '{user.Role}')";
                DatabaseHelper.insertUpdateDeleteData(query);
                MessageBox.Show("User had been created!", "Success", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
