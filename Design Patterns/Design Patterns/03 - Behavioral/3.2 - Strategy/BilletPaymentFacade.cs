using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class BilletPaymentFacade : IBilletPaymentFacade
    {
        public string GenerateBillet()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}