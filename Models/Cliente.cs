using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string DUI { get; set; }
        public byte[] Foto { get; set; }
    }
}
