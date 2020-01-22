using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // Returns null if not registered
            serviceProvider.GetRequiredService<ICustomerServices>().AddCustomer(new Customer());
        }
    }
}
