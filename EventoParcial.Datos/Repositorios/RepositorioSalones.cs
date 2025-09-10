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
    public class RepositorioSalones : IRepositorioSalones
    {
        private readonly BibliotecaDbContext _dbContext;
        public RepositorioSalones(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Salon> ObtenerLista()
        {
            return _dbContext.Salones
                .AsNoTracking()
                .ToList();
        }
    }
}
