using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.Data.Context;
using Sample.Data.Model;

namespace Sample.Data.Repository
{
    public class PersonRepository:IPersonRepository
    {
        private readonly PersonContext personContext;

        private void InitializeData()
        {
            personContext.Persons.AddRange(new Person[]
            {
                new Person()
                {
                    id = Guid.NewGuid(),
                    Name = "Jeremy Layson",
                    Age = 29
                },
                new Person()
                {
                    id = Guid.NewGuid(),
                    Name = "Juan Dela Cruz",
                    Age = 24
                },
            });
        }

        public PersonRepository(PersonContext _personContext)
        {
            this.personContext = _personContext;
            this.InitializeData();
        }

        public async Task<Person[]> GetAllPerson()
        {
            var personList = await personContext.Persons.ToArrayAsync();

            return personList;
        }

        Task<Person> IPersonRepository.AddNewPerson(Person person)
        {
            throw new NotImplementedException();
        }

        Task IPersonRepository.DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        Task<Person> IPersonRepository.GetPersonById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IPersonRepository.UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
