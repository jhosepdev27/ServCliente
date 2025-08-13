using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ObtenerTodosAsync();
        Task<Cliente> ObtenerPorIdAsync(int id);
        Task AgregarAsync(Cliente cliente);
        Task ActualizarAsync(Cliente cliente);
        Task EliminarAsync(int id);
    }
}
