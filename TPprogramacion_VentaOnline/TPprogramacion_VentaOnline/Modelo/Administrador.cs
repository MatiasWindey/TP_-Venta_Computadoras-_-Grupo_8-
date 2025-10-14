namespace TPprogramacion_VentaOnline.Modelo
{
    public class Administrador
    {
     public int Id { get; set; }

     public string Nombre { get; set; }
         
     public string Permisos { get; set; }

        public Administrador(int Id, string nombre, string permisos)
        {
            this.Id = Id;
            this.Nombre = nombre;
            this.Permisos = permisos;
        }

    }
}


