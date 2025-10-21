using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Componente
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public Componente(int  id, string tipo, string marca, string modelo,float precio,int Stock)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = Stock;

        }

    }
}
