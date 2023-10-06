using Drugovich.Entities;
using Drugovich.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Drugovich.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoRepositorio _grupoRepositorio;

        public GrupoController(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }
        /*
        [HttpGet]
        public async Task<ActionResult<List<Grupo>>> BuscarTodosGrupos() 
        {
            List<Grupo> grupos = await _grupoRepositorio.BuscarTodosGrupos();
            return Ok(grupos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Grupo>> BuscarPorId(int id)
        {
            Grupo grupos = await _grupoRepositorio.BuscarPorId(id);
            return Ok(grupos);
        }

        [HttpPost]
        public async Task<ActionResult<Grupo>> Cadastrar([FromBody] Grupo grupoModel)
        {
            Grupo grupo = await _grupoRepositorio.Adicionar(grupoModel);
            return Ok(grupo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Grupo>> Atualizar([FromBody] Grupo grupoModel, int id)
        {
            grupoModel.id = id;
            Grupo grupo = await _grupoRepositorio.Atualizar(grupoModel, id);
            return Ok(grupo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Grupo>> Apagar(int id)
        {
            bool deletado = await _grupoRepositorio.Apagar(id);
            return Ok(deletado);
        }
        */
    }
}
