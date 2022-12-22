using System.Collections.Generic;

namespace GraphQlExample.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetOne(int id);
    }
}