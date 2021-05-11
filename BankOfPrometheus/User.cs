using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BankOfPrometheus
{
    public class User
    {

        private string _username;
        private string _password;
        private string _role;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }


        public string Role
        {
            get
            {
                return _role ;
            }
            set
            {
                _role = value;
            }
        }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        //UpdateUser takes in a username and a role if the arguments pass the conditions the user will be updated in the DB
        public static void UpdateUser(string username, string role)
        {
            if (username == SessionStorage.currentLoggedInUser)
            {
                throw new Exception("You cannot update your own account");
            }
            if (role =="Select Role")//If the role value is Select User throw an exception
            {
                throw new Exception("Please select a valid role");
            }
            else
            {
                DatabaseHelper.insertUpdateDeleteData($"UPDATE Users SET Roles = '{role}' WHERE UserName = '{username}'");

            }
        }

        //Takes in a username and sends a query to get all Users with contain the argument
        //Returns a list of users
        public static List<string> GetUsers(string username)
        {
            
            List<string> output = DatabaseHelper.selectData($"Select * from Users where UserName != '{SessionStorage.currentLoggedInUser}'");
            List<string> listOfUsernames = new List<string>();
            
            if (username.Length > 0)
            {
                foreach (string currentRow in output)
                {
                    string[] rowData = currentRow.Split('|');
                    if (rowData[0].Contains(username))
                    {
                        listOfUsernames.Add(rowData[0]);
                    }
                }
                return listOfUsernames;
            }
            else
            {
                foreach (string currentRow in output)
                {
                    string[] rowData = currentRow.Split('|');
                    listOfUsernames.Add(rowData[0]);
                }
                return listOfUsernames;
            }

        }


        //Takes in a username and sends a query and delete the user associated with taht username
        //If the username is associated with the current logged user throw an exception
        public static void DeleteUser(string username)
        {


            if (username == SessionStorage.currentLoggedInUser)
            {
                throw new Exception("You cannot delete your own account");
            }
            else
            {
                DatabaseHelper.insertUpdateDeleteData($"Delete From Users where UserName = '{username}'");
            }

        }

    }
}
