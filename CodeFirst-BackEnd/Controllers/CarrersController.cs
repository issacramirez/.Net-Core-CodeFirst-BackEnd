using CodeFirst_BackEnd.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrersController : ControllerBase
    {
        // GET: api/<CarrersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarrersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarrersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            FCFMDbContext dbContext = new FCFMDbContext();

            var newCarrer = new Carreer();
            newCarrer.Name = value;
            newCarrer.Duration = 9;
            newCarrer.Plan = "MOD ACAD 420";
            newCarrer.IsInternationalCertification = true;
            newCarrer.Type = 1;

            dbContext.Carreers.Add(newCarrer);
            dbContext.SaveChanges();

        }

        // PUT api/<CarrersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarrersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
