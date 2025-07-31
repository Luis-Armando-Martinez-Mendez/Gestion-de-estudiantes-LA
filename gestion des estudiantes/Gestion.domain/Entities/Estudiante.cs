using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.domain.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Sexo")]
        [RegularExpression("Masculino|Femenino", ErrorMessage = "El sexo debe ser Masculino o Femenino")]
        public string Sexo { get; set; } = string.Empty;

        [Required]
        [Range(1, 120, ErrorMessage = "Edad inválida")]
        public int Edad { get; set; }

        [Required]
        [StringLength(50)]
        public string Matricula { get; set; } = string.Empty;

        [StringLength(100)]
        public string NombrePadre { get; set; } = string.Empty;

        [StringLength(20)]
        [Phone]
        public string TelefonoPadre { get; set; } = string.Empty;

        [StringLength(100)]
        public string NombreMadre { get; set; } = string.Empty;

        [StringLength(20)]
        [Phone]
        public string TelefonoMadre { get; set; } = string.Empty;

        [StringLength(200)]
        public string Domicilio { get; set; } = string.Empty;

        [StringLength(50)]
        public string Curso { get; set; } = string.Empty;

        public string Necesidades { get; set; } = string.Empty;

        public string Intervenciones { get; set; } = string.Empty;

        public string Resultados { get; set; } = string.Empty;
    }
};
