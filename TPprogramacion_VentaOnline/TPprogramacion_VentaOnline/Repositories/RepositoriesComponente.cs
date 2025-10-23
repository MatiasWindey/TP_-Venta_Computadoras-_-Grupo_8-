using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TPprogramacion_VentaOnline.Modelo;


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
        public static void EliminarComponente(int Id)
        {
            using (var context = new Data.AplicationDbContex())
            {
                var componenteAEliminar = context.Componentes.FirstOrDefault(c => c.Id == Id);
                if (componenteAEliminar != null)
                {
                    context.Componentes.Remove(componenteAEliminar);
                    context.SaveChanges();
                }
            }
        }
        public static void ModificarComponente(int id)
        {
            using (var context = new Data.AplicationDbContex())
            {
                var componenteAModificar = context.Componentes.FirstOrDefault(c => c.Id == id);
                if (componenteAModificar != null)
                {
                    context.SaveChanges();
                }
            }
        }
    }
}
