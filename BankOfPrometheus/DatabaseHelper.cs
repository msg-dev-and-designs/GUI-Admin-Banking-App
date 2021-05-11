using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BankOfPrometheus
{
    static class DatabaseHelper
    {
        
        static string dbConnectionString;
        static SqlConnection myConnection;

        static void loadDatabase()
        {
            //Setting up and configuring our database
            dbConnectionString = ConfigurationManager.ConnectionStrings["BankOfPrometheus.Properties.Settings.BankOfPrometheusConnectionString"].ConnectionString;
            myConnection = new SqlConnection(dbConnectionString);
        }

        public static List<string> selectData(string query)
        {
            loadDatabase();

            //Open new connection
            myConnection.Open();

            //Setup and execute SQL Query and store it in result variable of type SqlDataReader
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader result = command.ExecuteReader();

            List<string> output = new List<string>();

            //This loop will iterate through each row of result and will help us to store data in our output variable of type List<string>
            for (int row = 0; result.Read(); row++)
            {
                string currentRow = "";
                //this loop will iterate through each column value
                for (int column = 0; column < result.FieldCount; column++)//result.FieldCount is total number of columns in a database
                {
                    //Here we are checking if it's the last column then dont add '|' symbol to our string
                    if (column != result.FieldCount - 1)
                        currentRow += result.GetValue(column) + "|";
                    else
                        currentRow += result.GetValue(column);

                }
                //this is how the current row will look like 
                //1000|Dheeraj|Arora|4911 Dalham Crescent,NW,Calgary,AB - T3A1L8|4039181891|0|Chequing|2020-12-09 12:00:00|Active
                output.Add(currentRow);
            }

            //close the connection
            myConnection.Close();

            return output;
        }

        public static int insertUpdateDeleteData(string query)
        {
            loadDatabase();

            //open new connection
            myConnection.Open();

            //Setup and execute SQL Query and store number of rows affected in rowsAffected variable of type int
            SqlCommand command = new SqlCommand(query, myConnection);
            int rowsAffected = command.ExecuteNonQuery();

            //Dispose off the command
            command.Dispose();

            //Close the connection
            myConnection.Close();

            return rowsAffected;
        }

        //public static int insertData(string query)
        //{
        //    loadDatabase();

        //    myConnection.Open();

        //    SqlCommand command = new SqlCommand(query, myConnection);

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.InsertCommand = command;
        //    int rowsAffected = adapter.InsertCommand.ExecuteNonQuery();

        //    command.Dispose();
        //    myConnection.Close();

        //    return rowsAffected;
        //}

        //public static int updateDate(string query)
        //{
        //    loadDatabase();

        //    myConnection.Open();

        //    SqlCommand command = new SqlCommand(query, myConnection);

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.UpdateCommand = command;
        //    int rowsAffected = adapter.UpdateCommand.ExecuteNonQuery();

        //    command.Dispose();
        //    myConnection.Close();

        //    return rowsAffected;
        //}

        //public static int deleteData(string query)
        //{
        //    loadDatabase();

        //    SqlCommand command = new SqlCommand(query, myConnection);

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.DeleteCommand = command;
        //    int rowsAffected = adapter.DeleteCommand.ExecuteNonQuery();

        //    command.Dispose();
        //    myConnection.Close();

        //    return rowsAffected;
        //}

    }
}
