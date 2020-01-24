using System;

namespace DesignPatterns.FactoryMethod
{
    // Concrete Product
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connecting to the Oracle database...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}