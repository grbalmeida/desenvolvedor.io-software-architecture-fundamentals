using System;

namespace OOP
{
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public string Record { get; set; }
    }

    public class Process
    {
        public void Execution()
        {
            var employee = new Employee
            {
                Name = "João da Silva",
                DateOfBirth = Convert.ToDateTime("1990/01/01"),
                AdmissionDate = DateTime.Now,
                Record = "0123456"
            };

            var employeeAge = employee.CalculateAge();
        }
    }
}
