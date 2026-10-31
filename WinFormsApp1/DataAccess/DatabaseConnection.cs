using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1.DataAccess
{
    internal class DatabaseConnection
    {
        private string connectionString =
            "Server=sheyazz\\SQLEXPRESS;Database=ShoeStore;Trusted_Connection=True;TrustServerCertificate=True";

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
