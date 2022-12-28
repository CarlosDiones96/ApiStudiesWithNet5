using System.Threading.Tasks;

namespace IntegrationTesting.Models
{
    public interface IPeopleRepository
    {
        Task<PersonDto> GetOneAsync(int id);
    }
}