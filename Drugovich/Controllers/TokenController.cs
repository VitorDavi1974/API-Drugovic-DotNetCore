using Drugovich.Entities;
using Drugovich.Repositories;
using Drugovich.Repositories.Interfaces;
using Drugovich.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Drugovich.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class TokenController : Controller
    {
        private readonly IGerenteRepositorio _gerenteRepositorio;

        public TokenController(IGerenteRepositorio gerenteRepositorio)                                
        {
            _gerenteRepositorio = gerenteRepositorio;            
        }

        [HttpPost]
        public IActionResult Auth(int id)
        {
            //Gerente gerente = _gerenteRepositorio.BuscarPorId(id);
            //if(gerente != null)
            //{
                var token = TokenService.GenerateToken(new Gerente());
                return Ok(token);
            //}
            //return BadRequest($"Gerente {id} não encontrado");
        }
    }
}