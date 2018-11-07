using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Actividades_Complementarias.Models
{
    public class Actividades_ComplementariasContext : DbContext
    {
        public Actividades_ComplementariasContext(DbContextOptions<Actividades_ComplementariasContext> options)
            : base(options)
        {
        }

        public DbSet<Actividades_Complementarias.Models.Alumnos> Alumnos { get; set; }
        public DbSet<Actividades_Complementarias.Models.Instructores> Instructores { get; set; }
    }
}
