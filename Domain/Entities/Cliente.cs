using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

        public Cliente(string nombre, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Estado = true;
        }

        public void Actualizar(string nombre, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Estado = true;
        }
    }
}
