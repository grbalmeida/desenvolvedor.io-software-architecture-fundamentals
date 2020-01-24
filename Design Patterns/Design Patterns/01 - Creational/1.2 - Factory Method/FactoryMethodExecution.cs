using System;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExecution
    {
        public static void Execute()
        {
            var sqlConnection = DbFactory.Database(DataBase.SqlServer)
                                         .CreateConnector("mySQLServerConnectionString")
                                         .Connect();

            sqlConnection.ExecuteCommand("select * from sqlTable");
            sqlConnection.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleConnection = DbFactory.Database(DataBase.Oracle)
                                            .CreateConnector("myOracleConnectionString")
                                            .Connect();

            oracleConnection.ExecuteCommand("select * from oracleTable");
            oracleConnection.Close();
        }
    }
}
