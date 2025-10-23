using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contrasenia { get; set; }

        public Cliente(string nombre, string correo, string contrasenia)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Contrasenia = contrasenia;
            
        }
    }
} 

 
