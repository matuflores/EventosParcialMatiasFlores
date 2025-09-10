using EventoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Datos.Interfaces
{
    public interface IRepositorioEventos
    {
        List<Evento> ObtenerLista();//(int? generoId = null);
        //int ObtenerCantidad(int? generoId = null);

        //void Agregar(Libro libro);
        //bool ExisteLibro(Libro libro);
        //Libro? ObtenerPorId(int libroId);
    }
}
