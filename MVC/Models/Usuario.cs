using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 a 50 caracteres")]
        public string Pass {  get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}