using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPprogramacion_VentaOnline.Modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Fecha { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
      
        public Pedido(int id, int fecha, string estado, decimal total)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Estado = estado;
            this.Total = total;
        }
    }
}
