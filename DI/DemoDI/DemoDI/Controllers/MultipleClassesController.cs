using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoDI.Controllers
{
    public class MultipleClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccessor;

        public MultipleClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        public string Index()
        {
            var a = _serviceAccessor("A").Return();
            var b = _serviceAccessor("B").Return();
            var c = _serviceAccessor("C").Return();
            return c;
        }
    }
}