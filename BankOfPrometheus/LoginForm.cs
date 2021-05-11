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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoggingIn();
        }

        private void LoggingIn()
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                //Get the username and password values from Database and store it in output variable of type List<string>
                List<string> output = DatabaseHelper.selectData($"SELECT UserName, Password from Users Where UserName = '{username}'");
                
                //Just checking that we dont have users with same username becuase username is the PRIMARY_KEY in database
                if (output.Count == 1)
                {
                    //save the username in SessionStorage class to fetch it later to provide access accordingly
                    SessionStorage.currentLoggedInUser = username;
                    
                    string[] formattedData = output[0].Split('|');
                    //Check if the password from the output matches the password user typed in the login form
                    if(formattedData[1] == password)
                    {
                        //123456789 in default password someone with admin privilages creates new user 
                        //If user is having default password they need to change it first then they can acess everything
                        if (password == "123456789")
                        {
                            //Opening ChangePasswordForm
                            this.Hide();
                            new ChangePasswordForm(false).ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            //else open the admin form
                            this.Hide();
                            new Home().ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        //removing any saved value in session storage class
                        SessionStorage.currentLoggedInUser = "";

                        //Display the message, focus on username field
                        MessageBox.Show("Inavlid Password\nPlease Try Again!");
                        tbUsername.Focus();
                        tbPassword.Text = "";
                    }
                }
                else
                {
                    //clear the session storage variable if there's any value existed.
                    SessionStorage.currentLoggedInUser = "";
                    MessageBox.Show("Inavlid Username\nPlease Try Again!");
                    tbUsername.Focus();
                    tbPassword.Text = "";
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearTextBox(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = Color.White;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = headingLabel;
        }

        private void Logging(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoggingIn();
            }
        }
    }
}
