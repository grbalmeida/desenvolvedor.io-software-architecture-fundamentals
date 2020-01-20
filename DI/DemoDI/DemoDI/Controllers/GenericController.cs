using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Customer> _customerRepository;

        public GenericController(IGenericRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Index()
        {
            _customerRepository.Add(new Customer());
        }
    }
}
