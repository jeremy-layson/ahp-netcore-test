using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Model;

namespace Sample.Data.Repository
{
    public interface IPersonRepository
    {
        Task<Person[]> GetAllPerson();
        Task UpdatePerson(Person person);
        Task DeletePerson(Person person);
        Task<Person> GetPersonById(Guid id);
        Task<Person> AddNewPerson(Person person);

    }
}
