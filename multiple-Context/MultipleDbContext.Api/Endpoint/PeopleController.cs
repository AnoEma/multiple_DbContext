using Microsoft.AspNetCore.Mvc;
using MultipleDbContext.Api.Model;
using MultipleDbContext.Api.Repository;

namespace MultipleDbContext.Api.Endpoint
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;  
        }

        [HttpGet]
        [Route("{contextName}")]
        public List<People> Get([FromRoute] string contextName)
        {
            var people = _repository.GetAll(contextName);

            return people;
        }

        [HttpPost]
        [Route("{contextName}")]
        public IActionResult Post([FromRoute] string contextName, [FromBody] People people)
        {
            try
            {
                _repository.Post(people, contextName);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{contextName}")]
        public IActionResult Put([FromRoute] string contextName, [FromBody] People people)
        {
            try
            {
                _repository.Put(people, contextName);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}