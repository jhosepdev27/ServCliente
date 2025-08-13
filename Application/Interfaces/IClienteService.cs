using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> ObtenerTodosAsync();
        Task<ClienteDto> ObtenerPorIdAsync(int id);
        Task<ClienteDto> CrearClienteAsync(ClienteCrdDto clienteDto);
        Task<bool> ActualizarClienteAsync(int id, ClienteUpdDto clienteDto);
        Task<bool> EliminarClienteAsync(int id);
    }
}
