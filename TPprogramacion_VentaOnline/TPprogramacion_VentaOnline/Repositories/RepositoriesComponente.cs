using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.

namespace TPprogramacion_VentaOnline.Repositories
{
    public static class RepositoriesComponente
    {
        public static void AgregarComponente(Componente componente)
        {



            using (var context = new Data.AplicationDbContex())
            {
                
                context.Componentes.Add(componente);
                context.SaveChanges();




            }
        }

    }
}
