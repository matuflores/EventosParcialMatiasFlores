using EventoParcial.Datos.Interfaces;
using EventoParcial.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Datos.Repositorios
{
    public class RepositorioEventos : IRepositorioEventos
    {
        private readonly BibliotecaDbContext _dbContext;
        public RepositorioEventos(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Evento> ObtenerLista()
        {
            return _dbContext.Eventos
                .AsNoTracking()
                .ToList();
        }
    }
}
