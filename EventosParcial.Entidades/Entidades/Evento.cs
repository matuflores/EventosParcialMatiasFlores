using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Entidades.Entidades
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string NombreEvento { get; set; } = null!;
        public int? CantidadPersonas { get; set; }
        public DateTime? Fecha { get; set; }
        public TipoEvento TipoEvento { get; set; } = null!;
        public Salon Salon { get; set; } = null!;
        public bool Suspendido { get; set; }
    }
}
