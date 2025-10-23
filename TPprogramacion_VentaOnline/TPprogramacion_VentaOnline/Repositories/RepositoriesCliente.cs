using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Data;

namespace TPprogramacion_VentaOnline.Repositories
{
    public class RepositoriesCliente
    {
        public static void AgregarCliente(Cliente cliente)
        {
            using (var context = new Data.AplicationDbContex())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
    }


}
