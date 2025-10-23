using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Data;

namespace TPprogramacion_VentaOnline.Repositories
{
     public class RepositoriesPuntuacion
    {
      public static void AgregarPuntuacion(Puntuacion Valoracion)
        {
            using (var context = new AplicationDbContex())
            {
                context.Puntuaciones.Add(Valoracion);
                context.SaveChanges();
            }
        }

    }
}
