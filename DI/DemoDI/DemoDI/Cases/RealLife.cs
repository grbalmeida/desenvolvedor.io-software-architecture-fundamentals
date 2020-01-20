using System;

namespace DemoDI.Cases
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            // Do something
        }
    }

    public interface ICustomerServices
    {
        void AddCustomer(Customer customer);
    }

    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);   
        }
    }
}