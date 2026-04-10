using System;

namespace CollegeApp
{
    public static class DatabaseHelper
    {
        public static string ConnectionString => 
            @"Server=localhost\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True";
    }
}