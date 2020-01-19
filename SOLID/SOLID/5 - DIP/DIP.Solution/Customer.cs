using System;

namespace SOLID.DIP.Solution
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public DateTime CreationDate { get; set; }

        public bool Validate()
        {
            return Email.Validate() && CPF.Validate();
        }
    }
}
