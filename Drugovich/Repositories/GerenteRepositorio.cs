using Drugovich.DataContext;
using Drugovich.Entities;
using Drugovich.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.Repositories
{
    public class GerenteRepositorio : IGerenteRepositorio
    {
        private readonly ApplicationDbContext _dbContext;
         
        public GerenteRepositorio(ApplicationDbContext applicationDbContext) 
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Gerente> BuscarPorId(int id)
        {
            return await _dbContext.Gerentes.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<Gerente>> BuscarTodosGerentes()
        {
            return await _dbContext.Gerentes.ToListAsync();
        }
    }
}
