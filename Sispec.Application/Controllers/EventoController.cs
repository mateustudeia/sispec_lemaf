using Microsoft.AspNetCore.Mvc;
using Sispec.Domain.Entities;
using Sispec.Domain.Entities.Enums;
using Sispec.Domain.Models;
using Sispec.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sispec.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private EventoService _eventoService = new EventoService();
        private SispecService<Evento> _service = new SispecService<Evento>();

        [HttpGet]
        public ActionResult<IList<EventoModel>> Get()
        {
            var eventos = _eventoService.Get().Select(x => new EventoModel(x)).ToList();
            return Ok(eventos);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var _evento = new EventoModel(_eventoService.EventoById(id));

            return Ok(_evento);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EventoModel item)
        {

            _eventoService.Inserir(item);

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
            _service.Delete(id);
            return new NoContentResult();
        }
    }
}
