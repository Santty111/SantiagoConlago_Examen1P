using System.ComponentModel.DataAnnotations;

namespace SantiagoConlago_Examen1P.Models
{
    public class SantiagoConlago_model
    {
        public int SantiagoConlago_modelId { get; set; }
        [Required]
        public string? SCVideojuego { get; set; }
        public string? SCDescription { get; set; }
        public bool SCGarantia{ get; set; }
        public decimal SCPrecio { get; set; }
    }
}
