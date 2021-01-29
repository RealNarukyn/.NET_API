using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShipQuikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        // GET: api/<TestingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Are we geetting this the right way?", "Hell yeah we are!" };
        }

        // GET api/<TestingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
