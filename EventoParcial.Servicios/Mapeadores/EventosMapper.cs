using EventoParcial.Entidades.Entidades;
using EventoParcial.Servicios.DTOs.Evento;
using EventoParcial.Servicios.DTOs.Salon;
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

        public static SalonListDto MapearListDto(Salon salon)
        {
            return new SalonListDto
            {
                SalonId = salon.SalonId,
                NombreSalon = salon.NombreSalon,
            };
        }

        public static List<EventoListDto> MapearLista(List<Evento> eventos)
        {
            return eventos.Select(MapearListDto).ToList();
        }

        public static List<SalonListDto> MapearLista(List<Salon> salones)
        {
            return salones.Select(MapearListDto).ToList();
        }

    }
}
