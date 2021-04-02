using System;
using System.IO;


namespace Goalkeeper
{
    class DBConnection
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goalkeeper.mdb;");
        public readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="+dbPath;
    }
}
