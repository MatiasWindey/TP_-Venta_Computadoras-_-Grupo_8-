using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPprogramacion_VentaOnline.Modelo
{
    public class Configuracion_PC
    {
      public int Id { get; set; }
        public string Procesador { get; set; }
        public string PlacaBase { get; set; }
        public string MemoriaRAM { get; set; }
        public string Almacenamiento { get; set; }
        public string TarjetaGrafica { get; set; }
        public string FuentePoder { get; set; }
        public string Gabinete { get; set; }

        public Configuracion_PC (int id, string procesador, string placaBase, string memoriaRAM, string almacenamiento, string tarjetaGrafica, string fuentePoder, string gabinete)
        {
            this.Id = id;
            this.Procesador = procesador;
            this.PlacaBase = placaBase;
            this.MemoriaRAM = memoriaRAM;
            this.Almacenamiento = almacenamiento;
            this.TarjetaGrafica = tarjetaGrafica;
            this.FuentePoder = fuentePoder;
            this.Gabinete = gabinete;
        }

    }
}
