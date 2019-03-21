using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Value>> Get()
        {
            return new Value [] { new Value { Id = 1, Text = "Value 1" }, new Value { Id = 2, Text = "Value 2" } };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public ActionResult<Value> Get(int id)
        {
            return new Value { Id = id, Text="Value" };
        }

        // POST api/values
        [HttpPost]
        [Produces ("application/json", Type =typeof(Value))]
        public IActionResult Post([FromBody] Value value)
        {
            if ( !ModelState.IsValid )
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { id = value.Id }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
