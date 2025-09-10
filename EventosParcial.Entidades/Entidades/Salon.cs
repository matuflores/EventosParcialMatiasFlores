using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Entidades.Entidades
{
    public class Salon
    {
        public int SalonId { get; set; }
        public string NombreSalon { get; set; } = null!;
        public int Capacidad { get; set; }
        public string Direccion { get; set; } = null!;
        public Localidad Localidad { get; set; } = null!;

        public List<Evento> Eventos { get; set; } = new();
    }
}
