using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        public string Pelicula { get; set; }
        public string Cliente { get; set; }
        public string DUI { get; set; }
        public string FechaSalida { get; set; }
        public string FechaRetorno { get; set; }
          }
}

