using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class ClienteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Telefono { get; set; }
    }
}
