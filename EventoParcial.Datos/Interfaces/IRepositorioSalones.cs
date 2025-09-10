using EventoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Datos.Interfaces
{
    public interface IRepositorioSalones
    {
        List<Salon> ObtenerLista();
    }
}
