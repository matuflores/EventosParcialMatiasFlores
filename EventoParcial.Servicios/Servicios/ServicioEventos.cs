using EventoParcial.Datos.Interfaces;
using EventoParcial.Datos.Repositorios;
using EventoParcial.Entidades.Entidades;
using EventoParcial.Servicios.DTOs.Evento;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Servicios.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Servicios.Servicios
{
    public class ServicioEventos : IServicioEventos
    {
        private readonly IRepositorioEventos _repositorioEventos;
        public ServicioEventos(IRepositorioEventos repositorioEventos)
        {
            _repositorioEventos = repositorioEventos;
        }

        public int ObtenerCantidad()
        {
            return _repositorioEventos.ObtenerCantidad();
        }

        public List<EventoListDto> ObtenerLista()
        {
            var eventos=_repositorioEventos.ObtenerLista();
            return EventosMapper.MapearLista(eventos);
        }
    }
}
