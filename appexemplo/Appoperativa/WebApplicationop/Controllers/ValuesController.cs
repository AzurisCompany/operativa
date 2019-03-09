using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseLib.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return Produto.Listar();
        }

        // GET api/values/
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            return "value :" + id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
