using SOLID.ISP.Solution.Interfaces;

namespace SOLID.ISP.Solution
{
    public class RegisterCustomer : IRegisterCustomer
    {
        public void ValidateData()
        {
            // Validate CPF, Email
        }

        public void SaveToDatabase()
        {
            // Insert into Customer table
        }

        public void SendEmail()
        {
            // Send email to the customer
        }
    }
}
