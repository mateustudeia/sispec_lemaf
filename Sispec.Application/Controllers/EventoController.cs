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
        private SispecService<Evento> service = new SispecService<Evento>();

        [HttpGet]
        public ActionResult<IList<Evento>> Get()
        {
            return Ok(_eventoService.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<EventoModel> Get(int id)
        {
            var _evento = _eventoService.EventoById(id);
            switch (_evento.IdTipo)
            {
                case (int)TipoEventoEnum.Palestra:
                    var palestra = new PalestraModel(_evento);
                    return Ok(palestra);
                case (int)TipoEventoEnum.Entreterimento:
                    var entreterimento = new EntreterimentoModel(_evento);
                    break;
                case (int)TipoEventoEnum.Curso:
                    var curso = new CursoModel(_evento);
                    return Ok(curso);
                default:


                    break;
            }

            return Ok(_eventoService.EventoById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Evento item)
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
            service.Delete(id);
            return new NoContentResult();
        }
    }
}
