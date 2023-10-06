using Drugovich.Entities;

namespace Drugovich.Repositories.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<Cliente>> BuscarTodosClientes();
        Task<Cliente> BuscarPorId(int id);
        Task<List<Cliente>> BuscarPorIdGrupo(int id);
        Task<Cliente> Adicionar(Cliente cliente, int nivel);
        Task<Cliente> Atualizar(Cliente cliente, int id);
        Task<bool> Apagar(int id, int nivel);
    }
}
