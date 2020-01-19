namespace SOLID.DIP.Violation
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Invalid data";

            var customerRepository = new CustomerRepository();
            customerRepository.AddCustomer(customer);

            EmailServices.Send(
                "company@company.com",
                customer.Email.Address,
                "Welcome",
                "Congratulations you are registered"
            );

            return "Customer successfully registered";
        }
    }
}
