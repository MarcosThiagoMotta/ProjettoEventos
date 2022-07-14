using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.API.Models;


namespace ProjetoEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        public EventosController()
        {
           
        }

        [HttpGet]
        public List<Evento> GetEventos()
        {
            List<Evento> eventos = new List<Evento>();

            eventos.Add(
                new Evento{
                    EventoId = 1,
                    Tema = "Um estudo do Marcos Thiago",
                    Local = "São PAulo",
                    DataEvento = "HOJE",
                    Lote = "UM LOTE",
                    ImageUrl = "UMA IMAGEM"   
                });

            eventos.Add(new Evento{
                EventoId = 2,
                Tema = "Um estudo",
                Local = "Afeganistão",
                DataEvento = "Amanhã",
                Lote = "Outro LOte",
                ImageUrl = "UMA OUTRA IMAGEM"   
            });
            
            return eventos;
        }

        // [HttpGet("{id}")]
        // public Evento GetEventoById(int envetoId)
        // {
        //     return null;
        // }
    }
}