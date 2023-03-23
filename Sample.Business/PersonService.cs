using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Model;
using Sample.Data.Repository;

namespace Sample.Business
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository repository;

        public PersonService(IPersonRepository _repository) 
        {
            this.repository = _repository;
        }
        public async Task<Person> CreatePerson()
        {
            throw new NotImplementedException();
        }

        public Task DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person[]> GetPerson()
        {
            return this.repository.GetAllPerson();
        }

        public Task<Person> UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
