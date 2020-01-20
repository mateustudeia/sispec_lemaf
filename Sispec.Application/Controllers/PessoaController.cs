using Microsoft.AspNetCore.Mvc;
using Sispec.Domain.Entities;
using Sispec.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sispec.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : Controller
    {
        private SispecService<Pessoa> service = new SispecService<Pessoa>();

        [HttpGet]
        public ActionResult<IList<Pessoa>> Get()
        {
            return Ok(service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Pessoa> Get(int id)
        {
            return Ok(service.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa item)
        {
            service.Post(item);
            return Ok("Adicionado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Pessoa item)
        {

            return Ok("Editado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return new NoContentResult();
        }
    }
}
