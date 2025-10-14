using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        
        public Producto(int id, int stock, string nombre, string categoria, decimal precio)
        {
            this.Id = id;
            this.Stock = stock;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = precio;
        }
    }
}
