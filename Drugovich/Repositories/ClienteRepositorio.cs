using Drugovich.DataContext;
using Drugovich.Entities;
using Drugovich.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.Repositories
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly ApplicationDbContext _dbContext;
         
        public ClienteRepositorio(ApplicationDbContext applicationDbContext) 
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Cliente> BuscarPorId(int id)
        {
            return await _dbContext.Clientes.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task<List<Cliente>> BuscarPorIdGrupo(int id)
        {
            return await _dbContext.Clientes.Include(x => x.Grupo).Where(x => x.Grupoid == id).ToListAsync();
        }

        public async Task<List<Cliente>> BuscarTodosClientes()
        {
            return await _dbContext.Clientes.Include(x => x.Grupo).ToListAsync();
        }

        public async Task<Cliente> Adicionar(Cliente cliente, int nivel)
        {
            if (nivel == 2)
            {
                throw new Exception("Gerente não tem permissão de manutenção em Grupos");
            }
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();

            return cliente;
        }

        public async Task<bool> Apagar(int id, int nivel)
        {
            if (nivel == 2)
            {
                throw new Exception("Gerente não tem permissão de manutenção em Grupos");
            }
            Cliente clientePorId = await BuscarPorId(id);
            if (clientePorId == null)
            {
                throw new Exception($"Cliente: {id} não encontrado");
            }
            _dbContext.Clientes.Remove(clientePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> Atualizar(Cliente cliente, int id)
        {
            Cliente clientePorId = await BuscarPorId(id);
            if (clientePorId == null)
            {
                throw new Exception($"Cliente: {id} não encontrado");
            }
            clientePorId.nome = cliente.nome;

            _dbContext.Clientes.Update(clientePorId);
            await _dbContext.SaveChangesAsync();
            return clientePorId;
        }
    }
}
