using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlquileresMVC.Models
{
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Ingrese la fecha de inicio")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Ingrese la fecha de fin")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "Ingrese el monto del alquiler")]
        [Range(0,99999)]
        [Display(Name ="Monto del alquiler")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        [Column(TypeName = "varchar(200)")]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El número de días es obligatorio")]
        [Range(1,9999)]
        public int Dias { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Comentarios { get; set; }
    }
}
