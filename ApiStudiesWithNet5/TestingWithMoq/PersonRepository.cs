using System.Linq;

namespace TestingWithMoq
{
    public class PersonService
    {
        private readonly IPersonRepository personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public int CountLetters()
        {
            var names = personRepository.GetNames();
            var count = names.Select(n => n.Length).Sum();
            return count;
        }
    }
}