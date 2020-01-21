using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] ICustomerServices customerServices)
        {
            customerServices.AddCustomer(new Customer());
        }
    }
}
