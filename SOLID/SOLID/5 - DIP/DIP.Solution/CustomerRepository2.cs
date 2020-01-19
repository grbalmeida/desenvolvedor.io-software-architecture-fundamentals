using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class CustomerRepository2 : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            // Use another way to get to the database
        }
    }
}
