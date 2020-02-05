using Microsoft.AspNetCore.Mvc;
using Sispec.Domain.Entities;
using Sispec.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sispec.Application.Controllers
{
    public class EventoControler : Controller
    {
        private EventoService _eventoService;
        private SispecService<Evento> service = new SispecService<Evento>();

        [HttpGet]
        public ActionResult<IList<Evento>> Get()
        {
            return Ok(_eventoService.Get());
        }

        public IActionResult Listar(int id)
        {
            return View(_eventoService.EventoById(id));
        }


        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return Ok(_eventoService.EventoById(id));
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
