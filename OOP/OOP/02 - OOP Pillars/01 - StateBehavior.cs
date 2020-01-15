using System;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int CalculateAge()
        {
            var currentDate = DateTime.Now;
            var age = currentDate.Year - DateOfBirth.Year;

            if (currentDate < DateOfBirth.AddYears(age)) age--;

            return age;
        }
    }
}
