using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public List<Product> Products { get; set; }
    }
}