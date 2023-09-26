using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using Microsoft.EntityFrameworkCore;

namespace infraestructure.Data
{
    public class TiendaCampusContext : DbContext 
    {
        public TiendaCampusContext(DbContextOptions<TiendaCampusContext> options) : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
    } 
}