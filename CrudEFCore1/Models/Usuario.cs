using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCore1.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Email { get; set; } 
    }
}
