using EventoParcial.Entidades.Entidades;
using EventoParcial.Servicios.DTOs.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Servicios.Mapeadores
{
    public static class EventosMapper
    {
        public static EventoListDto MapearListDto(Evento evento)
        {
            return new EventoListDto
            {
                EventoId=evento.EventoId,
                Fecha=evento.Fecha,
                NombreEvento=evento.NombreEvento,
                CantidadPersonas=evento.CantidadPersonas,
                Salon=evento.Salon.NombreSalon,
                Suspendido=evento.Suspendido,
            };
        }

        public static List<EventoListDto> MapearLista(List<Evento> eventos)
        {
            return eventos.Select(MapearListDto).ToList();
        }

    }
}
