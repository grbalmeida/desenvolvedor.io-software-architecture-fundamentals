using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailServices _emailServices;

        public CustomerServices(
            IEmailServices emailServices,
            ICustomerRepository customerRepository)
        {
            _emailServices = emailServices;
            _customerRepository = customerRepository;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Invalid data";

            _customerRepository.AddCustomer(customer);

            _emailServices.Send(
                "company@company.com",
                customer.Email.Address,
                "Welcome",
                "Congratulations you are registered"
            );

            return "Customer successfully registered";
        }
    }

    public class DIPTest
    {
        public DIPTest()
        {
            CustomerServices customerServices;
            customerServices = new CustomerServices(new EmailServices(), new CustomerRepository());
            customerServices = new CustomerServices(new EmailServices(), new CustomerRepository2());

            customerServices.AddCustomer(new Customer());
        }
    }
}
