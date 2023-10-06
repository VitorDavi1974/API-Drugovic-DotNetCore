using Drugovich.Entities;
using Drugovich.Repositories;
using Drugovich.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Drugovich.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteRepositorio _gerenteRepositorio;
        private readonly IGrupoRepositorio _grupoRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;

        public GerenteController(IGerenteRepositorio gerenteRepositorio, 
                                 IGrupoRepositorio grupoRepositorio,
                                 IClienteRepositorio clienteRepositorio)
        {
            _gerenteRepositorio = gerenteRepositorio;
            _grupoRepositorio = grupoRepositorio;
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Gerente>>> BuscarTodosGerentes() 
        {
            List<Gerente> gerentes = await _gerenteRepositorio.BuscarTodosGerentes();
            return Ok(gerentes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gerente>> BuscarPorId(int id)
        {
            Gerente gerentes = await _gerenteRepositorio.BuscarPorId(id);
            return Ok(gerentes);
        }

        [HttpGet("{id}/grupo")]
        public async Task<ActionResult<List<Grupo>>> BuscarTodosGrupos()
        {
            List<Grupo> grupos = await _grupoRepositorio.BuscarTodosGrupos();
            return Ok(grupos);
        }

        [HttpGet("{id}/grupo/{idGrupo}")]
        public async Task<ActionResult<Grupo>> BuscarGrupoPorId(int idGrupo)
        {
            Grupo grupos = await _grupoRepositorio.BuscarPorId(idGrupo);
            return Ok(grupos);
        }

        [HttpPost("{id}/grupo")]
        public async Task<ActionResult<Grupo>> Cadastrar([FromBody] Grupo grupoModel, int id)
        {
            try
            { 
                Gerente gerente = await _gerenteRepositorio.BuscarPorId(id);
                Grupo grupo = await _grupoRepositorio.Adicionar(grupoModel, gerente.nivel);
                return Ok(grupo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}/grupo/{idGrupo}")]
        public async Task<ActionResult<Grupo>> Atualizar([FromBody] Grupo grupoModel, int id, int idGrupo)
        {
            try
            { 
                Gerente gerente = await _gerenteRepositorio.BuscarPorId(id);
                grupoModel.id = idGrupo;
                Grupo grupo = await _grupoRepositorio.Atualizar(grupoModel, idGrupo, gerente.nivel);
                return Ok(grupo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}/grupo/{idGrupo}")]
        public async Task<ActionResult<Grupo>> Apagar(int id,int idGrupo)
        {
            try
            { 
                Gerente gerente = await _gerenteRepositorio.BuscarPorId(id);
                bool deletado = await _grupoRepositorio.Apagar(idGrupo, gerente.nivel);
                return Ok(deletado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/cliente/{idGrupo}")]
        public async Task<ActionResult<List<Cliente>>> BuscarClientePorIdGrupo(int idGrupo)
        {
            List<Cliente> clientes = await _clienteRepositorio.BuscarPorIdGrupo(idGrupo);
            return Ok(clientes);
        }

        [HttpPost("{id}/cliente")]
        public async Task<ActionResult<Cliente>> CadastrarCliente([FromBody] Cliente clienteModel, int id)
        {
            try
            { 
                Gerente gerente = await _gerenteRepositorio.BuscarPorId(id);
                Cliente cliente = await _clienteRepositorio.Adicionar(clienteModel, gerente.nivel);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}/cliente/{idCliente}")]
        public async Task<ActionResult<Cliente>> ApagarCliente(int id, int idCliente)
        {
            try
            { 
                Gerente gerente = await _gerenteRepositorio.BuscarPorId(id);
                bool deletado = await _clienteRepositorio.Apagar(idCliente, gerente.nivel);
                return Ok(deletado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
