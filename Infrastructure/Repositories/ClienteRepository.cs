using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CajaValladolidContext _context;

        public ClienteRepository(CajaValladolidContext context)
        {
            _context = context;
        }

        public async Task AgregarAsync(Cliente cliente)
        {
            _context.Cliente.Add(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);

            if (cliente != null)
            {
                cliente.Estado = false;
                _context.Cliente.Update(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> ObtenerTodosAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> ObtenerPorIdAsync(int id)
        {
            return await _context.Cliente.FindAsync(id);
        }

        public async Task ActualizarAsync(Cliente cliente)
        {
            _context.Cliente.Update(cliente);

            await _context.SaveChangesAsync();
        }
    }
}
