using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Puntuacion
    {
        public int Id { get; set; }
        public int Valoracion { get; set; }

        public Puntuacion(int valoracion)
        {
            this.Valoracion = valoracion;
        }
    }

}
