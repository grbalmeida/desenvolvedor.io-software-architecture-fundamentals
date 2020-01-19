using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.Solution
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var sqlConnection = new SqlConnection())
            {
                var sqlCommand = new SqlCommand();

                sqlConnection.ConnectionString = "MyConnectionString";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL, CPF, CREATIONDATE) VALUES (@name, @email, @cpf, @creationDate)";

                sqlCommand.Parameters.AddWithValue("name", customer.Name);
                sqlCommand.Parameters.AddWithValue("email", customer.Email);
                sqlCommand.Parameters.AddWithValue("cpf", customer.CPF);
                sqlCommand.Parameters.AddWithValue("creationDate", customer.CreationDate);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
