using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_2.Models.DataLayer
{
    public static class AdminDB
    {
        public static AdminCredential GetAdminCredential(string username, string password)
        {
            AdminCredential adminCredential = null;
            string selectStatement =
                "SELECT AdminID, Username, Passwords " +
                "FROM AdminCredentials " +
                "WHERE Username = @username";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
               CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                adminCredential = new AdminCredential
                {
                    AdminID = (Int32)reader["AdminID"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Passwords"]
                };
            }
            return adminCredential;
        }
    }
}
