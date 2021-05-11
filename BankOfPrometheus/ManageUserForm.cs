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
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        //Upon key up the cmb box is populated with users the correlate with inputted text.
        //If the text is cleared all of the users will be populated into the cmb box.
        private void searchUser(object sender, KeyEventArgs e)
        {
            try
            {
                string username = cmbUserName.Text;
                cmbRole.SelectedIndex = 0;

                cmbUserName.Items.Clear();

                cmbUserName.Select(cmbUserName.Text.Length, 0);

                //Get the usernames in a list form from the GetUser method and converts it to an array.
                //The cmb box will then be populated with data in the Array.
                cmbUserName.Items.AddRange(User.GetUsers(username).ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //When the delete buttin is clicked the username selected will be sent to DeleteUser and the user will be deleted.
        //If no user is selected show a message box.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string username = cmbUserName.Text;

                if (username.Length > 0)
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        User.DeleteUser(username);
                        MessageBox.Show("User has been deleted!", "Success", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Username Required");
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        //When the the AdminManageUser loads the cmb box will be populated all users in the DB.
        private void AdminManageUser_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRole.SelectedIndex = 0;

                cmbUserName.Items.Clear();

                cmbUserName.Select(cmbUserName.Text.Length, 0);

                cmbUserName.Items.AddRange(User.GetUsers("").ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //When update button is clicked the username selected and the role UpdateUser will be called.
        //The user associated with the username give will be updated with the new role. 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = cmbUserName.Text;
                string role = cmbRole.Text;
                if (username.Length > 0)
                {
                   

                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        User.UpdateUser(username, role);
                        MessageBox.Show("User has been updated!", "Success", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string username = cmbUserName.Text;

                List<string> output = DatabaseHelper.selectData($"Select * from Users where UserName ='{username}'");

                cmbRole.Text = output[0].Split('|')[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
