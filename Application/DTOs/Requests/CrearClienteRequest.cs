using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Requests
{
    public class CrearClienteRequest
    {
        public CrearClienteRequest()
        {
            Nombre = string.Empty;
            CorreoElectronico = string.Empty;
            Telefono = string.Empty;
        }

        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}
