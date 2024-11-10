using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
        public byte[] Afiche { get; set; }
    }
}

