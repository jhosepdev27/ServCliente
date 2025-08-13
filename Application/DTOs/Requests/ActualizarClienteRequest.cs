using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Requests
{
    public class ActualizarClienteRequest
    {
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}
