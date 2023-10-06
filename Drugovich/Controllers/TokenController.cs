using Drugovich.Entities;
using Drugovich.Repositories;
using Drugovich.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Drugovich.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _configuration;

        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
    /*
    [HttpPost]
    public IActionResult RequestToken([FromBody] Gerente request)
    {
        
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, request.nome)
        };
;

        SigningCredentials creds = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(s: IConfiguration["SecurityKey"])), SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
                issuer: "drugovich.com.br",
                audience: "drugovich.com.br",
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: creds);

        return Ok(new
        { 
            token = new JwtSecurityTokenHandler().WriteToken(token) 
        });
    }
    */
}