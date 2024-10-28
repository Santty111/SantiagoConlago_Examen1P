using System.ComponentModel.DataAnnotations;

namespace SantiagoConlago_Examen1P.Models
{
    public class SantiagoConlago_model
    {
        public int videojuegoId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Enabled { get; set; }
    }
}
