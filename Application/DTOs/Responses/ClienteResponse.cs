using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Responses
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}
