namespace SOLID.ISP.Violation
{
    public class RegisterCustomer : IRegister
    {
        public void ValidateData()
        {
            // Validate CPF, Email
        }

        public void SaveToDatabase()
        {
            // Insert in the Customer table
        }

        public void SendEmail()
        {
            // Send email to the customer
        }
    }
}
