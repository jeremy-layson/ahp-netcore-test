using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Model;

namespace Sample.Business
{
    public interface IPersonService
    {
        Task<Person[]> GetPerson();
        Task<Person> CreatePerson();
        Task<Person> UpdatePerson(Person person);
        Task DeletePerson(Person person);
    }
}
