using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Business;
using Sample.Data.Model;

namespace SampleBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;

        public PersonController(IPersonService _personService)
        {
            this.personService = _personService;
        }

        [HttpGet]
        public async Task<Person[]> GetAllPerson()
        {
            var personList = await personService.GetPerson();

            return personList;
        }
    }
}
