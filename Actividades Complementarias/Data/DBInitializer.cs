using Actividades_Complementarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividades_Complementarias.Data
{
    public class DbInitializer
    {
        public static void Initialize(Actividades_ComplementariasContext context)
        {
            context.Database.EnsureCreated();
            if (context.Alumnos.Any())
            {
                return;
            }
            {
                var Alumnos = new Alumnos[]
                {
                new Alumnos {},

                };


                foreach (Alumnos a in Alumnos)
                {
                    context.Alumnos.Add(a);
                }

                context.SaveChanges();

            }
        }
    }
}
