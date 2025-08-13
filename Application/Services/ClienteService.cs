using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<ClienteDto>> ObtenerTodosAsync()
        {
            var clientes = await _clienteRepository.ObtenerTodosAsync();

            return clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                CorreoElectronico = c.CorreoElectronico,
                Telefono = c.Telefono
            });
        }

        public async Task<ClienteDto> ObtenerPorIdAsync(int id)
        {
            var cliente = await _clienteRepository.ObtenerPorIdAsync(id);

            if (cliente == null) return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                CorreoElectronico = cliente.CorreoElectronico,
                Telefono = cliente.Telefono
            };
        }

        public async Task<ClienteDto> CrearClienteAsync(ClienteCrdDto clienteDto)
        {
            var cliente = new Cliente(clienteDto.Nombre, clienteDto.CorreoElectronico, clienteDto.Telefono);

            await _clienteRepository.AgregarAsync(cliente);

            return new ClienteDto
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                CorreoElectronico = cliente.CorreoElectronico,
                Telefono = cliente.Telefono
            };
        }

        public async Task<bool> ActualizarClienteAsync(int id, ClienteUpdDto clienteDto)
        {
            var clienteExistente = await _clienteRepository.ObtenerPorIdAsync(id);

            if (clienteExistente == null) return false;

            clienteExistente.Actualizar(clienteDto.Nombre, clienteDto.CorreoElectronico, clienteDto.Telefono);

            await _clienteRepository.ActualizarAsync(clienteExistente);

            return true;
        }

        public async Task<bool> EliminarClienteAsync(int id)
        {
            var clienteExistente = await _clienteRepository.ObtenerPorIdAsync(id);

            if (clienteExistente == null) return false;

            await _clienteRepository.EliminarAsync(id);

            return true;
        }
    }
}
