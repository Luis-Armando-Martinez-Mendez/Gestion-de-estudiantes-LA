using Gestion.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Infrastructure.Context
{
    public class GestionContext : DbContext
    {
        public GestionContext(DbContextOptions<GestionContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        

    }

}