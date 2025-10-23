using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPprogramacion_VentaOnline.Modelo;

namespace TPprogramacion_VentaOnline.Data
{
    public class AplicationDbContex : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<Configuracion_PC> Configuracion_PC { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Puntuacion> Puntuaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TPprogamacionfinal;Trusted_Connection=true;TrustServerCertificate=True;");
        }


    }
}
