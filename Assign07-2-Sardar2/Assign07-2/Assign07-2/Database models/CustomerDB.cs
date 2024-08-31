using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace Assign07_2.Models.DataLayer
{
    public static class CustomerDB
    {
        public static CustomerCredential GetCustomerCredential(string username, string password)
        {
            CustomerCredential customerCredential = null;
            string selectStatement =
                "SELECT CustomerID, Username, Passwords " +
                "FROM CustomerCredentials " +
                "WHERE Username = @username " +
                "AND Passwords = @password";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
               CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                customerCredential = new CustomerCredential
                {
                    CustomerID = (Int32)reader["CustomerID"],
                    UserName = (string)reader["Username"],
                    Password = (string)reader["Passwords"]
                };
            }
            return customerCredential;
        }
    }
}
