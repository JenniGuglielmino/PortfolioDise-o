using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PortfolioDiseño.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        [StringLength(50, MinimumLength = 5, ErrorMessage ="El nombre ingresado debe tener de 5 a 50 caracteres")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public Boolean Active { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Image { get; set; }
    }
}
