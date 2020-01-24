using System;

namespace DesignPatterns.FactoryMethod
{
    // Concrete Product
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connecting to the SQL Server database...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}