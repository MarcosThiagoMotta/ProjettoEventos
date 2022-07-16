using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.API.Data;
using ProjetoEventos.API.Models;


namespace ProjetoEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        public DataContext Context { get; set; }
        public EventosController(DataContext context)
        {
            this.Context = context;
           
        }

        [HttpGet]
        public IEnumerable<Evento> GetEventos()
        {
            return Context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetEventoById(int envetoId)
        {
            return Context.Eventos.Where(x => x.EventoId == envetoId);
        }
    }
}