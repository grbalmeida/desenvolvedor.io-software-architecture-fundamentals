using System;

namespace SOLID.ISP.Violation
{
    public class RegisterProduct : IRegister
    {
        public void ValidateData()
        {
            // Validate value
        }

        public void SaveToDatabase()
        {
            // Insert into the Product table
        }

        public void SendEmail()
        {
            // Product has no email, what do I do now ???
            throw new NotImplementedException("This method is useless");
        }
    }
}
