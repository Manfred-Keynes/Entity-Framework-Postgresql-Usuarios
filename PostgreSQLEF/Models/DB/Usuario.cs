using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostgreSQLEF.Models.DB
{
    public class Usuario
    {
        
        public long Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El Celular es obligatorio")]
        public string? Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string? Email { get; set; }
        public DateTimeOffset? Fecha { get; set; }
    }
}
