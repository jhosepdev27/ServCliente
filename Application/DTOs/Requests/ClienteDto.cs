using Domain.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class ClienteUpdDto
    {
        [Required(ErrorMessage = GlobalConstantMessages.MSG_REQUIRED)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = GlobalConstantMessages.MSG_REQUIRED)]
        [EmailAddress(ErrorMessage = GlobalConstantMessages.MSG_VALIDATION_EMAIL)]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = GlobalConstantMessages.MSG_REQUIRED)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = GlobalConstantMessages.MSG_VALIDATION_PHONE)]
        public string Telefono { get; set; }
    }
}
