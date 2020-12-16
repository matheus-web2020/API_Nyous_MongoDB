using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nyous.API.NoSQL.Domains;
using Nyous.API.NoSQL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.API.NoSQL.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;
        public EventosController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        [HttpPost]
        public ActionResult<Evento>Post(Evento evento)
        {
            try
            {
                _eventoRepository.Adicionar(evento);
                return Ok(evento);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]

        public ActionResult<List<Evento>> Get(Evento
        {
            try
            {
                _eventoRepository.Adicionar(evento);
                return Ok(evento);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
