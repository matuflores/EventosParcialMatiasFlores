using EventoParcial.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Datos
{
    public class BibliotecaDbContext:DbContext
    {
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected BibliotecaDbContext()
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Salon> Salones { get; set; }

        public DbSet<TipoEvento> TiposEventos { get; set; }
    }
}
