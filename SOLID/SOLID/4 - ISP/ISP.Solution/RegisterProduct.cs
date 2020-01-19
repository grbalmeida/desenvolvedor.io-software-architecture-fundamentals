using SOLID.ISP.Solution.Interfaces;

namespace SOLID.ISP.Solution
{
    public class RegisterProduct : IProductRegister
    {
        public void ValidateData()
        {
            // Validate value
        }

        public void SaveToDatabase()
        {
            // Insert into the Product table
        }
    }
}
