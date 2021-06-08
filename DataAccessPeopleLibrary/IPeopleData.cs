using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task<PersonModel> GetPerson(int id);
        Task InsertPerson(PersonModel person);
        Task UpdatePerson(PersonModel person);
        Task DeletePerson(PersonModel person);
    }
}