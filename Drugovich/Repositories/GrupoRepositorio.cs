using Drugovich.DataContext;
using Drugovich.Entities;
using Drugovich.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.Repositories
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        private readonly ApplicationDbContext _dbContext;
         
        public GrupoRepositorio(ApplicationDbContext applicationDbContext) 
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Grupo> BuscarPorId(int id)
        {
            return await _dbContext.Grupos.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<Grupo>> BuscarTodosGrupos()
        {
            return await _dbContext.Grupos.ToListAsync();
        }

        public async Task<Grupo> Adicionar(Grupo grupo, int nivel)
        {
            if(nivel == 1)
            {
                throw new Exception("Gerente não tem permissão de manutenção em Grupos");
            }
            await _dbContext.Grupos.AddAsync(grupo);
            await _dbContext.SaveChangesAsync();

            return grupo;
        }

        public async Task<bool> Apagar(int id, int nivel)
        {
            if (nivel == 1)
            {
                throw new Exception("Gerente não tem permissão de manutenção em Grupos");
            }
            Grupo grupoPorId = await BuscarPorId(id);
            if (grupoPorId == null)
            {
                throw new Exception($"Grupo: {id} não encontrado");
            }
            _dbContext.Grupos.Remove(grupoPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Grupo> Atualizar(Grupo grupo, int id, int nivel)
        {
            if (nivel == 1)
            {
                throw new Exception("Gerente não tem permissão de manutenção em Grupos");
            }
            Grupo grupoPorId = await BuscarPorId(id);
            if (grupoPorId == null)
            {
                throw new Exception($"Grupo: {id} não encontrado");
            }
            grupoPorId.nome = grupo.nome;

            _dbContext.Grupos.Update(grupoPorId);
            await _dbContext.SaveChangesAsync();
            return grupoPorId;
        }
    }
}
