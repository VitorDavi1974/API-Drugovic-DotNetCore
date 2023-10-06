using Drugovich.Entities;

namespace Drugovich.Repositories.Interfaces
{
    public interface IGerenteRepositorio
    {
        Task<List<Gerente>> BuscarTodosGerentes();
        Task<Gerente> BuscarPorId(int id);
    }
}
