using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Cliente
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contrasenia { get; set; }

        
        public Cliente(int id, string nombre, string correo, string contrasenia)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Contrasenia = contrasenia;
        }
    }
} 

 
