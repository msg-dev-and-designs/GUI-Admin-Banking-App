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
    public partial class ChangePasswordForm : Form
    {
        private bool adminHomeIsOpened;
        public ChangePasswordForm(bool _adminHomeIsOpened = true)
        {
            InitializeComponent();
            adminHomeIsOpened = _adminHomeIsOpened;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmNewPassword = txtConfirmNewPassword.Text;

                //This query get the password of the current user that is logged into the system.
                List<string> output = DatabaseHelper.selectData($"Select Password from Users where username = '{SessionStorage.currentLoggedInUser}'");
               
                //If the query returns only one result we then check to make that the password returned matches the old password we move one.
                //If the new password and the old password don't match we can move on to the next step.
                //If the new password and the confirm password we move on to the updating of the password
                if (output.Count == 1)
                {
                    if (output[0]== oldPassword)
                    {
                        if (newPassword != oldPassword)
                        {
                            if (newPassword == confirmNewPassword)
                            {
                                //We will show a message making sure the user wants to change their password
                                //If they click yes we then send an update query to the DB to update the users password
                                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    if (DatabaseHelper.insertUpdateDeleteData($"Update Users SET password = '{newPassword}' where UserName = '{SessionStorage.currentLoggedInUser}'") > 0)
                                    {
                                        MessageBox.Show("Password Changed Successfully!");
                                        if (adminHomeIsOpened)
                                        {
                                            this.Close();
                                        }
                                        else
                                        {
                                            this.Hide();
                                            new Home().ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    //If there was an error trying to update we will throw an exception
                                    else
                                    {
                                        throw new Exception("Error Occured while Changing Password");
                                    }
                                }
                            
                            }
                            //If the passwords don't match we will reset the form and show message box telling the user that the passwords don't match.
                            else
                            {
                                txtConfirmNewPassword.Text = "";

                                txtConfirmNewPassword.Focus();

                                MessageBox.Show("Password doesn't match confirm passowrd");
                            }

                        }
                        //if the new password matches the old password inform the user with a message box and reset the form. 
                        else
                        {
                            txtNewPassword.Text = "";
                            txtConfirmNewPassword.Text = "";

                            txtNewPassword.Focus();
                            MessageBox.Show("New password cannot be same as old password");
                        }
                    }
                    //if the old password is inncorrect inform the user with a message box and reset the form. 
                    else
                    {
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmNewPassword.Text = "";

                        txtOldPassword.Focus();

                        throw new Exception("Invalid Old Password");

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtOldPassword;
        }
    }
}
