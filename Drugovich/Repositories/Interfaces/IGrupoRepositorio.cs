using Drugovich.Entities;

namespace Drugovich.Repositories.Interfaces
{
    public interface IGrupoRepositorio
    {
        Task<List<Grupo>> BuscarTodosGrupos();
        Task<Grupo> BuscarPorId(int id);
        Task<Grupo> Adicionar(Grupo grupo, int nivel);
        Task<Grupo> Atualizar(Grupo grupo, int id, int nivel);
        Task<bool> Apagar(int id, int nivel);
    }
}
