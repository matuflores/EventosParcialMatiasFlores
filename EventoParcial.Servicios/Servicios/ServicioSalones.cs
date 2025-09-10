using EventoParcial.Datos.Interfaces;
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
    public class ServicioSalones : IServicioSalones
    {
        private readonly IRepositorioSalones _repositorioSalones;
        public ServicioSalones(IRepositorioSalones repositorioSalones)
        {
            _repositorioSalones = repositorioSalones;
        }
        public List<Salon> ObtenerLista()
        {
            var salones = _repositorioSalones.ObtenerLista();
            return salones.ToList();
        }


        //public List<EventoListDto> ObtenerLista()
        //{
        //    var eventos = _repositorioEventos.ObtenerLista();
        //    return EventosMapper.MapearLista(eventos);
        //}
    }
}
