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
    public class EventoControler : Controller
    {
        private SispecService<Evento> service = new SispecService<Evento>();

        [HttpGet]
        public ActionResult<IList<Evento>> Get()
        {
            return Ok(service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return Ok(service.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Evento item)
        {
            service.Post(item);
            return Ok("Adicionado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Evento item)
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
