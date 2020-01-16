namespace OOP
{
    public interface IRepository
    {
        void Add();
    }

    public class Repository : IRepository
    {
        //public Repository(int a)
        //{

        //}

        public void Add()
        {
            // Add item
        }
    }

    public class FakeRepository : IRepository
    {
        public void Add()
        {
            // Add Item
        }
    }

    public class ImplementationUse
    {
        public void Process()
        {
            var repository = new Repository(); // high coupling
            repository.Add();
        }
    }

    public class AbstractionUse
    {
        private readonly IRepository _repository;

        public AbstractionUse(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }
    }

    public class InterfaceImplementationTest
    {
        public InterfaceImplementationTest()
        {
            var implementationRepository = new ImplementationUse();
            implementationRepository.Process();

            var abstractionRepository = new AbstractionUse(new Repository());
            abstractionRepository.Process();

            var abstractionFakeRepository = new AbstractionUse(new FakeRepository());
            abstractionFakeRepository.Process();
        }
    }
}