using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // Returns null if not registered
            _serviceProvider.GetRequiredService<ICustomerServices>().AddCustomer(new Customer());
        }
    }
}
