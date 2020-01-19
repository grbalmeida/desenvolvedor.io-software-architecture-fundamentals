using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violation
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime CreationDate { get; set; }

        public string AddCustomer()
        {
            if (!Email.Contains("@"))
            {
                return "Customer with invalid email";
            }

            if (CPF.Length != 11)
            {
                return "Customer with invalid CPF";
            }

            using (var sqlConnection = new SqlConnection())
            {
                var sqlCommand = new SqlCommand();

                sqlConnection.ConnectionString = "MyConnectionString";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL, CPF, CREATIONDATE) VALUES (@name, @email, @cpf, @creationDate)";

                sqlCommand.Parameters.AddWithValue("name", Name);
                sqlCommand.Parameters.AddWithValue("email", Email);
                sqlCommand.Parameters.AddWithValue("cpf", CPF);
                sqlCommand.Parameters.AddWithValue("creationDate", CreationDate);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }

            var mail = new MailMessage("company@company.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome.";
            mail.Body = "Congratulations! You are registered.";
            client.Send(mail);

            return "Customer successfully registered!";
        }
    }
}
