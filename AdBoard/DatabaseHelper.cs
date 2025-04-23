using System;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString = @"Server=DESKTOP-AQF96SU\SQLEXPRESS;Database=AdBoard;Trusted_Connection=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
