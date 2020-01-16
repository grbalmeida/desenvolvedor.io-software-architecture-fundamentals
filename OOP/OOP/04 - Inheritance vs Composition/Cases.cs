using System;

namespace OOP
{
    #region Case 1

    public class NaturalPerson : Person
    {
        public string Cpf { get; set; }
    }

    public class NaturalPerson2
    {
        public Person Person { get; set; }
        public string Cpf { get; set; }
    }

    public class InheritanceCompositionTests
    {
        public InheritanceCompositionTests()
        {
            var personInheritance = new NaturalPerson
            {
                Name = "João",
                DateOfBirth = DateTime.Now,
                Cpf = "32165498765"
            };

            var personComposition = new NaturalPerson2
            {
                Person = new Person
                {
                    Name = "João",
                    DateOfBirth = DateTime.Now
                },
                Cpf = "32165498765"
            };

            var nameInheritance = personInheritance.Name;
            var nameComposition = personComposition.Person.Name;
        }
    }

    #endregion

    #region Case 2

    // generic repository
    public interface IRepository<T>
    {
        void Add(T obj);
        void Delete(T obj);
    }

    // specialized repository
    public interface IPersonRepository
    {
        void Add(Person obj);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T obj)
        {

        }

        public void Delete(T obj)
        {

        }
    }

    public class PersonInheritanceRepository : Repository<Person>, IPersonRepository
    {

    }

    public class PersonCompositionRepository : IPersonRepository
    {
        private readonly IRepository<Person> _personRepository;

        public PersonCompositionRepository(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(Person obj)
        {
            _personRepository.Add(obj);
        }
    }

    public class InheritanceCompositionTests2
    {
        public InheritanceCompositionTests2()
        {
            var inheritanceRepository = new PersonInheritanceRepository();
            inheritanceRepository.Add(new Person());
            inheritanceRepository.Delete(new Person());

            var compositionRepository = new PersonCompositionRepository(new Repository<Person>());
            compositionRepository.Add(new Person());
        }
    }

    #endregion
}
