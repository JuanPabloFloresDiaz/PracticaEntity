using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio3.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(60)]
        public string Anio { get; set; }

        [Required]
        [StringLength(60)]
        public string Marca { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(20)]
        public string VIN { get; set; }
    }
}
